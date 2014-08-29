Imports System.Data.SqlClient
Public Class NewFoodOrder

    Dim count As Integer = 0
    Dim orderTime As DateTime
    Dim orderNo As Integer
    Dim itemNo As Integer

    Private Sub NewFoodOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT DISTINCT Vendor_ID, Vendor_Name FROM Vendor"
        End With

        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        ' Step through table and add each eventID to combobox
        For i As Integer = 0 To dt.Rows.Count - 1
            VendorComboBox.Items.Add(dt.Rows(i).Item("Vendor_Name"))
            'VendorComboBox.ValueMember = "Vendor_ID"
            'VendorComboBox.DisplayMember = "Vendor_Name"
        Next
    End Sub

    Private Sub VendorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VendorComboBox.SelectedIndexChanged
        ItemComboBox.Items.Clear()
        Dim vendorCd As String = VendorComboBox.SelectedItem.ToString
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT DISTINCT i.Item_ID, RTRIM(i.[Description]) as Description FROM ITEM i INNER JOIN VENDOR v ON i.Vendor_ID = v.Vendor_ID WHERE Type = 'Food' AND v.Vendor_Name = '" & vendorCd & "'"
        End With

        Dim objDataReader As SqlDataReader = sqlCmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(objDataReader)

        ' Step through table and add each eventID to combobox
        For i As Integer = 0 To dt.Rows.Count - 1
            ItemComboBox.Items.Add(dt.Rows(i).Item("Description"))
        Next
        ItemComboBox.Enabled = True
    End Sub

    Private Sub ItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemComboBox.SelectedIndexChanged
        Dim itemCd As String = ItemComboBox.SelectedItem.ToString
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            .CommandText = "SELECT Unit_Cost FROM ITEM WHERE [DESCRIPTION] = '" & itemCd & "'"
            PriceTxtbox.Text = .ExecuteScalar()
        End With
        chConn.Close()
        QtyTxtBox.Enabled = True
        AddToOrderButton.Enabled = True
    End Sub

    Private Sub AddToOrderButton_Click(sender As Object, e As EventArgs) Handles AddToOrderButton.Click
        count = count + 1
        Dim isNumeric As Boolean = validateQty(QtyTxtBox.Text)
        If isNumeric = True Then
            'create the order only once
            If count > 1 Then
                'order has already been created 
            Else
                'new order 
                Dim chConn1 As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
                chConn1.Open()
                Dim sqlCmd1 As SqlCommand = chConn1.CreateCommand()
                With sqlCmd1
                    orderTime = Convert.ToDateTime(Date.Now.TimeOfDay.ToString)
                    .Parameters.Add(New SqlParameter("@Order_Placed", SqlDbType.DateTime))
                    .Parameters("@Order_Placed").Value = orderTime
                    .CommandText = "INSERT INTO [ORDER] (Order_Placed) Values (@Order_Placed)"

                    .ExecuteNonQuery()
                End With
                chConn1.Close()
            End If
            'add item to order                              
            Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
            chConn.Open()
            Dim sqlCmd As SqlCommand = chConn.CreateCommand()
            With sqlCmd
                .Parameters.Add(New SqlParameter("@Order_Time", SqlDbType.DateTime))
                .Parameters("@Order_Time").Value = orderTime
                .CommandText = "SELECT Order_ID FROM [ORDER] WHERE Order_Placed = @Order_Time"
                orderNo = .ExecuteScalar()

                .CommandText = "SELECT Item_ID FROM ITEM WHERE [Description] = '" & ItemComboBox.SelectedItem.ToString & "'"
                itemNo = .ExecuteScalar()

                .Parameters.Add(New SqlParameter("@Order_ID", SqlDbType.Int))
                .Parameters("@Order_ID").Value = orderNo
                .Parameters.Add(New SqlParameter("@Item_ID", SqlDbType.Int))
                .Parameters("@Item_ID").Value = itemNo
                .Parameters.Add(New SqlParameter("@Qty_Ordered", SqlDbType.Int))
                .Parameters("@Qty_Ordered").Value = QtyTxtBox.Text

                .CommandText = "INSERT INTO ORDER_DETAILS Values (@Order_ID, @Item_ID, @Qty_Ordered)"

                .ExecuteNonQuery()
            End With
            chConn.Close()
        Else
            'qty is not valid, do not add to order 
        End If

        'refresh the datagridview with the most current order information 
        Dim chConn2 As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")

        chConn2.Open()
        Dim sqlCmd3 As SqlCommand = chConn2.CreateCommand()
        With sqlCmd3
            .CommandText = "SELECT i.Item_ID, RTRIM(i.[Description]) AS Description, od.Qty_Ordered, i.Unit_Cost, v.Vendor_Name FROM Order_Details od INNER JOIN ITEM i ON i.Item_ID = od.Item_ID INNER JOIN VENDOR v ON v.Vendor_ID = i.Vendor_ID WHERE ORDER_ID = " & orderNo
        End With

        Dim objDataSet As New DataSet()
        objDataSet.Clear()
        Dim objDataAdapter As New SqlDataAdapter()
        objDataAdapter.SelectCommand = sqlCmd3
        objDataAdapter.Fill(objDataSet)

        FoodOrderDataGridView.DataSource = objDataSet.Tables(0)

        chConn2.Close()
        PlaceOrderButton.Enabled = True
    End Sub

    Private Function validateQty(ByVal qty As String) As Boolean
        'validate the user input for the quantity of each item
        If String.IsNullOrEmpty(qty) = False Then
            If IsNumeric(qty) = False Then
                Return False
            Else
                If (Convert.ToInt32(qty) < 0) Then
                    Return False
                Else
                    Return True
                End If
            End If
        Else
            Return False
        End If
    End Function

    Private Sub PlaceOrderButton_Click(sender As Object, e As EventArgs) Handles PlaceOrderButton.Click
        'submit the order & calculate the order specific aggregations 
        count = 0
        Dim chConn As New SqlConnection("Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge")
        chConn.Open()
        Dim sqlCmd As SqlCommand = chConn.CreateCommand()
        With sqlCmd
            'order total
            .CommandText = "SELECT SUM(od.Qty_Ordered * i.Unit_Cost) as Order_Total FROM Order_Details od INNER JOIN Item i	ON od.Item_ID = i.Item_ID WHERE Order_ID = " & orderNo & " GROUP BY od.Order_ID "
            Dim orderTotal = .ExecuteScalar()
            OrderTotalTxtbox.Text = orderTotal

            'total items ordered
            .CommandText = "SELECT SUM(Qty_Ordered) as Total_Item_Qty FROM Order_Details od WHERE Order_ID = " & orderNo
            Dim totalItems = .ExecuteScalar()

            .Parameters.Add(New SqlParameter("@Order_Total", SqlDbType.Money))
            .Parameters("@Order_Total").Value = orderTotal

            .Parameters.Add(New SqlParameter("@Total_Item_Qty", SqlDbType.Int))
            .Parameters("@Total_Item_Qty").Value = totalItems

            .CommandText = "UPDATE [ORDER] SET Order_Total = @Order_Total, Total_Item_Qty = @Total_Item_Qty WHERE Order_ID = " & orderNo
            .ExecuteNonQuery()
        End With
        chConn.Close()

        ' Open assign delivery driver form
        Dim assignForm As New AssignDriverToDelivery
        assignForm.Show()
    End Sub

End Class