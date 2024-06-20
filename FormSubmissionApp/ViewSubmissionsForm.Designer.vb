<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(320, 22)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 60)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(320, 22)
        Me.txtEmail.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 100)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(320, 22)
        Me.txtPhone.TabIndex = 2
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(150, 140)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New System.Drawing.Size(320, 22)
        Me.txtGitHub.TabIndex = 3
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(150, 180)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Size = New System.Drawing.Size(320, 22)
        Me.txtStopwatch.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(20, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(20, 63)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(20, 103)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(77, 16)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGitHub
        '
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Location = New System.Drawing.Point(12, 146)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(129, 16)
        Me.lblGitHub.TabIndex = 8
        Me.lblGitHub.Text = "Github Link For Task"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(20, 183)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(97, 16)
        Me.lblStopwatch.TabIndex = 9
        Me.lblStopwatch.Text = "Stopwatch time"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Khaki
        Me.btnPrevious.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(71, 232)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(150, 30)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "PREVIOUS(CTRL+P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnNext.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(264, 232)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 30)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Crimson
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(71, 282)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(264, 282)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(150, 30)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 324)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "Swasti Sundar, Slidely Task- View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtGitHub As System.Windows.Forms.TextBox
    Private WithEvents txtStopwatch As System.Windows.Forms.TextBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhone As System.Windows.Forms.Label
    Private WithEvents lblGitHub As System.Windows.Forms.Label
    Private WithEvents lblStopwatch As System.Windows.Forms.Label
    Private WithEvents btnPrevious As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
End Class
