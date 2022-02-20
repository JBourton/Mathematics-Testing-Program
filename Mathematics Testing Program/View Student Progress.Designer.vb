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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.lblSelectionInfo = New System.Windows.Forms.Label()
        Me.lstStudentData = New System.Windows.Forms.ListBox()
        Me.lblShowChartX = New System.Windows.Forms.Label()
        Me.lblShowGraphX = New System.Windows.Forms.Label()
        Me.cmbSelectTopic = New System.Windows.Forms.ComboBox()
        Me.btnSelectModule = New System.Windows.Forms.Button()
        Me.cmbSelectModule = New System.Windows.Forms.ComboBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblNoAttempts = New System.Windows.Forms.Label()
        Me.chtDisplayTopic = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnGenGraph = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.chtDisplayTopic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(12, 390)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(402, 65)
        Me.btnSelect.TabIndex = 22
        Me.btnSelect.Text = "Select Student"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lstStudents
        '
        Me.lstStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 29
        Me.lstStudents.Location = New System.Drawing.Point(12, 52)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(402, 323)
        Me.lstStudents.TabIndex = 21
        '
        'lblSelectionInfo
        '
        Me.lblSelectionInfo.AutoSize = True
        Me.lblSelectionInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectionInfo.Location = New System.Drawing.Point(14, 9)
        Me.lblSelectionInfo.Name = "lblSelectionInfo"
        Me.lblSelectionInfo.Size = New System.Drawing.Size(521, 25)
        Me.lblSelectionInfo.TabIndex = 23
        Me.lblSelectionInfo.Text = "Select a student to view data on that student's performance"
        '
        'lstStudentData
        '
        Me.lstStudentData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentData.FormattingEnabled = True
        Me.lstStudentData.ItemHeight = 37
        Me.lstStudentData.Location = New System.Drawing.Point(489, 738)
        Me.lstStudentData.Name = "lstStudentData"
        Me.lstStudentData.Size = New System.Drawing.Size(572, 189)
        Me.lstStudentData.TabIndex = 33
        '
        'lblShowChartX
        '
        Me.lblShowChartX.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowChartX.Location = New System.Drawing.Point(547, 622)
        Me.lblShowChartX.Name = "lblShowChartX"
        Me.lblShowChartX.Size = New System.Drawing.Size(320, 104)
        Me.lblShowChartX.TabIndex = 32
        Me.lblShowChartX.Text = "Showing chart for:"
        '
        'lblShowGraphX
        '
        Me.lblShowGraphX.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowGraphX.Location = New System.Drawing.Point(588, 202)
        Me.lblShowGraphX.Name = "lblShowGraphX"
        Me.lblShowGraphX.Size = New System.Drawing.Size(320, 104)
        Me.lblShowGraphX.TabIndex = 31
        Me.lblShowGraphX.Text = "Showing graph for: "
        '
        'cmbSelectTopic
        '
        Me.cmbSelectTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectTopic.FormattingEnabled = True
        Me.cmbSelectTopic.Location = New System.Drawing.Point(12, 708)
        Me.cmbSelectTopic.Name = "cmbSelectTopic"
        Me.cmbSelectTopic.Size = New System.Drawing.Size(402, 40)
        Me.cmbSelectTopic.TabIndex = 30
        '
        'btnSelectModule
        '
        Me.btnSelectModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectModule.Location = New System.Drawing.Point(9, 636)
        Me.btnSelectModule.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelectModule.Name = "btnSelectModule"
        Me.btnSelectModule.Size = New System.Drawing.Size(403, 64)
        Me.btnSelectModule.TabIndex = 29
        Me.btnSelectModule.Text = "Confirm Module"
        Me.btnSelectModule.UseVisualStyleBackColor = True
        '
        'cmbSelectModule
        '
        Me.cmbSelectModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectModule.FormattingEnabled = True
        Me.cmbSelectModule.Items.AddRange(New Object() {"Pure Maths", "Statistics", "Mechanics"})
        Me.cmbSelectModule.Location = New System.Drawing.Point(9, 461)
        Me.cmbSelectModule.Name = "cmbSelectModule"
        Me.cmbSelectModule.Size = New System.Drawing.Size(402, 40)
        Me.cmbSelectModule.TabIndex = 28
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(798, 37)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(110, 90)
        Me.lblScore.TabIndex = 27
        Me.lblScore.Text = "Score (%)"
        '
        'lblNoAttempts
        '
        Me.lblNoAttempts.AutoSize = True
        Me.lblNoAttempts.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoAttempts.Location = New System.Drawing.Point(1393, 567)
        Me.lblNoAttempts.Name = "lblNoAttempts"
        Me.lblNoAttempts.Size = New System.Drawing.Size(300, 37)
        Me.lblNoAttempts.TabIndex = 26
        Me.lblNoAttempts.Text = "Number of attempts"
        '
        'chtDisplayTopic
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtDisplayTopic.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtDisplayTopic.Legends.Add(Legend1)
        Me.chtDisplayTopic.Location = New System.Drawing.Point(1128, 607)
        Me.chtDisplayTopic.Name = "chtDisplayTopic"
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Sub Topic"
        Me.chtDisplayTopic.Series.Add(Series1)
        Me.chtDisplayTopic.Size = New System.Drawing.Size(784, 320)
        Me.chtDisplayTopic.TabIndex = 25
        Me.chtDisplayTopic.Text = "Topic Results"
        '
        'btnGenGraph
        '
        Me.btnGenGraph.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenGraph.Location = New System.Drawing.Point(9, 845)
        Me.btnGenGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGenGraph.Name = "btnGenGraph"
        Me.btnGenGraph.Size = New System.Drawing.Size(405, 64)
        Me.btnGenGraph.TabIndex = 24
        Me.btnGenGraph.Text = "Confirm Topic"
        Me.btnGenGraph.UseVisualStyleBackColor = True
        '
        'frmViewStudentProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mathematics_Testing_Program.My.Resources.Resources.White_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.lstStudentData)
        Me.Controls.Add(Me.lblShowChartX)
        Me.Controls.Add(Me.lblShowGraphX)
        Me.Controls.Add(Me.cmbSelectTopic)
        Me.Controls.Add(Me.btnSelectModule)
        Me.Controls.Add(Me.cmbSelectModule)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNoAttempts)
        Me.Controls.Add(Me.chtDisplayTopic)
        Me.Controls.Add(Me.btnGenGraph)
        Me.Controls.Add(Me.lblSelectionInfo)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lstStudents)
        Me.Name = "frmViewStudentProgress"
        Me.Text = "View Student Progress"
        Me.TopMost = True
        CType(Me.chtDisplayTopic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelect As Button
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents lblSelectionInfo As Label
    Friend WithEvents lstStudentData As ListBox
    Friend WithEvents lblShowChartX As Label
    Friend WithEvents lblShowGraphX As Label
    Friend WithEvents cmbSelectTopic As ComboBox
    Friend WithEvents btnSelectModule As Button
    Friend WithEvents cmbSelectModule As ComboBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblNoAttempts As Label
    Friend WithEvents chtDisplayTopic As DataVisualization.Charting.Chart
    Friend WithEvents btnGenGraph As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
