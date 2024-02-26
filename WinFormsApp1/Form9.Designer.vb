<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Panel1 = New Panel()
        confirmButton = New Button()
        sign_up = New Label()
        confirmPasswordBox = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        passwordBox = New TextBox()
        userNameBox = New TextBox()
        Label3 = New Label()
        emailBox = New TextBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(confirmPasswordBox)
        Panel1.Controls.Add(confirmButton)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(sign_up)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(passwordBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(userNameBox)
        Panel1.Controls.Add(emailBox)
        Panel1.Location = New Point(281, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(319, 387)
        Panel1.TabIndex = 1
        ' 
        ' confirmButton
        ' 
        confirmButton.BackColor = SystemColors.HotTrack
        confirmButton.FlatStyle = FlatStyle.Flat
        confirmButton.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        confirmButton.ForeColor = SystemColors.ButtonHighlight
        confirmButton.Location = New Point(94, 308)
        confirmButton.Name = "confirmButton"
        confirmButton.Size = New Size(142, 37)
        confirmButton.TabIndex = 15
        confirmButton.Text = "Confirm"
        confirmButton.UseVisualStyleBackColor = False
        ' 
        ' sign_up
        ' 
        sign_up.AutoSize = True
        sign_up.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        sign_up.Location = New Point(81, 24)
        sign_up.Name = "sign_up"
        sign_up.Size = New Size(155, 26)
        sign_up.TabIndex = 0
        sign_up.Text = "Forget Password"
        ' 
        ' confirmPasswordBox
        ' 
        confirmPasswordBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        confirmPasswordBox.Location = New Point(34, 228)
        confirmPasswordBox.Name = "confirmPasswordBox"
        confirmPasswordBox.PlaceholderText = "Re-enter your password"
        confirmPasswordBox.Size = New Size(229, 25)
        confirmPasswordBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 20
        Label5.Text = "Confirm Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 19
        Label4.Text = "Username"
        ' 
        ' passwordBox
        ' 
        passwordBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        passwordBox.Location = New Point(34, 176)
        passwordBox.Name = "passwordBox"
        passwordBox.PlaceholderText = "Create Password"
        passwordBox.Size = New Size(229, 25)
        passwordBox.TabIndex = 18
        ' 
        ' userNameBox
        ' 
        userNameBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        userNameBox.Location = New Point(35, 124)
        userNameBox.Name = "userNameBox"
        userNameBox.PlaceholderText = "enter username"
        userNameBox.Size = New Size(229, 25)
        userNameBox.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(34, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 16
        Label3.Text = "Email"
        ' 
        ' emailBox
        ' 
        emailBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        emailBox.Location = New Point(34, 72)
        emailBox.Name = "emailBox"
        emailBox.PlaceholderText = "Enter your email"
        emailBox.Size = New Size(229, 25)
        emailBox.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 14
        Label2.Text = "Password"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form9"
        Text = "Form9"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents confirmButton As Button
    Friend WithEvents sign_up As Label
    Friend WithEvents confirmPasswordBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents passwordBox As TextBox
    Friend WithEvents userNameBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents emailBox As TextBox
    Friend WithEvents Label2 As Label
End Class
