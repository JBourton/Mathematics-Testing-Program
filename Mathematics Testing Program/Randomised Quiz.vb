Imports System.IO
Public Class frmRandomisedQuiz
    Public QuestionList As New List(Of String)
    Public FromSubTopic As Boolean

    Private MultipleChoiceAnswer As String = "N/A"
    Private NextQuestionNumber As Integer = 1
    Private Rndm As New Random
    Private UserAnswer As String
    Private Markscheme As Boolean
    Private SW As StreamWriter

    Structure Question
        Public QuestionTitle As String
        Public QuestionType As String
        Public NumberOfButtons As Integer
        Public ModuleType As String
        Public Topic As String
        Public SubTopic As String
        Public QuestionNumber As Integer
        Public CorrectAnswer As String
        Public DifficultyLevel As Integer
        Public IsAnswered As Boolean
        Public IsCorrect As Boolean
    End Structure

    Dim Question1 As New Question
    Dim Question2 As New Question
    Dim Question3 As New Question
    Dim Question4 As New Question
    Dim Question5 As New Question

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
    Dim SaveResults As New TestResults

    Private Sub RandomisedQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        For Each item In QuestionList
            MessageBox.Show(item)
        Next
        LoadQuiz(QuestionList, FromSubTopic)
    End Sub

    Private Sub LoadQuizButtons(ByVal NumberOfButtons As Integer)
        Dim btnMultipleChoice(NumberOfButtons) As Button
        Dim btnAdditonalControls(5) As Button

        ' Dynamically generate multiple choice input controls
        Dim X, Y As Integer
        Dim count As Integer
        Dim letters As String = "ABCDEFGH"
        ' Value of zero buttons is stored as 100 (value cannot be null)
        If NumberOfButtons > 8 Then
            X = 930
            Y = 200
            ' Generate text box
            AddNewTextBox(X, Y)

        ElseIf NumberOfButtons Mod 2 <> 0 Then
            ' Generate odd number of buttons
            X = 925
            Y = 60
            count = 0
            For i = 1 To (NumberOfButtons / 2)
                For j = 1 To 2
                    count += 1
                    btnMultipleChoice(count) = New Button
                    btnMultipleChoice(count).Location = New Point(X, Y)
                    btnMultipleChoice(count).Width = 90
                    btnMultipleChoice(count).Height = 65
                    btnMultipleChoice(count).Text = letters.Substring(count - 1, 1)
                    btnMultipleChoice(count).Name = "btn" & letters.Substring(count - 1, 1)
                    btnMultipleChoice(count).Font = New Font("Segoe UI", 16.0)
                    Me.Controls.Add(btnMultipleChoice(count))
                    X += 125
                Next
                Y += 80
                X = 925
            Next
            ' Add additional odd button
            count += 1
            X = 925
            btnMultipleChoice(count) = New Button
            btnMultipleChoice(count).Location = New Point(X, Y)
            btnMultipleChoice(count).Width = 90
            btnMultipleChoice(count).Height = 65
            btnMultipleChoice(count).Text = letters.Substring(count - 1, 1)
            btnMultipleChoice(count).Name = "btn" & letters.Substring(count - 1, 1)
            btnMultipleChoice(count).Font = New Font("Segoe UI", 16.0)
            Me.Controls.Add(btnMultipleChoice(count))
        Else
            ' Generate even number of buttons
            X = 925
            Y = 60
            count = 0
            For i = 1 To (NumberOfButtons / 2)
                For j = 1 To 2
                    count += 1
                    btnMultipleChoice(count) = New Button
                    btnMultipleChoice(count).Location = New Point(X, Y)
                    btnMultipleChoice(count).Width = 90
                    btnMultipleChoice(count).Height = 65
                    btnMultipleChoice(count).Text = letters.Substring(count - 1, 1)
                    btnMultipleChoice(count).Name = "btn" & letters.Substring(count - 1, 1)
                    btnMultipleChoice(count).Font = New Font("Segoe UI", 16.0)
                    Me.Controls.Add(btnMultipleChoice(count))
                    X += 125
                Next
                Y += 80
                X = 925
            Next
        End If


        ' Dynamically generate additional control buttons
        count = 0
        For i = 1 To 5
            count += 1
            btnAdditonalControls(count) = New Button
            btnAdditonalControls(count).Width = 140
            btnAdditonalControls(count).Height = 50
            btnAdditonalControls(count).Font = New Font("Segoe UI", 14.0, FontStyle.Bold)
            Me.Controls.Add(btnAdditonalControls(count))
        Next

        btnAdditonalControls(1).Location = New Point(960, 360)
        btnAdditonalControls(1).Text = "Submit"
        btnAdditonalControls(1).Name = "btnSubmit"

        btnAdditonalControls(2).Location = New Point(870, 480)
        btnAdditonalControls(2).Text = "Previous"
        btnAdditonalControls(2).Name = "btnPrevious"

        btnAdditonalControls(3).Location = New Point(1050, 480)
        btnAdditonalControls(3).Text = "Next"
        btnAdditonalControls(3).Name = "btnNext"

        btnAdditonalControls(4).Location = New Point(960, 540)
        btnAdditonalControls(4).Text = "End Quiz"
        btnAdditonalControls(4).Name = "btnEndQuiz"
        btnAdditonalControls(4).ForeColor = Color.Maroon

        btnAdditonalControls(5).Location = New Point(960, 300)
        btnAdditonalControls(5).Text = "Input Rules"
        btnAdditonalControls(5).Name = "btnInputRules"

        ' Add handlers 
        Select Case NumberOfButtons
            Case = 1
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
            Case = 2
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
            Case = 3
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
                AddHandler btnMultipleChoice(3).Click, AddressOf btnClickC
            Case = 4
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
                AddHandler btnMultipleChoice(3).Click, AddressOf btnClickC
                AddHandler btnMultipleChoice(4).Click, AddressOf btnClickD
            Case = 5
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
                AddHandler btnMultipleChoice(3).Click, AddressOf btnClickC
                AddHandler btnMultipleChoice(4).Click, AddressOf btnClickD
                AddHandler btnMultipleChoice(5).Click, AddressOf btnClickE
            Case = 6
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
                AddHandler btnMultipleChoice(3).Click, AddressOf btnClickC
                AddHandler btnMultipleChoice(4).Click, AddressOf btnClickD
                AddHandler btnMultipleChoice(5).Click, AddressOf btnClickE
                AddHandler btnMultipleChoice(6).Click, AddressOf btnClickF
            Case = 7
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
                AddHandler btnMultipleChoice(3).Click, AddressOf btnClickC
                AddHandler btnMultipleChoice(4).Click, AddressOf btnClickD
                AddHandler btnMultipleChoice(5).Click, AddressOf btnClickE
                AddHandler btnMultipleChoice(6).Click, AddressOf btnClickF
                AddHandler btnMultipleChoice(7).Click, AddressOf btnClickG
            Case = 8
                AddHandler btnMultipleChoice(1).Click, AddressOf btnClickA
                AddHandler btnMultipleChoice(2).Click, AddressOf btnClickB
                AddHandler btnMultipleChoice(3).Click, AddressOf btnClickC
                AddHandler btnMultipleChoice(4).Click, AddressOf btnClickD
                AddHandler btnMultipleChoice(5).Click, AddressOf btnClickE
                AddHandler btnMultipleChoice(6).Click, AddressOf btnClickF
                AddHandler btnMultipleChoice(7).Click, AddressOf btnClickG
                AddHandler btnMultipleChoice(8).Click, AddressOf btnClickH
        End Select


        AddHandler btnAdditonalControls(1).Click, AddressOf btnSubmit_Click
        AddHandler btnAdditonalControls(2).Click, AddressOf btnPrevious_Click
        AddHandler btnAdditonalControls(3).Click, AddressOf btnNext_Click
        AddHandler btnAdditonalControls(4).Click, AddressOf btnEndQuiz_Click
        AddHandler btnAdditonalControls(5).Click, AddressOf btnInputRules_Click
    End Sub

    Private Function AddNewTextBox(ByVal X As Integer, ByVal Y As Integer) As System.Windows.Forms.TextBox
        Dim txtAnswer As New System.Windows.Forms.TextBox()
        Me.Controls.Add(txtAnswer)
        txtAnswer.Location = New Point(X, Y)
        txtAnswer.Name = "txtAnswerBox"
        txtAnswer.Width = 200
        txtAnswer.Height = 60
        Return txtAnswer
    End Function

    Private Sub DeleteControls()
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is Button Or TypeOf Me.Controls(i) Is TextBox Then
                Me.Controls.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub DetermineQuestionToShow(ByVal CurrentQuestion As Question)
        ' Displays question image related to question name
        Select Case CurrentQuestion.QuestionTitle
            Case = "INDUCTION1"
                pcbQuestions.Image = My.Resources.INDUCTION1_QUE
            Case = "INDUCTION2"
                pcbQuestions.Image = My.Resources.INDUCTION2_QUE
            Case = "COUNTEREXAMPLE1"
                pcbQuestions.Image = My.Resources.COUNTEREXAMPLE1_QUE
            Case = "COUNTEREXAMPLE2"
                pcbQuestions.Image = My.Resources.COUNTEREXAMPLE2_QUE
            Case = "INTEGRATING_E1"
                pcbQuestions.Image = My.Resources.INTEGRATING_E1_QUE
            Case = "INTEGRATING_LN1"
                pcbQuestions.Image = My.Resources.INTEGRATINGLN_1_QUE
            Case = "VENNDIAGRAMS1"
                pcbQuestions.Image = My.Resources.VENNDIAGRAMS1_QUE
            Case = "LAWSOFPROBABILITY1"
                pcbQuestions.Image = My.Resources.LAWSOFPROBABILITY1_QUE
            Case = "BINOMIAL1"
                pcbQuestions.Image = My.Resources.BINOMIAL1_QUE
            Case = "NORMAL1"
                pcbQuestions.Image = My.Resources.NORMAL1_QUE
            Case = "ELASTICIN2D1"
                pcbQuestions.Image = My.Resources.ELASTICIN2D1_QUE
            Case = "ELASTICIN2D2"
                pcbQuestions.Image = My.Resources.ELASTICIN2D2_QUE
            Case = "OBLIQUE1"
                pcbQuestions.Image = My.Resources.OBLIQUE1_QUE
            Case = "KINETIC1"
                pcbQuestions.Image = My.Resources.KINETIC1_QUE
            Case = "GRAVITATIONAL1"
                pcbQuestions.Image = My.Resources.GRAVITATIONAL1_QUE
            Case Else
                MessageBox.Show("ERROR: IMAGE COULD NOT BE FOUND: STRING TO BE PARSED WAS " & CurrentQuestion.QuestionTitle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub DetermineAnswerToShow(ByVal CurrentAnswer As Question)
        ' Displays answer image related to answer name
        Select Case CurrentAnswer.QuestionTitle
            Case = "INDUCTION1"
                pcbQuestions.Image = My.Resources.INDUCTION01_ANS
            Case = "INDUCTION2"
                pcbQuestions.Image = My.Resources.INDUCTION02_ANS
            Case = "COUNTEREXAMPLE1"
                pcbQuestions.Image = My.Resources.COUNTEREXAMPLE1_ANS
            Case = "COUNTEREXAMPLE2"
                pcbQuestions.Image = My.Resources.COUNTEREXAMPLE2_ANS
            Case = "INTEGRATING_E1"
                pcbQuestions.Image = My.Resources.INTEGRATING_E1_ANS
            Case = "INTEGRATING_LN1"
                pcbQuestions.Image = My.Resources.INTEGRATING_LN1_ANS
            Case = "VENNDIAGRAMS1"
                pcbQuestions.Image = My.Resources.VENNDIAGRAMS1_ANS
            Case = "LAWSOFPROBABILITY1"
                pcbQuestions.Image = My.Resources.LAWSOFPROBABILITY1_ANS
            Case = "BINOMIAL1"
                pcbQuestions.Image = My.Resources.BINOMIAL1_ANS
            Case = "NORMAL1"
                pcbQuestions.Image = My.Resources.NORMAL1_ANS
            Case = "ELASTICIN2D1"
                pcbQuestions.Image = My.Resources.ELASTICIN2D1_ANS
            Case = "ELASTICIN2D2"
                pcbQuestions.Image = My.Resources.ELASTICIN2D2_ANS
            Case = "OBLIQUE1"
                pcbQuestions.Image = My.Resources.OBLIQUE1_ANS
            Case = "KINETIC1"
                pcbQuestions.Image = My.Resources.KINETIC1_ANS
            Case = "GRAVITATIONAL1"
                pcbQuestions.Image = My.Resources.GRAVITATIONAL1_ANS
            Case Else
                MessageBox.Show("ERROR: IMAGE COULD NOT BE FOUND: STRING TO BE PARSED WAS " & CurrentAnswer.QuestionTitle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub btnClickA(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "A"
        lblSelection.Text = "Your Selection: A"
    End Sub

    Private Sub btnClickB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "B"
        lblSelection.Text = "Your Selection: B"
    End Sub

    Private Sub btnClickC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "C"
        lblSelection.Text = "Your Selection: C"
    End Sub

    Private Sub btnClickD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "D"
        lblSelection.Text = "Your Selection: D"
    End Sub

    Private Sub btnClickE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "E"
        lblSelection.Text = "Your Selection: E"
    End Sub

    Private Sub btnClickF(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "F"
        lblSelection.Text = "Your Selection: F"
    End Sub

    Private Sub btnClickG(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "G"
        lblSelection.Text = "Your Selection: G"
    End Sub

    Private Sub btnClickH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MultipleChoiceAnswer = "H"
        lblSelection.Text = "Your Selection: H"
    End Sub

    Private Sub btnInputRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("The rules for inputting values into textboxes are as follows: " & Environment.NewLine & "Exponents: ^ " & Environment.NewLine & "Multiplication: *" & Environment.NewLine & "Division: /", "Input Rules", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function FormContainsTextbox()
        ' Check if textbox is present on form
        Dim ContainsTextbox As Boolean
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is TextBox Then
                ContainsTextbox = True
            End If
        Next
        Return ContainsTextbox
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        ' Determine if form contains a textbox
        Dim ContainsTextbox As Boolean
        ContainsTextbox = FormContainsTextbox()

        Dim ActiveQuesiton As New Question
        ActiveQuesiton = DetermineNextQuestion()

        If ContainsTextbox Then
            ' Search the form for the textbox
            For i As Integer = Me.Controls.Count - 1 To 0 Step -1
                If TypeOf Me.Controls(i) Is TextBox Then
                    ' Check if textbox is empty
                    If Not Me.Controls(i).Text Is Nothing Then
                        ActiveQuesiton.IsAnswered = True
                        ' Compare textbox value to correct answer
                        If Me.Controls(i).Text = ActiveQuesiton.CorrectAnswer Then
                            ActiveQuesiton.IsCorrect = True
                        End If
                        Me.lblAnswered.Text = "Answered: ✓"
                        TransferAnswer(ActiveQuesiton)
                    Else
                        MessageBox.Show("No answer has been input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Next
        Else
            ' If form does not contain textbox, determine if a button has been pressed
            If Not Me.lblSelection.Text = "Your Selection: N/A" Then
                Me.lblSelection.Text = "Your Selection: N/A"
                ActiveQuesiton.IsAnswered = True
                Me.lblAnswered.Text = "Answered: ✓"
                ' Determine if the button pressed is the correct answer
                If MultipleChoiceAnswer = ActiveQuesiton.CorrectAnswer Then
                    ActiveQuesiton.IsCorrect = True
                Else
                    ActiveQuesiton.IsCorrect = False
                End If
                TransferAnswer(ActiveQuesiton)
            Else
                MessageBox.Show("No answer has been input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        MultipleChoiceAnswer = "N/A"
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        ' Cycle through questions
        Dim NextQuestion As Question
        NextQuestionNumber += 1
        If NextQuestionNumber > 5 Then
            NextQuestionNumber = 1
        End If
        ' Fetching next question details
        NextQuestion = DetermineNextQuestion()
        DeleteControls()
        ' Reloading buttons for next question
        LoadQuizButtons(NextQuestion.NumberOfButtons)
        ' Displaying next question
        If Markscheme Then
            DetermineAnswerToShow(NextQuestion)
        Else
            DetermineQuestionToShow(NextQuestion)
        End If
        UpdateAnswerLabel()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs)
        ' Cycle through questions
        Dim NextQuestion As Question
        NextQuestionNumber -= 1
        If NextQuestionNumber < 1 Then
            NextQuestionNumber = 5
        End If
        ' Fetching next question details
        NextQuestion = DetermineNextQuestion()
        DeleteControls()
        ' Reloading buttons for next question
        LoadQuizButtons(NextQuestion.NumberOfButtons)
        ' Displaying next question
        If Markscheme Then
            DetermineAnswerToShow(NextQuestion)
        Else
            DetermineQuestionToShow(NextQuestion)
        End If
        UpdateAnswerLabel()
    End Sub

    Private Function DetermineNextQuestion()
        ' Fetches next question number
        Dim ActiveQuestion As New Question
        If NextQuestionNumber = Question1.QuestionNumber Then
            ActiveQuestion = Question1
        ElseIf NextQuestionNumber = Question2.QuestionNumber Then
            ActiveQuestion = Question2
        ElseIf NextQuestionNumber = Question3.QuestionNumber Then
            ActiveQuestion = Question3
        ElseIf NextQuestionNumber = Question4.QuestionNumber Then
            ActiveQuestion = Question4
        ElseIf NextQuestionNumber = Question5.QuestionNumber Then
            ActiveQuestion = Question5
        Else
            MessageBox.Show("An error has occured whilst attempting to switch questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return ActiveQuestion
    End Function

    Private Sub TransferAnswer(ByVal ActiveQuestion As Question)
        ' Transfer values over from placeholder structure to current question structure
        If NextQuestionNumber = Question1.QuestionNumber Then
            Question1.IsAnswered = ActiveQuestion.IsAnswered
            Question1.IsCorrect = ActiveQuestion.IsCorrect
        ElseIf NextQuestionNumber = Question2.QuestionNumber Then
            Question2.IsAnswered = ActiveQuestion.IsAnswered
            Question2.IsCorrect = ActiveQuestion.IsCorrect
        ElseIf NextQuestionNumber = Question3.QuestionNumber Then
            Question3.IsAnswered = ActiveQuestion.IsAnswered
            Question3.IsCorrect = ActiveQuestion.IsCorrect
        ElseIf NextQuestionNumber = Question4.QuestionNumber Then
            Question4.IsAnswered = ActiveQuestion.IsAnswered
            Question4.IsCorrect = ActiveQuestion.IsCorrect
        ElseIf NextQuestionNumber = Question5.QuestionNumber Then
            Question5.IsAnswered = ActiveQuestion.IsAnswered
            Question5.IsCorrect = ActiveQuestion.IsCorrect
        End If
    End Sub

    Private Sub btnEndQuiz_Click(sender As Object, e As EventArgs)
        Dim TotalScore As Integer
        Dim Sucsessful As Boolean

        Dim ViewMarkScheme As String

        ' Determine if the user has already been asked whether or not they want to view the markscheme
        If Not Markscheme Then
            ' Determine total score
            If Question1.IsCorrect = True Then TotalScore += 1
            If Question2.IsCorrect = True Then TotalScore += 1
            If Question3.IsCorrect = True Then TotalScore += 1
            If Question4.IsCorrect = True Then TotalScore += 1
            If Question5.IsCorrect = True Then TotalScore += 1

            MessageBox.Show("Your total score is: " & TotalScore)

            ' Display markscheme if user specifies to do so
            ViewMarkScheme = MsgBox("Thank you for taking the quiz. Would you like to view the markscheme?", vbQuestion + vbYesNo + vbDefaultButton2, "Notice")
            If ViewMarkScheme = vbYes Then
                Markscheme = True
                DetermineAnswerToShow(Question1)
            End If
        End If

        ' Read student's question data from file into SaveResults structure
        ReadData(Sucsessful)

        ' Place quiz results into SaveResults structure
        If Sucsessful Then
            UpdateResults(Question1)
            UpdateResults(Question2)
            UpdateResults(Question3)
            UpdateResults(Question4)
            UpdateResults(Question5)
        End If

        ' Overwrite contents of files with updated SaveResults structure & module averages
        WriteData()

        ' Reset Question structure values
        Question1.IsCorrect = False
        Question1.IsAnswered = False
        Question2.IsCorrect = False
        Question2.IsAnswered = False
        Question3.IsCorrect = False
        Question3.IsAnswered = False
        Question4.IsCorrect = False
        Question4.IsAnswered = False
        Question5.IsCorrect = False
        Question5.IsAnswered = False
    End Sub

    Private Sub ReadData(ByRef Sucsessful As Boolean)
        Dim filename As String = FetchFilename()
        Dim Score As Integer

        ' Populate instance of TestResults structure with values from a file
        Sucsessful = False
        Try
            Dim i As Integer = 1
            FileOpen(1, filename, OpenMode.Random, , , Len(SaveResults))
            While Not EOF(1)
                FileGet(1, SaveResults, i)
                i += 1
            End While
            FileClose(1)

            ' Increment SaveResults.NumOfAttempts by 1
            Score = CInt(SaveResults.NumOfAttempts.Substring(1, 5))
            Score += 1
            SaveResults.NumOfAttempts = CStr(Score)
            InsertLeadingZeros(SaveResults.NumOfAttempts)
            SaveResults.NumOfAttempts = "/" & SaveResults.NumOfAttempts

            Sucsessful = True
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to fetch your data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileClose(1)
        End Try
    End Sub

    Private Function FetchFilename()
        ' Fetch students's names from the login form
        Dim forename As String
        Dim surname As String
        Dim filename As String

        forename = frmLoginPage.UserLoginStructure.Forename.Trim()
        surname = frmLoginPage.UserLoginStructure.Surname.Trim()

        frmLoginPage.ASCIIDecryption(forename)
        frmLoginPage.ASCIIDecryption(surname)

        filename = forename + surname + ".txt"
        Return filename
    End Function

    Private Sub WriteData()
        Dim filename As String = FetchFilename()
        Dim avgScore As String = CalculateAverageScore()

        ' Overwrite contents of results file with values stored in an instance of the TestResults structure
        Try
            FileOpen(2, filename, OpenMode.Random, , , Len(SaveResults))
            With SaveResults
                .TotalScore = SaveResults.TotalScore
                .PureScore = SaveResults.PureScore
                .StatisticsScore = SaveResults.StatisticsScore
                .MechanicsScore = SaveResults.MechanicsScore
                .ProofScore = SaveResults.ProofScore
                .IntegrationScore = SaveResults.IntegrationScore
                .ProbabilityScore = SaveResults.ProbabilityScore
                .DistributionsScore = SaveResults.DistributionsScore
                .CollisionsScore = SaveResults.CollisionsScore
                .EnergyScore = SaveResults.EnergyScore
                .InductionScore = SaveResults.InductionScore
                .CounterexampleScore = SaveResults.CounterexampleScore
                .Integrating_E_Score = SaveResults.Integrating_E_Score
                .Integrating_LN_Score = SaveResults.Integrating_LN_Score
                .VennDiagramsScore = SaveResults.VennDiagramsScore
                .LawsOfProbabilityScore = SaveResults.LawsOfProbabilityScore
                .BinomialScore = SaveResults.BinomialScore
                .NormalScore = SaveResults.NormalScore
                .ElasticIn2DScore = SaveResults.ElasticIn2DScore
                .ObliqueScore = SaveResults.ObliqueScore
                .KinecticScore = SaveResults.KinecticScore
                .GravitationalScore = SaveResults.GravitationalScore
                .NumOfAttempts = SaveResults.NumOfAttempts
            End With
            FilePut(2, SaveResults, 1)
            FileClose(2)

            ' Update filename
            filename = filename.Insert(filename.Length - 4, "Attempts")

            ' Write percentage score to student's Attempt file
            SW = New StreamWriter(filename, True)
            SW.WriteLine(avgScore)
            SW.Close()
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to save your test result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FileClose(2)
        End Try
    End Sub

    Private Sub IncrementIfIsTopic(ByVal QuestionX As Question, ByVal ModuleType As String, ByRef TotalNum As Integer, ByRef TotalNumCorrect As String)
        ' Increments the counter variables to keep track of how many questions for a particular topic have been answered, and how many are correct
        If QuestionX.ModuleType = ModuleType Then
            TotalNum += 1
            If QuestionX.IsCorrect = True Then TotalNumCorrect += 1
        End If

    End Sub

    Private Sub AddAverageToString(ByRef CombinedAvg As String, ByVal TotalNum As Integer, ByVal TotalNumCorrect As Integer)
        ' Add topic average onto combined average string
        Dim avg As String
        If TotalNum = 0 Then
            CombinedAvg += "///"
        Else
            avg = CStr(Math.Round((TotalNumCorrect / TotalNum) * 100, 0))
            ' Add leading zeros if necessary so avg is 2 chars long
            If avg.Length = 1 Then
                CombinedAvg = CombinedAvg + "00" + avg
            ElseIf avg.Length = 2 Then
                CombinedAvg = CombinedAvg + "0" + avg
            Else
                CombinedAvg += avg
            End If
        End If
    End Sub

    Private Sub ResetTotalNumVariables(ByRef TotalNum As Integer, ByRef TotalNumCorrect As Integer)
        ' Set TotalNum variables to 0
        TotalNum = 0
        TotalNumCorrect = 0
    End Sub

    Private Function CalculateAverageScore()
        ' Return a single string containing the number of attempts (4 chars) and percentage correct (2 chars) for each topic
        Dim TotalNum As Integer
        Dim TotalNumCorrect As Integer
        Dim CombinedAvg As String

        ' Calculate pure maths average
        IncrementIfIsTopic(Question1, "PUREMATHS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question2, "PUREMATHS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question3, "PUREMATHS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question4, "PUREMATHS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question5, "PUREMATHS", TotalNum, TotalNumCorrect)
        AddAverageToString(CombinedAvg, TotalNum, TotalNumCorrect)
        ResetTotalNumVariables(TotalNum, TotalNumCorrect)

        ' Calculate statistics average
        IncrementIfIsTopic(Question1, "STATISTICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question2, "STATISTICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question3, "STATISTICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question4, "STATISTICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question5, "STATISTICS", TotalNum, TotalNumCorrect)
        AddAverageToString(CombinedAvg, TotalNum, TotalNumCorrect)
        ResetTotalNumVariables(TotalNum, TotalNumCorrect)

        ' Calculate mechanics average
        IncrementIfIsTopic(Question1, "MECHANICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question2, "MECHANICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question3, "MECHANICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question4, "MECHANICS", TotalNum, TotalNumCorrect)
        IncrementIfIsTopic(Question5, "MECHANICS", TotalNum, TotalNumCorrect)
        AddAverageToString(CombinedAvg, TotalNum, TotalNumCorrect)
        ResetTotalNumVariables(TotalNum, TotalNumCorrect)
        Return CombinedAvg
    End Function

    Private Sub UpdateResults(ByVal CurrentQuestion As Question)
        ' Each results string is in format Total attempts correct (6 chars) / Total attempts incorect (6 chars)

        Dim ResultsString As String

        ' Update .TotalScore 
        ResultsString = SaveResults.TotalScore
        IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
        SaveResults.TotalScore = ResultsString

        ' Update SaveResults to include new scores for module, topic & subtopic
        Select Case CurrentQuestion.SubTopic
            Case = "INDUCTION"
                ' Update module score
                ResultsString = SaveResults.PureScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.PureScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.ProofScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.ProofScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.InductionScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.InductionScore = ResultsString
            Case = "COUNTEREXAMPLE"
                ' Update module score
                ResultsString = SaveResults.PureScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.PureScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.ProofScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.ProofScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.CounterexampleScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.CounterexampleScore = ResultsString
            Case = "INTEGRATING_E"
                ' Update module score
                ResultsString = SaveResults.PureScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.PureScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.IntegrationScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.IntegrationScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.Integrating_E_Score
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.Integrating_E_Score = ResultsString
            Case = "INTEGRATING_LN"
                ' Update module score
                ResultsString = SaveResults.PureScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.PureScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.IntegrationScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.IntegrationScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.Integrating_LN_Score
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.Integrating_LN_Score = ResultsString
            Case = "VENNDIAGRAMS"
                ' Update module score
                ResultsString = SaveResults.StatisticsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.StatisticsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.ProbabilityScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.ProbabilityScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.VennDiagramsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.VennDiagramsScore = ResultsString
            Case = "LAWSOFPROBABILITY"
                ' Update module score
                ResultsString = SaveResults.StatisticsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.StatisticsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.ProbabilityScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.ProbabilityScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.LawsOfProbabilityScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.LawsOfProbabilityScore = ResultsString
            Case = "BINOMIAL"
                ' Update module score
                ResultsString = SaveResults.StatisticsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.StatisticsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.DistributionsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.DistributionsScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.BinomialScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.BinomialScore = ResultsString
            Case = "NORMAL"
                ' Update module score
                ResultsString = SaveResults.StatisticsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.StatisticsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.DistributionsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.DistributionsScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.NormalScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.NormalScore = ResultsString
            Case = "ELASTICIN2D"
                ' Update module score
                ResultsString = SaveResults.MechanicsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.MechanicsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.CollisionsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.CollisionsScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.ElasticIn2DScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.ElasticIn2DScore = ResultsString
            Case = "OBLIQUE"
                ' Update module score
                ResultsString = SaveResults.MechanicsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.MechanicsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.CollisionsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.CollisionsScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.ObliqueScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.ObliqueScore = ResultsString
            Case = "KINETIC"
                ' Update module score
                ResultsString = SaveResults.MechanicsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.MechanicsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.EnergyScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.EnergyScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.KinecticScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.KinecticScore = ResultsString
            Case = "GRAVITATIONAL"
                ' Update module score
                ResultsString = SaveResults.MechanicsScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.MechanicsScore = ResultsString

                ' Update topic score
                ResultsString = SaveResults.EnergyScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.EnergyScore = ResultsString

                ' Update sub topic score
                ResultsString = SaveResults.GravitationalScore
                IncrementResultsString(ResultsString, CurrentQuestion.IsCorrect)
                SaveResults.GravitationalScore = ResultsString
        End Select
    End Sub

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

    Private Sub IncrementResultsString(ByRef ResultsString As String, ByVal Correct As Boolean)
        Dim Score As Integer
        Dim ResultsSubstring As String
        Try
            If Correct Then
                ' Fetch first part of ResultsString
                ResultsSubstring = ResultsString.Substring(1, 5)

                ' Increment int value
                Score = CInt(ResultsSubstring)
                Score += 1

                ' Convert back to string
                ResultsSubstring = CStr(Score)

                ' Insert leading zeros
                InsertLeadingZeros(ResultsSubstring)

                ' Insert incremented score into ResultsString
                ResultsString = ResultsString.Substring(0, 1) & ResultsSubstring & ResultsString.Substring(6, 6)
            Else
                ' Fetch second part of ResultsString
                ResultsSubstring = ResultsString.Substring(7, 5)

                ' Increment int value
                Score = CInt(ResultsSubstring)
                Score += 1

                ' Convert back to string
                ResultsSubstring = CStr(Score)

                ' Insert leading zeros
                InsertLeadingZeros(ResultsSubstring)

                ' Insert incremented score into ResultsString
                ResultsString = ResultsString.Substring(0, 7) & ResultsSubstring
            End If

        Catch ex As Exception
            Console.WriteLine("Error")
        End Try
    End Sub

    Private Sub InsertLeadingZeros(ByRef str As String)
        Select Case str.Length
            Case = 1
                str = "0000" & str
            Case = 2
                str = "000" & str
            Case = 3
                str = "00" & str
            Case = 4
                str = "0" & str
            Case Else
                ' Do nothing
        End Select
    End Sub

    Private Sub UpdateAnswerLabel()
        ' Update answer label to indicate to user whether current question has been answered
        If NextQuestionNumber = Question1.QuestionNumber Then
            If Question1.IsAnswered = False Then
                Me.lblAnswered.Text = "Answered: ⨉"
            Else
                Me.lblAnswered.Text = "Answered: ✓"
            End If
        ElseIf NextQuestionNumber = Question2.QuestionNumber Then
            If Question2.IsAnswered = False Then
                Me.lblAnswered.Text = "Answered: ⨉"
            Else
                Me.lblAnswered.Text = "Answered: ✓"
            End If
        ElseIf NextQuestionNumber = Question3.QuestionNumber Then
            If Question3.IsAnswered = False Then
                Me.lblAnswered.Text = "Answered: ⨉"
            Else
                Me.lblAnswered.Text = "Answered: ✓"
            End If
        ElseIf NextQuestionNumber = Question4.QuestionNumber Then
            If Question4.IsAnswered = False Then
                Me.lblAnswered.Text = "Answered: ⨉"
            Else
                Me.lblAnswered.Text = "Answered: ✓"
            End If
        ElseIf NextQuestionNumber = Question5.QuestionNumber Then
            If Question5.IsAnswered = False Then
                Me.lblAnswered.Text = "Answered: ⨉"
            Else
                Me.lblAnswered.Text = "Answered: ✓"
            End If
        End If
    End Sub

    Private Function SelectRandomQuestion() As String
        ' Randomly select a question name

        Dim rnd = New Random()
        Dim ModuleName As String
        Dim TopicName As String
        Dim SubTopicName As String

        Dim ModuleNames As New List(Of String)

        Dim PureTopicNames As New List(Of String)
        Dim StatisticTopicNames As New List(Of String)
        Dim MechanicsTopicNames As New List(Of String)

        Dim PureSubTopic_Proof As New List(Of String)
        Dim PureSubTopic_Integration As New List(Of String)

        Dim StatisticsSubTopic_Probability As New List(Of String)
        Dim StatisticsSubTopic_Distributions As New List(Of String)

        Dim MechanicsSubTopic_Collisions As New List(Of String)
        Dim MechanicsSubTopic_Energy As New List(Of String)

        ModuleNames.AddRange(New String() {"PUREMATHS", "STATISTICS", "MECHANICS"})

        PureTopicNames.AddRange(New String() {"PROOF", "INTEGRATION"})
        StatisticTopicNames.AddRange(New String() {"PROBABILITY", "DISTRIBUTIONS"})
        MechanicsTopicNames.AddRange(New String() {"COLLISIONS", "ENERGY"})

        PureSubTopic_Proof.AddRange(New String() {"INDUCTION1", "INDUCTION2", "COUNTEREXAMPLE1", "COUNTEREXAMPLE2"})
        PureSubTopic_Integration.AddRange(New String() {"INTEGRATING_E1", "INTEGRATING_LN1"})

        StatisticsSubTopic_Probability.AddRange(New String() {"VENNDIAGRAMS1", "LAWSOFPROBABILITY1"})
        StatisticsSubTopic_Distributions.AddRange(New String() {"BINOMIAL1", "NORMAL1"})

        MechanicsSubTopic_Collisions.AddRange(New String() {"ELASTICIN2D1", "ELASTICIN2D2", "OBLIQUE1"})
        MechanicsSubTopic_Energy.AddRange(New String() {"KINETIC1", "GRAVITATIONAL1"})

        ModuleName += ModuleNames(rnd.Next(0, ModuleNames.Count))

        Select Case ModuleName
            Case = "PUREMATHS"
                TopicName = PureTopicNames(rnd.Next(0, PureTopicNames.Count))
                Select Case TopicName
                    Case = "PROOF"
                        SubTopicName = PureSubTopic_Proof(rnd.Next(0, PureSubTopic_Proof.Count))
                    Case = "INTEGRATION"
                        TopicName = "INTEGRATION"
                        SubTopicName = PureSubTopic_Integration(rnd.Next(0, PureSubTopic_Integration.Count))
                    Case Else
                        MessageBox.Show("An error has occured whilst selecting the pure topic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Case = "STATISTICS"
                TopicName = StatisticTopicNames(rnd.Next(0, StatisticTopicNames.Count))
                Select Case TopicName
                    Case = "PROBABILITY"
                        SubTopicName = StatisticsSubTopic_Probability(rnd.Next(0, StatisticsSubTopic_Probability.Count))
                        TopicName = "PROBABILITY"
                    Case = "DISTRIBUTIONS"
                        SubTopicName = StatisticsSubTopic_Distributions(rnd.Next(0, StatisticsSubTopic_Distributions.Count))
                        TopicName = "DISTRIBUTIONS"
                    Case Else
                        MessageBox.Show("An error has occured whilst selecting the statistics topic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Case = "MECHANICS"
                TopicName = MechanicsTopicNames(rnd.Next(0, StatisticTopicNames.Count))
                Select Case TopicName
                    Case = "COLLISIONS"
                        SubTopicName = MechanicsSubTopic_Collisions(rnd.Next(0, MechanicsSubTopic_Collisions.Count))
                        TopicName = "COLLISIONS"
                    Case = "ENERGY"
                        TopicName = "ENERGY"
                        SubTopicName = MechanicsSubTopic_Energy(rnd.Next(0, MechanicsSubTopic_Energy.Count))
                    Case Else
                        MessageBox.Show("An error has occured whilst selecting the mechanics topic", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Case Else
                MessageBox.Show("An error has occured whilst selecting the module", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
        Return SubTopicName
    End Function

    Private Sub LoadQuiz(ByVal QuestionList As List(Of String), ByVal FromSubTopic As Boolean)
        Dim FileName As String
        Markscheme = False

        If Not FromSubTopic Then
            ' Delete contents of QuestionList
            QuestionList.Clear()
            ' Randomly select names of 5 questions for the quiz
            Dim ProcedurallyGeneratedQuestionNames(4) As String
            Dim strQuestionName As String
            For i = 0 To ProcedurallyGeneratedQuestionNames.Count - 1
                strQuestionName = SelectRandomQuestion()
                ' Prevent repeats of questions from being selected
                Do Until Not (ProcedurallyGeneratedQuestionNames.Contains(strQuestionName))
                    strQuestionName = SelectRandomQuestion()
                Loop
                ProcedurallyGeneratedQuestionNames(i) = strQuestionName
            Next
            ' Transfer contents of generated names over to QuestionList
            For Each item In ProcedurallyGeneratedQuestionNames
                QuestionList.AddRange(New String() {item})
            Next
        End If

        ' Reset values of SaveResults structure
        ResetTestResultsStructure(SaveResults)

        ' Read question information from text files
        Using reader As TextReader = New StringReader(My.Resources.ResourceManager.GetObject(QuestionList(0) & "_INF"))
            Question1.QuestionTitle = reader.ReadLine
            Question1.QuestionType = reader.ReadLine
            Question1.NumberOfButtons = reader.ReadLine
            Question1.ModuleType = reader.ReadLine
            Question1.Topic = reader.ReadLine
            Question1.SubTopic = reader.ReadLine
            Question1.CorrectAnswer = reader.ReadLine
            Question1.DifficultyLevel = reader.ReadLine
            Question1.IsAnswered = reader.ReadLine
            Question1.IsCorrect = reader.ReadLine
        End Using

        DetermineFileName(FileName, QuestionList, 1)
        Using reader As TextReader = New StringReader(My.Resources.ResourceManager.GetObject(FileName & "_INF"))
            Question2.QuestionTitle = reader.ReadLine
            Question2.QuestionType = reader.ReadLine
            Question2.NumberOfButtons = reader.ReadLine
            Question2.ModuleType = reader.ReadLine
            Question2.Topic = reader.ReadLine
            Question2.SubTopic = reader.ReadLine
            Question2.CorrectAnswer = reader.ReadLine
            Question2.DifficultyLevel = reader.ReadLine
            Question2.IsAnswered = reader.ReadLine
            Question2.IsCorrect = reader.ReadLine
        End Using

        DetermineFileName(FileName, QuestionList, 2)
        Using reader As TextReader = New StringReader(My.Resources.ResourceManager.GetObject(FileName & "_INF"))
            Question3.QuestionTitle = reader.ReadLine
            Question3.QuestionType = reader.ReadLine
            Question3.NumberOfButtons = reader.ReadLine
            Question3.ModuleType = reader.ReadLine
            Question3.Topic = reader.ReadLine
            Question3.SubTopic = reader.ReadLine
            Question3.CorrectAnswer = reader.ReadLine
            Question3.DifficultyLevel = reader.ReadLine
            Question3.IsAnswered = reader.ReadLine
            Question3.IsCorrect = reader.ReadLine
        End Using

        DetermineFileName(FileName, QuestionList, 3)
        Using reader As TextReader = New StringReader(My.Resources.ResourceManager.GetObject(FileName & "_INF"))
            Question4.QuestionTitle = reader.ReadLine
            Question4.QuestionType = reader.ReadLine
            Question4.NumberOfButtons = reader.ReadLine
            Question4.ModuleType = reader.ReadLine
            Question4.Topic = reader.ReadLine
            Question4.SubTopic = reader.ReadLine
            Question4.CorrectAnswer = reader.ReadLine
            Question4.DifficultyLevel = reader.ReadLine
            Question4.IsAnswered = reader.ReadLine
            Question4.IsCorrect = reader.ReadLine
        End Using

        DetermineFileName(FileName, QuestionList, 4)
        Using reader As TextReader = New StringReader(My.Resources.ResourceManager.GetObject(FileName & "_INF"))
            Question5.QuestionTitle = reader.ReadLine
            Question5.QuestionType = reader.ReadLine
            Question5.NumberOfButtons = reader.ReadLine
            Question5.ModuleType = reader.ReadLine
            Question5.Topic = reader.ReadLine
            Question5.SubTopic = reader.ReadLine
            Question5.CorrectAnswer = reader.ReadLine
            Question5.DifficultyLevel = reader.ReadLine
            Question5.IsAnswered = reader.ReadLine
            Question5.IsCorrect = reader.ReadLine
        End Using

        Question1.QuestionNumber = 1
        Question2.QuestionNumber = 2
        Question3.QuestionNumber = 3
        Question4.QuestionNumber = 4
        Question5.QuestionNumber = 5

        LoadQuizButtons(Question1.NumberOfButtons)
        DetermineQuestionToShow(Question1)
        Me.lblSelection.Text = "Your Selection: N/A"
    End Sub

    Private Sub DetermineFileName(ByRef FileName As String, ByVal QuestionList As List(Of String), ByVal n As Integer)
        ' Assign FileName string the value held at position n in the list; if there are less than n items, assign FileName the final item in the list 
        If QuestionList.Count > n Then
            FileName = QuestionList(n)
        Else
            FileName = QuestionList(QuestionList.Count - 1)
        End If
    End Sub
End Class

