Imports System.Data.SqlClient

Public Class RevenueView

    ' Handles form being loaded
    Private Sub RevenueView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Initialize inputs
        EventTypeCombo.SelectedIndex = 0
        ToDate.MaxDate = Today().AddHours(23)
        FromDate.MaxDate = Today()

    End Sub

    ' Handles "Filter Date Range" checkbox state being changed
    Private Sub filterDateCheckbox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles filterDateCheckbox.CheckedChanged
        ' Enable search button if currently unabled; allows user to update table
        If (SearchButton.Enabled = False) Then
            SearchButton.Enabled = True
        End If

        ' Enable FromDate and ToDate only if filterDateCheckbox is checked
        If (filterDateCheckbox.Checked) Then
            FromDate.Enabled = True
            ToDate.Enabled = True
        Else
            FromDate.Enabled = False
            ToDate.Enabled = False
        End If
    End Sub

    ' Handles "Event Type" combo box state being changed
    Private Sub EventTypeCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles EventTypeCombo.SelectedIndexChanged
        ' Enable search button if currently unabled; allows user to update table
        If (SearchButton.Enabled = False) Then
            SearchButton.Enabled = True
        End If
    End Sub

    ' Handles "From" DateTimePicker state being changed
    Private Sub FromDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FromDate.ValueChanged
        ' Enable search button if currently unabled; allows user to update table
        If (SearchButton.Enabled = False) Then
            SearchButton.Enabled = True
        End If
    End Sub

    ' Handles "To" DateTimePicker state being changed
    Private Sub ToDate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles ToDate.ValueChanged
        ' Enable search button if currently unabled; allows user to update table
        If (SearchButton.Enabled = False) Then
            SearchButton.Enabled = True
        End If

        ' Restrict the max date for the "FromDate" field
        FromDate.MaxDate = ToDate.Value.Date

    End Sub

    ' Handles "Search!" button being clicked
    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        ' Disable search button until parameters for the search query have changed
        SearchButton.Enabled = False

        'Get chosen Event type to filter
        Dim eventTypeFilter As String = EventTypeCombo.SelectedItem.ToString()

        ' Start SQL Query Function
        Dim Sqlstr As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"


        Sqlstr = "SELECT Event_ID AS 'Event ID', Description , CONVERT(VARCHAR(11), Date, 106) AS 'Event Date' , Type AS 'Event Type' , client.Org_Name AS 'Client' , event.Client_ID AS 'Client ID' , CONVERT(Decimal (18,2), Revenue) AS 'Event Revenue' FROM event INNER JOIN client ON (event.Client_ID = client.Client_ID)"
        ' Update the DataGrid based on query
        If (filterDateCheckbox.Checked) Then
            'RUN QUERY BASED ON DATE
            Sqlstr &= "WHERE (date BETWEEN @fromDate AND @toDate)"

            If (Not (eventTypeFilter = "All")) Then
                'Modify Query string to be search by type
                Sqlstr &= " AND Type = @type"
            End If

        ElseIf (Not filterDateCheckbox.Checked) Then
            If (Not (eventTypeFilter = "All")) Then
                'Modify Query string to be search by type
                Sqlstr &= "WHERE Type = @type"
            End If
        End If

        ' Actually Run query
        Try

            Using connection = New SqlConnection(connectionString)
                ' Set Params for SQL query
                Dim cmd As New SqlCommand(Sqlstr, connection)
                cmd.Parameters.Add("@type", Data.SqlDbType.NVarChar).Value = EventTypeCombo.SelectedItem.ToString()
                cmd.Parameters.Add("@fromDate", Data.SqlDbType.DateTime).Value = FromDate.Value.ToString("yyyy-MM-dd hh:mm:ss")

                ' Add Hours to bring time to end of day
                ToDate.Value = ToDate.Value.Date.AddHours(23)
                cmd.Parameters.Add("@toDate", Data.SqlDbType.DateTime).Value = ToDate.Value.ToString("yyyy/MM/dd HH:mm:ss")

                ' Open the Connection
                connection.Open()

                Using da = New SqlDataAdapter(cmd)
                    Dim table = New DataTable()
                    da.Fill(table)
                    RevDGV.DataSource = table
                End Using

                ' close connection for house-keeping
                connection.Close()
            End Using

            ' Sum Revenue table and update 
            Dim totalRev As Decimal
            For i As Integer = 0 To RevDGV.RowCount - 1
                totalRev += RevDGV.Rows(i).Cells("Event Revenue").Value
            Next

            TotalRevTextBox.Text = FormatCurrency(totalRev)

        Catch ex As Exception
            MsgBox("Something went wrong with generating the list, please verify your settings and try again.")
        End Try

    End Sub
End Class