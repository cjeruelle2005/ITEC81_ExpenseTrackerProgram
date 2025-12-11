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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expense))
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
        Label3 = New Label()
        Text_Item = New TextBox()
        Btn_Back = New Button()
        SuspendLayout()
        ' 
        ' Label_Status
        ' 
        Label_Status.BackColor = Color.Transparent
        Label_Status.Font = New Font("Microsoft Sans Serif", 12F)
        Label_Status.Location = New Point(566, 814)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(627, 31)
        Label_Status.TabIndex = 37
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Combo_Category
        ' 
        Combo_Category.Font = New Font("Microsoft Sans Serif", 18F)
        Combo_Category.FormattingEnabled = True
        Combo_Category.Items.AddRange(New Object() {"Clothing", "Communication", "Debt / Loans", "Donations", "Education", "Entertainment", "Food", "Gifts", "Healthcare", "Housing", "Personal", "Savings & Investments", "Subscriptions", "Taxes", "Travel", "Transportation", "Others"})
        Combo_Category.Location = New Point(566, 540)
        Combo_Category.Name = "Combo_Category"
        Combo_Category.Size = New Size(627, 44)
        Combo_Category.TabIndex = 36
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(566, 506)
        Label2.Name = "Label2"
        Label2.Size = New Size(259, 31)
        Label2.TabIndex = 35
        Label2.Text = "CATEGORY"
        ' 
        ' Btn_Submit
        ' 
        Btn_Submit.BackColor = SystemColors.ButtonFace
        Btn_Submit.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold)
        Btn_Submit.Location = New Point(764, 848)
        Btn_Submit.Name = "Btn_Submit"
        Btn_Submit.Size = New Size(262, 40)
        Btn_Submit.TabIndex = 34
        Btn_Submit.Text = "SUBMIT"
        Btn_Submit.UseVisualStyleBackColor = False
        ' 
        ' Text_Description
        ' 
        Text_Description.Font = New Font("Microsoft Sans Serif", 18F)
        Text_Description.Location = New Point(566, 770)
        Text_Description.Name = "Text_Description"
        Text_Description.Size = New Size(627, 41)
        Text_Description.TabIndex = 33
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(566, 737)
        Label6.Name = "Label6"
        Label6.Size = New Size(223, 30)
        Label6.TabIndex = 32
        Label6.Text = "DESCRIPTION"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(566, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(259, 31)
        Label5.TabIndex = 30
        Label5.Text = "DATE"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(566, 623)
        Label4.Name = "Label4"
        Label4.Size = New Size(259, 31)
        Label4.TabIndex = 28
        Label4.Text = "AMOUNT"
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonFace
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold)
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(1271, 113)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(395, 49)
        Btn_Statistic.TabIndex = 27
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonShadow
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold)
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(870, 113)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(395, 49)
        Btn_Expense.TabIndex = 26
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonFace
        Btn_Income.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold)
        Btn_Income.ForeColor = SystemColors.ControlText
        Btn_Income.Location = New Point(469, 113)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(395, 49)
        Btn_Income.TabIndex = 25
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Transaction
        ' 
        Btn_Transaction.BackColor = SystemColors.ButtonFace
        Btn_Transaction.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold)
        Btn_Transaction.ForeColor = SystemColors.ControlText
        Btn_Transaction.Location = New Point(68, 113)
        Btn_Transaction.Name = "Btn_Transaction"
        Btn_Transaction.Size = New Size(395, 49)
        Btn_Transaction.TabIndex = 24
        Btn_Transaction.Text = "TRANSACTION"
        Btn_Transaction.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Purple
        Label1.Font = New Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Info
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1902, 162)
        Label1.TabIndex = 23
        Label1.Text = "EXPENSE"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DateTimeExpense
        ' 
        DateTimeExpense.Font = New Font("Microsoft Sans Serif", 18F)
        DateTimeExpense.Location = New Point(566, 308)
        DateTimeExpense.Name = "DateTimeExpense"
        DateTimeExpense.Size = New Size(627, 41)
        DateTimeExpense.TabIndex = 38
        ' 
        ' Text_Amount
        ' 
        Text_Amount.Font = New Font("Microsoft Sans Serif", 18F)
        Text_Amount.Location = New Point(566, 657)
        Text_Amount.Name = "Text_Amount"
        Text_Amount.Size = New Size(627, 41)
        Text_Amount.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(566, 392)
        Label3.Name = "Label3"
        Label3.Size = New Size(259, 31)
        Label3.TabIndex = 40
        Label3.Text = "ITEM"
        ' 
        ' Text_Item
        ' 
        Text_Item.Font = New Font("Microsoft Sans Serif", 18F)
        Text_Item.Location = New Point(566, 426)
        Text_Item.Name = "Text_Item"
        Text_Item.Size = New Size(627, 41)
        Text_Item.TabIndex = 41
        ' 
        ' Btn_Back
        ' 
        Btn_Back.BackColor = Color.Tomato
        Btn_Back.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Btn_Back.Location = New Point(12, 11)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(129, 37)
        Btn_Back.TabIndex = 42
        Btn_Back.Text = "LOGOUT"
        Btn_Back.UseVisualStyleBackColor = False
        ' 
        ' Expense
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1732, 1003)
        Controls.Add(Btn_Back)
        Controls.Add(Text_Item)
        Controls.Add(Label3)
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
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_Item As TextBox
    Friend WithEvents Btn_Back As Button
End Class
