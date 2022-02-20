<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Me.lblGreeting1 = New System.Windows.Forms.Label()
        Me.lblGreeting2 = New System.Windows.Forms.Label()
        Me.lblGreeting3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCreateUsername = New System.Windows.Forms.Label()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.txtCreateUsername = New System.Windows.Forms.TextBox()
        Me.lblCreatePassword = New System.Windows.Forms.Label()
        Me.txtCreatePassword = New System.Windows.Forms.TextBox()
        Me.lblCreateForenamename = New System.Windows.Forms.Label()
        Me.txtCreateForename = New System.Windows.Forms.TextBox()
        Me.lblCreateSurname = New System.Windows.Forms.Label()
        Me.txtCreateSurname = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGreeting1
        '
        Me.lblGreeting1.AutoSize = True
        Me.lblGreeting1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting1.Location = New System.Drawing.Point(57, 210)
        Me.lblGreeting1.Name = "lblGreeting1"
        Me.lblGreeting1.Size = New System.Drawing.Size(889, 40)
        Me.lblGreeting1.TabIndex = 7
        Me.lblGreeting1.Text = "Welcome to the 'Create an account' section.                 "
        '
        'lblGreeting2
        '
        Me.lblGreeting2.AutoSize = True
        Me.lblGreeting2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting2.Location = New System.Drawing.Point(57, 312)
        Me.lblGreeting2.Name = "lblGreeting2"
        Me.lblGreeting2.Size = New System.Drawing.Size(895, 40)
        Me.lblGreeting2.TabIndex = 8
        Me.lblGreeting2.Text = "To create you account, fill in the fields on this page.      "
        '
        'lblGreeting3
        '
        Me.lblGreeting3.AutoSize = True
        Me.lblGreeting3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting3.Location = New System.Drawing.Point(57, 445)
        Me.lblGreeting3.Name = "lblGreeting3"
        Me.lblGreeting3.Size = New System.Drawing.Size(893, 40)
        Me.lblGreeting3.TabIndex = 9
        Me.lblGreeting3.Text = "To return to the login page, click the the button below.  "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(176, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(776, 64)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Mathematics Testing Program"
        '
        'lblCreateUsername
        '
        Me.lblCreateUsername.AutoSize = True
        Me.lblCreateUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateUsername.Location = New System.Drawing.Point(1232, 210)
        Me.lblCreateUsername.Name = "lblCreateUsername"
        Me.lblCreateUsername.Size = New System.Drawing.Size(373, 40)
        Me.lblCreateUsername.TabIndex = 11
        Me.lblCreateUsername.Text = "Enter a username       "
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.Location = New System.Drawing.Point(1232, 35)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(365, 40)
        Me.lblUserType.TabIndex = 10
        Me.lblUserType.Text = "Select a user type      "
        '
        'cmbUserType
        '
        Me.cmbUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"", "Student", "Teacher"})
        Me.cmbUserType.Location = New System.Drawing.Point(1229, 116)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(531, 48)
        Me.cmbUserType.TabIndex = 0
        '
        'txtCreateUsername
        '
        Me.txtCreateUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateUsername.Location = New System.Drawing.Point(1231, 299)
        Me.txtCreateUsername.Name = "txtCreateUsername"
        Me.txtCreateUsername.Size = New System.Drawing.Size(531, 44)
        Me.txtCreateUsername.TabIndex = 1
        '
        'lblCreatePassword
        '
        Me.lblCreatePassword.AutoSize = True
        Me.lblCreatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatePassword.Location = New System.Drawing.Point(1235, 387)
        Me.lblCreatePassword.Name = "lblCreatePassword"
        Me.lblCreatePassword.Size = New System.Drawing.Size(367, 40)
        Me.lblCreatePassword.TabIndex = 12
        Me.lblCreatePassword.Text = "Enter a password       "
        '
        'txtCreatePassword
        '
        Me.txtCreatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreatePassword.Location = New System.Drawing.Point(1233, 467)
        Me.txtCreatePassword.Name = "txtCreatePassword"
        Me.txtCreatePassword.Size = New System.Drawing.Size(543, 48)
        Me.txtCreatePassword.TabIndex = 2
        Me.txtCreatePassword.UseSystemPasswordChar = True
        '
        'lblCreateForenamename
        '
        Me.lblCreateForenamename.AutoSize = True
        Me.lblCreateForenamename.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateForenamename.Location = New System.Drawing.Point(1226, 564)
        Me.lblCreateForenamename.Name = "lblCreateForenamename"
        Me.lblCreateForenamename.Size = New System.Drawing.Size(365, 40)
        Me.lblCreateForenamename.TabIndex = 13
        Me.lblCreateForenamename.Text = "Enter your forename  "
        '
        'txtCreateForename
        '
        Me.txtCreateForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateForename.Location = New System.Drawing.Point(1228, 653)
        Me.txtCreateForename.Name = "txtCreateForename"
        Me.txtCreateForename.Size = New System.Drawing.Size(534, 48)
        Me.txtCreateForename.TabIndex = 3
        '
        'lblCreateSurname
        '
        Me.lblCreateSurname.AutoSize = True
        Me.lblCreateSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateSurname.Location = New System.Drawing.Point(1224, 753)
        Me.lblCreateSurname.Name = "lblCreateSurname"
        Me.lblCreateSurname.Size = New System.Drawing.Size(373, 40)
        Me.lblCreateSurname.TabIndex = 14
        Me.lblCreateSurname.Text = "Enter your surname    "
        '
        'txtCreateSurname
        '
        Me.txtCreateSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateSurname.Location = New System.Drawing.Point(1219, 841)
        Me.txtCreateSurname.Name = "txtCreateSurname"
        Me.txtCreateSurname.Size = New System.Drawing.Size(543, 48)
        Me.txtCreateSurname.TabIndex = 4
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(230, 645)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(563, 95)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return to login page"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.Location = New System.Drawing.Point(1217, 919)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(545, 90)
        Me.btnCreateAccount.TabIndex = 5
        Me.btnCreateAccount.Text = "Create Acount"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.Maths_background_main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.txtCreateSurname)
        Me.Controls.Add(Me.lblCreateSurname)
        Me.Controls.Add(Me.txtCreateForename)
        Me.Controls.Add(Me.lblCreateForenamename)
        Me.Controls.Add(Me.txtCreatePassword)
        Me.Controls.Add(Me.lblCreatePassword)
        Me.Controls.Add(Me.txtCreateUsername)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.lblUserType)
        Me.Controls.Add(Me.lblCreateUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblGreeting3)
        Me.Controls.Add(Me.lblGreeting2)
        Me.Controls.Add(Me.lblGreeting1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create An Account              "
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGreeting1 As Label
    Friend WithEvents lblGreeting2 As Label
    Friend WithEvents lblGreeting3 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCreateUsername As Label
    Friend WithEvents lblUserType As Label
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents txtCreateUsername As TextBox
    Friend WithEvents lblCreatePassword As Label
    Friend WithEvents txtCreatePassword As TextBox
    Friend WithEvents lblCreateForenamename As Label
    Friend WithEvents txtCreateForename As TextBox
    Friend WithEvents lblCreateSurname As Label
    Friend WithEvents txtCreateSurname As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnCreateAccount As Button
End Class
