<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        logInButton = New Button()
        logInPassword = New TextBox()
        logInUserName = New TextBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        Label1 = New Label()
        sign_up = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(logInButton)
        Panel1.Controls.Add(logInPassword)
        Panel1.Controls.Add(logInUserName)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(sign_up)
        Panel1.Location = New Point(54, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(319, 346)
        Panel1.TabIndex = 0
        ' 
        ' logInButton
        ' 
        logInButton.BackColor = SystemColors.HotTrack
        logInButton.FlatStyle = FlatStyle.Flat
        logInButton.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        logInButton.ForeColor = SystemColors.ButtonHighlight
        logInButton.Location = New Point(94, 222)
        logInButton.Name = "logInButton"
        logInButton.Size = New Size(142, 37)
        logInButton.TabIndex = 15
        logInButton.Text = "Log In"
        logInButton.UseVisualStyleBackColor = False
        ' 
        ' logInPassword
        ' 
        logInPassword.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        logInPassword.Location = New Point(46, 160)
        logInPassword.Name = "logInPassword"
        logInPassword.PlaceholderText = "Enter password"
        logInPassword.Size = New Size(229, 25)
        logInPassword.TabIndex = 6
        ' 
        ' logInUserName
        ' 
        logInUserName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        logInUserName.Location = New Point(46, 97)
        logInUserName.Name = "logInUserName"
        logInUserName.PlaceholderText = "Enter username"
        logInUserName.Size = New Size(229, 25)
        logInUserName.TabIndex = 5
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(212, 194)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(100, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot password?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' sign_up
        ' 
        sign_up.AutoSize = True
        sign_up.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        sign_up.Location = New Point(125, 25)
        sign_up.Name = "sign_up"
        sign_up.Size = New Size(58, 26)
        sign_up.TabIndex = 0
        sign_up.Text = "Login"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents sign_up As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logInPassword As TextBox
    Friend WithEvents logInUserName As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents logInButton As Button
End Class
