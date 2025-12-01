<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Btn_Transaction = New Button()
        Btn_Income = New Button()
        Btn_Expense = New Button()
        Btn_Statistic = New Button()
        Label2 = New Label()
        Label_Balance = New Label()
        Label3 = New Label()
        Label_TotalSpend = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(29, 150)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(744, 288)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(0, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(801, 45)
        Label1.TabIndex = 1
        Label1.Text = "TRANSACTION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_Transaction
        ' 
        Btn_Transaction.BackColor = SystemColors.ButtonShadow
        Btn_Transaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Transaction.ForeColor = SystemColors.ControlText
        Btn_Transaction.Location = New Point(29, 47)
        Btn_Transaction.Name = "Btn_Transaction"
        Btn_Transaction.Size = New Size(178, 41)
        Btn_Transaction.TabIndex = 2
        Btn_Transaction.Text = "TRANSACTION"
        Btn_Transaction.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonShadow
        Btn_Income.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Income.ForeColor = SystemColors.ControlText
        Btn_Income.Location = New Point(218, 47)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(178, 41)
        Btn_Income.TabIndex = 3
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonShadow
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(406, 47)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(178, 41)
        Btn_Expense.TabIndex = 4
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(595, 47)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(178, 41)
        Btn_Statistic.TabIndex = 5
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 22)
        Label2.TabIndex = 6
        Label2.Text = "Balance"
        ' 
        ' Label_Balance
        ' 
        Label_Balance.AutoSize = True
        Label_Balance.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Balance.Location = New Point(130, 105)
        Label_Balance.Name = "Label_Balance"
        Label_Balance.Size = New Size(50, 25)
        Label_Balance.TabIndex = 7
        Label_Balance.Text = "0.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(406, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 22)
        Label3.TabIndex = 8
        Label3.Text = "Money Spend"
        ' 
        ' Label_TotalSpend
        ' 
        Label_TotalSpend.AutoSize = True
        Label_TotalSpend.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_TotalSpend.Location = New Point(543, 105)
        Label_TotalSpend.Name = "Label_TotalSpend"
        Label_TotalSpend.Size = New Size(50, 25)
        Label_TotalSpend.TabIndex = 9
        Label_TotalSpend.Text = "0.00"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label_TotalSpend)
        Controls.Add(Label3)
        Controls.Add(Label_Balance)
        Controls.Add(Label2)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Dashboard"
        Text = "Dashboard"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Balance As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_TotalSpend As Label
End Class
