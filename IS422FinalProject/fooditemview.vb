Imports System.Data.SqlClient
Imports System.Configuration

Public Class fooditemview

    'loads the possible items into the combo box for the user to select the item about which they would like to view the details
    Private Sub fooditemview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Item_ID, RTRIM(Description) AS Description FROM ITEM WHERE [Type] = 'Food' ORDER BY Item_ID"
        End With

        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        SelectItemComboBox.ValueMember = "Item_ID"
        SelectItemComboBox.DisplayMember = "Description"
        SelectItemComboBox.DataSource = dt
        chConn.Close()
    End Sub

    'After the user has selected the item, display the details in the form's labels
    Private Sub SelectItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectItemComboBox.SelectedIndexChanged
        Dim ItemID As Integer = Convert.ToInt32(SelectItemComboBox.SelectedValue.ToString)

        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT i.Item_ID FROM ITEM i INNER JOIN FOOD_ITEM f on i.Item_ID = f.Item_ID WHERE i.Item_ID = " & ItemID
            LblItemNum.Text = .ExecuteScalar()
            .CommandText = "SELECT i.Description FROM ITEM i INNER JOIN FOOD_ITEM f on i.Item_ID = f.Item_ID WHERE i.Item_ID = " & ItemID
            LblItemName.Text = .ExecuteScalar()
            .CommandText = "SELECT i.Unit_Cost FROM ITEM i INNER JOIN FOOD_ITEM f on i.Item_ID = f.Item_ID WHERE i.Item_ID = " & ItemID
            LblItemCost.Text = .ExecuteScalar()
            .CommandText = "SELECT f.Ingredients FROM ITEM i INNER JOIN FOOD_ITEM f on i.Item_ID = f.Item_ID WHERE i.Item_ID = " & ItemID
            LblItemIngredients.Text = .ExecuteScalar()
        End With
        chConn.Close()
    End Sub
End Class