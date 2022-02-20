<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRandomisedQuiz
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
        Me.lblAnswered = New System.Windows.Forms.Label()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.pcbQuestions = New System.Windows.Forms.PictureBox()
        CType(Me.pcbQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAnswered
        '
        Me.lblAnswered.AutoSize = True
        Me.lblAnswered.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswered.Location = New System.Drawing.Point(1396, 12)
        Me.lblAnswered.Name = "lblAnswered"
        Me.lblAnswered.Size = New System.Drawing.Size(261, 46)
        Me.lblAnswered.TabIndex = 22
        Me.lblAnswered.Text = "Answered: ⨉"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(1351, 660)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(319, 46)
        Me.lblSelection.TabIndex = 23
        Me.lblSelection.Text = "Your Selection: "
        '
        'pcbQuestions
        '
        Me.pcbQuestions.Location = New System.Drawing.Point(40, 12)
        Me.pcbQuestions.Name = "pcbQuestions"
        Me.pcbQuestions.Size = New System.Drawing.Size(1221, 939)
        Me.pcbQuestions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbQuestions.TabIndex = 24
        Me.pcbQuestions.TabStop = False
        '
        'frmRandomisedQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.Question_Mark_Neon_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.pcbQuestions)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lblAnswered)
        Me.Name = "frmRandomisedQuiz"
        Me.Text = "Randomised Quiz"
        CType(Me.pcbQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnswered As Label
    Friend WithEvents lblSelection As Label
    Friend WithEvents pcbQuestions As PictureBox
End Class
