Imports System.Text.RegularExpressions
Public Class frmViewClassProgress
    Structure AddClass
        <VBFixedString(5)> Public ClassName As String
        <VBFixedString(3)> Public ClassSize As String
        <VBFixedString(150)> Public Students As String
    End Structure
    Dim PopulateClass As AddClass

    Public Class StudentInformation
        Public StudentName As String
        Public StudentScores As String
        Public StudentAttempts As String
    End Class
    Dim sInfo As List(Of StudentInformation) = New List(Of StudentInformation)()

    Private Sub frmViewClassProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Me.WindowState.Maximized
        Me.Visible = True

        ' Display names of classes in cmbSelectClass
        GetClassnames()
    End Sub

    Private Sub GetClassnames()
        ' Retrieve class names from textfile
        Try
            Dim i As Integer = 1
            FileOpen(1, "classes.txt", OpenMode.Random, , , Len(PopulateClass))
            While Not EOF(1)
                FileGet(1, PopulateClass, i)
                ' Add name to listbox
                cmbSelectClass.Items.Add(PopulateClass.ClassName)
                i += 1
            End While
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to retrive your data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSelectClass_Click(sender As Object, e As EventArgs) Handles btnSelectClass.Click
        ' Retrieve student names into an instance of the student scores structure

        ' Fetch current class
        RetrieveClassStruc(cmbSelectClass.SelectedItem)

        ' Add class name to label
        lblStudents.Text = "Students in class: " & cmbSelectClass.SelectedItem

        ' Clear contents of sInfo
        sInfo.Clear()

        ' Fetch student names from file
        PopulateStudentList()

        ' Display student names
        PopulatelstStudentNames()

        ' Populate bar chart with average scores for each student in the class
        PopulateBarChart()

        ' Populate line graph with average scores for each attempt across the class
        PopulateLineGraph()
    End Sub

    Private Sub RetrieveClassStruc(ByVal ClassName As String)
        ' Fetch instance of AddClass structure that contains the selected class name
        Try
            Dim i As Integer = 1
            FileOpen(1, "classes.txt", OpenMode.Random, , , Len(PopulateClass))
            Do Until EOF(1) Or PopulateClass.ClassName = ClassName
                FileGet(1, PopulateClass, i)
                i += 1
            Loop
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to retrive your data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateStudentList()
        ' Split PopulateClass.Students by the commma
        Dim ArrayOfStudentNames As String() = PopulateClass.Students.Split(New Char() {","c})
        Dim StudentName As String
        ' Add each student to lstStudentNames
        For Each StudentName In ArrayOfStudentNames
            ' Collect together data stored about the student's results from .txt files
            GatherStudentInformation(StudentName)
        Next
    End Sub

    Private Sub GatherStudentInformation(ByVal StudentName As String)
        ' Add student name to sInfo list
        Dim StudentScores As String
        Dim StudentAttempts As String
        Try
            StudentScores = My.Computer.FileSystem.ReadAllText(RemoveWhitespace(StudentName) & ".txt")
            StudentAttempts = My.Computer.FileSystem.ReadAllText(RemoveWhitespace(StudentName) & "Attempts.txt")
            sInfo.Add(New StudentInformation() With {.StudentName = StudentName, .StudentScores = StudentScores, .StudentAttempts = StudentAttempts})
        Catch ex As Exception
            MessageBox.Show("Invalid class name. Please select a classname from the combo box.")
        End Try
    End Sub

    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Private Sub PopulatelstStudentNames()
        ' Clear lstStudentNames
        lstStudentNames.Items.Clear()
        For i = 0 To sInfo.Count - 1
            lstStudentNames.Items.Add(sInfo(i).StudentName.Trim())
        Next
    End Sub

    Private Sub PopulateBarChart()
        ' Reset bar chart 
        chtStudentAverages.Series.Clear()
        chtStudentAverages.Series.Add("Students")

        ' Declare array to hold student scores
        Dim StudentScores(sInfo.Count - 1) As Integer

        For i = 0 To sInfo.Count - 1
            StudentScores(i) = CalculateStudentScoresAvg(sInfo(i).StudentScores.Substring(0, 12))
        Next

        ' Quicksort student scores
        InitiateQuicksort(StudentScores)

        ' Plot average score for each student on bar chart in descending order
        For i = sInfo.Count - 1 To 0 Step -1
            Me.chtStudentAverages.Series("Students").Points.AddXY(sInfo(i).StudentName, StudentScores(i))
        Next
    End Sub

    Private Function CalculateStudentScoresAvg(ByRef strToAverage As String)
        ' Calculate average of the StudentScores variable in the StudentInformation structure
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

    Private Function CalculateStudentAttemptsAvg(ByVal ResultsLine As String)
        ' Return the average of a single line from sInfo(n).StudentAttempts
        Dim Results(3) As Integer

        For i = 0 To 2
            Results(i) = CInt(ResultsLine.Substring((3 * i), 3))
        Next
        Return Math.Round(Results.Average())
    End Function

    Sub InitiateQuicksort(ByRef StudentScores() As Integer)
        Dim First As Integer = 0
        Dim Last As Integer = sInfo.Count - 1

        Dim str As String = ""

        Call Quicksort(First, Last, StudentScores)

        For i = 0 To sInfo.Count - 1
            str += StudentScores(i) & " "
        Next
    End Sub

    Sub Quicksort(ByVal First As Integer, ByVal Last As Integer, ByRef StudentScores() As Integer)
        ' Perform a quicksort on the array of student scores
        Dim j As Integer
        Dim k As Integer
        If First < Last Then
            j = First
            k = Last + 1
            Do
                Do
                    j += 1
                Loop Until StudentScores(j) >= StudentScores(First) Or j = Last

                Do
                    k -= 1
                Loop Until StudentScores(k) <= StudentScores(First)

                If j < k Then
                    Call Swap(StudentScores(j), StudentScores(k))
                End If
            Loop Until j >= k
            Call Swap(StudentScores(First), StudentScores(k))
            Call Quicksort(First, k - 1, StudentScores)
            Call Quicksort(k + 1, Last, StudentScores)
        End If
    End Sub

    Private Sub Swap(ByRef A As String, ByRef B As String)
        Dim Temp As String
        Temp = A
        A = B
        B = Temp
    End Sub

    Private Sub PopulateLineGraph()
        ' Populate line graph with combined average of each student's average score
        Dim arrOfStudentAttempts As String()
        Dim avgOfStudentAttempts(5) As Integer
        Dim ClassAvg(sInfo.Count - 1) As Integer

        ' Calculate average score for each student
        For i = 0 To sInfo.Count - 1
            ' Split each line of an instance of StudentAttempts into an array using Regex
            arrOfStudentAttempts = Regex.Split(sInfo(i).StudentAttempts, Environment.NewLine)

            ' Declare new integer array to hold average of each individual line
            ReDim Preserve avgOfStudentAttempts(arrOfStudentAttempts.Length - 1)

            For j = 0 To arrOfStudentAttempts.Length - 1
                avgOfStudentAttempts(j) = CalculateStudentAttemptsAvg(arrOfStudentAttempts(j).Trim())
            Next

            ClassAvg(i) = avgOfStudentAttempts.Average()
        Next

        For k = 0 To ClassAvg.Length - 1
            Me.chtAvgOfAttempts.Series("Average Score Per Attempt").Points.AddXY(k + 1, ClassAvg(k))
        Next
    End Sub

    Private Sub btnGoToGraph2_Click(sender As Object, e As EventArgs) Handles btnGoToGraph2.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub btnGoToGraph1_Click(sender As Object, e As EventArgs) Handles btnGoToGraph1.Click
        Panel2.Visible = False
        Panel1.Visible = True
    End Sub
End Class