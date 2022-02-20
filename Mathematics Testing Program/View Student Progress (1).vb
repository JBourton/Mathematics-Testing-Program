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

    Private Sub frmViewStudentProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        GetStudents()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ResetTestResultsStructure(RetrieveResults)
        ' Extract filename from selected index
        Dim Filename = lstStudents.SelectedItem.Remove(0, 4)
        Filename = RemoveWhitespace(Filename)
        Filename = Filename + ".txt"
        Try
            Dim i As Integer = 1
            FileOpen(1, Filename, OpenMode.Random, , , Len(RetrieveResults))
            While Not EOF(1)
                FileGet(1, RetrieveResults, i)
            End While
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to retrieve student data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("Debug test for & " & lstStudents.SelectedItem.Remove(0, 4) & ": RetrieveResults.TotalScore is " & RetrieveResults.TotalScore & " & numofattempts is " & RetrieveResults.NumOfAttempts)

        ' Read a line in. Analyse it, and plot a point on the graph with it.
    End Sub

    'Private Sub drawline()
    '    Dim formgraphics As Drawing.Graphics
    '    Dim Y1, Y2 As Integer
    '    Dim lblAxis(10) As Label
    '    Dim loc(10) As Point
    '    Randomize()
    '    formgraphics = Me.CreateGraphics
    '    formgraphics.DrawLine(Pens.Black, 50, 50, 50, 320)
    '    formgraphics.DrawLine(Pens.Black, 50, 320, 600, 320)

    '    For i = 0 To 5
    '        loc(i).X = i * 100 + 45
    '        loc(i).Y = 330
    '        lblAxis(i) = New Label
    '        lblAxis(i).Location = loc(i)
    '        lblAxis(i).Text = loc(i).X - 45
    '        Me.Controls.Add(lblAxis(i))
    '    Next i

    '    ' Change co-ordinates to label the y axis
    '    'For i = 0 To 5
    '    '    loc(i).Y = i * 100 + 45
    '    '    loc(i).Y = 100
    '    '    lblAxis(i) = New Label
    '    '    lblAxis(i).Location = loc(i)
    '    '    lblAxis(i).Text = loc(i).Y - 45
    '    '    Me.Controls.Add(lblAxis(i))
    '    'Next i

    '    Y1 = 100
    '    For x = 50 To 500 Step 50
    '        Y2 = Rnd() * 200 + 50
    '        formgraphics.DrawLine(Pens.Red, x, Y1, x + 50, Y2)
    '        Y1 = Y2
    '    Next
    'End Sub

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
End Class