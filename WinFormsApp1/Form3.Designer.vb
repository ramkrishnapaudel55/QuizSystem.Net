<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        nextButton = New Button()
        mathRadioButton = New RadioButton()
        historyRadioButton = New RadioButton()
        sportsRadioButton = New RadioButton()
        scienceRadioButton = New RadioButton()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(nextButton)
        Panel1.Controls.Add(mathRadioButton)
        Panel1.Controls.Add(historyRadioButton)
        Panel1.Controls.Add(sportsRadioButton)
        Panel1.Controls.Add(scienceRadioButton)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(202, 196)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(405, 213)
        Panel1.TabIndex = 4
        ' 
        ' nextButton
        ' 
        nextButton.BackColor = Color.DarkKhaki
        nextButton.FlatStyle = FlatStyle.Popup
        nextButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        nextButton.Location = New Point(301, 158)
        nextButton.Name = "nextButton"
        nextButton.Size = New Size(75, 28)
        nextButton.TabIndex = 3
        nextButton.Text = "Next"
        nextButton.UseVisualStyleBackColor = False
        ' 
        ' mathRadioButton
        ' 
        mathRadioButton.AutoSize = True
        mathRadioButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        mathRadioButton.Location = New Point(231, 57)
        mathRadioButton.Name = "mathRadioButton"
        mathRadioButton.Size = New Size(66, 25)
        mathRadioButton.TabIndex = 5
        mathRadioButton.TabStop = True
        mathRadioButton.Text = "Math"
        mathRadioButton.UseVisualStyleBackColor = True
        ' 
        ' historyRadioButton
        ' 
        historyRadioButton.AutoSize = True
        historyRadioButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        historyRadioButton.Location = New Point(86, 110)
        historyRadioButton.Name = "historyRadioButton"
        historyRadioButton.Size = New Size(82, 25)
        historyRadioButton.TabIndex = 4
        historyRadioButton.TabStop = True
        historyRadioButton.Text = "History"
        historyRadioButton.UseVisualStyleBackColor = True
        ' 
        ' sportsRadioButton
        ' 
        sportsRadioButton.AutoSize = True
        sportsRadioButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sportsRadioButton.Location = New Point(231, 110)
        sportsRadioButton.Name = "sportsRadioButton"
        sportsRadioButton.Size = New Size(76, 25)
        sportsRadioButton.TabIndex = 3
        sportsRadioButton.TabStop = True
        sportsRadioButton.Text = "Sports"
        sportsRadioButton.UseVisualStyleBackColor = True
        ' 
        ' scienceRadioButton
        ' 
        scienceRadioButton.AutoSize = True
        scienceRadioButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        scienceRadioButton.Location = New Point(86, 57)
        scienceRadioButton.Name = "scienceRadioButton"
        scienceRadioButton.Size = New Size(84, 25)
        scienceRadioButton.TabIndex = 2
        scienceRadioButton.TabStop = True
        scienceRadioButton.Text = "Science"
        scienceRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(57, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 25)
        Label1.TabIndex = 1
        Label1.Text = "Choose your preferred subject."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-2, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(805, 452)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents nextButton As Button
    Friend WithEvents mathRadioButton As RadioButton
    Friend WithEvents historyRadioButton As RadioButton
    Friend WithEvents sportsRadioButton As RadioButton
    Friend WithEvents scienceRadioButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
