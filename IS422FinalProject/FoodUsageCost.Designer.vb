<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodUsageCost
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.foodIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.clientNameCombo = New System.Windows.Forms.ComboBox()
        Me.clientIDTextbox = New System.Windows.Forms.TextBox()
        Me.foodIDCombo = New System.Windows.Forms.ComboBox()
        Me.FiscalWeekTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.numConsumedTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.NumberWastedTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.totalCostConsumedTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.totalCostWastedTextbox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Number Consumed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Food"
        '
        'foodIDTextbox
        '
        Me.foodIDTextbox.Location = New System.Drawing.Point(200, 91)
        Me.foodIDTextbox.Name = "foodIDTextbox"
        Me.foodIDTextbox.Size = New System.Drawing.Size(97, 20)
        Me.foodIDTextbox.TabIndex = 12
        Me.foodIDTextbox.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total Cost Wasted"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total Cost Consumed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Number Wasted"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Fiscal Week"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(131, 296)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(65, 41)
        Me.submitButton.TabIndex = 28
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Client"
        '
        'clientNameCombo
        '
        Me.clientNameCombo.FormattingEnabled = True
        Me.clientNameCombo.Location = New System.Drawing.Point(199, 55)
        Me.clientNameCombo.Name = "clientNameCombo"
        Me.clientNameCombo.Size = New System.Drawing.Size(98, 21)
        Me.clientNameCombo.TabIndex = 31
        '
        'clientIDTextbox
        '
        Me.clientIDTextbox.Location = New System.Drawing.Point(199, 55)
        Me.clientIDTextbox.Name = "clientIDTextbox"
        Me.clientIDTextbox.Size = New System.Drawing.Size(100, 20)
        Me.clientIDTextbox.TabIndex = 32
        Me.clientIDTextbox.Visible = False
        '
        'foodIDCombo
        '
        Me.foodIDCombo.FormattingEnabled = True
        Me.foodIDCombo.Location = New System.Drawing.Point(199, 85)
        Me.foodIDCombo.Name = "foodIDCombo"
        Me.foodIDCombo.Size = New System.Drawing.Size(100, 21)
        Me.foodIDCombo.TabIndex = 33
        '
        'FiscalWeekTextBox
        '
        Me.FiscalWeekTextBox.Location = New System.Drawing.Point(196, 20)
        Me.FiscalWeekTextBox.Mask = "00/00/0000 90:00"
        Me.FiscalWeekTextBox.Name = "FiscalWeekTextBox"
        Me.FiscalWeekTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FiscalWeekTextBox.TabIndex = 34
        Me.FiscalWeekTextBox.ValidatingType = GetType(Date)
        '
        'numConsumedTextbox
        '
        Me.numConsumedTextbox.Location = New System.Drawing.Point(196, 128)
        Me.numConsumedTextbox.Mask = "00000"
        Me.numConsumedTextbox.Name = "numConsumedTextbox"
        Me.numConsumedTextbox.Size = New System.Drawing.Size(100, 20)
        Me.numConsumedTextbox.TabIndex = 35
        Me.numConsumedTextbox.ValidatingType = GetType(Integer)
        '
        'NumberWastedTextbox
        '
        Me.NumberWastedTextbox.Location = New System.Drawing.Point(196, 167)
        Me.NumberWastedTextbox.Mask = "00000"
        Me.NumberWastedTextbox.Name = "NumberWastedTextbox"
        Me.NumberWastedTextbox.Size = New System.Drawing.Size(100, 20)
        Me.NumberWastedTextbox.TabIndex = 36
        Me.NumberWastedTextbox.ValidatingType = GetType(Integer)
        '
        'totalCostConsumedTextbox
        '
        Me.totalCostConsumedTextbox.Location = New System.Drawing.Point(196, 208)
        Me.totalCostConsumedTextbox.Mask = "$00000.00"
        Me.totalCostConsumedTextbox.Name = "totalCostConsumedTextbox"
        Me.totalCostConsumedTextbox.Size = New System.Drawing.Size(100, 20)
        Me.totalCostConsumedTextbox.TabIndex = 37
        '
        'totalCostWastedTextbox
        '
        Me.totalCostWastedTextbox.Location = New System.Drawing.Point(196, 251)
        Me.totalCostWastedTextbox.Mask = "$00000.00"
        Me.totalCostWastedTextbox.Name = "totalCostWastedTextbox"
        Me.totalCostWastedTextbox.Size = New System.Drawing.Size(100, 20)
        Me.totalCostWastedTextbox.TabIndex = 38
        '
        'FoodUsageCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 347)
        Me.Controls.Add(Me.totalCostWastedTextbox)
        Me.Controls.Add(Me.totalCostConsumedTextbox)
        Me.Controls.Add(Me.NumberWastedTextbox)
        Me.Controls.Add(Me.numConsumedTextbox)
        Me.Controls.Add(Me.FiscalWeekTextBox)
        Me.Controls.Add(Me.foodIDCombo)
        Me.Controls.Add(Me.clientIDTextbox)
        Me.Controls.Add(Me.clientNameCombo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.foodIDTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FoodUsageCost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Usage Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents foodIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents clientNameCombo As System.Windows.Forms.ComboBox
    Friend WithEvents clientIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents foodIDCombo As System.Windows.Forms.ComboBox
    Friend WithEvents FiscalWeekTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents numConsumedTextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NumberWastedTextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents totalCostConsumedTextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents totalCostWastedTextbox As System.Windows.Forms.MaskedTextBox
End Class
