﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnToggleStopwatch.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnToggleStopwatch.ForeColor = System.Drawing.Color.White
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(97, 315)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(262, 54)
        Me.btnToggleStopwatch.TabIndex = 0
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(491, 315)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(177, 54)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(368, 212)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(139, 22)
        Me.txtGithub.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(368, 163)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(139, 22)
        Me.txtPhone.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(368, 54)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(139, 22)
        Me.txtName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(368, 103)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(139, 22)
        Me.txtEmail.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Github Link"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stopwatch"
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(368, 256)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.Size = New System.Drawing.Size(139, 22)
        Me.txtStopwatch.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(303, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "New Submission"
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 482)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents Label6 As Label
End Class
