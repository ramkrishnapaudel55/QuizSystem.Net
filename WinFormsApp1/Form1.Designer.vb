<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Panel2 = New Panel()
        signUp = New Button()
        Label4 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Salmon
        Label1.Location = New Point(346, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 74)
        Label1.TabIndex = 0
        Label1.Text = "Quiz"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(signUp)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(-1, -1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(846, 485)
        Panel2.TabIndex = 1
        ' 
        ' signUp
        ' 
        signUp.BackColor = Color.Peru
        signUp.Cursor = Cursors.Hand
        signUp.FlatAppearance.BorderSize = 0
        signUp.FlatStyle = FlatStyle.Flat
        signUp.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        signUp.ForeColor = SystemColors.Info
        signUp.Location = New Point(372, 365)
        signUp.Name = "signUp"
        signUp.Size = New Size(134, 45)
        signUp.TabIndex = 3
        signUp.Text = "Sign Up"
        signUp.TextImageRelation = TextImageRelation.ImageAboveText
        signUp.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Azure
        Label4.Location = New Point(359, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 16)
        Label4.TabIndex = 2
        Label4.Text = "Find your path to wellness"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Peru
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(370, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 45)
        Button1.TabIndex = 1
        Button1.Text = "Log In"
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Azure
        Label3.Location = New Point(190, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(492, 31)
        Label3.TabIndex = 0
        Label3.Text = "Communication Styles Quiz And Assessment" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(844, 483)
        Controls.Add(Panel2)
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents signUp As Button
End Class
