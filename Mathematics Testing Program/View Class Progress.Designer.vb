<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewClassProgress
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chtAvgOfAttempts = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnGoToGraph1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGoToGraph2 = New System.Windows.Forms.Button()
        Me.chtStudentAverages = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lstStudentNames = New System.Windows.Forms.ListBox()
        Me.btnSelectClass = New System.Windows.Forms.Button()
        Me.cmbSelectClass = New System.Windows.Forms.ComboBox()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.chtAvgOfAttempts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chtStudentAverages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chtAvgOfAttempts)
        Me.Panel2.Controls.Add(Me.btnGoToGraph1)
        Me.Panel2.Location = New System.Drawing.Point(857, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1005, 1031)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'chtAvgOfAttempts
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtAvgOfAttempts.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtAvgOfAttempts.Legends.Add(Legend1)
        Me.chtAvgOfAttempts.Location = New System.Drawing.Point(55, 42)
        Me.chtAvgOfAttempts.Name = "chtAvgOfAttempts"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Average Score Per Attempt"
        Me.chtAvgOfAttempts.Series.Add(Series1)
        Me.chtAvgOfAttempts.Size = New System.Drawing.Size(888, 536)
        Me.chtAvgOfAttempts.TabIndex = 8
        Me.chtAvgOfAttempts.Text = "Average Score Per Attempt"
        '
        'btnGoToGraph1
        '
        Me.btnGoToGraph1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToGraph1.Location = New System.Drawing.Point(259, 663)
        Me.btnGoToGraph1.Name = "btnGoToGraph1"
        Me.btnGoToGraph1.Size = New System.Drawing.Size(480, 140)
        Me.btnGoToGraph1.TabIndex = 7
        Me.btnGoToGraph1.Text = "Next Graph"
        Me.btnGoToGraph1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnGoToGraph2)
        Me.Panel1.Controls.Add(Me.chtStudentAverages)
        Me.Panel1.Location = New System.Drawing.Point(857, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1011, 1037)
        Me.Panel1.TabIndex = 11
        '
        'btnGoToGraph2
        '
        Me.btnGoToGraph2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToGraph2.Location = New System.Drawing.Point(259, 663)
        Me.btnGoToGraph2.Name = "btnGoToGraph2"
        Me.btnGoToGraph2.Size = New System.Drawing.Size(480, 140)
        Me.btnGoToGraph2.TabIndex = 6
        Me.btnGoToGraph2.Text = "Next Graph"
        Me.btnGoToGraph2.UseVisualStyleBackColor = True
        '
        'chtStudentAverages
        '
        ChartArea2.Name = "ChartArea1"
        Me.chtStudentAverages.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chtStudentAverages.Legends.Add(Legend2)
        Me.chtStudentAverages.Location = New System.Drawing.Point(34, 33)
        Me.chtStudentAverages.Name = "chtStudentAverages"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Students"
        Me.chtStudentAverages.Series.Add(Series2)
        Me.chtStudentAverages.Size = New System.Drawing.Size(968, 545)
        Me.chtStudentAverages.TabIndex = 5
        Me.chtStudentAverages.Text = "chtStudentAverages"
        '
        'lstStudentNames
        '
        Me.lstStudentNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentNames.FormattingEnabled = True
        Me.lstStudentNames.ItemHeight = 37
        Me.lstStudentNames.Location = New System.Drawing.Point(60, 559)
        Me.lstStudentNames.Name = "lstStudentNames"
        Me.lstStudentNames.Size = New System.Drawing.Size(690, 263)
        Me.lstStudentNames.TabIndex = 10
        '
        'btnSelectClass
        '
        Me.btnSelectClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectClass.Location = New System.Drawing.Point(60, 351)
        Me.btnSelectClass.Name = "btnSelectClass"
        Me.btnSelectClass.Size = New System.Drawing.Size(392, 95)
        Me.btnSelectClass.TabIndex = 9
        Me.btnSelectClass.Text = "Select Class"
        Me.btnSelectClass.UseVisualStyleBackColor = True
        '
        'cmbSelectClass
        '
        Me.cmbSelectClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectClass.FormattingEnabled = True
        Me.cmbSelectClass.Location = New System.Drawing.Point(60, 111)
        Me.cmbSelectClass.Name = "cmbSelectClass"
        Me.cmbSelectClass.Size = New System.Drawing.Size(392, 37)
        Me.cmbSelectClass.TabIndex = 8
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudents.Location = New System.Drawing.Point(54, 501)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(277, 37)
        Me.lblStudents.TabIndex = 13
        Me.lblStudents.Text = "Students in class: "
        '
        'frmViewClassProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.White_background
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstStudentNames)
        Me.Controls.Add(Me.btnSelectClass)
        Me.Controls.Add(Me.cmbSelectClass)
        Me.Controls.Add(Me.lblStudents)
        Me.Name = "frmViewClassProgress"
        Me.Text = "View Class Progress"
        Me.Panel2.ResumeLayout(False)
        CType(Me.chtAvgOfAttempts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.chtStudentAverages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents chtAvgOfAttempts As DataVisualization.Charting.Chart
    Friend WithEvents btnGoToGraph1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGoToGraph2 As Button
    Friend WithEvents chtStudentAverages As DataVisualization.Charting.Chart
    Friend WithEvents lstStudentNames As ListBox
    Friend WithEvents btnSelectClass As Button
    Friend WithEvents cmbSelectClass As ComboBox
    Friend WithEvents lblStudents As Label
End Class
