Imports System.Data.SqlClient

Public Class AssignDriverToDelivery

    Private Sub AssignDriverToDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Delivery Number

        ' Populate All Drivers to combobox
        ' Create Connection String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        Dim populateSqlStr As String
        Dim getDeliveryIDs As String

        ' Get a list of all Driver Names's
        populateSqlStr = "SELECT driver_name FROM delivery_Driver ORDER BY driver_name ASC"

        ' Get delivery ID
        getDeliveryIDs = "SELECT delivery_Num FROM delivery"

        Try
            Using connection = New SqlConnection(connectionString)



                ' Open the Connection
                connection.Open()

                Using deliveryIDs = New SqlDataAdapter(getDeliveryIDs, connection)
                    Dim deliveryIDTable = New DataTable()
                    deliveryIDs.Fill(deliveryIDTable)

                    ' Assign deliveryNumTextBox
                    DeliveryNumTextbox.Text = deliveryIDTable.Rows(deliveryIDTable.Rows.Count - 1).Item("delivery_Num")

                End Using


                ' Update DataGridView based on info generated
                Using driverNamesTable = New SqlDataAdapter(populateSqlStr, connection)
                    Dim driverNames = New DataTable()
                    driverNamesTable.Fill(driverNames)

                    ' Step through table and add each Driver_Name to combobox
                    For i As Integer = 0 To driverNames.Rows.Count - 1
                        DriversComboBox.Items.Add(driverNames.Rows(i).Item("driver_name"))
                    Next
                End Using

                ' Close connection
                connection.Close()
            End Using

        Catch ex As Exception
            MsgBox("Not a valid selection, please try again.")
        End Try
        ' Create New Order
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ' Update delivery info
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        Dim Sqlstr = "UPDATE delivery SET driver_name = @driverName , est_delivery_day = @deliveryDay WHERE delivery_Num = @deliveryNum"

        Try
            Using connection = New SqlConnection(connectionString)
                Dim cmdInsert As New SqlCommand(Sqlstr, connection)
                cmdInsert.Parameters.Add("@driverName", Data.SqlDbType.NVarChar).Value = DriversComboBox.SelectedItem.ToString()
                cmdInsert.Parameters.Add("@deliveryDay", Data.SqlDbType.DateTime).Value = EstimatedDeliveryDatePick.Value.ToString("yyyy-MM-dd hh:mm:ss")
                cmdInsert.Parameters.Add("@deliveryNum", Data.SqlDbType.Int).Value = DeliveryNumTextbox.Text
                ' Open the Connection
                connection.Open()

                cmdInsert.ExecuteNonQuery()

                MsgBox("Successfully added driver!")

                ' Close connection
                connection.Close()
                Me.Close()
            End Using
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DriversComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriversComboBox.SelectedIndexChanged
        ' Enable the add button if unenabled
        If (Not AddBtn.Enabled) Then
            AddBtn.Enabled = True
        End If
    End Sub
End Class