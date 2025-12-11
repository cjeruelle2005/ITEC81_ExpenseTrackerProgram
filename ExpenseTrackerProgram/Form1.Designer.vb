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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        Text_Email = New TextBox()
        Label2 = New Label()
        Text_Password = New TextBox()
        Btn_Login = New Button()
        Btn_SignUp = New Button()
        Btn_Exit = New Button()
        Label_Status = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(582, 496)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 29)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Text_Email
        ' 
        Text_Email.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Email.Location = New Point(582, 530)
        Text_Email.Margin = New Padding(3, 5, 3, 5)
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(517, 41)
        Text_Email.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(582, 602)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 29)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' Text_Password
        ' 
        Text_Password.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Password.Location = New Point(582, 636)
        Text_Password.Margin = New Padding(3, 5, 3, 5)
        Text_Password.Name = "Text_Password"
        Text_Password.PasswordChar = "*"c
        Text_Password.Size = New Size(517, 41)
        Text_Password.TabIndex = 3
        ' 
        ' Btn_Login
        ' 
        Btn_Login.BackColor = SystemColors.ButtonHighlight
        Btn_Login.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Login.Location = New Point(582, 730)
        Btn_Login.Margin = New Padding(3, 5, 3, 5)
        Btn_Login.Name = "Btn_Login"
        Btn_Login.Size = New Size(165, 36)
        Btn_Login.TabIndex = 4
        Btn_Login.Text = "LOGIN"
        Btn_Login.UseVisualStyleBackColor = False
        ' 
        ' Btn_SignUp
        ' 
        Btn_SignUp.BackColor = SystemColors.ButtonHighlight
        Btn_SignUp.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_SignUp.Location = New Point(758, 730)
        Btn_SignUp.Margin = New Padding(3, 5, 3, 5)
        Btn_SignUp.Name = "Btn_SignUp"
        Btn_SignUp.Size = New Size(165, 36)
        Btn_SignUp.TabIndex = 5
        Btn_SignUp.Text = "SIGN UP"
        Btn_SignUp.UseVisualStyleBackColor = False
        ' 
        ' Btn_Exit
        ' 
        Btn_Exit.BackColor = Color.Tomato
        Btn_Exit.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Exit.ForeColor = SystemColors.InfoText
        Btn_Exit.Location = New Point(934, 730)
        Btn_Exit.Margin = New Padding(3, 5, 3, 5)
        Btn_Exit.Name = "Btn_Exit"
        Btn_Exit.Size = New Size(165, 36)
        Btn_Exit.TabIndex = 6
        Btn_Exit.Text = "EXIT"
        Btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' Label_Status
        ' 
        Label_Status.BackColor = Color.Transparent
        Label_Status.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Status.ForeColor = SystemColors.ControlLightLight
        Label_Status.Location = New Point(582, 682)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(517, 31)
        Label_Status.TabIndex = 7
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1732, 1003)
        Controls.Add(Label_Status)
        Controls.Add(Btn_Exit)
        Controls.Add(Btn_SignUp)
        Controls.Add(Btn_Login)
        Controls.Add(Text_Password)
        Controls.Add(Label2)
        Controls.Add(Text_Email)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.InfoText
        Margin = New Padding(3, 5, 3, 5)
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
    Friend WithEvents Timer1 As Timer

End Class
