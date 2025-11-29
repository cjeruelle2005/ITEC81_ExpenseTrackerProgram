<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Label2 = New Label()
        Text_FirstName = New TextBox()
        Label3 = New Label()
        Text_LastName = New TextBox()
        Label4 = New Label()
        Text_Email = New TextBox()
        Label5 = New Label()
        Text_Password = New TextBox()
        Label6 = New Label()
        Text_Contact = New TextBox()
        Btn_Enter = New Button()
        Btn_Back = New Button()
        Status_Text = New TextBox()
        Label_Status = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 32)
        Label1.TabIndex = 1
        Label1.Text = "Sign Up"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(66, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 2
        Label2.Text = "First name"
        ' 
        ' Text_FirstName
        ' 
        Text_FirstName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_FirstName.Location = New Point(66, 114)
        Text_FirstName.Name = "Text_FirstName"
        Text_FirstName.Size = New Size(299, 30)
        Text_FirstName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(66, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 25)
        Label3.TabIndex = 4
        Label3.Text = "Last name"
        ' 
        ' Text_LastName
        ' 
        Text_LastName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_LastName.Location = New Point(66, 175)
        Text_LastName.Name = "Text_LastName"
        Text_LastName.Size = New Size(299, 30)
        Text_LastName.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(66, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 25)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        ' 
        ' Text_Email
        ' 
        Text_Email.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Email.Location = New Point(66, 236)
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(299, 30)
        Text_Email.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(66, 269)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 25)
        Label5.TabIndex = 8
        Label5.Text = "Password"
        ' 
        ' Text_Password
        ' 
        Text_Password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Password.Location = New Point(66, 297)
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(299, 30)
        Text_Password.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(66, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 25)
        Label6.TabIndex = 10
        Label6.Text = "Contact"
        ' 
        ' Text_Contact
        ' 
        Text_Contact.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Contact.Location = New Point(66, 358)
        Text_Contact.Name = "Text_Contact"
        Text_Contact.Size = New Size(299, 30)
        Text_Contact.TabIndex = 11
        ' 
        ' Btn_Enter
        ' 
        Btn_Enter.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Enter.Location = New Point(266, 406)
        Btn_Enter.Name = "Btn_Enter"
        Btn_Enter.Size = New Size(99, 31)
        Btn_Enter.TabIndex = 12
        Btn_Enter.Text = "ENTER"
        Btn_Enter.UseVisualStyleBackColor = True
        ' 
        ' Btn_Back
        ' 
        Btn_Back.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Back.Location = New Point(61, 406)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(99, 31)
        Btn_Back.TabIndex = 13
        Btn_Back.Text = "BACK"
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' Status_Text
        ' 
        Status_Text.BackColor = SystemColors.Control
        Status_Text.BorderStyle = BorderStyle.None
        Status_Text.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Status_Text.Location = New Point(89, 44)
        Status_Text.Name = "Status_Text"
        Status_Text.Size = New Size(250, 17)
        Status_Text.TabIndex = 14
        ' 
        ' Label_Status
        ' 
        Label_Status.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Status.Location = New Point(66, 44)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(299, 27)
        Label_Status.TabIndex = 15
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 450)
        Controls.Add(Label_Status)
        Controls.Add(Status_Text)
        Controls.Add(Btn_Back)
        Controls.Add(Btn_Enter)
        Controls.Add(Text_Contact)
        Controls.Add(Label6)
        Controls.Add(Text_Password)
        Controls.Add(Label5)
        Controls.Add(Text_Email)
        Controls.Add(Label4)
        Controls.Add(Text_LastName)
        Controls.Add(Label3)
        Controls.Add(Text_FirstName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "SignUp"
        Text = "SignUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text_FirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_LastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_Email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Text_Password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Text_Contact As TextBox
    Friend WithEvents Btn_Enter As Button
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Status_Text As TextBox
    Friend WithEvents Label_Status As Label
End Class
