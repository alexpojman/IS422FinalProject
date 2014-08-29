<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceView
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InvoiceNumLabel = New System.Windows.Forms.Label()
        Me.invoiceDateLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datePlacedLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalItemsLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.invoiceDGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.orderNumCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.invoiceDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Invoice Number:"
        '
        'InvoiceNumLabel
        '
        Me.InvoiceNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InvoiceNumLabel.Location = New System.Drawing.Point(318, 37)
        Me.InvoiceNumLabel.Name = "InvoiceNumLabel"
        Me.InvoiceNumLabel.Size = New System.Drawing.Size(59, 19)
        Me.InvoiceNumLabel.TabIndex = 2
        '
        'invoiceDateLabel
        '
        Me.invoiceDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.invoiceDateLabel.Location = New System.Drawing.Point(163, 73)
        Me.invoiceDateLabel.Name = "invoiceDateLabel"
        Me.invoiceDateLabel.Size = New System.Drawing.Size(79, 19)
        Me.invoiceDateLabel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Invoice Date:"
        '
        'datePlacedLabel
        '
        Me.datePlacedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datePlacedLabel.Location = New System.Drawing.Point(466, 73)
        Me.datePlacedLabel.Name = "datePlacedLabel"
        Me.datePlacedLabel.Size = New System.Drawing.Size(83, 19)
        Me.datePlacedLabel.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Placed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Order Number:"
        '
        'totalCostLabel
        '
        Me.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalCostLabel.Location = New System.Drawing.Point(318, 156)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(59, 18)
        Me.totalCostLabel.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Cost: "
        '
        'TotalItemsLabel
        '
        Me.TotalItemsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalItemsLabel.Location = New System.Drawing.Point(318, 184)
        Me.TotalItemsLabel.Name = "TotalItemsLabel"
        Me.TotalItemsLabel.Size = New System.Drawing.Size(59, 19)
        Me.TotalItemsLabel.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(227, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total Items:"
        '
        'invoiceDGV
        '
        Me.invoiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invoiceDGV.Location = New System.Drawing.Point(46, 266)
        Me.invoiceDGV.Name = "invoiceDGV"
        Me.invoiceDGV.Size = New System.Drawing.Size(549, 150)
        Me.invoiceDGV.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 31)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "View Invoice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'orderNumCombo
        '
        Me.orderNumCombo.FormattingEnabled = True
        Me.orderNumCombo.Location = New System.Drawing.Point(318, 115)
        Me.orderNumCombo.Name = "orderNumCombo"
        Me.orderNumCombo.Size = New System.Drawing.Size(73, 21)
        Me.orderNumCombo.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Invoice Details"
        '
        'InvoiceView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 418)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.orderNumCombo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.invoiceDGV)
        Me.Controls.Add(Me.TotalItemsLabel)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datePlacedLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.invoiceDateLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InvoiceNumLabel)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "InvoiceView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Label"
        CType(Me.invoiceDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InvoiceNumLabel As System.Windows.Forms.Label
    Friend WithEvents invoiceDateLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents datePlacedLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totalCostLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TotalItemsLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents invoiceDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents orderNumCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
