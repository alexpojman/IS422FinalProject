<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostOfLabor
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
        Me.costOFLaborDGV = New System.Windows.Forms.DataGridView()
        Me.totalLaborCostDGV = New System.Windows.Forms.DataGridView()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.costOFLaborDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalLaborCostDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'costOFLaborDGV
        '
        Me.costOFLaborDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.costOFLaborDGV.Location = New System.Drawing.Point(31, 79)
        Me.costOFLaborDGV.Name = "costOFLaborDGV"
        Me.costOFLaborDGV.Size = New System.Drawing.Size(645, 150)
        Me.costOFLaborDGV.TabIndex = 8
        '
        'totalLaborCostDGV
        '
        Me.totalLaborCostDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.totalLaborCostDGV.Location = New System.Drawing.Point(31, 258)
        Me.totalLaborCostDGV.Name = "totalLaborCostDGV"
        Me.totalLaborCostDGV.Size = New System.Drawing.Size(645, 150)
        Me.totalLaborCostDGV.TabIndex = 9
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(89, 12)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(187, 41)
        Me.submitButton.TabIndex = 10
        Me.submitButton.Text = "View Reports"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cost Per Day by Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total Wages Per Day"
        '
        'CostOfLabor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 419)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.totalLaborCostDGV)
        Me.Controls.Add(Me.costOFLaborDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CostOfLabor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cost of Labor"
        CType(Me.costOFLaborDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalLaborCostDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents costOFLaborDGV As System.Windows.Forms.DataGridView
    Friend WithEvents totalLaborCostDGV As System.Windows.Forms.DataGridView
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
