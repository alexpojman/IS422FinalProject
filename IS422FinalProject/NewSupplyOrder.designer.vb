<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSupplyOrder
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
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderTotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addToOrderButton = New System.Windows.Forms.Button()
        Me.submitOrderButton = New System.Windows.Forms.Button()
        Me.SupplyOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.VendorComboBox = New System.Windows.Forms.ComboBox()
        Me.ItemComboBox = New System.Windows.Forms.ComboBox()
        Me.QtyTxtBox = New System.Windows.Forms.TextBox()
        CType(Me.SupplyOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'priceTextBox
        '
        Me.priceTextBox.Enabled = False
        Me.priceTextBox.Location = New System.Drawing.Point(175, 145)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(97, 20)
        Me.priceTextBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Supplies"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Vendor"
        '
        'OrderTotalTextBox
        '
        Me.OrderTotalTextBox.Enabled = False
        Me.OrderTotalTextBox.Location = New System.Drawing.Point(479, 234)
        Me.OrderTotalTextBox.Name = "OrderTotalTextBox"
        Me.OrderTotalTextBox.Size = New System.Drawing.Size(97, 20)
        Me.OrderTotalTextBox.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(413, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Order Total"
        '
        'addToOrderButton
        '
        Me.addToOrderButton.Enabled = False
        Me.addToOrderButton.Location = New System.Drawing.Point(79, 229)
        Me.addToOrderButton.Name = "addToOrderButton"
        Me.addToOrderButton.Size = New System.Drawing.Size(165, 29)
        Me.addToOrderButton.TabIndex = 19
        Me.addToOrderButton.Text = "Add To Order"
        Me.addToOrderButton.UseVisualStyleBackColor = True
        '
        'submitOrderButton
        '
        Me.submitOrderButton.Enabled = False
        Me.submitOrderButton.Location = New System.Drawing.Point(386, 80)
        Me.submitOrderButton.Name = "submitOrderButton"
        Me.submitOrderButton.Size = New System.Drawing.Size(165, 78)
        Me.submitOrderButton.TabIndex = 20
        Me.submitOrderButton.Text = "Submit Order"
        Me.submitOrderButton.UseVisualStyleBackColor = True
        '
        'SupplyOrderDataGridView
        '
        Me.SupplyOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplyOrderDataGridView.Location = New System.Drawing.Point(43, 297)
        Me.SupplyOrderDataGridView.Name = "SupplyOrderDataGridView"
        Me.SupplyOrderDataGridView.Size = New System.Drawing.Size(551, 150)
        Me.SupplyOrderDataGridView.TabIndex = 21
        '
        'VendorComboBox
        '
        Me.VendorComboBox.FormattingEnabled = True
        Me.VendorComboBox.Location = New System.Drawing.Point(175, 47)
        Me.VendorComboBox.Name = "VendorComboBox"
        Me.VendorComboBox.Size = New System.Drawing.Size(100, 21)
        Me.VendorComboBox.TabIndex = 23
        '
        'ItemComboBox
        '
        Me.ItemComboBox.Enabled = False
        Me.ItemComboBox.FormattingEnabled = True
        Me.ItemComboBox.Location = New System.Drawing.Point(175, 98)
        Me.ItemComboBox.Name = "ItemComboBox"
        Me.ItemComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ItemComboBox.TabIndex = 24
        '
        'QtyTxtBox
        '
        Me.QtyTxtBox.Enabled = False
        Me.QtyTxtBox.Location = New System.Drawing.Point(175, 188)
        Me.QtyTxtBox.Name = "QtyTxtBox"
        Me.QtyTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.QtyTxtBox.TabIndex = 25
        '
        'NewSupplyOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 488)
        Me.Controls.Add(Me.QtyTxtBox)
        Me.Controls.Add(Me.ItemComboBox)
        Me.Controls.Add(Me.VendorComboBox)
        Me.Controls.Add(Me.SupplyOrderDataGridView)
        Me.Controls.Add(Me.submitOrderButton)
        Me.Controls.Add(Me.addToOrderButton)
        Me.Controls.Add(Me.OrderTotalTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewSupplyOrder"
        Me.Text = "NewSupplyOrder"
        CType(Me.SupplyOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents addToOrderButton As System.Windows.Forms.Button
    Friend WithEvents submitOrderButton As System.Windows.Forms.Button
    Friend WithEvents SupplyOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VendorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ItemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QtyTxtBox As System.Windows.Forms.TextBox
End Class
