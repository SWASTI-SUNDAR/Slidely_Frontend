<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.btnSearchSubmission = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Gold
        Me.btnViewSubmissions.Location = New System.Drawing.Point(74, 233)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(265, 52)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(423, 233)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(326, 52)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'btnSearchSubmission
        '
        Me.btnSearchSubmission.BackColor = System.Drawing.Color.LightGreen
        Me.btnSearchSubmission.Location = New System.Drawing.Point(234, 337)
        Me.btnSearchSubmission.Name = "btnSearchSubmission"
        Me.btnSearchSubmission.Size = New System.Drawing.Size(296, 52)
        Me.btnSearchSubmission.TabIndex = 2
        Me.btnSearchSubmission.Text = "Search Submission (Ctrl + F)"
        Me.btnSearchSubmission.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(340, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Swasti Sundar Pradhan , Slidely Task -Slidely Form App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearchSubmission)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnSearchSubmission As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
