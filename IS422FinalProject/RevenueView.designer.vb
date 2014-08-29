<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevenueView
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filterDateCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EventTypeCombo = New System.Windows.Forms.ComboBox()
        Me.RevDGV = New System.Windows.Forms.DataGridView()
        Me.TotalRevTextBox = New System.Windows.Forms.Label()
        Me.TotalRevLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me._2013FA422_TeamBDataSet = New WindowsApplication1._2013FA422_TeamBDataSet()
        Me.EVENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EVENTTableAdapter = New WindowsApplication1._2013FA422_TeamBDataSetTableAdapters.EVENTTableAdapter()
        CType(Me.RevDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._2013FA422_TeamBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "By Event"
        '
        'filterDateCheckbox
        '
        Me.filterDateCheckbox.AutoSize = True
        Me.filterDateCheckbox.Location = New System.Drawing.Point(47, 63)
        Me.filterDateCheckbox.Name = "filterDateCheckbox"
        Me.filterDateCheckbox.Size = New System.Drawing.Size(109, 17)
        Me.filterDateCheckbox.TabIndex = 4
        Me.filterDateCheckbox.Text = "Filter Date Range"
        Me.filterDateCheckbox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "To"
        '
        'FromDate
        '
        Me.FromDate.Enabled = False
        Me.FromDate.Location = New System.Drawing.Point(42, 129)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(200, 20)
        Me.FromDate.TabIndex = 7
        '
        'ToDate
        '
        Me.ToDate.Enabled = False
        Me.ToDate.Location = New System.Drawing.Point(483, 129)
        Me.ToDate.MaxDate = New Date(2013, 12, 8, 0, 0, 0, 0)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(200, 20)
        Me.ToDate.TabIndex = 8
        Me.ToDate.Value = New Date(2013, 12, 8, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Event Type"
        '
        'EventTypeCombo
        '
        Me.EventTypeCombo.FormattingEnabled = True
        Me.EventTypeCombo.Items.AddRange(New Object() {"All", "Banquet", "Daily Breakfast", "Lunch"})
        Me.EventTypeCombo.Location = New System.Drawing.Point(122, 167)
        Me.EventTypeCombo.Name = "EventTypeCombo"
        Me.EventTypeCombo.Size = New System.Drawing.Size(121, 21)
        Me.EventTypeCombo.TabIndex = 10
        '
        'RevDGV
        '
        Me.RevDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RevDGV.Location = New System.Drawing.Point(12, 231)
        Me.RevDGV.Name = "RevDGV"
        Me.RevDGV.Size = New System.Drawing.Size(747, 150)
        Me.RevDGV.TabIndex = 11
        '
        'TotalRevTextBox
        '
        Me.TotalRevTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalRevTextBox.Location = New System.Drawing.Point(135, 415)
        Me.TotalRevTextBox.Name = "TotalRevTextBox"
        Me.TotalRevTextBox.Size = New System.Drawing.Size(96, 19)
        Me.TotalRevTextBox.TabIndex = 16
        '
        'TotalRevLabel
        '
        Me.TotalRevLabel.AutoSize = True
        Me.TotalRevLabel.Location = New System.Drawing.Point(30, 416)
        Me.TotalRevLabel.Name = "TotalRevLabel"
        Me.TotalRevLabel.Size = New System.Drawing.Size(81, 13)
        Me.TotalRevLabel.TabIndex = 15
        Me.TotalRevLabel.Text = "Total Revenue:"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(483, 167)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(200, 55)
        Me.SearchButton.TabIndex = 17
        Me.SearchButton.Text = "Search!"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        '_2013FA422_TeamBDataSet
        '
        Me._2013FA422_TeamBDataSet.DataSetName = "_2013FA422_TeamBDataSet"
        Me._2013FA422_TeamBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENTBindingSource
        '
        Me.EVENTBindingSource.DataMember = "EVENT"
        Me.EVENTBindingSource.DataSource = Me._2013FA422_TeamBDataSet
        '
        'EVENTTableAdapter
        '
        Me.EVENTTableAdapter.ClearBeforeFill = True
        '
        'RevenueView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 494)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.TotalRevTextBox)
        Me.Controls.Add(Me.TotalRevLabel)
        Me.Controls.Add(Me.RevDGV)
        Me.Controls.Add(Me.EventTypeCombo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.filterDateCheckbox)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "RevenueView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revenue View"
        CType(Me.RevDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._2013FA422_TeamBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents filterDateCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EventTypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents RevDGV As System.Windows.Forms.DataGridView
    Friend WithEvents TotalRevTextBox As System.Windows.Forms.Label
    Friend WithEvents TotalRevLabel As System.Windows.Forms.Label
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents _2013FA422_TeamBDataSet As WindowsApplication1._2013FA422_TeamBDataSet
    Friend WithEvents EVENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EVENTTableAdapter As WindowsApplication1._2013FA422_TeamBDataSetTableAdapters.EVENTTableAdapter
End Class
