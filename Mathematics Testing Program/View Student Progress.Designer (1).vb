<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewStudentProgress
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.lblSelectionInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(32, 802)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(765, 105)
        Me.btnSelect.TabIndex = 22
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lstStudents
        '
        Me.lstStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 32
        Me.lstStudents.Location = New System.Drawing.Point(32, 141)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(765, 612)
        Me.lstStudents.TabIndex = 21
        '
        'lblSelectionInfo
        '
        Me.lblSelectionInfo.AutoSize = True
        Me.lblSelectionInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionInfo.Location = New System.Drawing.Point(40, 63)
        Me.lblSelectionInfo.Name = "lblSelectionInfo"
        Me.lblSelectionInfo.Size = New System.Drawing.Size(757, 32)
        Me.lblSelectionInfo.TabIndex = 23
        Me.lblSelectionInfo.Text = "Select a student to view data on that student's performance"
        '
        'frmViewStudentProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.People
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.lblSelectionInfo)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lstStudents)
        Me.Name = "frmViewStudentProgress"
        Me.Text = "View Student Progress"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents lblSelectionInfo As Label
End Class
