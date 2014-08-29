<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeesched
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
        Me.punchINbutton = New System.Windows.Forms.Button()
        Me.punchOUTbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.empNametextbox = New System.Windows.Forms.MaskedTextBox()
        Me.hourratetextbox = New System.Windows.Forms.MaskedTextBox()
        Me.datetextbox = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.SelectEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.StudentAssignComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnAssign = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AssignShiftDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.AssignShiftTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Approval = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'punchINbutton
        '
        Me.punchINbutton.Enabled = False
        Me.punchINbutton.Location = New System.Drawing.Point(25, 256)
        Me.punchINbutton.Name = "punchINbutton"
        Me.punchINbutton.Size = New System.Drawing.Size(75, 23)
        Me.punchINbutton.TabIndex = 0
        Me.punchINbutton.Text = "Punch IN"
        Me.punchINbutton.UseVisualStyleBackColor = True
        '
        'punchOUTbutton
        '
        Me.punchOUTbutton.Enabled = False
        Me.punchOUTbutton.Location = New System.Drawing.Point(135, 256)
        Me.punchOUTbutton.Name = "punchOUTbutton"
        Me.punchOUTbutton.Size = New System.Drawing.Size(75, 23)
        Me.punchOUTbutton.TabIndex = 1
        Me.punchOUTbutton.Text = "Punch OUT"
        Me.punchOUTbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hourly Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date"
        '
        'empNametextbox
        '
        Me.empNametextbox.Enabled = False
        Me.empNametextbox.Location = New System.Drawing.Point(110, 146)
        Me.empNametextbox.Name = "empNametextbox"
        Me.empNametextbox.Size = New System.Drawing.Size(100, 20)
        Me.empNametextbox.TabIndex = 8
        '
        'hourratetextbox
        '
        Me.hourratetextbox.Enabled = False
        Me.hourratetextbox.Location = New System.Drawing.Point(110, 172)
        Me.hourratetextbox.Name = "hourratetextbox"
        Me.hourratetextbox.Size = New System.Drawing.Size(100, 20)
        Me.hourratetextbox.TabIndex = 9
        '
        'datetextbox
        '
        Me.datetextbox.Enabled = False
        Me.datetextbox.Location = New System.Drawing.Point(110, 198)
        Me.datetextbox.Name = "datetextbox"
        Me.datetextbox.Size = New System.Drawing.Size(170, 20)
        Me.datetextbox.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Approval})
        Me.DataGridView1.Location = New System.Drawing.Point(226, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(652, 160)
        Me.DataGridView1.TabIndex = 12
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Enabled = False
        Me.BtnSubmit.Location = New System.Drawing.Point(67, 82)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 17
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'SelectEmployeeComboBox
        '
        Me.SelectEmployeeComboBox.FormattingEnabled = True
        Me.SelectEmployeeComboBox.Location = New System.Drawing.Point(89, 22)
        Me.SelectEmployeeComboBox.Name = "SelectEmployeeComboBox"
        Me.SelectEmployeeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SelectEmployeeComboBox.TabIndex = 18
        '
        'StudentAssignComboBox
        '
        Me.StudentAssignComboBox.Enabled = False
        Me.StudentAssignComboBox.FormattingEnabled = True
        Me.StudentAssignComboBox.Location = New System.Drawing.Point(678, 197)
        Me.StudentAssignComboBox.Name = "StudentAssignComboBox"
        Me.StudentAssignComboBox.Size = New System.Drawing.Size(200, 21)
        Me.StudentAssignComboBox.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(622, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Student:"
        '
        'BtnAssign
        '
        Me.BtnAssign.Enabled = False
        Me.BtnAssign.Location = New System.Drawing.Point(740, 276)
        Me.BtnAssign.Name = "BtnAssign"
        Me.BtnAssign.Size = New System.Drawing.Size(75, 23)
        Me.BtnAssign.TabIndex = 23
        Me.BtnAssign.Text = "Assign"
        Me.BtnAssign.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(89, 50)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PasswordTextBox.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Password"
        '
        'AssignShiftDatePicker
        '
        Me.AssignShiftDatePicker.Enabled = False
        Me.AssignShiftDatePicker.Location = New System.Drawing.Point(678, 224)
        Me.AssignShiftDatePicker.Name = "AssignShiftDatePicker"
        Me.AssignShiftDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.AssignShiftDatePicker.TabIndex = 26
        '
        'AssignShiftTimePicker
        '
        Me.AssignShiftTimePicker.Enabled = False
        Me.AssignShiftTimePicker.Location = New System.Drawing.Point(678, 250)
        Me.AssignShiftTimePicker.Name = "AssignShiftTimePicker"
        Me.AssignShiftTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AssignShiftTimePicker.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(636, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(608, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Start Time: "
        '
        'Approval
        '
        Me.Approval.Frozen = True
        Me.Approval.HeaderText = "Approve"
        Me.Approval.Name = "Approval"
        Me.Approval.ReadOnly = True
        '
        'employeesched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 330)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AssignShiftTimePicker)
        Me.Controls.Add(Me.AssignShiftDatePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.BtnAssign)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StudentAssignComboBox)
        Me.Controls.Add(Me.SelectEmployeeComboBox)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.datetextbox)
        Me.Controls.Add(Me.hourratetextbox)
        Me.Controls.Add(Me.empNametextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.punchOUTbutton)
        Me.Controls.Add(Me.punchINbutton)
        Me.Name = "employeesched"
        Me.Text = "Employee Schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents punchINbutton As System.Windows.Forms.Button
    Friend WithEvents punchOUTbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents empNametextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents hourratetextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents datetextbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents SelectEmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StudentAssignComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnAssign As System.Windows.Forms.Button
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AssignShiftDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AssignShiftTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Approval As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
