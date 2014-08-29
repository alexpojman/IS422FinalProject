Imports System.Data.SqlClient
Public Class employeesched

    'load list of student employees 
    Private Sub employeesched_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Employee_ID, Employee_Name FROM EMPLOYEE"
        End With

        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        SelectEmployeeComboBox.ValueMember = "Employee_ID"
        SelectEmployeeComboBox.DisplayMember = "Employee_Name"
        SelectEmployeeComboBox.DataSource = dt

        With sqlCmd
            .CommandText = "SELECT sched.Employee_Num, emp.Employee_Name, emp.Wage_Rate, sched.Day_of_Week, sched.Punch_In, sched.Punch_Out FROM SCHEDULE sched INNER JOIN EMPLOYEE emp ON sched.Employee_Num = emp.Employee_ID"
        End With

        Dim objDataSet As New DataSet()
        Dim objDataAdapter As New SqlDataAdapter()
        objDataAdapter.SelectCommand = sqlCmd
        objDataAdapter.Fill(objDataSet)

        DataGridView1.DataSource = objDataSet.Tables(0)

        chConn.Close()

        PasswordTextBox.Enabled = True
    End Sub

    'load the specific information for the selected employee
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim employeeID As Integer = Convert.ToInt32(SelectEmployeeComboBox.SelectedValue)
        Dim enteredPassword As String = PasswordTextBox.Text
        Dim realPassword As String
        Dim managerFlag As Boolean = False

        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Password FROM EMPLOYEE WHERE Employee_ID = " & employeeID
            realPassword = .ExecuteScalar()
            .CommandText = "SELECT Employee_Type FROM EMPLOYEE WHERE Employee_ID = " & employeeID
            Dim managerCheck As String = .ExecuteScalar()
            If String.Equals(managerCheck, "Manager") Then
                managerFlag = True
            End If
        End With
        If String.Equals(enteredPassword, realPassword) Then
            If managerFlag.Equals(True) Then
                'employee is a manager
                DataGridView1.ReadOnly = False
                With sqlCmd
                    .CommandText = "SELECT Employee_ID, Employee_Name FROM EMPLOYEE WHERE Employee_Type = 'Student'"
                End With
                Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
                Dim dt As New DataTable
                dt.Load(objDataReader)

                StudentAssignComboBox.ValueMember = "Employee_ID"
                StudentAssignComboBox.DisplayMember = "Employee_Name"
                StudentAssignComboBox.DataSource = dt

                StudentAssignComboBox.Enabled = True
                AssignShiftDatePicker.Format = DateTimePickerFormat.Custom
                AssignShiftDatePicker.CustomFormat = "MM dd yyyy"
                AssignShiftTimePicker.Format = DateTimePickerFormat.Time
                AssignShiftTimePicker.ShowUpDown = True
                AssignShiftDatePicker.Enabled = True
                AssignShiftTimePicker.Enabled = True
                BtnAssign.Enabled = True
            Else
                'employee is a student
                With sqlCmd
                    .CommandText = "SELECT Employee_Name FROM EMPLOYEE WHERE Employee_ID = " & employeeID
                    empNametextbox.Text = .ExecuteScalar()
                    .CommandText = "SELECT Wage_Rate FROM EMPLOYEE WHERE Employee_ID = " & employeeID
                    hourratetextbox.Text = .ExecuteScalar()
                    datetextbox.Text = Date.Now.ToString("D")

                    punchINbutton.Enabled = True
                    punchOUTbutton.Enabled = True
                End With
            End If
        Else
            MessageBox.Show("Password does not match username. Please reenter the password", "Log-In Failed", MessageBoxButtons.OK)
        End If
        chConn.Close()
    End Sub

    Private Sub punchINbutton_Click(sender As Object, e As EventArgs) Handles punchINbutton.Click
        Dim employeeID As Integer = Convert.ToInt32(SelectEmployeeComboBox.SelectedValue)
        Dim startTime As String
        'record the date and time of the punch at the beginning of the shift in the schedule table 
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Start_Time FROM SCHEDULE WHERE Employee_Num = " & employeeID & " AND Day_of_Week = '" & Date.Now.Date & "'"
            startTime = .ExecuteScalar().ToString()
        End With
        With sqlCmd
            .Parameters.Add(New SqlParameter("@Punch_In", SqlDbType.DateTime))
            .Parameters("@Punch_IN").Value = Date.Now
            .CommandText = "UPDATE SCHEDULE SET Punch_In = @PUNCH_IN WHERE Employee_Num = " & employeeID & " AND Day_of_Week = '" & Date.Now.Date & "' AND Start_Time = '" & startTime & "'"

            .ExecuteNonQuery()
        End With
        chConn.Close()
    End Sub

    Private Sub punchOUTbutton_Click(sender As Object, e As EventArgs) Handles punchOUTbutton.Click
        'record the date and time of the punch at the end of the shift in the schedule table 
        Dim employeeID As Integer = Convert.ToInt32(SelectEmployeeComboBox.SelectedValue)
        Dim startTime As String
        'record the date and time of the punch at the beginning of the shift in the schedule table 
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Start_Time FROM SCHEDULE WHERE Employee_Num = '" & employeeID & "' AND Day_of_Week = '" & Date.Now.Date & "'"
            startTime = .ExecuteScalar().ToString()
        End With
        With sqlCmd
            .Parameters.Add(New SqlParameter("@Punch_Out", SqlDbType.DateTime))
            .Parameters("@Punch_Out").Value = Date.Now
            .CommandText = "UPDATE SCHEDULE SET Punch_Out = @PUNCH_Out WHERE Employee_Num = " & employeeID & " AND Day_of_Week = '" & Date.Now.Date & "' AND Start_Time = '" & startTime & "'"

            .ExecuteNonQuery()
        End With
        chConn.Close()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        BtnSubmit.Enabled = True
    End Sub

    Private Sub BtnAssign_Click(sender As Object, e As EventArgs) Handles BtnAssign.Click
        Dim dayOfWeek As DateTime = AssignShiftDatePicker.Value.Date
        Dim startTime As DateTime = Convert.ToDateTime(AssignShiftTimePicker.Value.TimeOfDay.ToString)

        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT * FROM SHIFT WHERE Day_of_Week = '" & dayOfWeek & "' AND Start_Time = '" & startTime & "'"
        End With

        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        With sqlCmd
            .Parameters.Add(New SqlParameter("@Day_of_Week", SqlDbType.DateTime))
            .Parameters.Add(New SqlParameter("@Start_Time", SqlDbType.DateTime))
            .Parameters("@Day_of_Week").Value = dayOfWeek
            .Parameters("@Start_Time").Value = startTime
        End With
        If dt.Rows.Count > 0 Then
            'shift already exists in the database table SHIFT, no need to create it. 
        Else
            'need to create shift in database
            With sqlCmd
                'create the shift in the shift table 
                .CommandText = "INSERT INTO SHIFT VALUES(@Day_of_Week, @Start_Time)"

                .ExecuteNonQuery()
            End With
        End If

        'assign the shift (using the same info) in the schedule table by associating it with an employee
        Dim employeeID As Integer = Convert.ToInt32(StudentAssignComboBox.SelectedValue)
        With sqlCmd
            .Parameters.Add(New SqlParameter("@Employee_Num", SqlDbType.Int))
            .Parameters("@Employee_Num").Value = employeeID
            .CommandText = "INSERT INTO SCHEDULE (Employee_Num, Day_of_Week, Start_Time) VALUES(@Employee_Num, @Day_of_Week, @Start_Time)"

            .ExecuteNonQuery()
        End With
        chConn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'manager approves a shift that was worked by an employee 
        Dim empNo As Integer = DataGridView1.Rows(e.RowIndex).Cells("Employee_Num").Value
        Dim dayOfWeek As DateTime = DataGridView1.Rows(e.RowIndex).Cells("Day_of_Week").Value
        Dim startTime As String
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Start_Time FROM SCHEDULE WHERE Employee_Num = " & empNo & " AND Day_of_Week = '" & dayOfWeek & "'"
            startTime = .ExecuteScalar().ToString()
        End With
        With sqlCmd
            .Parameters.Add(New SqlParameter("@Employee_Num", SqlDbType.Int))
            .Parameters("@Employee_Num").Value = empNo
            .Parameters.Add(New SqlParameter("@Day_of_Week", SqlDbType.DateTime))
            .Parameters("@Day_of_Week").Value = dayOfWeek
            .Parameters.Add(New SqlParameter("@Start_Time", SqlDbType.DateTime))
            .Parameters("@Start_Time").Value = startTime
            .CommandText = "UPDATE SCHEDULE SET Manager_Approval = 1 WHERE Employee_Num = @Employee_Num AND Day_of_Week = @Day_of_Week AND Start_Time = @Start_Time"

            .ExecuteNonQuery()
        End With
        chConn.Close()
    End Sub
End Class