Option Strict On
Public Class frmTeacherHomepage
    Dim CreateClass As New frmCreateNewClass
    Dim ViewStudentProgress As New frmViewStudentProgress
    Dim ViewClassProgress As New frmViewClassProgress
    Private Sub Teacher_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CreateClass.MdiParent = Me
        CreateClass.WindowState = CreateClass.WindowState.Maximized
        CreateClass.Show()
    End Sub

    Private Sub tlb_lbl_CreateNewClass_Click(sender As Object, e As EventArgs) Handles tlb_lbl_CreateNewClass.Click
        MinimiseForms()
        CreateClass.MdiParent = Me
        CreateClass.WindowState = CreateClass.WindowState.Maximized
        CreateClass.Show()
    End Sub

    Private Sub tbl_lbl_ViewStudentProgress_Click(sender As Object, e As EventArgs) Handles tbl_lbl_ViewStudentProgress.Click
        MinimiseForms()
        ViewStudentProgress.MdiParent = Me
        ViewStudentProgress.WindowState = ViewStudentProgress.WindowState.Maximized
        ViewStudentProgress.Show()
    End Sub

    Private Sub tbl_lbl_ViewClassProgress_Click(sender As Object, e As EventArgs) Handles tbl_lbl_ViewClassProgress.Click
        MinimiseForms()
        ViewClassProgress.MdiParent = Me
        ViewClassProgress.WindowState = ViewClassProgress.WindowState.Maximized
        ViewClassProgress.Show()
    End Sub

    Private Sub MinimiseForms()
        ' Hide all open forms
        For Each form As Form In Me.MdiChildren
            form.WindowState = FormWindowState.Minimized
        Next
    End Sub
End Class