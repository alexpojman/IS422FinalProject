<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Occupancy_Data
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
        Me.RoomsTxtBox = New System.Windows.Forms.TextBox()
        Me.GuestsTxtBox = New System.Windows.Forms.TextBox()
        Me.SelectDayComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "# Rooms Filled"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total # of Guests"
        '
        'RoomsTxtBox
        '
        Me.RoomsTxtBox.Enabled = False
        Me.RoomsTxtBox.Location = New System.Drawing.Point(152, 56)
        Me.RoomsTxtBox.Name = "RoomsTxtBox"
        Me.RoomsTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.RoomsTxtBox.TabIndex = 4
        '
        'GuestsTxtBox
        '
        Me.GuestsTxtBox.Enabled = False
        Me.GuestsTxtBox.Location = New System.Drawing.Point(152, 90)
        Me.GuestsTxtBox.Name = "GuestsTxtBox"
        Me.GuestsTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.GuestsTxtBox.TabIndex = 5
        '
        'SelectDayComboBox
        '
        Me.SelectDayComboBox.FormattingEnabled = True
        Me.SelectDayComboBox.Location = New System.Drawing.Point(143, 23)
        Me.SelectDayComboBox.Name = "SelectDayComboBox"
        Me.SelectDayComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SelectDayComboBox.TabIndex = 6
        '
        'Occupancy_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 133)
        Me.Controls.Add(Me.SelectDayComboBox)
        Me.Controls.Add(Me.GuestsTxtBox)
        Me.Controls.Add(Me.RoomsTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Occupancy_Data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Occupancy Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RoomsTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents GuestsTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents SelectDayComboBox As System.Windows.Forms.ComboBox

End Class
