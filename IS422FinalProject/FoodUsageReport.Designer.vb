<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodUsageReport
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
        Me.totalFoodUsageDGV = New System.Windows.Forms.DataGridView()
        Me.runReport = New System.Windows.Forms.Button()
        Me.foodUsageDGV2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.totalFoodUsageDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foodUsageDGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totalFoodUsageDGV
        '
        Me.totalFoodUsageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.totalFoodUsageDGV.Location = New System.Drawing.Point(12, 278)
        Me.totalFoodUsageDGV.Name = "totalFoodUsageDGV"
        Me.totalFoodUsageDGV.Size = New System.Drawing.Size(684, 150)
        Me.totalFoodUsageDGV.TabIndex = 27
        '
        'runReport
        '
        Me.runReport.Location = New System.Drawing.Point(261, 21)
        Me.runReport.Name = "runReport"
        Me.runReport.Size = New System.Drawing.Size(109, 36)
        Me.runReport.TabIndex = 28
        Me.runReport.Text = "Run Report"
        Me.runReport.UseVisualStyleBackColor = True
        '
        'foodUsageDGV2
        '
        Me.foodUsageDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.foodUsageDGV2.Location = New System.Drawing.Point(12, 74)
        Me.foodUsageDGV2.Name = "foodUsageDGV2"
        Me.foodUsageDGV2.Size = New System.Drawing.Size(684, 150)
        Me.foodUsageDGV2.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Consumption by Event"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Total Consumption by Week"
        '
        'FoodUsageReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 440)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.foodUsageDGV2)
        Me.Controls.Add(Me.runReport)
        Me.Controls.Add(Me.totalFoodUsageDGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FoodUsageReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FoodUsageReport"
        CType(Me.totalFoodUsageDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foodUsageDGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents totalFoodUsageDGV As System.Windows.Forms.DataGridView
    Friend WithEvents runReport As System.Windows.Forms.Button
    Friend WithEvents foodUsageDGV2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
