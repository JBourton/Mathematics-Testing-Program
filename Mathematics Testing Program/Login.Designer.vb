<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginPage
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
        Me.lblStudentLogin = New System.Windows.Forms.Label()
        Me.lblTeacherLogin = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStudentUsername = New System.Windows.Forms.Label()
        Me.lblTeacherPassword = New System.Windows.Forms.Label()
        Me.lblTeacherUsername = New System.Windows.Forms.Label()
        Me.lblStudentPassword = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentUsername = New System.Windows.Forms.TextBox()
        Me.txtTeacherPassword = New System.Windows.Forms.TextBox()
        Me.txtTeacherUsername = New System.Windows.Forms.TextBox()
        Me.txtStudentPassword = New System.Windows.Forms.TextBox()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStudentLogin
        '
        Me.lblStudentLogin.AutoSize = True
        Me.lblStudentLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentLogin.Location = New System.Drawing.Point(77, 168)
        Me.lblStudentLogin.Name = "lblStudentLogin"
        Me.lblStudentLogin.Size = New System.Drawing.Size(321, 55)
        Me.lblStudentLogin.TabIndex = 7
        Me.lblStudentLogin.Text = "Student Login"
        '
        'lblTeacherLogin
        '
        Me.lblTeacherLogin.AutoSize = True
        Me.lblTeacherLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherLogin.Location = New System.Drawing.Point(1028, 173)
        Me.lblTeacherLogin.Name = "lblTeacherLogin"
        Me.lblTeacherLogin.Size = New System.Drawing.Size(332, 55)
        Me.lblTeacherLogin.TabIndex = 10
        Me.lblTeacherLogin.Text = "Teacher Login"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(572, 28)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(776, 64)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Mathematics Testing Program"
        '
        'lblStudentUsername
        '
        Me.lblStudentUsername.AutoSize = True
        Me.lblStudentUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentUsername.Location = New System.Drawing.Point(80, 311)
        Me.lblStudentUsername.Name = "lblStudentUsername"
        Me.lblStudentUsername.Size = New System.Drawing.Size(193, 40)
        Me.lblStudentUsername.TabIndex = 8
        Me.lblStudentUsername.Text = "Username:"
        '
        'lblTeacherPassword
        '
        Me.lblTeacherPassword.AutoSize = True
        Me.lblTeacherPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherPassword.Location = New System.Drawing.Point(1031, 553)
        Me.lblTeacherPassword.Name = "lblTeacherPassword"
        Me.lblTeacherPassword.Size = New System.Drawing.Size(185, 40)
        Me.lblTeacherPassword.TabIndex = 12
        Me.lblTeacherPassword.Text = "Password:"
        '
        'lblTeacherUsername
        '
        Me.lblTeacherUsername.AutoSize = True
        Me.lblTeacherUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacherUsername.Location = New System.Drawing.Point(1031, 307)
        Me.lblTeacherUsername.Name = "lblTeacherUsername"
        Me.lblTeacherUsername.Size = New System.Drawing.Size(193, 40)
        Me.lblTeacherUsername.TabIndex = 11
        Me.lblTeacherUsername.Text = "Username:"
        '
        'lblStudentPassword
        '
        Me.lblStudentPassword.AutoSize = True
        Me.lblStudentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentPassword.Location = New System.Drawing.Point(80, 545)
        Me.lblStudentPassword.Name = "lblStudentPassword"
        Me.lblStudentPassword.Size = New System.Drawing.Size(185, 40)
        Me.lblStudentPassword.TabIndex = 9
        Me.lblStudentPassword.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 902)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(815, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "New to the program? Create an account here    →"
        '
        'txtStudentUsername
        '
        Me.txtStudentUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentUsername.Location = New System.Drawing.Point(309, 308)
        Me.txtStudentUsername.Name = "txtStudentUsername"
        Me.txtStudentUsername.Size = New System.Drawing.Size(582, 48)
        Me.txtStudentUsername.TabIndex = 0
        '
        'txtTeacherPassword
        '
        Me.txtTeacherPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherPassword.Location = New System.Drawing.Point(1266, 553)
        Me.txtTeacherPassword.Name = "txtTeacherPassword"
        Me.txtTeacherPassword.Size = New System.Drawing.Size(582, 48)
        Me.txtTeacherPassword.TabIndex = 4
        Me.txtTeacherPassword.UseSystemPasswordChar = True
        '
        'txtTeacherUsername
        '
        Me.txtTeacherUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherUsername.Location = New System.Drawing.Point(1266, 308)
        Me.txtTeacherUsername.Name = "txtTeacherUsername"
        Me.txtTeacherUsername.Size = New System.Drawing.Size(582, 48)
        Me.txtTeacherUsername.TabIndex = 3
        '
        'txtStudentPassword
        '
        Me.txtStudentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentPassword.Location = New System.Drawing.Point(309, 545)
        Me.txtStudentPassword.Name = "txtStudentPassword"
        Me.txtStudentPassword.Size = New System.Drawing.Size(582, 48)
        Me.txtStudentPassword.TabIndex = 1
        Me.txtStudentPassword.UseSystemPasswordChar = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.Location = New System.Drawing.Point(1346, 891)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(280, 68)
        Me.btnCreateAccount.TabIndex = 5
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(844, 705)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(317, 103)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'frmLoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.Maths_background_main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.txtStudentPassword)
        Me.Controls.Add(Me.txtTeacherUsername)
        Me.Controls.Add(Me.txtTeacherPassword)
        Me.Controls.Add(Me.txtStudentUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStudentPassword)
        Me.Controls.Add(Me.lblTeacherUsername)
        Me.Controls.Add(Me.lblTeacherPassword)
        Me.Controls.Add(Me.lblStudentUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTeacherLogin)
        Me.Controls.Add(Me.lblStudentLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudentLogin As Label
    Friend WithEvents lblTeacherLogin As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStudentUsername As Label
    Friend WithEvents lblTeacherPassword As Label
    Friend WithEvents lblTeacherUsername As Label
    Friend WithEvents lblStudentPassword As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentUsername As TextBox
    Friend WithEvents txtTeacherPassword As TextBox
    Friend WithEvents txtTeacherUsername As TextBox
    Friend WithEvents txtStudentPassword As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnLogin As Button
End Class
