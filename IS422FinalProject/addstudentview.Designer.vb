<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addstudentview
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.firstnameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.lastnameTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.middleInitTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.titleTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.payRateTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.hoursPerWeekTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.DeptComboBox = New System.Windows.Forms.ComboBox()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.StartDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add Student"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Middle Initial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pay Rate:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Title:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Hours Per Week:"
        '
        'firstnameTextBox
        '
        Me.firstnameTextBox.Location = New System.Drawing.Point(103, 27)
        Me.firstnameTextBox.Name = "firstnameTextBox"
        Me.firstnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.firstnameTextBox.TabIndex = 1
        '
        'lastnameTextBox
        '
        Me.lastnameTextBox.Location = New System.Drawing.Point(103, 79)
        Me.lastnameTextBox.Name = "lastnameTextBox"
        Me.lastnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lastnameTextBox.TabIndex = 3
        '
        'middleInitTextBox
        '
        Me.middleInitTextBox.Location = New System.Drawing.Point(103, 53)
        Me.middleInitTextBox.Mask = "a"
        Me.middleInitTextBox.Name = "middleInitTextBox"
        Me.middleInitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.middleInitTextBox.TabIndex = 2
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(103, 105)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.titleTextBox.TabIndex = 4
        '
        'payRateTextBox
        '
        Me.payRateTextBox.Location = New System.Drawing.Point(103, 131)
        Me.payRateTextBox.Mask = "$00.00"
        Me.payRateTextBox.Name = "payRateTextBox"
        Me.payRateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.payRateTextBox.TabIndex = 5
        '
        'hoursPerWeekTextBox
        '
        Me.hoursPerWeekTextBox.Location = New System.Drawing.Point(103, 157)
        Me.hoursPerWeekTextBox.Mask = "00.00"
        Me.hoursPerWeekTextBox.Name = "hoursPerWeekTextBox"
        Me.hoursPerWeekTextBox.Size = New System.Drawing.Size(100, 20)
        Me.hoursPerWeekTextBox.TabIndex = 6
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.AutoSize = True
        Me.DepartmentLabel.Location = New System.Drawing.Point(8, 186)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(65, 13)
        Me.DepartmentLabel.TabIndex = 14
        Me.DepartmentLabel.Text = "Department:"
        '
        'DeptComboBox
        '
        Me.DeptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeptComboBox.FormattingEnabled = True
        Me.DeptComboBox.Items.AddRange(New Object() {"Food"})
        Me.DeptComboBox.Location = New System.Drawing.Point(103, 183)
        Me.DeptComboBox.Name = "DeptComboBox"
        Me.DeptComboBox.Size = New System.Drawing.Size(100, 21)
        Me.DeptComboBox.TabIndex = 7
        '
        'StartDateLabel
        '
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Location = New System.Drawing.Point(8, 211)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(58, 13)
        Me.StartDateLabel.TabIndex = 15
        Me.StartDateLabel.Text = "Start Date:"
        '
        'StartDatePicker
        '
        Me.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDatePicker.Location = New System.Drawing.Point(103, 211)
        Me.StartDatePicker.MinDate = New Date(2013, 12, 8, 0, 0, 0, 0)
        Me.StartDatePicker.Name = "StartDatePicker"
        Me.StartDatePicker.Size = New System.Drawing.Size(100, 20)
        Me.StartDatePicker.TabIndex = 16
        '
        'addstudentview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 274)
        Me.Controls.Add(Me.StartDatePicker)
        Me.Controls.Add(Me.StartDateLabel)
        Me.Controls.Add(Me.DeptComboBox)
        Me.Controls.Add(Me.DepartmentLabel)
        Me.Controls.Add(Me.hoursPerWeekTextBox)
        Me.Controls.Add(Me.payRateTextBox)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.middleInitTextBox)
        Me.Controls.Add(Me.lastnameTextBox)
        Me.Controls.Add(Me.firstnameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "addstudentview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents firstnameTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lastnameTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents middleInitTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents titleTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents payRateTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents hoursPerWeekTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DepartmentLabel As System.Windows.Forms.Label
    Friend WithEvents DeptComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StartDateLabel As System.Windows.Forms.Label
    Friend WithEvents StartDatePicker As System.Windows.Forms.DateTimePicker
End Class
