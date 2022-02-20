<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateNewClass
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
        Me.lblIDSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCreateClass = New System.Windows.Forms.Button()
        Me.lblSelectionInfo = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lstNewClass = New System.Windows.Forms.ListBox()
        Me.lblCreateClass = New System.Windows.Forms.Label()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblIDSearch
        '
        Me.lblIDSearch.AutoSize = True
        Me.lblIDSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDSearch.Location = New System.Drawing.Point(978, 832)
        Me.lblIDSearch.Name = "lblIDSearch"
        Me.lblIDSearch.Size = New System.Drawing.Size(444, 40)
        Me.lblIDSearch.TabIndex = 24
        Me.lblIDSearch.Text = "Search for a student by ID:"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1461, 810)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(421, 91)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCreateClass
        '
        Me.btnCreateClass.Enabled = False
        Me.btnCreateClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateClass.Location = New System.Drawing.Point(135, 810)
        Me.btnCreateClass.Name = "btnCreateClass"
        Me.btnCreateClass.Size = New System.Drawing.Size(574, 91)
        Me.btnCreateClass.TabIndex = 22
        Me.btnCreateClass.Text = "Create class"
        Me.btnCreateClass.UseVisualStyleBackColor = True
        '
        'lblSelectionInfo
        '
        Me.lblSelectionInfo.AutoSize = True
        Me.lblSelectionInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionInfo.Location = New System.Drawing.Point(18, 281)
        Me.lblSelectionInfo.Name = "lblSelectionInfo"
        Me.lblSelectionInfo.Size = New System.Drawing.Size(885, 32)
        Me.lblSelectionInfo.TabIndex = 21
        Me.lblSelectionInfo.Text = "Add students from the adjacent list using the add and remove buttons"
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(716, 161)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(185, 67)
        Me.btnRemove.TabIndex = 20
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(716, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(185, 69)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudents.Location = New System.Drawing.Point(17, 210)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(169, 40)
        Me.lblStudents.TabIndex = 18
        Me.lblStudents.Text = "Students:"
        '
        'lstNewClass
        '
        Me.lstNewClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNewClass.FormattingEnabled = True
        Me.lstNewClass.ItemHeight = 32
        Me.lstNewClass.Location = New System.Drawing.Point(12, 356)
        Me.lstNewClass.Name = "lstNewClass"
        Me.lstNewClass.Size = New System.Drawing.Size(893, 420)
        Me.lstNewClass.TabIndex = 17
        '
        'lblCreateClass
        '
        Me.lblCreateClass.AutoSize = True
        Me.lblCreateClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateClass.Location = New System.Drawing.Point(199, 18)
        Me.lblCreateClass.Name = "lblCreateClass"
        Me.lblCreateClass.Size = New System.Drawing.Size(345, 55)
        Me.lblCreateClass.TabIndex = 16
        Me.lblCreateClass.Text = "Create a class"
        '
        'txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(24, 161)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(467, 26)
        Me.txtClassName.TabIndex = 15
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.Location = New System.Drawing.Point(27, 94)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(217, 40)
        Me.lblClassName.TabIndex = 14
        Me.lblClassName.Text = "Class name:"
        '
        'lstStudents
        '
        Me.lstStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 32
        Me.lstStudents.Location = New System.Drawing.Point(985, 42)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(899, 740)
        Me.lstStudents.TabIndex = 13
        '
        'frmCreateNewClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.People
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.lblIDSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCreateClass)
        Me.Controls.Add(Me.lblSelectionInfo)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblStudents)
        Me.Controls.Add(Me.lstNewClass)
        Me.Controls.Add(Me.lblCreateClass)
        Me.Controls.Add(Me.txtClassName)
        Me.Controls.Add(Me.lblClassName)
        Me.Controls.Add(Me.lstStudents)
        Me.Name = "frmCreateNewClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateNewClass"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIDSearch As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCreateClass As Button
    Friend WithEvents lblSelectionInfo As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblStudents As Label
    Friend WithEvents lstNewClass As ListBox
    Friend WithEvents lblCreateClass As Label
    Friend WithEvents txtClassName As TextBox
    Friend WithEvents lblClassName As Label
    Friend WithEvents lstStudents As ListBox
End Class
