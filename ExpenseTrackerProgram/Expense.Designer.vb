<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expense
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
        Label_Status = New Label()
        Combo_Category = New ComboBox()
        Label2 = New Label()
        Btn_Submit = New Button()
        Text_Description = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Btn_Statistic = New Button()
        Btn_Expense = New Button()
        Btn_Income = New Button()
        Btn_Transaction = New Button()
        Label1 = New Label()
        DateTimeExpense = New DateTimePicker()
        Text_Amount = New TextBox()
        SuspendLayout()
        ' 
        ' Label_Status
        ' 
        Label_Status.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Status.Location = New Point(249, 84)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(332, 27)
        Label_Status.TabIndex = 37
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Combo_Category
        ' 
        Combo_Category.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo_Category.FormattingEnabled = True
        Combo_Category.Items.AddRange(New Object() {"Company Salary", "Part-Time Job", "Online Selling", "Freelance Project", "Commission"})
        Combo_Category.Location = New Point(249, 199)
        Combo_Category.Name = "Combo_Category"
        Combo_Category.Size = New Size(332, 33)
        Combo_Category.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(249, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 20)
        Label2.TabIndex = 35
        Label2.Text = "CATEGORY"
        ' 
        ' Btn_Submit
        ' 
        Btn_Submit.BackColor = SystemColors.ButtonHighlight
        Btn_Submit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Submit.Location = New Point(327, 386)
        Btn_Submit.Name = "Btn_Submit"
        Btn_Submit.Size = New Size(141, 35)
        Btn_Submit.TabIndex = 34
        Btn_Submit.Text = "SUBMIT"
        Btn_Submit.UseVisualStyleBackColor = False
        ' 
        ' Text_Description
        ' 
        Text_Description.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Description.Location = New Point(249, 342)
        Text_Description.Name = "Text_Description"
        Text_Description.Size = New Size(332, 30)
        Text_Description.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(249, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 20)
        Label6.TabIndex = 32
        Label6.Text = "DESCRIPTION"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(249, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 30
        Label5.Text = "DATE"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(249, 244)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 20)
        Label4.TabIndex = 28
        Label4.Text = "AMOUNT"
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(592, 44)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(178, 41)
        Btn_Statistic.TabIndex = 27
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonShadow
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(403, 44)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(178, 41)
        Btn_Expense.TabIndex = 26
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonShadow
        Btn_Income.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Income.ForeColor = SystemColors.ControlText
        Btn_Income.Location = New Point(215, 44)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(178, 41)
        Btn_Income.TabIndex = 25
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Transaction
        ' 
        Btn_Transaction.BackColor = SystemColors.ButtonShadow
        Btn_Transaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_Transaction.ForeColor = SystemColors.ControlText
        Btn_Transaction.Location = New Point(26, 44)
        Btn_Transaction.Name = "Btn_Transaction"
        Btn_Transaction.Size = New Size(178, 41)
        Btn_Transaction.TabIndex = 24
        Btn_Transaction.Text = "TRANSACTION"
        Btn_Transaction.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(-1, -4)
        Label1.Name = "Label1"
        Label1.Size = New Size(801, 45)
        Label1.TabIndex = 23
        Label1.Text = "EXPENSE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateTimeExpense
        ' 
        DateTimeExpense.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimeExpense.Location = New Point(249, 134)
        DateTimeExpense.Name = "DateTimeExpense"
        DateTimeExpense.Size = New Size(332, 30)
        DateTimeExpense.TabIndex = 38
        ' 
        ' Text_Amount
        ' 
        Text_Amount.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Amount.Location = New Point(256, 276)
        Text_Amount.Name = "Text_Amount"
        Text_Amount.Size = New Size(325, 30)
        Text_Amount.TabIndex = 39
        ' 
        ' Expense
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Text_Amount)
        Controls.Add(DateTimeExpense)
        Controls.Add(Label_Status)
        Controls.Add(Combo_Category)
        Controls.Add(Label2)
        Controls.Add(Btn_Submit)
        Controls.Add(Text_Description)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Name = "Expense"
        Text = "Expense"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label_Status As Label
    Friend WithEvents Combo_Category As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Submit As Button
    Friend WithEvents Text_Description As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimeExpense As DateTimePicker
    Friend WithEvents Text_Amount As TextBox
End Class
