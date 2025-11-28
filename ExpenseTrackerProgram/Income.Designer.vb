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
        Label4 = New Label()
        Combo_Category = New ComboBox()
        Label5 = New Label()
        Text_incomeAmount = New TextBox()
        Label6 = New Label()
        Text_Description = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Combo_Source = New ComboBox()
        Label_Status = New Label()
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
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(250, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 20)
        Label4.TabIndex = 13
        Label4.Text = "CATEGORY"
        ' 
        ' Combo_Category
        ' 
        Combo_Category.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo_Category.FormattingEnabled = True
        Combo_Category.Items.AddRange(New Object() {"Allowance", "Award", "Bonus", "Investment", "Lottery", "Salary", "Tips", "Others"})
        Combo_Category.Location = New Point(250, 271)
        Combo_Category.Name = "Combo_Category"
        Combo_Category.Size = New Size(332, 33)
        Combo_Category.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(250, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 20)
        Label5.TabIndex = 15
        Label5.Text = "AMOUNT"
        ' 
        ' Text_incomeAmount
        ' 
        Text_incomeAmount.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_incomeAmount.Location = New Point(250, 138)
        Text_incomeAmount.Name = "Text_incomeAmount"
        Text_incomeAmount.Size = New Size(332, 30)
        Text_incomeAmount.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(250, 323)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 20)
        Label6.TabIndex = 17
        Label6.Text = "DESCRIPTION"
        ' 
        ' Text_Description
        ' 
        Text_Description.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Description.Location = New Point(250, 346)
        Text_Description.Name = "Text_Description"
        Text_Description.Size = New Size(332, 27)
        Text_Description.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(328, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 35)
        Button1.TabIndex = 19
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(250, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 20
        Label2.Text = "SOURCE"
        ' 
        ' Combo_Source
        ' 
        Combo_Source.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo_Source.FormattingEnabled = True
        Combo_Source.Items.AddRange(New Object() {"Company Salary", "Part-Time Job", "Online Selling", "Freelance Project", "Commission"})
        Combo_Source.Location = New Point(250, 203)
        Combo_Source.Name = "Combo_Source"
        Combo_Source.Size = New Size(332, 33)
        Combo_Source.TabIndex = 21
        ' 
        ' Label_Status
        ' 
        Label_Status.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Status.Location = New Point(250, 88)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(332, 27)
        Label_Status.TabIndex = 22
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Income
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label_Status)
        Controls.Add(Combo_Source)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Text_Description)
        Controls.Add(Label6)
        Controls.Add(Text_incomeAmount)
        Controls.Add(Label5)
        Controls.Add(Combo_Category)
        Controls.Add(Label4)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Name = "Income"
        Text = "Income"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Combo_Category As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Text_incomeAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Text_Description As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Combo_Source As ComboBox
    Friend WithEvents Label_Status As Label
End Class
