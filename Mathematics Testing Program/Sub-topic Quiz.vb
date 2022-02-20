Imports System.IO
Public Class frmSubTopicQuiz

    Private MultipleChoiceAnswer As String = "N/A"
    Private NextQuestionNumber As Integer = 1
    Private QuestionNumbers As New List(Of String)
    Private Rndm As New Random
    Private UserAnswer As String
    Private Markscheme As Boolean
    Private FilePath As String
    Private SubTopicQuestions As New List(Of String)

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
    Dim Question1 As Question
    Dim Question2 As Question

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
    End Structure
    Dim SaveResults As New TestResults

    Structure SelectedFolders
        Public MathsModule As String
        Public Topic As String
    End Structure
    Dim QuizPath As New SelectedFolders


    Private Sub frmSubTopicQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadStartupElements()
        LoadModuleButtons()
    End Sub

    Private Sub LoadStartupElements()
        ' Create picturebox
        Dim pcbFolder As New PictureBox
        pcbFolder.Name = "pcbFolder"
        pcbFolder.Width = 100
        pcbFolder.Height = 80
        pcbFolder.Image = My.Resources.Blue_Folder
        pcbFolder.Location = New Point(155, 85)
        pcbFolder.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(pcbFolder)

        ' Create label
        Dim lblInfo As New Label
        lblInfo.Name = "lblInfo"
        lblInfo.Text = "Navigate to your desired sub-topic by clicking on the icons below."
        lblInfo.Width = 320
        lblInfo.Height = 20
        lblInfo.Location = New Point(130, 10)
        Me.Controls.Add(lblInfo)

        ' Create collapse button
        Dim btnCollapse As New Button
        btnCollapse.Name = "btnCollapse"
        btnCollapse.Location = New Point(155, 190)
        btnCollapse.Width = 100
        btnCollapse.Height = 40
        btnCollapse.Text = "Collapse folders"
        btnCollapse.Font = New Font("Segoe UI", 14.0, FontStyle.Bold)
        Me.Controls.Add(btnCollapse)

        ' Add handler
        AddHandler btnCollapse.Click, AddressOf btnCollapse_Click
    End Sub

    Private Sub LoadModuleButtons()
        ' Load names of modules into dynamically created buttons
        Dim ModuleButtons(3) As Button
        Dim X, Y As Integer

        ' Declare starting position of first button
        X = 300
        Y = 100

        ' Add shared button properties
        For i = 1 To 3
            ModuleButtons(i) = New Button
            ModuleButtons(i).Location = New Point(X, Y)
            ModuleButtons(i).Width = 200
            ModuleButtons(i).Height = 50
            ModuleButtons(i).Font = New Font("Segoe UI", 13.0, FontStyle.Bold)
            Me.Controls.Add(ModuleButtons(i))
            X += 300
        Next

        ' Add specific button properties
        ModuleButtons(1).Name = "btnPure"
        ModuleButtons(2).Name = "btnStatistics"
        ModuleButtons(3).Name = "btnMechanics"

        ModuleButtons(1).Text = "Pure"
        ModuleButtons(2).Text = "Statistics"
        ModuleButtons(3).Text = "Mechanics"

        ' Add handlers
        AddHandler ModuleButtons(1).Click, AddressOf btnPure_Click
        AddHandler ModuleButtons(2).Click, AddressOf btnStatistics_Click
        AddHandler ModuleButtons(3).Click, AddressOf btnMechanics_Click
    End Sub

    Private Sub LoadTopicButtons()
        ' Load names of topics related to selected module into dynamically created buttons
        Dim TopicButtons(2) As Button
        Dim X, Y As Integer

        ' Declare starting position of first button
        X = 400
        Y = 200

        ' Add shared button properties
        For i = 1 To 2
            TopicButtons(i) = New Button
            TopicButtons(i).Location = New Point(X, Y)
            TopicButtons(i).Width = 200
            TopicButtons(i).Height = 50
            TopicButtons(i).Font = New Font("Segoe UI", 13.0, FontStyle.Bold)
            Me.Controls.Add(TopicButtons(i))
            X += 400
        Next

        TopicButtons(1).Name = "btnTopic1"
        TopicButtons(2).Name = "btnTopic2"

        ' Add specific button properties based off selected module
        Select Case QuizPath.MathsModule
            Case = "Pure"
                TopicButtons(1).Text = "Proof"
                TopicButtons(2).Text = "Integration"
            Case = "Statistics"
                TopicButtons(1).Text = "Probability"
                TopicButtons(2).Text = "Distributions"
            Case = "Mechanics"
                TopicButtons(1).Text = "Collisions"
                TopicButtons(2).Text = "Energy"
        End Select

        ' Add handlers
        AddHandler TopicButtons(1).Click, AddressOf btnTopic1_Click
        AddHandler TopicButtons(2).Click, AddressOf btnTopic2_Click
    End Sub

    Private Sub LoadSubTopicButtons()
        ' Load names of sub topics related to selected topic into dynamically created buttons
        Dim SubTopicButtons(2) As Button
        Dim X, Y As Integer

        ' Declare starting position of first button
        X = 500
        Y = 300

        ' Add shared button properties
        For i = 1 To 2
            SubTopicButtons(i) = New Button
            SubTopicButtons(i).Location = New Point(X, Y)
            SubTopicButtons(i).Width = 200
            SubTopicButtons(i).Height = 50
            SubTopicButtons(i).Font = New Font("Segoe UI", 14.0, FontStyle.Bold)
            Me.Controls.Add(SubTopicButtons(i))
            X += 200
        Next

        SubTopicButtons(1).Name = "btnSubTopic1"
        SubTopicButtons(2).Name = "btnSubTopic2"

        ' Add specific button properties based off selected module
        Select Case QuizPath.Topic
            Case = "Proof"
                SubTopicButtons(1).Text = "Induction"
                SubTopicButtons(2).Text = "Counter-example"
            Case = "Integration"
                SubTopicButtons(1).Text = "Integrating e"
                SubTopicButtons(2).Text = "Integrating ln"
            Case = "Probability"
                SubTopicButtons(1).Text = "Venn diagrams"
                SubTopicButtons(2).Text = "Laws of probability"
            Case = "Distributions"
                SubTopicButtons(1).Text = "Binomial"
                SubTopicButtons(2).Text = "Normal"
            Case = "Collisions"
                SubTopicButtons(1).Text = "Elastic in 2D"
                SubTopicButtons(2).Text = "Oblique"
            Case = "Energy"
                SubTopicButtons(1).Text = "Kinetic"
                SubTopicButtons(2).Text = "Gravitational"
        End Select

        ' Add handlers
        AddHandler SubTopicButtons(1).Click, AddressOf btnSubTopic1_Click
        AddHandler SubTopicButtons(2).Click, AddressOf btnSubTopic2_Click
    End Sub

    Private Sub btnPure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Load topic buttons related to the pure module
        QuizPath.MathsModule = "Pure"

        ' Display next hierarchy of buttons
        LoadTopicButtons()
    End Sub
    Private Sub btnStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Load topic buttons related to the statistics module
        QuizPath.MathsModule = "Statistics"

        ' Display next hierarchy of buttons
        LoadTopicButtons()
    End Sub
    Private Sub btnMechanics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Load topic buttons related to the mechanics module
        QuizPath.MathsModule = "Mechanics"

        ' Display next hierarchy of buttons
        LoadTopicButtons()
    End Sub

    Private Sub btnTopic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Assign Topic variable in SelectedFolders structure
        Select Case QuizPath.MathsModule
            Case = "Pure"
                QuizPath.Topic = "Proof"
            Case = "Statistics"
                QuizPath.Topic = "Probability"
            Case = "Mechanics"
                QuizPath.Topic = "Collisions"
        End Select

        ' Display next hierarchy of buttons
        LoadSubTopicButtons()
    End Sub

    Private Sub btnTopic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Assign Topic variable in SelectedFolders structure
        Select Case QuizPath.MathsModule
            Case = "Pure"
                QuizPath.Topic = "Integration"
            Case = "Statistics"
                QuizPath.Topic = "Distributions"
            Case = "Mechanics"
                QuizPath.Topic = "Energy"
        End Select

        ' Display next hierarchy of buttons
        LoadSubTopicButtons()
    End Sub

    Private Sub btnSubTopic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case QuizPath.Topic
            Case = "Proof"
                SubTopicQuestions.AddRange(New String() {"INDUCTION1", "INDUCTION2"})
            Case = "Integration"
                SubTopicQuestions.AddRange(New String() {"INTEGRATING_E1"})
            Case = "Probability"
                SubTopicQuestions.AddRange(New String() {"VENNDIAGRAMS1"})
            Case = "Distributions"
                SubTopicQuestions.AddRange(New String() {"BINOMIAL1"})
            Case = "Collisions"
                SubTopicQuestions.AddRange(New String() {"ELASTICIN2D1", "ELASTICIN2D2"})
            Case = "Energy"
                SubTopicQuestions.AddRange(New String() {"KINETIC1"})
        End Select
        DisplayQuiz()
    End Sub

    Private Sub btnSubTopic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case QuizPath.Topic
            Case = "Proof"
                SubTopicQuestions.AddRange(New String() {"COUNTEREXAMPLE1", "COUNTEREXAMPLE2"})
            Case = "Integration"
                SubTopicQuestions.AddRange(New String() {"INTEGRATING_LN1"})
            Case = "Probability"
                SubTopicQuestions.AddRange(New String() {"LAWSOFPROBABILITY1"})
            Case = "Distributions"
                SubTopicQuestions.AddRange(New String() {"NORMAL1"})
            Case = "Collisions"
                SubTopicQuestions.AddRange(New String() {"OBLIQUE1"})
            Case = "Energy"
                SubTopicQuestions.AddRange(New String() {"GRAVITATIONAL1"})
        End Select
        DisplayQuiz()
    End Sub

    Private Sub btnCollapse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Reset controls
        DeleteControls()

        ' Reset SelectedFolders structure values
        QuizPath.MathsModule = ""
        QuizPath.Topic = ""

        ' Load controls back in
        LoadStartupElements()
        LoadModuleButtons()
    End Sub

    Private Sub DeleteControls()
        ' Delete all controls
        For i As Integer = Me.Controls.Count - 1 To 0 Step -1
            If TypeOf Me.Controls(i) Is Button Or TypeOf Me.Controls(i) Is TextBox Or TypeOf Me.Controls(i) Is PictureBox Then
                Me.Controls.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub DisplayQuiz()
        ' Transfer selected question names to a list in frmRandomisedQuiz
        frmRandomisedQuiz.QuestionList.Clear()
        For Each item In SubTopicQuestions
            frmRandomisedQuiz.QuestionList.AddRange(New String() {item})
        Next
        ' Load frmRandomisedQuiz
        frmRandomisedQuiz.Show()
    End Sub

End Class