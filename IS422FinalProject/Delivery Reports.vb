Imports System.Data.SqlClient
Public Class Delivery_Reports

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Sqlstr As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        'Query to view delivery reports
        Sqlstr = "Select Delivery.Delivery_Num, [Order].Order_ID, [Order].Order_Placed, Delivery.Est_Delivery_Day, [Order].Order_Received, Delivery.Driver_Name FROM Delivery Inner JOIN [Order] ON (Delivery.Delivery_Num = [Order].Delivery_Num)"


        ' Actually Run query
        Try

            Using connection = New SqlConnection(connectionString)

                Dim cmd As New SqlCommand(Sqlstr, connection)
                

                ' Open the Connection
                connection.Open()

                Using da = New SqlDataAdapter(cmd)
                    Dim table = New DataTable()
                    da.Fill(table)
                    deliveryReportDGV.DataSource = table
                End Using

                ' close connection for house-keeping
                connection.Close()
            End Using

           
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class