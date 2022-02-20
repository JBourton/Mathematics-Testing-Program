Option Strict On
Public Class frmStudentHomepage
    ' Declare instances of the quiz modules
    Dim RandomisedTest As New frmRandomisedQuiz
    Dim SubTopicQuiz As New frmSubTopicQuiz
    Private Sub frmStudentHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display Randomised Quiz on load
        Me.WindowState = FormWindowState.Maximized
        RandomisedTest.MdiParent = Me
        RandomisedTest.WindowState = RandomisedTest.WindowState.Maximized
        RandomisedTest.Show()
    End Sub

    Private Sub tls_lbl_RandomisedQuiz_Click(sender As Object, e As EventArgs) Handles tls_lbl_RandomisedQuiz.Click
        ' Show Randomised Quiz form
        frmRandomisedQuiz.FromSubTopic = False
        MinimiseForms()
        RandomisedTest.MdiParent = Me
        RandomisedTest.WindowState = RandomisedTest.WindowState.Maximized
        RandomisedTest.Show()
    End Sub

    Private Sub tbl_lbl_SubTopicQuiz_Click(sender As Object, e As EventArgs) Handles tbl_lbl_SubTopicQuiz.Click
        ' Show Sub-topic Quiz form
        frmRandomisedQuiz.FromSubTopic = True
        MinimiseForms()
        SubTopicQuiz.MdiParent = Me
        SubTopicQuiz.WindowState = SubTopicQuiz.WindowState.Maximized
        SubTopicQuiz.Show()
    End Sub

    Private Sub MinimiseForms()
        ' Hide all open forms
        For Each form As Form In Me.MdiChildren
            form.WindowState = FormWindowState.Minimized
        Next
    End Sub
End Class