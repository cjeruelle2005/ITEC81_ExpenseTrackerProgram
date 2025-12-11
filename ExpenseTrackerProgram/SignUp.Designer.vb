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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
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
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(14, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 58)
        Label1.TabIndex = 1
        Label1.Text = "Sign Up"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(605, 386)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 29)
        Label2.TabIndex = 2
        Label2.Text = "First name"
        ' 
        ' Text_FirstName
        ' 
        Text_FirstName.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_FirstName.Location = New Point(605, 418)
        Text_FirstName.Name = "Text_FirstName"
        Text_FirstName.Size = New Size(525, 38)
        Text_FirstName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(605, 459)
        Label3.Name = "Label3"
        Label3.Size = New Size(169, 29)
        Label3.TabIndex = 4
        Label3.Text = "Last name"
        ' 
        ' Text_LastName
        ' 
        Text_LastName.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_LastName.Location = New Point(605, 491)
        Text_LastName.Name = "Text_LastName"
        Text_LastName.Size = New Size(525, 38)
        Text_LastName.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(605, 532)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 29)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        ' 
        ' Text_Email
        ' 
        Text_Email.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Email.Location = New Point(605, 564)
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(525, 38)
        Text_Email.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(605, 605)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 29)
        Label5.TabIndex = 8
        Label5.Text = "Password"
        ' 
        ' Text_Password
        ' 
        Text_Password.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Password.Location = New Point(605, 637)
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(525, 38)
        Text_Password.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(605, 678)
        Label6.Name = "Label6"
        Label6.Size = New Size(156, 29)
        Label6.TabIndex = 10
        Label6.Text = "Contact"
        ' 
        ' Text_Contact
        ' 
        Text_Contact.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Text_Contact.Location = New Point(605, 710)
        Text_Contact.Name = "Text_Contact"
        Text_Contact.Size = New Size(525, 38)
        Text_Contact.TabIndex = 11
        ' 
        ' Btn_Enter
        ' 
        Btn_Enter.BackColor = SystemColors.ButtonFace
        Btn_Enter.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Enter.Location = New Point(956, 754)
        Btn_Enter.Name = "Btn_Enter"
        Btn_Enter.Size = New Size(174, 44)
        Btn_Enter.TabIndex = 12
        Btn_Enter.Text = "ENTER"
        Btn_Enter.UseVisualStyleBackColor = False
        ' 
        ' Btn_Back
        ' 
        Btn_Back.BackColor = SystemColors.ButtonFace
        Btn_Back.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn_Back.Location = New Point(605, 754)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(174, 44)
        Btn_Back.TabIndex = 13
        Btn_Back.Text = "BACK"
        Btn_Back.UseVisualStyleBackColor = False
        ' 
        ' Status_Text
        ' 
        Status_Text.BackColor = SystemColors.Control
        Status_Text.BorderStyle = BorderStyle.None
        Status_Text.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Status_Text.Location = New Point(605, 348)
        Status_Text.Name = "Status_Text"
        Status_Text.Size = New Size(525, 23)
        Status_Text.TabIndex = 14
        ' 
        ' Label_Status
        ' 
        Label_Status.BackColor = Color.Transparent
        Label_Status.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label_Status.Location = New Point(605, 309)
        Label_Status.Name = "Label_Status"
        Label_Status.Size = New Size(525, 36)
        Label_Status.TabIndex = 15
        Label_Status.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1732, 1003)
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
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
