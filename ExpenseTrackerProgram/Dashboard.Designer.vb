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
        components = New ComponentModel.Container()
        SQLControlBindingSource = New BindingSource(components)
        Label1 = New Label()
        Btn_Transaction = New Button()
        Btn_Income = New Button()
        Btn_Expense = New Button()
        Btn_Statistic = New Button()
        Label2 = New Label()
        Label_Balance = New Label()
        Label3 = New Label()
        Label_TotalSpend = New Label()
        SQLControlBindingSource1 = New BindingSource(components)
        Btn_Back = New Button()
        Search_Bar = New TextBox()
        T_DateTime = New DateTimePicker()
        FLP_Transaction = New FlowLayoutPanel()
        CType(SQLControlBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(SQLControlBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SQLControlBindingSource
        ' 
        SQLControlBindingSource.DataSource = GetType(SQLControl)
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Firebrick
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.ImageAlign = ContentAlignment.MiddleRight
        Label1.Location = New Point(0, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(1252, 155)
        Label1.TabIndex = 1
        Label1.Text = "TRANSACTION"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Btn_Transaction
        ' 
        Btn_Transaction.BackColor = SystemColors.ButtonShadow
        Btn_Transaction.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Transaction.ForeColor = SystemColors.ControlText
        Btn_Transaction.Location = New Point(70, 107)
        Btn_Transaction.Name = "Btn_Transaction"
        Btn_Transaction.Size = New Size(273, 47)
        Btn_Transaction.TabIndex = 2
        Btn_Transaction.Text = "TRANSACTION"
        Btn_Transaction.UseVisualStyleBackColor = False
        ' 
        ' Btn_Income
        ' 
        Btn_Income.BackColor = SystemColors.ButtonShadow
        Btn_Income.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Income.ForeColor = SystemColors.ControlText
        Btn_Income.Location = New Point(349, 107)
        Btn_Income.Name = "Btn_Income"
        Btn_Income.Size = New Size(273, 47)
        Btn_Income.TabIndex = 3
        Btn_Income.Text = "INCOME"
        Btn_Income.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonShadow
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(628, 107)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(273, 47)
        Btn_Expense.TabIndex = 4
        Btn_Expense.Text = "EXPENSE"
        Btn_Expense.UseVisualStyleBackColor = False
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(907, 107)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(273, 47)
        Btn_Statistic.TabIndex = 5
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 28)
        Label2.TabIndex = 6
        Label2.Text = "Balance"
        ' 
        ' Label_Balance
        ' 
        Label_Balance.AutoSize = True
        Label_Balance.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Balance.Location = New Point(175, 171)
        Label_Balance.Name = "Label_Balance"
        Label_Balance.Size = New Size(58, 29)
        Label_Balance.TabIndex = 7
        Label_Balance.Text = "0.00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(879, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 29)
        Label3.TabIndex = 8
        Label3.Text = "Money Spent"
        ' 
        ' Label_TotalSpend
        ' 
        Label_TotalSpend.AutoSize = True
        Label_TotalSpend.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_TotalSpend.Location = New Point(1050, 170)
        Label_TotalSpend.Name = "Label_TotalSpend"
        Label_TotalSpend.Size = New Size(58, 29)
        Label_TotalSpend.TabIndex = 9
        Label_TotalSpend.Text = "0.00"
        ' 
        ' SQLControlBindingSource1
        ' 
        SQLControlBindingSource1.DataSource = GetType(SQLControl)
        ' 
        ' Btn_Back
        ' 
        Btn_Back.BackColor = SystemColors.ButtonHighlight
        Btn_Back.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Back.Location = New Point(12, 11)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(121, 30)
        Btn_Back.TabIndex = 44
        Btn_Back.Text = "LOGOUT"
        Btn_Back.UseVisualStyleBackColor = False
        ' 
        ' Search_Bar
        ' 
        Search_Bar.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search_Bar.ForeColor = SystemColors.InfoText
        Search_Bar.Location = New Point(68, 230)
        Search_Bar.Name = "Search_Bar"
        Search_Bar.Size = New Size(306, 27)
        Search_Bar.TabIndex = 45
        ' 
        ' T_DateTime
        ' 
        T_DateTime.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        T_DateTime.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        T_DateTime.Location = New Point(879, 230)
        T_DateTime.Name = "T_DateTime"
        T_DateTime.Size = New Size(305, 27)
        T_DateTime.TabIndex = 46
        ' 
        ' FLP_Transaction
        ' 
        FLP_Transaction.Location = New Point(70, 277)
        FLP_Transaction.Name = "FLP_Transaction"
        FLP_Transaction.Size = New Size(1038, 350)
        FLP_Transaction.TabIndex = 49
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1252, 702)
        Controls.Add(FLP_Transaction)
        Controls.Add(T_DateTime)
        Controls.Add(Search_Bar)
        Controls.Add(Btn_Back)
        Controls.Add(Label_TotalSpend)
        Controls.Add(Label3)
        Controls.Add(Label_Balance)
        Controls.Add(Label2)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Dashboard"
        Text = "Dashboard"
        CType(SQLControlBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(SQLControlBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_Balance As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_TotalSpend As Label
    Friend WithEvents SQLControlBindingSource As BindingSource
    Friend WithEvents SQLControlBindingSource1 As BindingSource
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Search_Bar As TextBox
    Friend WithEvents T_DateTime As DateTimePicker
    Friend WithEvents FLP_Transaction As FlowLayoutPanel
End Class
