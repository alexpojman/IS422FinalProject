<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery_Driver
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
        Me.DriverNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.DoBLabel = New System.Windows.Forms.Label()
        Me.AddDriverBtn = New System.Windows.Forms.Button()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.DeliveryDriverDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ZipTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CityTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AdressTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DriverNameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'DriverNameLabel
        '
        Me.DriverNameLabel.AutoSize = True
        Me.DriverNameLabel.Location = New System.Drawing.Point(19, 16)
        Me.DriverNameLabel.Name = "DriverNameLabel"
        Me.DriverNameLabel.Size = New System.Drawing.Size(66, 13)
        Me.DriverNameLabel.TabIndex = 0
        Me.DriverNameLabel.Text = "Driver Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(19, 44)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 1
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(19, 73)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 2
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(19, 99)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 3
        Me.StateLabel.Text = "State"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(19, 126)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(22, 13)
        Me.ZipLabel.TabIndex = 4
        Me.ZipLabel.Text = "Zip"
        '
        'DoBLabel
        '
        Me.DoBLabel.AutoSize = True
        Me.DoBLabel.Location = New System.Drawing.Point(19, 152)
        Me.DoBLabel.Name = "DoBLabel"
        Me.DoBLabel.Size = New System.Drawing.Size(68, 13)
        Me.DoBLabel.TabIndex = 5
        Me.DoBLabel.Text = "Date Of Birth"
        '
        'AddDriverBtn
        '
        Me.AddDriverBtn.Location = New System.Drawing.Point(183, 175)
        Me.AddDriverBtn.Name = "AddDriverBtn"
        Me.AddDriverBtn.Size = New System.Drawing.Size(89, 34)
        Me.AddDriverBtn.TabIndex = 8
        Me.AddDriverBtn.Text = "Add Driver Info"
        Me.AddDriverBtn.UseVisualStyleBackColor = True
        '
        'StateComboBox
        '
        Me.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"Alabama" & Global.Microsoft.VisualBasic.ChrW(9), "Alaska" & Global.Microsoft.VisualBasic.ChrW(9), "Arizona", "Arkansas", "California" & Global.Microsoft.VisualBasic.ChrW(9), "Colorado" & Global.Microsoft.VisualBasic.ChrW(9), "Connecticut" & Global.Microsoft.VisualBasic.ChrW(9), "Delaware", "Florida" & Global.Microsoft.VisualBasic.ChrW(9), "Georgia" & Global.Microsoft.VisualBasic.ChrW(9), "Hawaii" & Global.Microsoft.VisualBasic.ChrW(9), "Idaho", "Illinois" & Global.Microsoft.VisualBasic.ChrW(9), "Indiana" & Global.Microsoft.VisualBasic.ChrW(9), "Iowa" & Global.Microsoft.VisualBasic.ChrW(9), "Kansas", "Kentucky" & Global.Microsoft.VisualBasic.ChrW(9), "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9), "Maine" & Global.Microsoft.VisualBasic.ChrW(9), "Maryland", "Massachusetts" & Global.Microsoft.VisualBasic.ChrW(9), "Michigan" & Global.Microsoft.VisualBasic.ChrW(9), "Minnesota" & Global.Microsoft.VisualBasic.ChrW(9), "Mississippi", "Missouri", "Montana" & Global.Microsoft.VisualBasic.ChrW(9), "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9), "Nevada", "New Hampshire" & Global.Microsoft.VisualBasic.ChrW(9), "New Jersey" & Global.Microsoft.VisualBasic.ChrW(9), "New Mexico" & Global.Microsoft.VisualBasic.ChrW(9), "New York", "North Carolina" & Global.Microsoft.VisualBasic.ChrW(9), "North Dakota" & Global.Microsoft.VisualBasic.ChrW(9), "Ohio" & Global.Microsoft.VisualBasic.ChrW(9), "Oklahoma", "Oregon" & Global.Microsoft.VisualBasic.ChrW(9), "Pennsylvania" & Global.Microsoft.VisualBasic.ChrW(9), "Rhode Island" & Global.Microsoft.VisualBasic.ChrW(9), "South Carolina", "South Dakota" & Global.Microsoft.VisualBasic.ChrW(9), "Tennessee" & Global.Microsoft.VisualBasic.ChrW(9), "Texas" & Global.Microsoft.VisualBasic.ChrW(9), "Utah", "Vermont" & Global.Microsoft.VisualBasic.ChrW(9), "Virginia" & Global.Microsoft.VisualBasic.ChrW(9), "Washington" & Global.Microsoft.VisualBasic.ChrW(9), "West Virginia", "Wisconsin", "Wyoming" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.StateComboBox.Location = New System.Drawing.Point(151, 96)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StateComboBox.TabIndex = 4
        '
        'DeliveryDriverDateTimePicker
        '
        Me.DeliveryDriverDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DeliveryDriverDateTimePicker.Location = New System.Drawing.Point(151, 149)
        Me.DeliveryDriverDateTimePicker.Name = "DeliveryDriverDateTimePicker"
        Me.DeliveryDriverDateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.DeliveryDriverDateTimePicker.TabIndex = 6
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(151, 123)
        Me.ZipTextBox.Mask = "00000"
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ZipTextBox.TabIndex = 5
        Me.ZipTextBox.ValidatingType = GetType(Integer)
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(151, 70)
        Me.CityTextBox.Mask = "?????????????????????????????????????????????????????????????????????"
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CityTextBox.TabIndex = 3
        '
        'AdressTextBox
        '
        Me.AdressTextBox.Location = New System.Drawing.Point(151, 44)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AdressTextBox.TabIndex = 2
        '
        'DriverNameTextBox
        '
        Me.DriverNameTextBox.Location = New System.Drawing.Point(151, 18)
        Me.DriverNameTextBox.Mask = "???????????????????????????????????????????"
        Me.DriverNameTextBox.Name = "DriverNameTextBox"
        Me.DriverNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DriverNameTextBox.TabIndex = 1
        '
        'Delivery_Driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 221)
        Me.Controls.Add(Me.DriverNameTextBox)
        Me.Controls.Add(Me.AdressTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.DeliveryDriverDateTimePicker)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(Me.AddDriverBtn)
        Me.Controls.Add(Me.DoBLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.DriverNameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Delivery_Driver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Driver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DriverNameLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents StateLabel As System.Windows.Forms.Label
    Friend WithEvents ZipLabel As System.Windows.Forms.Label
    Friend WithEvents DoBLabel As System.Windows.Forms.Label
    Friend WithEvents AddDriverBtn As System.Windows.Forms.Button
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeliveryDriverDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ZipTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AdressTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DriverNameTextBox As System.Windows.Forms.MaskedTextBox
End Class
