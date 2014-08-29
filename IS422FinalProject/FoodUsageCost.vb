Imports System.Data.SqlClient
Public Class FoodUsageCost
    Dim ClientSel As String
    Dim FoodSel As String

    Private Sub FoodUsageCost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim SqlstrLoad As String
        Dim SqlstrLoad2 As String
        Dim connectionString2 As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        Dim connectionString3 As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        SqlstrLoad = "SELECT rtrim(Org_Name) As OrgName FROM CLIENT"
        SqlstrLoad2 = "SELECT rtrim(Description) As ItemName FROM ITEM"

        Using connection2 = New SqlConnection(connectionString2)
            Dim cmd2 As New SqlCommand(SqlstrLoad, connection2)

            connection2.Open()

            Using da2 = New SqlDataAdapter(cmd2)
                Dim table2 = New DataTable
                da2.Fill(table2)

                If table2.Rows.Count > 0 Then
                    clientNameCombo.DataSource = table2
                    clientNameCombo.DisplayMember = "OrgName"
                Else
                    MsgBox("Empty")
                End If
            End Using
            connection2.Close()
        End Using

        Using connection3 = New SqlConnection(connectionString3)
            Dim cmd3 As New SqlCommand(SqlstrLoad2, connection3)

            connection3.Open()

            Using da3 = New SqlDataAdapter(cmd3)
                Dim table3 = New DataTable
                da3.Fill(table3)

                If table3.Rows.Count > 0 Then
                    foodIDCombo.Datasource = table3
                    foodIDCombo.DisplayMember = "ItemName"
                Else
                    MsgBox("Empty")
                End If
            End Using
            connection3.Close()
        End Using
    End Sub

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click
        Dim Sqlstr As String
        Dim SqlstrClient As String
        Dim SqlstrFood As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        Dim connectionClient As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        Dim connectionFood As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        ClientSel = clientNameCombo.Text
        FoodSel = foodIDCombo.Text


        'Query to add consumption information to the database
        Sqlstr = "INSERT INTO CONSUMPTION(Client_ID, item_ID, Week, Amount_Consumed, Total_Cost_Consumed, Amount_Wasted, Total_Cost_Wasted) VALUES (@client, @item, @week, @amtConsumed, @costConsumed, @amtWasted, @costWasted);"
        SqlstrClient = "SELECT client_ID From CLIENT Where org_Name = '" & ClientSel & "'"
        SqlstrFood = "SELECT item_ID FROM ITEM Where Description = '" & FoodSel & "'"

        Using connectionB As New SqlConnection(connectionClient)
            Dim cmdClient As New SqlCommand(SqlstrClient, connectionB)

            connectionB.Open()

            Using daClient = New SqlDataAdapter(cmdClient)
                Dim tableClient = New DataTable
                daClient.Fill(tableClient)
                clientIDTextbox.Text = tableClient.Rows(0).Item(0)


            End Using
            connectionB.Close()
        End Using

        Using connectionC As New SqlConnection(connectionFood)
            Dim cmdFood As New SqlCommand(SqlstrFood, connectionC)

            connectionC.Open()

            Using daFood = New SqlDataAdapter(cmdFood)
                Dim tableFood = New DataTable
                daFood.Fill(tableFood)
                foodIDTextbox.Text = tableFood.Rows(0).Item(0)
            End Using
        End Using

        Try
            Using connection As New SqlConnection(connectionString)
                Dim cmdInsert As New SqlCommand(Sqlstr, connection)

                'Uses the textboxes on the form as the information it passes to the database
                cmdInsert.Parameters.Add("@client", Data.SqlDbType.NVarChar).Value = clientIDTextbox.Text
                cmdInsert.Parameters.Add("@item", Data.SqlDbType.NVarChar).Value = foodIDTextbox.Text
                cmdInsert.Parameters.Add("@week", Data.SqlDbType.DateTime).Value = FiscalWeekTextBox.Text
                cmdInsert.Parameters.Add("@amtconsumed", Data.SqlDbType.Int).Value = numConsumedTextbox.Text
                cmdInsert.Parameters.Add("@costConsumed", Data.SqlDbType.Money).Value = totalCostConsumedTextbox.Text
                cmdInsert.Parameters.Add("@amtwasted", Data.SqlDbType.Int).Value = NumberWastedTextbox.Text
                cmdInsert.Parameters.Add("@costWasted", Data.SqlDbType.Money).Value = totalCostWastedTextbox.Text

                'opens and executes the query
                connection.Open()
                cmdInsert.ExecuteNonQuery()
                MsgBox("Successfully Added Food Information")

            End Using
        Catch ex As Exception
            MsgBox("One of the fields was not entered correctly")
        End Try

    End Sub
End Class