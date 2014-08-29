<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomInfoInput
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
        Me.RoomNumComboBox = New System.Windows.Forms.ComboBox()
        Me.OccupiedCheckBox = New System.Windows.Forms.CheckBox()
        Me.RoomDateTimePick = New System.Windows.Forms.DateTimePicker()
        Me.NumGuestsTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(46, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room:"
        '
        'RoomNumComboBox
        '
        Me.RoomNumComboBox.Enabled = False
        Me.RoomNumComboBox.FormattingEnabled = True
        Me.RoomNumComboBox.Location = New System.Drawing.Point(90, 66)
        Me.RoomNumComboBox.Name = "RoomNumComboBox"
        Me.RoomNumComboBox.Size = New System.Drawing.Size(159, 21)
        Me.RoomNumComboBox.TabIndex = 1
        '
        'OccupiedCheckBox
        '
        Me.OccupiedCheckBox.AutoSize = True
        Me.OccupiedCheckBox.Enabled = False
        Me.OccupiedCheckBox.Location = New System.Drawing.Point(49, 106)
        Me.OccupiedCheckBox.Name = "OccupiedCheckBox"
        Me.OccupiedCheckBox.Size = New System.Drawing.Size(103, 17)
        Me.OccupiedCheckBox.TabIndex = 2
        Me.OccupiedCheckBox.Text = "Room Occupied"
        Me.OccupiedCheckBox.UseVisualStyleBackColor = True
        '
        'RoomDateTimePick
        '
        Me.RoomDateTimePick.Location = New System.Drawing.Point(49, 26)
        Me.RoomDateTimePick.Name = "RoomDateTimePick"
        Me.RoomDateTimePick.Size = New System.Drawing.Size(200, 20)
        Me.RoomDateTimePick.TabIndex = 3
        '
        'NumGuestsTxtBox
        '
        Me.NumGuestsTxtBox.Enabled = False
        Me.NumGuestsTxtBox.Location = New System.Drawing.Point(113, 139)
        Me.NumGuestsTxtBox.Name = "NumGuestsTxtBox"
        Me.NumGuestsTxtBox.Size = New System.Drawing.Size(136, 20)
        Me.NumGuestsTxtBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(46, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "# of Guests:"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Enabled = False
        Me.BtnSubmit.Location = New System.Drawing.Point(101, 190)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 6
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'RoomInfoInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumGuestsTxtBox)
        Me.Controls.Add(Me.RoomDateTimePick)
        Me.Controls.Add(Me.OccupiedCheckBox)
        Me.Controls.Add(Me.RoomNumComboBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "RoomInfoInput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomInfoInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RoomNumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OccupiedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RoomDateTimePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumGuestsTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
End Class
