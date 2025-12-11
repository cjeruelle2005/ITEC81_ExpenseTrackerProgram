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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistic))
        Btn_Statistic = New Button()
        Btn_Expense = New Button()
        Btn_Income = New Button()
        Btn_Transaction = New Button()
        Label1 = New Label()
        Btn_Back = New Button()
        Expense_Chart = New DataVisualization.Charting.Chart()
        Expense_Bar = New DataVisualization.Charting.Chart()
        Combo_Dates = New ComboBox()
        CType(Expense_Chart, ComponentModel.ISupportInitialize).BeginInit()
        CType(Expense_Bar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_Statistic
        ' 
        Btn_Statistic.BackColor = SystemColors.ButtonShadow
        Btn_Statistic.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold)
        Btn_Statistic.ForeColor = SystemColors.ControlText
        Btn_Statistic.Location = New Point(1271, 113)
        Btn_Statistic.Name = "Btn_Statistic"
        Btn_Statistic.Size = New Size(395, 49)
        Btn_Statistic.TabIndex = 14
        Btn_Statistic.Text = "STATISTIC"
        Btn_Statistic.UseVisualStyleBackColor = False
        ' 
        ' Btn_Expense
        ' 
        Btn_Expense.BackColor = SystemColors.ButtonFace
        Btn_Expense.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold)
        Btn_Expense.ForeColor = SystemColors.ControlText
        Btn_Expense.Location = New Point(870, 113)
        Btn_Expense.Name = "Btn_Expense"
        Btn_Expense.Size = New Size(395, 49)
        Btn_Expense.TabIndex = 13
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
        Btn_Income.TabIndex = 12
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
        Btn_Transaction.TabIndex = 11
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
        Label1.TabIndex = 10
        Label1.Text = "STATISTIC"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Btn_Back
        ' 
        Btn_Back.BackColor = Color.Tomato
        Btn_Back.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold)
        Btn_Back.ForeColor = Color.Black
        Btn_Back.Location = New Point(12, 11)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(129, 37)
        Btn_Back.TabIndex = 45
        Btn_Back.Text = "LOGOUT"
        Btn_Back.UseVisualStyleBackColor = False
        ' 
        ' Expense_Chart
        ' 
        ChartArea1.Name = "ChartArea1"
        Expense_Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Expense_Chart.Legends.Add(Legend1)
        Expense_Chart.Location = New Point(68, 202)
        Expense_Chart.Name = "Expense_Chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Expense_Chart.Series.Add(Series1)
        Expense_Chart.Size = New Size(656, 686)
        Expense_Chart.TabIndex = 46
        Expense_Chart.Text = "Chart1"
        ' 
        ' Expense_Bar
        ' 
        ChartArea2.Name = "ChartArea1"
        Expense_Bar.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Expense_Bar.Legends.Add(Legend2)
        Expense_Bar.Location = New Point(747, 241)
        Expense_Bar.Name = "Expense_Bar"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Expense_Bar.Series.Add(Series2)
        Expense_Bar.Size = New Size(919, 647)
        Expense_Bar.TabIndex = 47
        Expense_Bar.Text = "Chart1"
        ' 
        ' Combo_Dates
        ' 
        Combo_Dates.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Combo_Dates.FormattingEnabled = True
        Combo_Dates.Location = New Point(1323, 202)
        Combo_Dates.Name = "Combo_Dates"
        Combo_Dates.Size = New Size(343, 33)
        Combo_Dates.TabIndex = 48
        ' 
        ' Statistic
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1732, 1003)
        Controls.Add(Combo_Dates)
        Controls.Add(Expense_Bar)
        Controls.Add(Expense_Chart)
        Controls.Add(Btn_Back)
        Controls.Add(Btn_Statistic)
        Controls.Add(Btn_Expense)
        Controls.Add(Btn_Income)
        Controls.Add(Btn_Transaction)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Statistic"
        Text = "Statistic"
        CType(Expense_Chart, ComponentModel.ISupportInitialize).EndInit()
        CType(Expense_Bar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Statistic As Button
    Friend WithEvents Btn_Expense As Button
    Friend WithEvents Btn_Income As Button
    Friend WithEvents Btn_Transaction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Expense_Chart As DataVisualization.Charting.Chart
    Friend WithEvents Expense_Bar As DataVisualization.Charting.Chart
    Friend WithEvents Combo_Dates As ComboBox
End Class
