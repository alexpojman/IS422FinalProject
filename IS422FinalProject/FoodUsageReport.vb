Imports System.Data.SqlClient

Public Class FoodUsageReport

    Private Sub runReport_Click(sender As System.Object, e As System.EventArgs) Handles runReport.Click
        Dim Sqlstr As String
        Dim Sqlstr2 As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        'Query to get the consumption of events
        Sqlstr = "SELECT Client_ID, Item_ID, Week, Amount_Consumed, Total_Cost_Consumed, Amount_Wasted, Total_Cost_Wasted FROM CONSUMPTION"

        Try
            Using connection = New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(Sqlstr, connection)

                'open connection
                connection.Open()

                Using da = New SqlDataAdapter(cmd)
                    'create virtual table and fill it with query information
                    Dim table = New DataTable()
                    da.Fill(table)
                    'use the virtual table to populate the food usage DataGridView
                    foodUsageDGV2.DataSource = table
                End Using

                connection.Close()

            End Using

        Catch ex As Exception
            MsgBox("This table does not exist")

        End Try

        'Query to get the total consumption organized by week
        Sqlstr2 = "SELECT Week, Sum(Total_Cost_Consumed) As Total_Cost_Consumed, Sum(Total_Cost_Wasted) As Total_Cost_Wasted FROM CONSUMPTION GROUP BY week"

        Using connection2 = New SqlConnection(connectionString)
            Dim cmd2 As New SqlCommand(Sqlstr2, connection2)
            connection2.Open()

            Using da2 = New SqlDataAdapter(cmd2)
                'Create virtual table and fill it
                Dim table2 = New DataTable()
                da2.Fill(table2)
                'Use virtual table to populate the total food usage DataGridView
                totalFoodUsageDGV.DataSource = table2
            End Using

            connection2.Close()
        End Using
    End Sub


End Class