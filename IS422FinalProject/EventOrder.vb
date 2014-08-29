Imports System.Data.SqlClient

Public Class EventOrder

    ' On Form load, initialize Event Number Combo box values
    Private Sub EventOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Create Connection String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        Dim populateSqlStr As String

        ' Get a list of all event ID's
        populateSqlStr = "SELECT Event_ID FROM event ORDER BY Event_ID ASC"

        Try
            Using connection = New SqlConnection(connectionString)
                ' Open the Connection
                connection.Open()

                ' Update DataGridView based on info generated
                Using eventNumTable = New SqlDataAdapter(populateSqlStr, connection)
                    Dim eventNumbers = New DataTable()
                    eventNumTable.Fill(eventNumbers)

                    ' Step through table and add each eventID to combobox
                    For i As Integer = 0 To eventNumbers.Rows.Count - 1
                        EventNumComboBox.Items.Add(eventNumbers.Rows(i).Item("Event_ID"))
                    Next
                End Using

                ' Close connection
                connection.Close()
            End Using

        Catch ex As Exception
            MsgBox("Not a valid selection, please try again.")
        End Try


    End Sub

    ' Handles the "Event Number" combo box value being changes
    Private Sub EventNumComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventNumComboBox.SelectedIndexChanged

        ' Start SQL Query Function
        Dim orderTableSqlstr As String
        Dim contactSqlstr As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        orderTableSqlstr = "SELECT [order].order_ID AS 'Order #' , CONVERT(Decimal (18,2), order_total) AS 'Total Price' , CONVERT(VARCHAR(11), delivery.est_delivery_day, 106) AS 'Delivery Date' , total_item_qty AS 'Total Order Items' FROM [ORDER] INNER JOIN delivery ON ([order].delivery_num = delivery.delivery_num) INNER JOIN [event_order] ON ([order].order_ID = event_order.order_ID AND event_order.event_ID = @eventID)"

        contactSqlstr = "SELECT client.coordinator AS 'Coordinator' , client.org_name AS 'Organization' , client.phone AS 'Phone' , client.email AS 'Email' , CONVERT(VARCHAR(11), event.date, 106) AS 'Date' , event.attendance AS Attendance FROM client INNER JOIN event ON (client.client_ID = event.client_ID) WHERE event.event_ID = @eventID"

        ' Run query
        Try
            Using connection = New SqlConnection(connectionString)
                ' Set Params for SQL query
                Dim tableCmd As New SqlCommand(orderTableSqlstr, connection)
                Dim contactCmd As New SqlCommand(contactSqlstr, connection)

                ' Set Params for SqlCommands
                tableCmd.Parameters.Add("@eventID", Data.SqlDbType.Int).Value = EventNumComboBox.SelectedItem.ToString()
                contactCmd.Parameters.Add("@eventID", Data.SqlDbType.Int).Value = EventNumComboBox.SelectedItem.ToString()

                ' Open the Connection
                connection.Open()

                ' Update DataGridView based on info generated
                Using tableda = New SqlDataAdapter(tableCmd)
                    Dim orderTable = New DataTable()
                    tableda.Fill(orderTable)
                    EventOrderDGV.DataSource = orderTable
                End Using

                ' Update contact information based on query
                Using contactda = New SqlDataAdapter(contactCmd)
                    Dim contactTable = New DataTable()
                    contactda.Fill(contactTable)

                    ' Populate contact textboxes based on ClientID
                    CoordinatorTextBox.Text = contactTable.Rows(0).Item("Coordinator").ToString()
                    OrgTextBox.Text = contactTable.Rows(0).Item("Organization").ToString()
                    PhoneTextBox.Text = contactTable.Rows(0).Item("Phone").ToString()
                    EmailTextBox.Text = contactTable.Rows(0).Item("Email").ToString()
                    EventDateTextBox.Text = contactTable.Rows(0).Item("Date").ToString()
                    AttendanceLabel.Text = "Estimated Attendance: " + contactTable.Rows(0).Item("Attendance").ToString()
                End Using

                ' close connection
                connection.Close()
            End Using

        Catch ex As Exception
            MsgBox("Something went wrong, please check your values and try again.")
        End Try
    End Sub
End Class