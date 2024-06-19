<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(311, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.LightGray
        Me.txtEmail.Location = New System.Drawing.Point(311, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtEmail.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.LightGray
        Me.txtPhone.Location = New System.Drawing.Point(311, 125)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtPhone.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GitHub Repo Link For Task 2"
        '
        'txtGitHub
        '
        Me.txtGitHub.BackColor = System.Drawing.Color.LightGray
        Me.txtGitHub.Location = New System.Drawing.Point(311, 176)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New System.Drawing.Size(100, 22)
        Me.txtGitHub.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stopwatch Time"
        '
        'txtStopwatch
        '
        Me.txtStopwatch.BackColor = System.Drawing.Color.LightGray
        Me.txtStopwatch.Location = New System.Drawing.Point(311, 223)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Size = New System.Drawing.Size(100, 22)
        Me.txtStopwatch.TabIndex = 11
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Location = New System.Drawing.Point(82, 302)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(205, 48)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Aqua
        Me.btnNext.Location = New System.Drawing.Point(418, 302)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(223, 48)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.LawnGreen
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnEdit.Location = New System.Drawing.Point(82, 388)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(205, 42)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(418, 388)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(238, 42)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 477)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submission Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
