<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeacherHomepage
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
        Me.tlsTeacherHomepage = New System.Windows.Forms.ToolStrip()
        Me.tlb_lbl_CreateNewClass = New System.Windows.Forms.ToolStripLabel()
        Me.tbl_lbl_ViewStudentProgress = New System.Windows.Forms.ToolStripLabel()
        Me.tbl_lbl_ViewClassProgress = New System.Windows.Forms.ToolStripLabel()
        Me.tlsTeacherHomepage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlsTeacherHomepage
        '
        Me.tlsTeacherHomepage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlsTeacherHomepage.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tlsTeacherHomepage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlb_lbl_CreateNewClass, Me.tbl_lbl_ViewStudentProgress, Me.tbl_lbl_ViewClassProgress})
        Me.tlsTeacherHomepage.Location = New System.Drawing.Point(0, 0)
        Me.tlsTeacherHomepage.Name = "tlsTeacherHomepage"
        Me.tlsTeacherHomepage.Size = New System.Drawing.Size(1924, 50)
        Me.tlsTeacherHomepage.TabIndex = 1
        Me.tlsTeacherHomepage.Text = "ToolStrip1"
        '
        'tlb_lbl_CreateNewClass
        '
        Me.tlb_lbl_CreateNewClass.Name = "tlb_lbl_CreateNewClass"
        Me.tlb_lbl_CreateNewClass.Size = New System.Drawing.Size(255, 45)
        Me.tlb_lbl_CreateNewClass.Text = "Create new class"
        '
        'tbl_lbl_ViewStudentProgress
        '
        Me.tbl_lbl_ViewStudentProgress.Name = "tbl_lbl_ViewStudentProgress"
        Me.tbl_lbl_ViewStudentProgress.Size = New System.Drawing.Size(355, 45)
        Me.tbl_lbl_ViewStudentProgress.Text = "| View student progress"
        '
        'tbl_lbl_ViewClassProgress
        '
        Me.tbl_lbl_ViewClassProgress.Name = "tbl_lbl_ViewClassProgress"
        Me.tbl_lbl_ViewClassProgress.Size = New System.Drawing.Size(314, 45)
        Me.tbl_lbl_ViewClassProgress.Text = "| View class progress"
        '
        'frmTeacherHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.tlsTeacherHomepage)
        Me.IsMdiContainer = True
        Me.Name = "frmTeacherHomepage"
        Me.Text = "MDITeacherHomepage"
        Me.tlsTeacherHomepage.ResumeLayout(False)
        Me.tlsTeacherHomepage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlsTeacherHomepage As ToolStrip
    Friend WithEvents tlb_lbl_CreateNewClass As ToolStripLabel
    Friend WithEvents tbl_lbl_ViewStudentProgress As ToolStripLabel
    Friend WithEvents tbl_lbl_ViewClassProgress As ToolStripLabel
End Class
