<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.Name = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.GitHubRepo = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHubRepo = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(172, 94)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(51, 20)
        Me.Name.TabIndex = 0
        Me.Name.Text = "Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(172, 142)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(48, 20)
        Me.Email.TabIndex = 1
        Me.Email.Text = "Email"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Location = New System.Drawing.Point(172, 188)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(92, 20)
        Me.PhoneNumber.TabIndex = 2
        Me.PhoneNumber.Text = "Phone Num"
        '
        'GitHubRepo
        '
        Me.GitHubRepo.AutoSize = True
        Me.GitHubRepo.Location = New System.Drawing.Point(172, 237)
        Me.GitHubRepo.Name = "GitHubRepo"
        Me.GitHubRepo.Size = New System.Drawing.Size(169, 20)
        Me.GitHubRepo.TabIndex = 3
        Me.GitHubRepo.Text = "Github Link For Task 2"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(383, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 26)
        Me.txtName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(383, 142)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(186, 26)
        Me.txtEmail.TabIndex = 5
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(383, 188)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(186, 26)
        Me.txtPhoneNumber.TabIndex = 6
        '
        'txtGitHubRepo
        '
        Me.txtGitHubRepo.Location = New System.Drawing.Point(383, 237)
        Me.txtGitHubRepo.Name = "txtGitHubRepo"
        Me.txtGitHubRepo.Size = New System.Drawing.Size(186, 26)
        Me.txtGitHubRepo.TabIndex = 7
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Location = New System.Drawing.Point(176, 325)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(192, 31)
        Me.lblStopwatch.TabIndex = 8
        Me.lblStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.lblStopwatch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(176, 390)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(393, 34)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(395, 327)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(174, 26)
        Me.TextBox5.TabIndex = 10
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtGitHubRepo)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.GitHubRepo)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Name)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name As Label
    Friend WithEvents Email As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents GitHubRepo As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents lblStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents TextBox5 As TextBox
End Class
