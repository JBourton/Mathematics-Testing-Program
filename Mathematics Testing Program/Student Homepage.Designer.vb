<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentHomepage
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
        Me.tlsStudentHomepage = New System.Windows.Forms.ToolStrip()
        Me.tls_lbl_RandomisedQuiz = New System.Windows.Forms.ToolStripLabel()
        Me.tbl_lbl_SubTopicQuiz = New System.Windows.Forms.ToolStripLabel()
        Me.tlsStudentHomepage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlsStudentHomepage
        '
        Me.tlsStudentHomepage.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlsStudentHomepage.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tlsStudentHomepage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tls_lbl_RandomisedQuiz, Me.tbl_lbl_SubTopicQuiz})
        Me.tlsStudentHomepage.Location = New System.Drawing.Point(0, 0)
        Me.tlsStudentHomepage.Name = "tlsStudentHomepage"
        Me.tlsStudentHomepage.Size = New System.Drawing.Size(1924, 50)
        Me.tlsStudentHomepage.TabIndex = 1
        Me.tlsStudentHomepage.Text = "tlsStudentHomepage"
        '
        'tls_lbl_RandomisedQuiz
        '
        Me.tls_lbl_RandomisedQuiz.Name = "tls_lbl_RandomisedQuiz"
        Me.tls_lbl_RandomisedQuiz.Size = New System.Drawing.Size(270, 45)
        Me.tls_lbl_RandomisedQuiz.Text = "Randomised Quiz"
        '
        'tbl_lbl_SubTopicQuiz
        '
        Me.tbl_lbl_SubTopicQuiz.Name = "tbl_lbl_SubTopicQuiz"
        Me.tbl_lbl_SubTopicQuiz.Size = New System.Drawing.Size(249, 45)
        Me.tbl_lbl_SubTopicQuiz.Text = "| Sub-topic Quiz"
        '
        'frmStudentHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.tlsStudentHomepage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.Name = "frmStudentHomepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MDIStudentHompage"
        Me.tlsStudentHomepage.ResumeLayout(False)
        Me.tlsStudentHomepage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlsStudentHomepage As ToolStrip
    Friend WithEvents tls_lbl_RandomisedQuiz As ToolStripLabel
    Friend WithEvents tbl_lbl_SubTopicQuiz As ToolStripLabel
End Class
