Imports System.Data.SqlClient

Public Class AddManager

    ' Handles "Add" button being clicked
    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click

        ' Get full name of manager
        Dim fullMgrName As String
        If (Not MiddleInitialTextBox.Text = "") Then
            fullMgrName = FirstNameTextBox.Text + " " + MiddleInitialTextBox.Text + " " + LastNameTextBox.Text
        Else
            fullMgrName = FirstNameTextBox.Text + " " + LastNameTextBox.Text
        End If

        ' Generate Connection string and query string objects
        Dim Sqlstr As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        ' Insert Employee and student with new manager information
        Sqlstr = "INSERT INTO EMPLOYEE(employee_Name , Wage_Rate , Job_Title , Start_Date , Employee_Type) VALUES (@empName , @wage , @title, @startDate , 'Manager');"
        Sqlstr &= "INSERT INTO MANAGER(Employee_Num, Department, Address , City , State , ZIP , Phone) VALUES (IDENT_CURRENT('employee') , @dept , @address , @city , @state , @ZIP , @phone);"

        ' Clean up pay rate info
        Dim payRate As String
        payRate = PayRateTextBox.Text.Trim({"$"c})

        ' Attempt to update the database with form information
        Try
            Using connection As New SqlConnection(connectionString)
                Dim cmdInsert As New SqlCommand(Sqlstr, connection)
                cmdInsert.Parameters.Add("@empName", Data.SqlDbType.NVarChar).Value = fullMgrName
                cmdInsert.Parameters.Add("@wage", Data.SqlDbType.SmallMoney).Value = payRate
                cmdInsert.Parameters.Add("@title", Data.SqlDbType.NVarChar).Value = TitleTextBox.Text
                cmdInsert.Parameters.Add("@startDate", Data.SqlDbType.DateTime).Value = StartDatePicker.Value.ToString("yyyy-MM-dd hh:mm:ss")

                cmdInsert.Parameters.Add("@dept", Data.SqlDbType.NVarChar).Value = DeptComboBox.SelectedItem.ToString()
                cmdInsert.Parameters.Add("@address", Data.SqlDbType.NVarChar).Value = AddressTextBox.Text
                cmdInsert.Parameters.Add("@city", Data.SqlDbType.NVarChar).Value = CityTextBox.Text
                cmdInsert.Parameters.Add("@state", Data.SqlDbType.NChar).Value = StateComboBox.SelectedItem.ToString()
                cmdInsert.Parameters.Add("@ZIP", Data.SqlDbType.NChar).Value = ZipTextBox.Text
                cmdInsert.Parameters.Add("@phone", Data.SqlDbType.NVarChar).Value = PhoneTextBox.Text

                ' Open connection and execute query
                connection.Open()
                cmdInsert.ExecuteNonQuery()

                MsgBox("Successfully added " + fullMgrName)

                ' Close connection
                connection.Close()
                Me.Close()
            End Using
        Catch ex As Exception
            MsgBox("Manager could not be added. Please verify that all fields are filled with valid information.")
        End Try
    End Sub

    ' On Form Loading
    Private Sub AddManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Initialize Inputs
        DeptComboBox.SelectedIndex = 0
        StateComboBox.SelectedItem = "Wisconsin"
        StartDatePicker.MinDate = Today()
    End Sub
End Class