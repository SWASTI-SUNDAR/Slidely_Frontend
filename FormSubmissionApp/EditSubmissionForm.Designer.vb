<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditSubmissionForm
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
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSubmitEdit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtStopwatch.Location = New System.Drawing.Point(200, 221)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.Size = New System.Drawing.Size(320, 27)
        Me.txtStopwatch.TabIndex = 6
        '
        'txtGitHub
        '
        Me.txtGitHub.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtGitHub.Location = New System.Drawing.Point(200, 174)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(320, 27)
        Me.txtGitHub.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtPhone.Location = New System.Drawing.Point(200, 124)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(320, 27)
        Me.txtPhone.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(200, 79)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(320, 27)
        Me.txtEmail.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(200, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(320, 27)
        Me.txtName.TabIndex = 10
        '
        'btnSubmitEdit
        '
        Me.btnSubmitEdit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSubmitEdit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmitEdit.ForeColor = System.Drawing.Color.White
        Me.btnSubmitEdit.Location = New System.Drawing.Point(94, 280)
        Me.btnSubmitEdit.Name = "btnSubmitEdit"
        Me.btnSubmitEdit.Size = New System.Drawing.Size(320, 40)
        Me.btnSubmitEdit.TabIndex = 0
        Me.btnSubmitEdit.Text = "Submit Changes"
        Me.btnSubmitEdit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(50, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Stopwatch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(50, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "GitHub Link"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(38, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(78, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(78, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(150, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(294, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Edit the Submitted Form"
        '
        'EditSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 355)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.btnSubmitEdit)
        Me.Name = "EditSubmissionForm"
        Me.Text = "Edit Submission Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmitEdit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
