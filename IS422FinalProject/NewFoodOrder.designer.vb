﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFoodOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VendorComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemComboBox = New System.Windows.Forms.ComboBox()
        Me.QtyTxtBox = New System.Windows.Forms.MaskedTextBox()
        Me.FoodOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.PlaceOrderButton = New System.Windows.Forms.Button()
        Me.AddToOrderButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriceTxtbox = New System.Windows.Forms.TextBox()
        Me.OrderTotalTxtbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.FoodOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vendor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item"
        '
        'VendorComboBox
        '
        Me.VendorComboBox.FormattingEnabled = True
        Me.VendorComboBox.Location = New System.Drawing.Point(86, 16)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.VendorComboBox.TabIndex = 3
        '
        'ItemComboBox
        '
        Me.ItemComboBox.Enabled = False
        Me.ItemComboBox.FormattingEnabled = True
        Me.ItemComboBox.Location = New System.Drawing.Point(86, 43)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ItemComboBox.TabIndex = 4
        '
        'QtyTxtBox
        '
        Me.QtyTxtBox.Enabled = False
        Me.QtyTxtBox.Location = New System.Drawing.Point(86, 97)
        Me.QtyTxtBox.Name = "QtyTxtBox"
        Me.QtyTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTxtBox.TabIndex = 5
        '
        'FoodOrderDataGridView
        '
        Me.FoodOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodOrderDataGridView.Location = New System.Drawing.Point(25, 260)
        Me.FoodOrderDataGridView.Name = "FoodOrderDataGridView"
        Me.FoodOrderDataGridView.Size = New System.Drawing.Size(506, 150)
        Me.FoodOrderDataGridView.TabIndex = 6
        '
        'PlaceOrderButton
        '
        Me.PlaceOrderButton.Enabled = False
        Me.PlaceOrderButton.Location = New System.Drawing.Point(327, 43)
        Me.PlaceOrderButton.Name = "PlaceOrderButton"
        Me.PlaceOrderButton.Size = New System.Drawing.Size(204, 64)
        Me.PlaceOrderButton.TabIndex = 7
        Me.PlaceOrderButton.Text = "Place Order"
        Me.PlaceOrderButton.UseVisualStyleBackColor = True
        '
        'AddToOrderButton
        '
        Me.AddToOrderButton.Enabled = False
        Me.AddToOrderButton.Location = New System.Drawing.Point(25, 145)
        Me.AddToOrderButton.Name = "AddToOrderButton"
        Me.AddToOrderButton.Size = New System.Drawing.Size(231, 37)
        Me.AddToOrderButton.TabIndex = 8
        Me.AddToOrderButton.Text = "Add To Current Order"
        Me.AddToOrderButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Price"
        '
        'PriceTxtbox
        '
        Me.PriceTxtbox.Enabled = False
        Me.PriceTxtbox.Location = New System.Drawing.Point(86, 71)
        Me.PriceTxtbox.Name = "PriceTxtbox"
        Me.PriceTxtbox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTxtbox.TabIndex = 10
        '
        'OrderTotalTxtbox
        '
        Me.OrderTotalTxtbox.Enabled = False
        Me.OrderTotalTxtbox.Location = New System.Drawing.Point(432, 161)
        Me.OrderTotalTxtbox.Name = "OrderTotalTxtbox"
        Me.OrderTotalTxtbox.Size = New System.Drawing.Size(100, 20)
        Me.OrderTotalTxtbox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(366, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Order Total"
        '
        'NewFoodOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 464)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.OrderTotalTxtbox)
        Me.Controls.Add(Me.PriceTxtbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AddToOrderButton)
        Me.Controls.Add(Me.PlaceOrderButton)
        Me.Controls.Add(Me.FoodOrderDataGridView)
        Me.Controls.Add(Me.QtyTxtBox)
        Me.Controls.Add(Me.ItemComboBox)
        Me.Controls.Add(Me.VendorComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewFoodOrder"
        Me.Text = "New Food Order"
        CType(Me.FoodOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VendorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ItemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QtyTxtBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FoodOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PlaceOrderButton As System.Windows.Forms.Button
    Friend WithEvents AddToOrderButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PriceTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents OrderTotalTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
