<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventOrder
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
        Me.components = New System.ComponentModel.Container()
        Me.OrderSumGroup = New System.Windows.Forms.GroupBox()
        Me.EventOrderDGV = New System.Windows.Forms.DataGridView()
        Me.OrderSumLabel = New System.Windows.Forms.Label()
        Me.EventNumLabel = New System.Windows.Forms.Label()
        Me.EventDateLabel = New System.Windows.Forms.Label()
        Me.ContactInfoGroup = New System.Windows.Forms.GroupBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.OrgTextBox = New System.Windows.Forms.TextBox()
        Me.CoordinatorTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CoordinatorLabel = New System.Windows.Forms.Label()
        Me.EventDateTextBox = New System.Windows.Forms.TextBox()
        Me.EventNumComboBox = New System.Windows.Forms.ComboBox()
        Me.EVENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._2013FA422_TeamBDataSet = New WindowsApplication1._2013FA422_TeamBDataSet()
        Me.EVENTTableAdapter = New WindowsApplication1._2013FA422_TeamBDataSetTableAdapters.EVENTTableAdapter()
        Me.AttendanceLabel = New System.Windows.Forms.Label()
        Me.OrderSumGroup.SuspendLayout()
        CType(Me.EventOrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContactInfoGroup.SuspendLayout()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._2013FA422_TeamBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderSumGroup
        '
        Me.OrderSumGroup.Controls.Add(Me.EventOrderDGV)
        Me.OrderSumGroup.Location = New System.Drawing.Point(12, 232)
        Me.OrderSumGroup.Name = "OrderSumGroup"
        Me.OrderSumGroup.Size = New System.Drawing.Size(465, 229)
        Me.OrderSumGroup.TabIndex = 0
        Me.OrderSumGroup.TabStop = False
        Me.OrderSumGroup.Text = "Order Summary"
        '
        'EventOrderDGV
        '
        Me.EventOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EventOrderDGV.Location = New System.Drawing.Point(6, 19)
        Me.EventOrderDGV.Name = "EventOrderDGV"
        Me.EventOrderDGV.Size = New System.Drawing.Size(453, 243)
        Me.EventOrderDGV.TabIndex = 0
        '
        'OrderSumLabel
        '
        Me.OrderSumLabel.AutoSize = True
        Me.OrderSumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OrderSumLabel.Location = New System.Drawing.Point(166, 1)
        Me.OrderSumLabel.Name = "OrderSumLabel"
        Me.OrderSumLabel.Size = New System.Drawing.Size(165, 20)
        Me.OrderSumLabel.TabIndex = 1
        Me.OrderSumLabel.Text = "Event Order Summary"
        '
        'EventNumLabel
        '
        Me.EventNumLabel.AutoSize = True
        Me.EventNumLabel.Location = New System.Drawing.Point(147, 28)
        Me.EventNumLabel.Name = "EventNumLabel"
        Me.EventNumLabel.Size = New System.Drawing.Size(78, 13)
        Me.EventNumLabel.TabIndex = 2
        Me.EventNumLabel.Text = "Event Number:"
        '
        'EventDateLabel
        '
        Me.EventDateLabel.AutoSize = True
        Me.EventDateLabel.Location = New System.Drawing.Point(147, 54)
        Me.EventDateLabel.Name = "EventDateLabel"
        Me.EventDateLabel.Size = New System.Drawing.Size(64, 13)
        Me.EventDateLabel.TabIndex = 3
        Me.EventDateLabel.Text = "Event Date:"
        '
        'ContactInfoGroup
        '
        Me.ContactInfoGroup.Controls.Add(Me.EmailTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.EmailLabel)
        Me.ContactInfoGroup.Controls.Add(Me.PhoneTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.OrgTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.CoordinatorTextBox)
        Me.ContactInfoGroup.Controls.Add(Me.Label6)
        Me.ContactInfoGroup.Controls.Add(Me.Label5)
        Me.ContactInfoGroup.Controls.Add(Me.CoordinatorLabel)
        Me.ContactInfoGroup.Location = New System.Drawing.Point(18, 77)
        Me.ContactInfoGroup.Name = "ContactInfoGroup"
        Me.ContactInfoGroup.Size = New System.Drawing.Size(283, 149)
        Me.ContactInfoGroup.TabIndex = 5
        Me.ContactInfoGroup.TabStop = False
        Me.ContactInfoGroup.Text = "Organization Contact Info"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(107, 107)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(10, 107)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(35, 13)
        Me.EmailLabel.TabIndex = 6
        Me.EmailLabel.Text = "Email:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(107, 81)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 5
        '
        'OrgTextBox
        '
        Me.OrgTextBox.Location = New System.Drawing.Point(107, 55)
        Me.OrgTextBox.Name = "OrgTextBox"
        Me.OrgTextBox.ReadOnly = True
        Me.OrgTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrgTextBox.TabIndex = 4
        '
        'CoordinatorTextBox
        '
        Me.CoordinatorTextBox.Location = New System.Drawing.Point(107, 28)
        Me.CoordinatorTextBox.Name = "CoordinatorTextBox"
        Me.CoordinatorTextBox.ReadOnly = True
        Me.CoordinatorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CoordinatorTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Organization:"
        '
        'CoordinatorLabel
        '
        Me.CoordinatorLabel.AutoSize = True
        Me.CoordinatorLabel.Location = New System.Drawing.Point(8, 31)
        Me.CoordinatorLabel.Name = "CoordinatorLabel"
        Me.CoordinatorLabel.Size = New System.Drawing.Size(64, 13)
        Me.CoordinatorLabel.TabIndex = 0
        Me.CoordinatorLabel.Text = "Coordinator:"
        '
        'EventDateTextBox
        '
        Me.EventDateTextBox.Location = New System.Drawing.Point(231, 51)
        Me.EventDateTextBox.Name = "EventDateTextBox"
        Me.EventDateTextBox.ReadOnly = True
        Me.EventDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EventDateTextBox.TabIndex = 9
        '
        'EventNumComboBox
        '
        Me.EventNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventNumComboBox.FormattingEnabled = True
        Me.EventNumComboBox.Location = New System.Drawing.Point(232, 24)
        Me.EventNumComboBox.Name = "EventNumComboBox"
        Me.EventNumComboBox.Size = New System.Drawing.Size(99, 21)
        Me.EventNumComboBox.TabIndex = 10
        '
        'EVENTBindingSource
        '
        Me.EVENTBindingSource.DataMember = "EVENT"
        Me.EVENTBindingSource.DataSource = Me._2013FA422_TeamBDataSet
        '
        '_2013FA422_TeamBDataSet
        '
        Me._2013FA422_TeamBDataSet.DataSetName = "_2013FA422_TeamBDataSet"
        Me._2013FA422_TeamBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTTableAdapter
        '
        Me.EVENTTableAdapter.ClearBeforeFill = True
        '
        'AttendanceLabel
        '
        Me.AttendanceLabel.AutoSize = True
        Me.AttendanceLabel.Location = New System.Drawing.Point(307, 87)
        Me.AttendanceLabel.Name = "AttendanceLabel"
        Me.AttendanceLabel.Size = New System.Drawing.Size(114, 13)
        Me.AttendanceLabel.TabIndex = 11
        Me.AttendanceLabel.Text = "Estimated Attendance:"
        '
        'EventOrder
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(489, 473)
        Me.Controls.Add(Me.AttendanceLabel)
        Me.Controls.Add(Me.EventNumComboBox)
        Me.Controls.Add(Me.EventDateTextBox)
        Me.Controls.Add(Me.ContactInfoGroup)
        Me.Controls.Add(Me.EventDateLabel)
        Me.Controls.Add(Me.EventNumLabel)
        Me.Controls.Add(Me.OrderSumLabel)
        Me.Controls.Add(Me.OrderSumGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "EventOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Event Order Summary"
        Me.OrderSumGroup.ResumeLayout(False)
        CType(Me.EventOrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContactInfoGroup.ResumeLayout(False)
        Me.ContactInfoGroup.PerformLayout()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._2013FA422_TeamBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderSumGroup As System.Windows.Forms.GroupBox
    Friend WithEvents EventOrderDGV As System.Windows.Forms.DataGridView
    Friend WithEvents OrderSumLabel As System.Windows.Forms.Label
    Friend WithEvents EventNumLabel As System.Windows.Forms.Label
    Friend WithEvents EventDateLabel As System.Windows.Forms.Label
    Friend WithEvents ContactInfoGroup As System.Windows.Forms.GroupBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoordinatorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CoordinatorLabel As System.Windows.Forms.Label
    Friend WithEvents EventDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventNumComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents _2013FA422_TeamBDataSet As WindowsApplication1._2013FA422_TeamBDataSet
    Friend WithEvents EVENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTTableAdapter As WindowsApplication1._2013FA422_TeamBDataSetTableAdapters.EVENTTableAdapter
    Friend WithEvents AttendanceLabel As System.Windows.Forms.Label
End Class
