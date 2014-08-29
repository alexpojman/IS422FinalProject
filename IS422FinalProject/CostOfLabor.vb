Imports System.Data.SqlClient
Public Class CostOfLabor

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click
        Dim Sqlstr As String
        Dim Sqlstr2 As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Kurtz;Password=2013FA422_TeamB_Kurtz"
        Dim connectionString2 As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Kurtz;Password=2013FA422_TeamB_Kurtz"

        'Query to see each cost per day by employee wage
        Sqlstr = "SELECT Schedule.Day_of_week, Schedule.Employee_Num, EMPLOYEE.Wage_Rate, DateDiff(second, Schedule.Punch_In, Schedule.Punch_Out) As HoursWorked, (DateDiff(second, Schedule.Punch_In, Schedule.Punch_Out) * EMPLOYEE.Wage_Rate) As TotalLaborCost FROM SCHEDULE INNER JOIN EMPLOYEE ON (Schedule.Employee_Num = Employee.Employee_ID)"
        'Query for daily cost of wages
        Sqlstr2 = "SELECT Schedule.Day_of_week, AVG(EMPLOYEE.Wage_Rate) As AvgWageRate, Sum(DateDiff(second, Schedule.Punch_In, Schedule.Punch_Out)) As TotalHoursWorked, (Sum(DateDiff(second, Schedule.Punch_In, Schedule.Punch_Out)) * Avg(EMPLOYEE.Wage_Rate)) As TotalLaborCost FROM SCHEDULE INNER JOIN EMPLOYEE ON (Schedule.Employee_Num = Employee.Employee_ID) Group By Day_of_week"

        'Run each employees cost query
        Try
            Using CONNECTION = New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(Sqlstr, CONNECTION)


                CONNECTION.Open()
                Using da = New SqlDataAdapter(cmd)
                    Dim table = New DataTable()
                    da.Fill(table)
                    costOFLaborDGV.DataSource = table
                End Using
                CONNECTION.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex)
        End Try

        'Run the total daily wage cost
        Try
            Using Connection2 = New SqlConnection(connectionString2)
                Dim cmd2 As New SqlCommand(Sqlstr2, Connection2)

                Connection2.Open()
                Using da2 = New SqlDataAdapter(cmd2)
                    Dim table2 = New DataTable()
                    da2.Fill(table2)
                    totalLaborCostDGV.DataSource = table2
                End Using
                Connection2.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

   
End Class
