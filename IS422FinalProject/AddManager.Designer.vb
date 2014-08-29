<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddManager
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
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.MiddleInitialLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.DeptLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.PayRateLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MiddleInitialTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.LastNameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TitleTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PayRateTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AddressTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CityTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ZipTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PhoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DeptComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(5, 25)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(5, 77)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(61, 13)
        Me.LastNameLabel.TabIndex = 1
        Me.LastNameLabel.Text = "Last Name:"
        '
        'MiddleInitialLabel
        '
        Me.MiddleInitialLabel.AutoSize = True
        Me.MiddleInitialLabel.Location = New System.Drawing.Point(5, 51)
        Me.MiddleInitialLabel.Name = "MiddleInitialLabel"
        Me.MiddleInitialLabel.Size = New System.Drawing.Size(68, 13)
        Me.MiddleInitialLabel.TabIndex = 2
        Me.MiddleInitialLabel.Text = "Middle Initial:"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(5, 16)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(30, 13)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Title:"
        '
        'DeptLabel
        '
        Me.DeptLabel.AutoSize = True
        Me.DeptLabel.Location = New System.Drawing.Point(6, 68)
        Me.DeptLabel.Name = "DeptLabel"
        Me.DeptLabel.Size = New System.Drawing.Size(65, 13)
        Me.DeptLabel.TabIndex = 4
        Me.DeptLabel.Text = "Department:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(4, 21)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(48, 13)
        Me.AddressLabel.TabIndex = 5
        Me.AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(6, 47)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(27, 13)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City:"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(4, 99)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(27, 13)
        Me.ZipLabel.TabIndex = 7
        Me.ZipLabel.Text = "ZIP:"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(4, 125)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(44, 13)
        Me.PhoneLabel.TabIndex = 8
        Me.PhoneLabel.Text = "Phone: "
        '
        'PayRateLabel
        '
        Me.PayRateLabel.AutoSize = True
        Me.PayRateLabel.Location = New System.Drawing.Point(5, 42)
        Me.PayRateLabel.Name = "PayRateLabel"
        Me.PayRateLabel.Size = New System.Drawing.Size(54, 13)
        Me.PayRateLabel.TabIndex = 9
        Me.PayRateLabel.Text = "Pay Rate:"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(4, 73)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(35, 13)
        Me.StateLabel.TabIndex = 10
        Me.StateLabel.Text = "State:"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(198, 400)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 12
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(115, 22)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(136, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'MiddleInitialTextBox
        '
        Me.MiddleInitialTextBox.Location = New System.Drawing.Point(115, 48)
        Me.MiddleInitialTextBox.Mask = "a"
        Me.MiddleInitialTextBox.Name = "MiddleInitialTextBox"
        Me.MiddleInitialTextBox.Size = New System.Drawing.Size(136, 20)
        Me.MiddleInitialTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(115, 74)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(136, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(115, 13)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(136, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'PayRateTextBox
        '
        Me.PayRateTextBox.Location = New System.Drawing.Point(115, 39)
        Me.PayRateTextBox.Mask = "$00000.00"
        Me.PayRateTextBox.Name = "PayRateTextBox"
        Me.PayRateTextBox.Size = New System.Drawing.Size(136, 20)
        Me.PayRateTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(115, 18)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(136, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(115, 44)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(136, 20)
        Me.CityTextBox.TabIndex = 8
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(115, 96)
        Me.ZipTextBox.Mask = "00000"
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(136, 20)
        Me.ZipTextBox.TabIndex = 10
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(115, 122)
        Me.PhoneTextBox.Mask = "(999) 000-0000"
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(136, 20)
        Me.PhoneTextBox.TabIndex = 11
        '
        'DeptComboBox
        '
        Me.DeptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeptComboBox.FormattingEnabled = True
        Me.DeptComboBox.Items.AddRange(New Object() {"Food"})
        Me.DeptComboBox.Location = New System.Drawing.Point(115, 65)
        Me.DeptComboBox.Name = "DeptComboBox"
        Me.DeptComboBox.Size = New System.Drawing.Size(138, 21)
        Me.DeptComboBox.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MiddleInitialLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.MiddleInitialTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 100)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.StartDatePicker)
        Me.GroupBox2.Controls.Add(Me.StartDateLabel)
        Me.GroupBox2.Controls.Add(Me.TitleLabel)
        Me.GroupBox2.Controls.Add(Me.DeptLabel)
        Me.GroupBox2.Controls.Add(Me.DeptComboBox)
        Me.GroupBox2.Controls.Add(Me.PayRateLabel)
        Me.GroupBox2.Controls.Add(Me.TitleTextBox)
        Me.GroupBox2.Controls.Add(Me.PayRateTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 121)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position Info"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.StateComboBox)
        Me.GroupBox3.Controls.Add(Me.AddressLabel)
        Me.GroupBox3.Controls.Add(Me.CityLabel)
        Me.GroupBox3.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox3.Controls.Add(Me.ZipLabel)
        Me.GroupBox3.Controls.Add(Me.ZipTextBox)
        Me.GroupBox3.Controls.Add(Me.PhoneLabel)
        Me.GroupBox3.Controls.Add(Me.CityTextBox)
        Me.GroupBox3.Controls.Add(Me.StateLabel)
        Me.GroupBox3.Controls.Add(Me.AddressTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 149)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Info"
        '
        'StateComboBox
        '
        Me.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"Alabama" & Global.Microsoft.VisualBasic.ChrW(9), "Alaska" & Global.Microsoft.VisualBasic.ChrW(9), "Arizona", "Arkansas", "California" & Global.Microsoft.VisualBasic.ChrW(9), "Colorado" & Global.Microsoft.VisualBasic.ChrW(9), "Connecticut" & Global.Microsoft.VisualBasic.ChrW(9), "Delaware", "Florida" & Global.Microsoft.VisualBasic.ChrW(9), "Georgia" & Global.Microsoft.VisualBasic.ChrW(9), "Hawaii" & Global.Microsoft.VisualBasic.ChrW(9), "Idaho", "Illinois" & Global.Microsoft.VisualBasic.ChrW(9), "Indiana" & Global.Microsoft.VisualBasic.ChrW(9), "Iowa" & Global.Microsoft.VisualBasic.ChrW(9), "Kansas", "Kentucky" & Global.Microsoft.VisualBasic.ChrW(9), "Louisiana" & Global.Microsoft.VisualBasic.ChrW(9), "Maine" & Global.Microsoft.VisualBasic.ChrW(9), "Maryland", "Massachusetts" & Global.Microsoft.VisualBasic.ChrW(9), "Michigan" & Global.Microsoft.VisualBasic.ChrW(9), "Minnesota" & Global.Microsoft.VisualBasic.ChrW(9), "Mississippi", "Missouri", "Montana" & Global.Microsoft.VisualBasic.ChrW(9), "Nebraska" & Global.Microsoft.VisualBasic.ChrW(9), "Nevada", "New Hampshire" & Global.Microsoft.VisualBasic.ChrW(9), "New Jersey" & Global.Microsoft.VisualBasic.ChrW(9), "New Mexico" & Global.Microsoft.VisualBasic.ChrW(9), "New York", "North Carolina" & Global.Microsoft.VisualBasic.ChrW(9), "North Dakota" & Global.Microsoft.VisualBasic.ChrW(9), "Ohio" & Global.Microsoft.VisualBasic.ChrW(9), "Oklahoma", "Oregon" & Global.Microsoft.VisualBasic.ChrW(9), "Pennsylvania" & Global.Microsoft.VisualBasic.ChrW(9), "Rhode Island" & Global.Microsoft.VisualBasic.ChrW(9), "South Carolina", "South Dakota" & Global.Microsoft.VisualBasic.ChrW(9), "Tennessee" & Global.Microsoft.VisualBasic.ChrW(9), "Texas" & Global.Microsoft.VisualBasic.ChrW(9), "Utah", "Vermont" & Global.Microsoft.VisualBasic.ChrW(9), "Virginia" & Global.Microsoft.VisualBasic.ChrW(9), "Washington" & Global.Microsoft.VisualBasic.ChrW(9), "West Virginia", "Wisconsin", "Wyoming" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.StateComboBox.Location = New System.Drawing.Point(115, 69)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(136, 21)
        Me.StateComboBox.TabIndex = 9
        '
        'StartDateLabel
        '
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Location = New System.Drawing.Point(6, 92)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(58, 13)
        Me.StartDateLabel.TabIndex = 10
        Me.StartDateLabel.Text = "Start Date:"
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDatePicker.Location = New System.Drawing.Point(115, 92)
        Me.StartDatePicker.MinDate = New Date(2013, 12, 8, 0, 0, 0, 0)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(138, 20)
        Me.StartDatePicker.TabIndex = 11
        '
        'AddManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 435)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "AddManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents MiddleInitialLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents DeptLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents CityLabel As System.Windows.Forms.Label
    Friend WithEvents ZipLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents PayRateLabel As System.Windows.Forms.Label
    Friend WithEvents StateLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MiddleInitialTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PayRateTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DeptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDateLabel As System.Windows.Forms.Label
End Class
