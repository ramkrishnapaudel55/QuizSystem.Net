<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnSignUp = New Button()
        confirmPasswordBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        passwordBox = New TextBox()
        userNameBox = New TextBox()
        Label3 = New Label()
        emailBox = New TextBox()
        Label2 = New Label()
        fullNameBox = New TextBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(808, 456)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnSignUp)
        Panel1.Controls.Add(confirmPasswordBox)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(userNameBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(emailBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(fullNameBox)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(36, 46)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(317, 369)
        Panel1.TabIndex = 1
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = SystemColors.HotTrack
        btnSignUp.FlatStyle = FlatStyle.Flat
        btnSignUp.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSignUp.ForeColor = SystemColors.ButtonHighlight
        btnSignUp.Location = New Point(88, 290)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(142, 39)
        btnSignUp.TabIndex = 14
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' confirmPasswordBox
        ' 
        confirmPasswordBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        confirmPasswordBox.Location = New Point(36, 247)
        confirmPasswordBox.Name = "confirmPasswordBox"
        confirmPasswordBox.PlaceholderText = "Re-enter your password"
        confirmPasswordBox.Size = New Size(229, 25)
        confirmPasswordBox.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 228)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 12
        Label5.Text = "Confirm Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(37, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 11
        Label4.Text = "Username"
        ' 
        ' passwordBox
        ' 
        passwordBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        passwordBox.Location = New Point(36, 195)
        passwordBox.Name = "passwordBox"
        passwordBox.PlaceholderText = "Create Password"
        passwordBox.Size = New Size(229, 25)
        passwordBox.TabIndex = 10
        ' 
        ' userNameBox
        ' 
        userNameBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        userNameBox.Location = New Point(37, 143)
        userNameBox.Name = "userNameBox"
        userNameBox.PlaceholderText = "enter username"
        userNameBox.Size = New Size(229, 25)
        userNameBox.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 8
        Label3.Text = "Email"
        ' 
        ' emailBox
        ' 
        emailBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        emailBox.Location = New Point(36, 91)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "Enter your email"
        emailBox.Size = New Size(229, 25)
        emailBox.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' fullNameBox
        ' 
        fullNameBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        fullNameBox.Location = New Point(36, 38)
        fullNameBox.Name = "fullNameBox"
        fullNameBox.PlaceholderText = "Enter your full name"
        fullNameBox.Size = New Size(229, 25)
        fullNameBox.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(36, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 3
        Label1.Text = "Full Name"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents fullNameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents userNameBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents confirmPasswordBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSignUp As Button
End Class
