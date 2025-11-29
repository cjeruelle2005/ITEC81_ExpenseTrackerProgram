<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Text_Email = New TextBox()
        Label2 = New Label()
        Text_Password = New TextBox()
        Btn_Login = New Button()
        Btn_SignUp = New Button()
        Btn_Exit = New Button()
        Label_Status = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 25)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Text_Email
        ' 
        Text_Email.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Email.Location = New Point(75, 204)
        Text_Email.Margin = New Padding(3, 4, 3, 4)
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(299, 34)
        Text_Email.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(75, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 22)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Text_Password
        ' 
        Text_Password.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Password.Location = New Point(75, 274)
        Text_Password.Margin = New Padding(3, 4, 3, 4)
        Text_Password.Name = "Text_Password"
        Text_Password.PasswordChar = "*"c
        Text_Password.Size = New Size(299, 34)
        Text_Password.TabIndex = 3
        ' 
        ' Btn_Login
        ' 
        Btn_Login.BackColor = SystemColors.ButtonHighlight
        Btn_Login.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Login.Location = New Point(75, 332)
        Btn_Login.Margin = New Padding(3, 4, 3, 4)
        Btn_Login.Name = "Btn_Login"
        Btn_Login.Size = New Size(104, 31)
        Btn_Login.TabIndex = 4
        Btn_Login.Text = "LOGIN"
        Btn_Login.UseVisualStyleBackColor = False
        ' 
        ' Btn_SignUp
        ' 
        Btn_SignUp.BackColor = SystemColors.ButtonHighlight
        Btn_SignUp.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_SignUp.Location = New Point(185, 332)
        Btn_SignUp.Margin = New Padding(3, 4, 3, 4)
        Btn_SignUp.Name = "Btn_SignUp"
        Btn_SignUp.Size = New Size(107, 31)
        Btn_SignUp.TabIndex = 5
        Btn_SignUp.Text = "SIGN UP"
        Btn_SignUp.UseVisualStyleBackColor = False
        ' 
        ' Btn_Exit
        ' 
        Btn_Exit.BackColor = Color.Tomato
        Btn_Exit.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Exit.ForeColor = SystemColors.InfoText
        Btn_Exit.Location = New Point(299, 332)
        Btn_Exit.Margin = New Padding(3, 4, 3, 4)
        Btn_Exit.Name = "Btn_Exit"
        Btn_Exit.Size = New Size(75, 31)
        Btn_Exit.TabIndex = 6
        Btn_Exit.Text = "EXIT"
        Btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' Label_Status
        ' 
        Label_Status.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Status.Location = New Point(75, 311)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(299, 18)
        Label_Status.TabIndex = 7
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(464, 449)
        Controls.Add(Label_Status)
        Controls.Add(Btn_Exit)
        Controls.Add(Btn_SignUp)
        Controls.Add(Btn_Login)
        Controls.Add(Text_Password)
        Controls.Add(Label2)
        Controls.Add(Text_Email)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.InfoText
        Margin = New Padding(3, 4, 3, 4)
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Text_Email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_Password As TextBox
    Friend WithEvents Btn_Login As Button
    Friend WithEvents Btn_SignUp As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Label_Status As Label

End Class
