Imports System.Data.SqlClient
Public Class RoomInfoInput

    Private Sub RoomInfoInput_Load(sender As Object, e As EventArgs) Handles Me.Load
        'load room numbers into the combo box
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT DISTINCT Room_Num FROM OCCUPANCY"
        End With

        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        RoomNumComboBox.ValueMember = "Room_Num"
        RoomNumComboBox.DisplayMember = "Room_Num"
        RoomNumComboBox.DataSource = dt
    End Sub

    Private Sub RoomDateTimePick_ValueChanged(sender As Object, e As EventArgs) Handles RoomDateTimePick.ValueChanged
        RoomNumComboBox.Enabled = True
    End Sub

    Private Sub RoomNumComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomNumComboBox.SelectedIndexChanged
        OccupiedCheckBox.Enabled = True
        NumGuestsTxtBox.Enabled = True
        BtnSubmit.Enabled = True
    End Sub


    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        'user inputs the occupancy data for the hotel rooms of the Lowell Center
        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .Parameters.Add(New SqlParameter("@Room_Num", SqlDbType.Int))
            .Parameters("@Room_Num").Value = Convert.ToInt32(RoomNumComboBox.SelectedValue)
            .Parameters.Add(New SqlParameter("@Day_of_Week", SqlDbType.NVarChar))
            .Parameters("@Day_of_Week").Value = RoomDateTimePick.Value.ToString
            .Parameters.Add(New SqlParameter("@OccupiedFl", SqlDbType.Int))
            If OccupiedCheckBox.Checked = True Then
                'room is occupied
                .Parameters("@OccupiedFl").Value = 1
            Else
                'room is empty
                .Parameters("@OccupiedFl").Value = 0
            End If
            .Parameters.Add(New SqlParameter("@Num_Guests", SqlDbType.Int))
            If OccupiedCheckBox.Checked = True Then
                If IsNumeric(NumGuestsTxtBox.Text) = True And NumGuestsTxtBox.Text <> "" Then
                    .Parameters("@Num_Guests").Value = Convert.ToInt32(NumGuestsTxtBox.Text)
                Else
                    'user did not enter a numeric value or did not enter a value at all 
                    MessageBox.Show("Please enter a numeric value for the number of guests.", "Invalid Input", MessageBoxButtons.OK)
                End If
            Else
                'room is unoccupied, so number of guests has to be 0
                .Parameters("@Num_Guests").Value = 0
            End If
            .CommandText = "INSERT INTO OCCUPANCY VALUES(@Room_Num, @Day_of_Week, @OccupiedFl, @Num_Guests)"
        End With
    End Sub
End Class