Imports System.Data.SqlClient

Public Class Delivery_Driver
    Private Sub AddDriverBtn_Click(sender As Object, e As EventArgs) Handles AddDriverBtn.Click
        Try
            Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Mitchell;Password=2013FA422_TeamB_Mitchell")
            chConn.Open()
            Dim sqlCmd As SqlCommand = chConn.CreateCommand()
            With sqlCmd
                .Parameters.Add(New SqlParameter("@Driver_Name", SqlDbType.Char))
                .Parameters.Add(New SqlParameter("@City", SqlDbType.Char))
                .Parameters.Add(New SqlParameter("@State", SqlDbType.Text))
                .Parameters.Add(New SqlParameter("@Zip", SqlDbType.Int))
                .Parameters.Add(New SqlParameter("@DOB", SqlDbType.DateTime))


                .Parameters("@Driver_Name").Value = DriverNameTextBox.Text
                .Parameters("@City").Value = CityTextBox.Text
                .Parameters("@State").Value = StateComboBox.SelectedItem.ToString
                .Parameters("@Zip").Value = ZipTextBox.Text
                .Parameters("@DOB").Value = DeliveryDriverDateTimePicker.Text


                .CommandText = "INSERT INTO DELIVERY_DRIVER VALUES(@Driver_Name,  @City, @State, @Zip, @DOB)"

                .ExecuteNonQuery()
            End With
            chConn.Close()

            MsgBox("Driver Added Successfully.")
            Me.Close()
        Catch ex As Exception
            MsgBox("Some info not added correctly. Please verify that all information is valid.")
        End Try
       
    End Sub


    Private Sub CityTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles CityTextBox.MaskInputRejected

    End Sub
End Class