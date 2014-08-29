<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.FoodItemDgv = New System.Windows.Forms.DataGridView()
        Me.SupplyItemDgv = New System.Windows.Forms.DataGridView()
        Me.SupplyItemsGroup = New System.Windows.Forms.GroupBox()
        Me.FoodItemsGroup = New System.Windows.Forms.GroupBox()
        Me.CurInvLabel = New System.Windows.Forms.Label()
        Me.CurDateLabel = New System.Windows.Forms.Label()
        Me.CurTimeLabel = New System.Windows.Forms.Label()
        CType(Me.FoodItemDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplyItemDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplyItemsGroup.SuspendLayout()
        Me.FoodItemsGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'FoodItemDgv
        '
        Me.FoodItemDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FoodItemDgv.Location = New System.Drawing.Point(6, 23)
        Me.FoodItemDgv.Name = "FoodItemDgv"
        Me.FoodItemDgv.Size = New System.Drawing.Size(486, 184)
        Me.FoodItemDgv.TabIndex = 0
        '
        'SupplyItemDgv
        '
        Me.SupplyItemDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplyItemDgv.Location = New System.Drawing.Point(6, 19)
        Me.SupplyItemDgv.Name = "SupplyItemDgv"
        Me.SupplyItemDgv.Size = New System.Drawing.Size(486, 197)
        Me.SupplyItemDgv.TabIndex = 1
        '
        'SupplyItemsGroup
        '
        Me.SupplyItemsGroup.Controls.Add(Me.SupplyItemDgv)
        Me.SupplyItemsGroup.Location = New System.Drawing.Point(12, 288)
        Me.SupplyItemsGroup.Name = "SupplyItemsGroup"
        Me.SupplyItemsGroup.Size = New System.Drawing.Size(498, 222)
        Me.SupplyItemsGroup.TabIndex = 2
        Me.SupplyItemsGroup.TabStop = False
        Me.SupplyItemsGroup.Text = "Supply Items"
        '
        'FoodItemsGroup
        '
        Me.FoodItemsGroup.Controls.Add(Me.FoodItemDgv)
        Me.FoodItemsGroup.Location = New System.Drawing.Point(12, 69)
        Me.FoodItemsGroup.Name = "FoodItemsGroup"
        Me.FoodItemsGroup.Size = New System.Drawing.Size(498, 213)
        Me.FoodItemsGroup.TabIndex = 3
        Me.FoodItemsGroup.TabStop = False
        Me.FoodItemsGroup.Text = "Food Items"
        '
        'CurInvLabel
        '
        Me.CurInvLabel.AutoSize = True
        Me.CurInvLabel.Location = New System.Drawing.Point(211, 9)
        Me.CurInvLabel.Name = "CurInvLabel"
        Me.CurInvLabel.Size = New System.Drawing.Size(88, 13)
        Me.CurInvLabel.TabIndex = 4
        Me.CurInvLabel.Text = "Current Inventory"
        Me.CurInvLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CurDateLabel
        '
        Me.CurDateLabel.AutoSize = True
        Me.CurDateLabel.Location = New System.Drawing.Point(229, 22)
        Me.CurDateLabel.Name = "CurDateLabel"
        Me.CurDateLabel.Size = New System.Drawing.Size(42, 13)
        Me.CurDateLabel.TabIndex = 5
        Me.CurDateLabel.Text = "Label 2"
        Me.CurDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CurTimeLabel
        '
        Me.CurTimeLabel.AutoSize = True
        Me.CurTimeLabel.Location = New System.Drawing.Point(229, 35)
        Me.CurTimeLabel.Name = "CurTimeLabel"
        Me.CurTimeLabel.Size = New System.Drawing.Size(39, 13)
        Me.CurTimeLabel.TabIndex = 6
        Me.CurTimeLabel.Text = "Label3"
        Me.CurTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 525)
        Me.Controls.Add(Me.CurTimeLabel)
        Me.Controls.Add(Me.CurDateLabel)
        Me.Controls.Add(Me.CurInvLabel)
        Me.Controls.Add(Me.FoodItemsGroup)
        Me.Controls.Add(Me.SupplyItemsGroup)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.FoodItemDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplyItemDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplyItemsGroup.ResumeLayout(False)
        Me.FoodItemsGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FoodItemDgv As System.Windows.Forms.DataGridView
    Friend WithEvents SupplyItemDgv As System.Windows.Forms.DataGridView
    Friend WithEvents SupplyItemsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents FoodItemsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CurInvLabel As System.Windows.Forms.Label
    Friend WithEvents CurDateLabel As System.Windows.Forms.Label
    Friend WithEvents CurTimeLabel As System.Windows.Forms.Label
End Class
