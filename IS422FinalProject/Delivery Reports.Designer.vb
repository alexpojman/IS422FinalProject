<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery_Reports
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
        Me.deliveryReportGB = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.deliveryReportDGV = New System.Windows.Forms.DataGridView()
        Me.deliveryReportGB.SuspendLayout()
        CType(Me.deliveryReportDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deliveryReportGB
        '
        Me.deliveryReportGB.Controls.Add(Me.Button1)
        Me.deliveryReportGB.Controls.Add(Me.deliveryReportDGV)
        Me.deliveryReportGB.Location = New System.Drawing.Point(12, 12)
        Me.deliveryReportGB.Name = "deliveryReportGB"
        Me.deliveryReportGB.Size = New System.Drawing.Size(772, 277)
        Me.deliveryReportGB.TabIndex = 0
        Me.deliveryReportGB.TabStop = False
        Me.deliveryReportGB.Text = "Delivery Info"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Run Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deliveryReportDGV
        '
        Me.deliveryReportDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.deliveryReportDGV.Location = New System.Drawing.Point(6, 55)
        Me.deliveryReportDGV.Name = "deliveryReportDGV"
        Me.deliveryReportDGV.Size = New System.Drawing.Size(760, 252)
        Me.deliveryReportDGV.TabIndex = 0
        '
        'Delivery_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 347)
        Me.Controls.Add(Me.deliveryReportGB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Delivery_Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Reports"
        Me.deliveryReportGB.ResumeLayout(False)
        CType(Me.deliveryReportDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deliveryReportGB As System.Windows.Forms.GroupBox
    Friend WithEvents deliveryReportDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
