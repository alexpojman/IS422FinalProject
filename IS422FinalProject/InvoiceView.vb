
Imports System.Data.SqlClient

Public Class InvoiceView
    Dim aConnection As New Odbc.OdbcConnection
    Dim orderIDHolder As String


    Private Sub InvoiceView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim SqlstrLoad As String
        Dim connectionString2 As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        'Query to populate the order Order Number Combo Box
        SqlstrLoad = "SELECT Order_ID FROM [Order]"

        Using connection2 = New SqlConnection(connectionString2)
            Dim cmd2 As New SqlCommand(SqlstrLoad, connection2)

            'Open connection
            connection2.Open()

            Using da2 = New SqlDataAdapter(cmd2)
                Dim table2 = New DataTable
                da2.Fill(table2)
                'If the table is filled, populate the tabel with the items
                If table2.Rows.Count > 0 Then
                    orderNumCombo.DataSource = table2
                    orderNumCombo.DisplayMember = "Order_ID"
                Else
                    MsgBox("Empty")
                End If
            End Using

            connection2.Close()
        End Using


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Sqlstr As String
        Dim Sqlstr2 As String
        Dim connectionString As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"
        Dim connectionString2 As String = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=True;User ID=2013FA422_TeamB_Pojman;Password=2013FA422_TeamB_Pojman"

        ' MsgBox(ComboBox1.SelectedItem.ToString)
        'MsgBox(ComboBox1.Text)
        orderIDHolder = orderNumCombo.Text

        'SQL Query to fill in labels 
        Sqlstr = "SELECT Invoice.Invoice_Num, Invoice_Date, Total_Amt, Total_Items, Order_ID, Invoice_Items.Item_ID, Invoice_Items.Qty_Shipped, Invoice_Items.Total_Price FROM INVOICE INNER JOIN INVOICE_ITEMS ON (invoice.invoice_num = invoice_items.invoice_num) WHERE invoice.order_id = '" & orderIDHolder & "'"

        'SQL Query to fill in Data Grid View
        Sqlstr2 = "SELECT Order_Details.Item_ID, ITEM.[Description], Item.Unit_Cost, Order_Details.Qty_Ordered, (Order_Details.Qty_Ordered * Item.Unit_Cost) As TotalPrice FROM Order_Details INNER JOIN ITEM On (Order_Details.Item_ID = Item.Item_ID) WHERE Order_DEtails.Order_ID = '" & orderIDHolder & "'"


        Try
            Using connection = New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(Sqlstr, connection)

                'Open Connection
                connection.Open()

                Using da = New SqlDataAdapter(cmd)
                    'Create virtual table and fill it
                    Dim table = New DataTable
                    da.Fill(table)

                    'Take all information from table and insert it into the labels
                    InvoiceNumLabel.Text = table.Rows(0).Item("Invoice_Num")
                    invoiceDateLabel.Text = table.Rows(0).Item("Invoice_Date").ToString
                    totalCostLabel.Text = table.Rows(0).Item("Total_Amt").ToString
                    TotalItemsLabel.Text = table.Rows(0).Item("Total_Items").ToString

                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("This order does not have any associated order detail information.")
        End Try

        'Query for filling out Data Grid View
        Try
            Using connection2 = New SqlConnection(connectionString2)

                Dim cmd2 As New SqlCommand(Sqlstr2, connection2)

                Using da2 = New SqlDataAdapter(cmd2)
                    'Create virtual table and fill it with the query information
                    Dim table2 = New DataTable
                    da2.Fill(table2)

                    'Use virtual table to fill in the Data grid view
                    invoiceDGV.DataSource = table2
                End Using
                connection2.Close()
            End Using
        Catch ex As Exception
            MsgBox("The table does not exist")
        End Try

    End Sub

   
    
End Class