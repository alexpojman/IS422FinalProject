<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fooditemview
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.foodCost = New System.Windows.Forms.Label()
        Me.foodIngredients = New System.Windows.Forms.Label()
        Me.foodName = New System.Windows.Forms.Label()
        Me.foodItemNum = New System.Windows.Forms.Label()
        Me.LblItemNum = New System.Windows.Forms.Label()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.LblItemCost = New System.Windows.Forms.Label()
        Me.LblItemIngredients = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectItemComboBox = New System.Windows.Forms.ComboBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food Item Summary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingredients:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cost:"
        '
        'foodCost
        '
        Me.foodCost.AutoSize = True
        Me.foodCost.Location = New System.Drawing.Point(145, 145)
        Me.foodCost.Name = "foodCost"
        Me.foodCost.Size = New System.Drawing.Size(0, 13)
        Me.foodCost.TabIndex = 5
        '
        'foodIngredients
        '
        Me.foodIngredients.AutoSize = True
        Me.foodIngredients.Location = New System.Drawing.Point(145, 167)
        Me.foodIngredients.Name = "foodIngredients"
        Me.foodIngredients.Size = New System.Drawing.Size(0, 13)
        Me.foodIngredients.TabIndex = 6
        '
        'foodName
        '
        Me.foodName.AutoSize = True
        Me.foodName.Location = New System.Drawing.Point(145, 121)
        Me.foodName.Name = "foodName"
        Me.foodName.Size = New System.Drawing.Size(0, 13)
        Me.foodName.TabIndex = 7
        '
        'foodItemNum
        '
        Me.foodItemNum.AutoSize = True
        Me.foodItemNum.Location = New System.Drawing.Point(145, 97)
        Me.foodItemNum.Name = "foodItemNum"
        Me.foodItemNum.Size = New System.Drawing.Size(0, 13)
        Me.foodItemNum.TabIndex = 8
        '
        'LblItemNum
        '
        Me.LblItemNum.AutoSize = True
        Me.LblItemNum.Location = New System.Drawing.Point(146, 97)
        Me.LblItemNum.Name = "LblItemNum"
        Me.LblItemNum.Size = New System.Drawing.Size(62, 13)
        Me.LblItemNum.TabIndex = 9
        Me.LblItemNum.Text = "[DYNAMIC]"
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Location = New System.Drawing.Point(146, 121)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(62, 13)
        Me.LblItemName.TabIndex = 10
        Me.LblItemName.Text = "[DYNAMIC]"
        '
        'LblItemCost
        '
        Me.LblItemCost.AutoSize = True
        Me.LblItemCost.Location = New System.Drawing.Point(146, 144)
        Me.LblItemCost.Name = "LblItemCost"
        Me.LblItemCost.Size = New System.Drawing.Size(62, 13)
        Me.LblItemCost.TabIndex = 11
        Me.LblItemCost.Text = "[DYNAMIC]"
        '
        'LblItemIngredients
        '
        Me.LblItemIngredients.AutoSize = True
        Me.LblItemIngredients.Location = New System.Drawing.Point(146, 167)
        Me.LblItemIngredients.Name = "LblItemIngredients"
        Me.LblItemIngredients.Size = New System.Drawing.Size(62, 13)
        Me.LblItemIngredients.TabIndex = 12
        Me.LblItemIngredients.Text = "[DYNAMIC]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Select the Food Item:"
        '
        'SelectItemComboBox
        '
        Me.SelectItemComboBox.FormattingEnabled = True
        Me.SelectItemComboBox.Location = New System.Drawing.Point(149, 63)
        Me.SelectItemComboBox.Name = "SelectItemComboBox"
        Me.SelectItemComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SelectItemComboBox.TabIndex = 14
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=144.92.212.69;Initial Catalog=2013FA422_TeamB;Persist Security Info=T" & _
    "rue;User ID=2013FA422_TeamB_Delforge;Password=2013FA422_TeamB_Delforge"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'fooditemview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 262)
        Me.Controls.Add(Me.SelectItemComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblItemIngredients)
        Me.Controls.Add(Me.LblItemCost)
        Me.Controls.Add(Me.LblItemName)
        Me.Controls.Add(Me.LblItemNum)
        Me.Controls.Add(Me.foodItemNum)
        Me.Controls.Add(Me.foodName)
        Me.Controls.Add(Me.foodIngredients)
        Me.Controls.Add(Me.foodCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fooditemview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents foodCost As System.Windows.Forms.Label
    Friend WithEvents foodIngredients As System.Windows.Forms.Label
    Friend WithEvents foodName As System.Windows.Forms.Label
    Friend WithEvents foodItemNum As System.Windows.Forms.Label
    Friend WithEvents LblItemNum As System.Windows.Forms.Label
    Friend WithEvents LblItemName As System.Windows.Forms.Label
    Friend WithEvents LblItemCost As System.Windows.Forms.Label
    Friend WithEvents LblItemIngredients As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SelectItemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
