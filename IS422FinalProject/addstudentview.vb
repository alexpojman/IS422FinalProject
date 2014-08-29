Imports System.Data.SqlClient

Public Class addstudentview

    ' Handles "Add Student" button being clicked
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        ' Get full name of student
        Dim fullStudentName As String
        If (Not middleInitTextBox.Text = "") Then
            fullStudentName = firstnameTextBox.Text + " " + middleInitTextBox.Text + " " + lastnameTextBox.Text
        Else
            fullStudentName = firstnameTextBox.Text + " " + lastnameTextBox.Text
        End If

        ' Generate Connection string and query string objects
        Dim Sqlstr As String
        Dim getManagerSqlstr As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        ' Insert Employee and student with new student information
        Sqlstr = "INSERT INTO EMPLOYEE(employee_Name , Wage_Rate , Job_Title , Start_Date , Employee_Type) VALUES (@empName , @wage , @title, @startDate , 'Student');"
        Sqlstr &= "INSERT INTO STUDENT(Employee_Num, Hours_per_Week, Manager_Employee_Num) VALUES (IDENT_CURRENT('employee') , @hoursPerWeek,  @dept);"

        ' Update manager info query
        getManagerSqlstr = "SELECT manager.employee_num AS mgrNum FROM manager WHERE manager.department = @mgrDept"

        ' Clean up pay rate info
        Dim payRate As String
        payRate = payRateTextBox.Text.Trim({"$"c})

        ' Attempt to update the database with form information
        Try
            Using connection As New SqlConnection(connectionString)
                Dim cmdInsert As New SqlCommand(Sqlstr, connection)
                Dim mgrCmd As New SqlCommand(getManagerSqlstr, connection)

                ' Set cmdInsert Params
                cmdInsert.Parameters.Add("@empName", Data.SqlDbType.NVarChar).Value = fullStudentName
                cmdInsert.Parameters.Add("@wage", Data.SqlDbType.SmallMoney).Value = payRate
                cmdInsert.Parameters.Add("@title", Data.SqlDbType.NVarChar).Value = titleTextBox.Text
                cmdInsert.Parameters.Add("@startDate", Data.SqlDbType.DateTime).Value = StartDatePicker.Value.ToString("yyyy-MM-dd hh:mm:ss")
                cmdInsert.Parameters.Add("@hoursPerWeek", Data.SqlDbType.Float).Value = hoursPerWeekTextBox.Text

                ' Set mgrCmd Params
                mgrCmd.Parameters.Add("@mgrDept", Data.SqlDbType.NVarChar).Value = DeptComboBox.SelectedItem.ToString()

                ' Open the connection and execute query
                connection.Open()

                ' Get Manager Number based on department information
                Using da = New SqlDataAdapter(mgrCmd)
                    Dim mgrInfoTable = New DataTable()
                    da.Fill(mgrInfoTable)
                    cmdInsert.Parameters.Add("@dept", Data.SqlDbType.NVarChar).Value = mgrInfoTable.Rows(0).Item("mgrNum")
                End Using

                ' Run cmdInsert command
                cmdInsert.ExecuteNonQuery()

                MsgBox("Successfully added " + fullStudentName)

                ' Close the connection
                connection.Close()
                Me.Close()
            End Using
        Catch ex As Exception
            MsgBox("Student could not be added. Please verify that information is valid.")
        End Try

    End Sub

    ' Handles Form being loaded
    Private Sub addstudentview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize Inputs
        DeptComboBox.SelectedIndex = 0
        StartDatePicker.MinDate = Today()
    End Sub
End Class