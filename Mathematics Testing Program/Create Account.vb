Public Class frmCreateAccount
    Private Sub frmCreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Structure AccountDetails
        <VBFixedString(20)> Public Username As String
        <VBFixedString(20)> Public Password As String
        <VBFixedString(20)> Public Forename As String
        <VBFixedString(20)> Public Surname As String
    End Structure
    Dim NewUser As AccountDetails

    Structure WriteAccountDetails
        Public filename As String
        Public EncryptedUsername As String
        Public EncryptedPassword As String
        Public EncryptedForename As String
        Public EncryptedSurname As String
    End Structure
    Dim AccountCreation As WriteAccountDetails

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        frmLoginPage.Show()
    End Sub

    Private Sub btnCreateAnAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        ' Type check: ensuring only teacher or student has been selected for the usertype
        If Not (String.IsNullOrEmpty(cmbUserType.Text) Or String.IsNullOrEmpty(txtCreateUsername.Text) Or String.IsNullOrEmpty(txtCreatePassword.Text) Or String.IsNullOrEmpty(txtCreateForename.Text) Or String.IsNullOrEmpty(txtCreateSurname.Text)) Then
            If cmbUserType.Text = "Student" Then
                AccountCreation.filename = "studentaccounts.txt"
            ElseIf cmbUserType.Text = "Teacher" Then
                AccountCreation.filename = "teacheraccounts.txt"
            Else
                MessageBox.Show("Invalid user type entered, account has not been created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ASCIIEncryption(txtCreateUsername.Text, txtCreatePassword.Text, txtCreateForename.Text, txtCreateSurname.Text, AccountCreation.EncryptedUsername, AccountCreation.EncryptedPassword, AccountCreation.EncryptedForename, AccountCreation.EncryptedSurname)

            Try
                Dim InvalidUsername As Boolean
                Dim i As Integer = 1
                Dim NextRecord As Integer
                FileOpen(1, AccountCreation.filename, OpenMode.Random, , , Len(NewUser))
                ' Iterate through txt file to identify if input username is already in use by another user
                While Not EOF(1)
                    FileGet(1, NewUser, i)
                    If AccountCreation.EncryptedUsername = NewUser.Username.Trim Then
                        MessageBox.Show("This username is already in use. Please enter a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        InvalidUsername = True
                    End If
                    i += 1
                End While
                If AccountCreation.EncryptedUsername.Length >= 20 Or AccountCreation.EncryptedPassword.Length >= 20 Or AccountCreation.EncryptedForename.Length >= 20 Or AccountCreation.EncryptedSurname.Length >= 20 Then
                    MessageBox.Show("Maximum length of data entry for signup must be less than or equal to 20", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    InvalidUsername = True
                End If
                If Not InvalidUsername Then
                    NextRecord = (LOF(1) / Len(NewUser)) + 1
                    With NewUser
                        .Username = AccountCreation.EncryptedUsername
                        .Password = AccountCreation.EncryptedPassword
                        .Forename = AccountCreation.EncryptedForename
                        .Surname = AccountCreation.EncryptedSurname
                    End With
                    FilePut(1, NewUser, NextRecord)
                    FileClose(1)
                    MessageBox.Show("Successful account creation", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    FileClose(1)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occured whilst attempting to log you in. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FileClose(1)
            End Try
            ResetControls()
        Else
            MessageBox.Show("Please input values into all fields to complete sign-up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ASCIIEncryption(ByVal username As String, ByVal password As String, ByVal forename As String, ByVal surname As String, ByRef EncryptedUsername As String, ByRef EncryptedPassword As String, ByRef EncryptedForename As String, ByRef EncryptedSurname As String)
        ' Perform ceasear shift with pad of 3
        Dim EncryptionFactor As Integer = 3
        For Each letter As String In username
            EncryptedUsername = EncryptedUsername + (Chr(Asc(letter) + EncryptionFactor))
        Next
        For Each letter As String In password
            EncryptedPassword = EncryptedPassword + (Chr(Asc(letter) + EncryptionFactor))
        Next
        For Each letter As String In forename
            EncryptedForename = EncryptedForename + (Chr(Asc(letter) + EncryptionFactor))
        Next
        For Each letter As String In surname
            EncryptedSurname = EncryptedSurname + (Chr(Asc(letter) + EncryptionFactor))
        Next
    End Sub

    Private Sub ResetControls()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            ElseIf TypeOf control Is ComboBox Then
                cmbUserType.SelectedIndex = 0
            End If
        Next
    End Sub

End Class