<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignDriverToDelivery
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
        Me.DriversComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeliveryNumTextbox = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.EstimatedDeliveryDatePick = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DriversComboBox
        '
        Me.DriversComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DriversComboBox.FormattingEnabled = True
        Me.DriversComboBox.Location = New System.Drawing.Point(102, 54)
        Me.DriversComboBox.Name = "DriversComboBox"
        Me.DriversComboBox.Size = New System.Drawing.Size(170, 21)
        Me.DriversComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Driver to Assign:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delivery Number"
        '
        'DeliveryNumTextbox
        '
        Me.DeliveryNumTextbox.Location = New System.Drawing.Point(138, 6)
        Me.DeliveryNumTextbox.Name = "DeliveryNumTextbox"
        Me.DeliveryNumTextbox.ReadOnly = True
        Me.DeliveryNumTextbox.Size = New System.Drawing.Size(100, 20)
        Me.DeliveryNumTextbox.TabIndex = 3
        '
        'AddBtn
        '
        Me.AddBtn.Enabled = False
        Me.AddBtn.Location = New System.Drawing.Point(70, 130)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(144, 23)
        Me.AddBtn.TabIndex = 4
        Me.AddBtn.Text = "Assign Driver to Delivery"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'EstimatedDeliveryDatePick
        '
        Me.EstimatedDeliveryDatePick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EstimatedDeliveryDatePick.Location = New System.Drawing.Point(138, 82)
        Me.EstimatedDeliveryDatePick.Name = "EstimatedDeliveryDatePick"
        Me.EstimatedDeliveryDatePick.Size = New System.Drawing.Size(134, 20)
        Me.EstimatedDeliveryDatePick.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estimated Delivery Date"
        '
        'AssignDriverToDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 165)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EstimatedDeliveryDatePick)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DeliveryNumTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DriversComboBox)
        Me.Name = "AssignDriverToDelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssignDriverToDelivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DriversComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DeliveryNumTextbox As System.Windows.Forms.TextBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents EstimatedDeliveryDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
