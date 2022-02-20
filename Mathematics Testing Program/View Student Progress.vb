Imports System.IO
Public Class frmViewStudentProgress
    Structure AccountDetails
        <VBFixedString(20)> Public Username As String
        <VBFixedString(20)> Public Password As String
        <VBFixedString(20)> Public Forename As String
        <VBFixedString(20)> Public Surname As String
    End Structure

    Structure SearchListBox
        Public SearchID As Integer
        Public FullStudentName As String
        Public DecryptedForename As String
        Public DecryptedSurname As String
        Public StudentAlreadyInList As Boolean
    End Structure

    Structure TestResults
        <VBFixedString(12)> Dim TotalScore As String

        <VBFixedString(12)> Dim PureScore As String
        <VBFixedString(12)> Dim StatisticsScore As String
        <VBFixedString(12)> Dim MechanicsScore As String

        <VBFixedString(12)> Dim ProofScore As String
        <VBFixedString(12)> Dim IntegrationScore As String

        <VBFixedString(12)> Dim ProbabilityScore As String
        <VBFixedString(12)> Dim DistributionsScore As String

        <VBFixedString(12)> Dim CollisionsScore As String
        <VBFixedString(12)> Dim EnergyScore As String

        <VBFixedString(12)> Dim InductionScore As String
        <VBFixedString(12)> Dim CounterexampleScore As String

        <VBFixedString(12)> Dim Integrating_E_Score As String
        <VBFixedString(12)> Dim Integrating_LN_Score As String

        <VBFixedString(12)> Dim VennDiagramsScore As String
        <VBFixedString(12)> Dim LawsOfProbabilityScore As String

        <VBFixedString(12)> Dim BinomialScore As String
        <VBFixedString(12)> Dim NormalScore As String

        <VBFixedString(12)> Dim ElasticIn2DScore As String
        <VBFixedString(12)> Dim ObliqueScore As String

        <VBFixedString(12)> Dim KinecticScore As String
        <VBFixedString(12)> Dim GravitationalScore As String

        <VBFixedString(6)> Dim NumOfAttempts As String
    End Structure

    Dim StudentInfo As AccountDetails
    Dim SearchStudents As SearchListBox
    Dim RetrieveResults As New TestResults

    Dim SR As StreamReader
    Dim Filename As String

    Private Sub frmViewStudentProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' Load student names into listbox
        GetStudents()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ResetTestResultsStructure(RetrieveResults)
        ' Extract filename from selected index
        Filename = lstStudents.SelectedItem.Remove(0, 4)
        Filename = RemoveWhitespace(Filename)
        Try
            Dim i As Integer = 1
            FileOpen(1, Filename & ".txt", OpenMode.Random, , , Len(RetrieveResults))
            While Not EOF(1)
                FileGet(1, RetrieveResults, i)
            End While
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to retrieve student data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetStudents()
        ' Retrieve student names from textfile
        Try
            Dim i As Integer = 1
            FileOpen(1, "studentaccounts.txt", OpenMode.Random, , , Len(StudentInfo))
            While Not EOF(1)
                FileGet(1, StudentInfo, i)
                SearchStudents.DecryptedForename = StudentInfo.Forename.Trim
                SearchStudents.DecryptedSurname = StudentInfo.Surname.Trim
                ' Decrypt contents of file
                frmCreateNewClass.ASCIIDecryption(SearchStudents.DecryptedForename)
                frmCreateNewClass.ASCIIDecryption(SearchStudents.DecryptedSurname)
                ' Add name to listbox
                lstStudents.Items.Add(i.ToString + ".  " + SearchStudents.DecryptedForename + " " + SearchStudents.DecryptedSurname)
                i += 1
            End While
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to retrive your data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function RemoveWhitespace(fullString As String) As String
        ' Remove all whitespaces from a string
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Private Sub ResetTestResultsStructure(ByRef ResultsStructure As TestResults)
        ' Resets the values of a TestResults structure to default
        ResultsStructure.TotalScore = "/00000/00000"
        ResultsStructure.PureScore = "/00000/00000"
        ResultsStructure.StatisticsScore = "/00000/00000"
        ResultsStructure.MechanicsScore = "/00000/00000"
        ResultsStructure.ProofScore = "/00000/00000"
        ResultsStructure.IntegrationScore = "/00000/00000"
        ResultsStructure.ProbabilityScore = "/00000/00000"
        ResultsStructure.DistributionsScore = "/00000/00000"
        ResultsStructure.CollisionsScore = "/00000/00000"
        ResultsStructure.EnergyScore = "/00000/00000"
        ResultsStructure.InductionScore = "/00000/00000"
        ResultsStructure.CounterexampleScore = "/00000/00000"
        ResultsStructure.Integrating_E_Score = "/00000/00000"
        ResultsStructure.Integrating_LN_Score = "/00000/00000"
        ResultsStructure.VennDiagramsScore = "/00000/00000"
        ResultsStructure.LawsOfProbabilityScore = "/00000/00000"
        ResultsStructure.BinomialScore = "/00000/00000"
        ResultsStructure.NormalScore = "/00000/00000"
        ResultsStructure.ElasticIn2DScore = "/00000/00000"
        ResultsStructure.ObliqueScore = "/00000/00000"
        ResultsStructure.KinecticScore = "/00000/00000"
        ResultsStructure.GravitationalScore = "/00000/00000"
        ResultsStructure.NumOfAttempts = "/00000"
    End Sub

    Private Sub drawline(ByVal ModuleType As String, ByVal StudentName As String)
        Dim ResultsLine As String
        Dim formgraphics As Drawing.Graphics
        Dim Y1, Y2 As Integer
        Dim lblXAxis(10) As Label
        Dim lblYAxis(10) As Label
        Dim loc(10) As Point
        Randomize()
        formgraphics = Me.CreateGraphics

        ' Draw axis; y-axis(start, end), x-axis(start, end)
        formgraphics.DrawLine(Pens.Black, 725, 10, 725, 330)
        formgraphics.DrawLine(Pens.Black, 725, 330, 1250, 330)

        ' Label x axis in intervals of multiples of i; i determines number of labels
        For i = 0 To 5
            ' Set interval between labels on x axis
            loc(i).X = i * 100 + 725
            ' Set vertical position of x axis label
            loc(i).Y = 340
            lblXAxis(i) = New Label
            lblXAxis(i).Location = loc(i)
            lblXAxis(i).Text = i + 1
            Me.Controls.Add(lblXAxis(i))
        Next i

        ' Change co-ordinates to label the y axis
        For i = 0 To 5
            loc(i).Y = i * 62.5 + 10
            loc(i).X = 625
            lblYAxis(i) = New Label
            lblYAxis(i).Location = loc(i)
            lblYAxis(i).Text = Math.Abs(20 * (5 - i))
            Me.Controls.Add(lblYAxis(i))
        Next i

        SR = New StreamReader(StudentName & "Attempts.txt", True)
        ResultsLine = SR.ReadLine()
        Y1 = PercentageOfYAxis(ResultsLine, ModuleType)
        For x = 725 To 1175 Step 100
            ResultsLine = SR.ReadLine()
            If Not IsNothing(ResultsLine) Then
                Y2 = PercentageOfYAxis(ResultsLine, ModuleType)
                formgraphics.DrawLine(Pens.Red, x, Y1, x + 100, Y2)
                Y1 = Y2
            End If
        Next
        SR.Close()
    End Sub

    Private Function PercentageOfYAxis(ByVal ResultsLine As String, ByVal ModuleType As String)
        ' Calculate position of a point to be plotted on the y axis
        Dim Y1 As Integer
        Select Case ModuleType
            Case = "P"
                Y1 = CInt((1 - (ResultsLine.Substring(0, 3) / 100)) * 320) + 10
            Case = "S"
                Y1 = CInt((1 - (ResultsLine.Substring(3, 3) / 100)) * 320) + 10
            Case = "M"
                Y1 = CInt((1 - (ResultsLine.Substring(6, 3) / 100)) * 320) + 10
        End Select
        Return Y1
    End Function

    Private Sub btnGenGraph_Click(sender As Object, e As EventArgs) Handles btnGenGraph.Click
        ' Display user scores for the selected module; P = puremaths, S = statistics & M = mechanics
        If cmbSelectTopic.Text <> Nothing Then
            ' Delete current graph
            Me.Refresh()
            Select Case cmbSelectModule.SelectedIndex
                Case = 0
                    drawline("P", Filename)
                Case = 1
                    drawline("S", Filename)
                Case = 2
                    drawline("M", Filename)
            End Select
        Else
            MessageBox.Show("Please select a module and topic to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        lstStudentData.Items.Clear()
        PopulateBarChart(cmbSelectTopic.Text)
        PopulateListBox()

        lblShowGraphX.Text = "Showing graph for: " & cmbSelectModule.Text
        lblShowChartX.Text = "Showing chart for: " & cmbSelectTopic.Text
        ' Might need to refresh this instead
        cmbSelectModule.SelectedIndex = -1
        cmbSelectTopic.SelectedIndex = -1
    End Sub

    Private Sub PopulateBarChart(ByVal Topic As String)
        ' Reset bar chart 
        chtDisplayTopic.Series.Clear()
        chtDisplayTopic.Series.Add("Sub Topic")

        ' Display average score for each topic on a bar chart
        Dim avg1 As Integer
        Dim avg2 As Integer
        Dim SubTopic1 As String
        Dim SubTopic2 As String

        ' Identify sub-topics to display on bar chart
        Select Case Topic
            Case = "Proof"
                SubTopic1 = "Induction"
                SubTopic2 = "Counter-example"
                avg1 = CalculateAverage(RetrieveResults.InductionScore)
                avg2 = CalculateAverage(RetrieveResults.CounterexampleScore)
            Case = "Integration"
                SubTopic1 = "Integrating e"
                SubTopic2 = "Integrating ln"
                avg1 = CalculateAverage(RetrieveResults.Integrating_E_Score)
                avg2 = CalculateAverage(RetrieveResults.Integrating_LN_Score)
            Case = "Probability"
                SubTopic1 = "Venn Diagrams"
                SubTopic2 = "Laws Of Probability"
                avg1 = CalculateAverage(RetrieveResults.VennDiagramsScore)
                avg2 = CalculateAverage(RetrieveResults.LawsOfProbabilityScore)
            Case = "Distributions"
                SubTopic1 = "Binomial"
                SubTopic2 = "Normal"
                avg1 = CalculateAverage(RetrieveResults.BinomialScore)
                avg2 = CalculateAverage(RetrieveResults.NormalScore)
            Case = "Collisions"
                SubTopic1 = "Elastic in 2D"
                SubTopic2 = "Oblique"
                avg1 = CalculateAverage(RetrieveResults.ElasticIn2DScore)
                avg2 = CalculateAverage(RetrieveResults.ObliqueScore)
            Case = "Energy"
                SubTopic1 = "Kinetic"
                SubTopic2 = "Gravitational"
                avg1 = CalculateAverage(RetrieveResults.KinecticScore)
                avg2 = CalculateAverage(RetrieveResults.GravitationalScore)
        End Select

        ' Plot bars
        Me.chtDisplayTopic.Series("Sub Topic").Points.AddXY(SubTopic1, avg1)
        Me.chtDisplayTopic.Series("Sub Topic").Points.AddXY(SubTopic2, avg2)
    End Sub

    Private Sub PopulateListBox()
        ' Populate lstStudentData with student's scores in a variety of categories
        lstStudentData.Items.Add("Overall score: " & CalculateAverage(RetrieveResults.TotalScore) & "%")
        lstStudentData.Items.Add("Pure Maths score: " & CalculateAverage(RetrieveResults.PureScore) & "%")
        lstStudentData.Items.Add("Statistics score: " & CalculateAverage(RetrieveResults.StatisticsScore) & "%")
        lstStudentData.Items.Add("Mechanics score: " & CalculateAverage(RetrieveResults.MechanicsScore) & "%")
    End Sub

    Private Function CalculateAverage(ByRef strToAverage As String)
        ' Calculate average of a variable in the TestResults structure
        Dim avg As Integer
        ' Ensure average score is <= 100%
        Try
            If CInt(strToAverage.Substring(1, 5)) <= CInt(strToAverage.Substring(7, 5)) And strToAverage.Length() = 12 Then
                avg = (CInt(strToAverage.Substring(1, 5)) / CInt(strToAverage.Substring(7, 5))) * 100
            Else
                avg = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Please parse a valid scores string into the subroutine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            avg = 0
        End Try
        Return avg
    End Function

    Private Function GetResults(ByRef strToAverage As String)
        ' Calculate average of a variable in the TestResults structure
        Dim avg As Integer
        ' Ensuring average <= 100%
        Try
            If CInt(strToAverage.Substring(1, 5)) <= CInt(strToAverage.Substring(7, 5)) And strToAverage.Length() = 12 Then
                avg = (CInt(strToAverage.Substring(1, 5)) / CInt(strToAverage.Substring(7, 5))) * 100
            Else
                avg = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Please parse a valid scores string into the subroutine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            avg = 0
        End Try
        Return avg
    End Function

    Private Sub btnSelectModule_Click(sender As Object, e As EventArgs) Handles btnSelectModule.Click
        ' Select values for topics to populate the combo box based on the user's selection in the module combobox
        cmbSelectTopic.Items.Clear()
        Select Case cmbSelectModule.SelectedIndex
            Case = 0
                cmbSelectTopic.Items.Add("Proof")
                cmbSelectTopic.Items.Add("Integration")
            Case = 1
                cmbSelectTopic.Items.Add("Probability")
                cmbSelectTopic.Items.Add("Distributions")
            Case = 2
                cmbSelectTopic.Items.Add("Collisions")
                cmbSelectTopic.Items.Add("Energy")
            Case Else
                MessageBox.Show("Please select a module to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
End Class