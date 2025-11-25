<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income
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
        Label1 = New Label()
        Btn_Statistic = New Button()
        Btn_Expense = New Button()
        Btn_Income = New Button()
        Btn_Transaction = New Button()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(801, 45)
        Label1.TabIndex = 2
        Label1.Text = "INCOME"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(593, 48)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(178, 41)
        Btn_Statistic.TabIndex = 9
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonShadow
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(404, 48)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(178, 41)
        Btn_Expense.TabIndex = 8
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonShadow
        Btn_Income.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Income.ForeColor = SystemColors.ControlText
        Btn_Income.Location = New Point(216, 48)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(178, 41)
        Btn_Income.TabIndex = 7
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Transaction
        ' 
        Btn_Transaction.BackColor = SystemColors.ButtonShadow
        Btn_Transaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Transaction.ForeColor = SystemColors.ControlText
        Btn_Transaction.Location = New Point(27, 48)
        Btn_Transaction.Name = "Btn_Transaction"
        Btn_Transaction.Size = New Size(178, 41)
        Btn_Transaction.TabIndex = 6
        Btn_Transaction.Text = "TRANSACTION"
        Btn_Transaction.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(27, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 10
        Label2.Text = "DATE"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(27, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 23)
        Label3.TabIndex = 11
        Label3.Text = "YYYY-MM-DD"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(216, 128)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(17, 27)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Income
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Name = "Income"
        Text = "Income"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
