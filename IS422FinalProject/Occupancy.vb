Imports System.Data.SqlClient
Public Class Occupancy_Data

    Private Sub Occupancy_Data_Load(sender As Object, e As EventArgs) Handles Me.Load
        'load days of the week so the user can select the day for which they want to view the occupancy data
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Day_of_Week FROM OCCUPANCY GROUP BY Day_of_Week ORDER BY CASE  WHEN day_of_week = 'Sunday' THEN 1 WHEN day_of_week = 'Monday' THEN 2 WHEN day_of_week = 'Tuesday' THEN 3 WHEN day_of_week = 'Wednesday' THEN 4 WHEN day_of_week = 'Thursday' THEN 5 WHEN day_of_week = 'Friday' THEN 6 WHEN day_of_week = 'Saturday' THEN 7 End"
        End With
        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        SelectDayComboBox.ValueMember = "Day_of_Week"
        SelectDayComboBox.DisplayMember = "Day_of_Week"
        SelectDayComboBox.DataSource = dt
    End Sub

    '

    Private Sub SelectDayComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectDayComboBox.SelectedIndexChanged
        'once the user has chosen the day of the week, load the number of occupied rooms and the total number of guests staying in the hotel
        Dim dayOfWeek As String = SelectDayComboBox.SelectedValue.ToString
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT SUM(OccupiedFl) FROM OCCUPANCY WHERE Day_of_Week = '" & dayOfWeek & "'"
            RoomsTxtBox.Text = .ExecuteScalar()
            .CommandText = "SELECT SUM(Num_Guests) FROM OCCUPANCY WHERE Day_of_Week = '" & dayOfWeek & "'"
            GuestsTxtBox.Text = .ExecuteScalar()
        End With
        
    End Sub
End Class
