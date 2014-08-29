Imports System.Data.SqlClient
Public Class Inventory

    'populate the form when it loads
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate the current date and time labels to tell the user when the report was run
        CurDateLabel.Text = Date.Today
        CurTimeLabel.Text = Date.Now.ToString("hh:mm tt")

        'populate the datagridview with current inventory info for the food items
        Dim cmdSql As New SqlCommand()
        Dim objDataSet As New DataSet()
        Dim objDataAdapter As New SqlDataAdapter()
        Dim connSql As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
        connSql.Open()
        With cmdSql
            .Connection = connSql

            .CommandText = "SELECT Item_ID, Description, Qty_on_Hand, Reorder_Qty FROM ITEM WHERE Type = 'Food'" 
        End With

        objDataAdapter.SelectCommand = cmdSql
        objDataAdapter.Fill(objDataSet)

        FoodItemDgv.DataSource = objDataSet.Tables(0)

        'populate the datagridview with current inventory information for the supply items 
        With cmdSql
            .CommandText = "SELECT Item_ID, Description, Qty_on_Hand, Reorder_Qty FROM ITEM WHERE Type = 'Supply'"
        End With

        Dim objDataSet2 As New DataSet()
        objDataAdapter.SelectCommand = cmdSql
        objDataAdapter.Fill(objDataSet2)

        SupplyItemDgv.DataSource = objDataSet2.Tables(0)
        connSql.Close()
    End Sub

End Class