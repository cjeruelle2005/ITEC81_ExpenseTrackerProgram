<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistic
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
        Btn_Statistic = New Button()
        Btn_Expense = New Button()
        Btn_Income = New Button()
        Btn_Transaction = New Button()
        Label1 = New Label()
        Btn_Back = New Button()
        SuspendLayout()
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(667, 55)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(200, 47)
        Btn_Statistic.TabIndex = 14
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonShadow
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(454, 55)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(200, 47)
        Btn_Expense.TabIndex = 13
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonShadow
        Btn_Income.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Income.ForeColor = SystemColors.ControlText
        Btn_Income.Location = New Point(243, 55)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(200, 47)
        Btn_Income.TabIndex = 12
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Transaction
        ' 
        Btn_Transaction.BackColor = SystemColors.ButtonShadow
        Btn_Transaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Transaction.ForeColor = SystemColors.ControlText
        Btn_Transaction.Location = New Point(30, 55)
        Btn_Transaction.Name = "Btn_Transaction"
        Btn_Transaction.Size = New Size(200, 47)
        Btn_Transaction.TabIndex = 11
        Btn_Transaction.Text = "TRANSACTION"
        Btn_Transaction.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(901, 52)
        Label1.TabIndex = 10
        Label1.Text = "STATISTIC"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_Back
        ' 
        Btn_Back.BackColor = SystemColors.ButtonHighlight
        Btn_Back.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Back.Location = New Point(8, 8)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(85, 30)
        Btn_Back.TabIndex = 45
        Btn_Back.Text = "BACK"
        Btn_Back.UseVisualStyleBackColor = False
        ' 
        ' Statistic
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 518)
        Controls.Add(Btn_Back)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Statistic"
        Text = "Statistic"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Back As Button
End Class
