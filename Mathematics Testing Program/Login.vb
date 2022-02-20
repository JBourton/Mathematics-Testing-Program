Public Class frmLoginPage
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Structure AccountDetails
        <VBFixedString(20)> Public Username As String
        <VBFixedString(20)> Public Password As String
        <VBFixedString(20)> Public Forename As String
        <VBFixedString(20)> Public Surname As String
    End Structure

    Structure LoginValidation
        Public InputDataValid As Boolean
        Public CorrectFieldsFilled As Boolean
        Public StudentUsernameEmpty As Boolean
        Public StudentPasswordEmpty As Boolean
        Public TeacherUsernameEmpty As Boolean
        Public TeacherPasswordEmpty As Boolean
        Public Student As Boolean
        Public Teacher As Boolean
        Public LoginDetailsFound As Boolean
        Public filename As String
        Public username As String
        Public password As String
        Public DecryptedCiphertext As String
    End Structure

    Public UserLoginStructure As AccountDetails
    Private LoginAttempt As LoginValidation

    Private Sub BtnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        ClearFields()
        Me.Hide()
        frmCreateAccount.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click, MyBase.Click
        LoginAttempt.InputDataValid = False
        LoginAttempt.CorrectFieldsFilled = False

        ' Presence check: determine which text boxes are empty
        If (String.IsNullOrEmpty(txtStudentUsername.Text)) Then
            LoginAttempt.StudentUsernameEmpty = True
        End If
        If (String.IsNullOrEmpty(txtStudentPassword.Text)) Then
            LoginAttempt.StudentPasswordEmpty = True
        End If
        If (String.IsNullOrEmpty(txtTeacherUsername.Text)) Then
            LoginAttempt.TeacherUsernameEmpty = True
        End If
        If (String.IsNullOrEmpty(txtTeacherPassword.Text)) Then
            LoginAttempt.TeacherPasswordEmpty = True
        End If
        ' Determines if both of the text boxes in one field, but neither of the textboxes in the other field, have been filled
        If LoginAttempt.StudentUsernameEmpty And LoginAttempt.StudentPasswordEmpty And LoginAttempt.TeacherUsernameEmpty And LoginAttempt.TeacherPasswordEmpty Then
            ' Both catgories are fully empty
            MessageBox.Show("Please input values into either the teacher or student category to login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (Not LoginAttempt.StudentUsernameEmpty Or Not LoginAttempt.StudentPasswordEmpty) And (Not LoginAttempt.TeacherUsernameEmpty Or Not LoginAttempt.TeacherPasswordEmpty) Then
            ' Both teacher and student categories have data input into one of the relevant texboxes
            MessageBox.Show("Please do not attempt to fill in both teacher and student login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (LoginAttempt.StudentUsernameEmpty And Not LoginAttempt.StudentPasswordEmpty) And (LoginAttempt.TeacherUsernameEmpty And LoginAttempt.TeacherPasswordEmpty) Then
            ' The teacher category is empty but the student category has a password but no username
            MessageBox.Show("Please enter a value for the the student username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (Not LoginAttempt.StudentUsernameEmpty And LoginAttempt.StudentPasswordEmpty) And (LoginAttempt.TeacherUsernameEmpty And LoginAttempt.TeacherPasswordEmpty) Then
            ' The teacher category is empty but the student category has a username but no password
            MessageBox.Show("Please enter a value for the the student password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (LoginAttempt.StudentUsernameEmpty And LoginAttempt.StudentPasswordEmpty) And (LoginAttempt.TeacherUsernameEmpty And Not LoginAttempt.TeacherPasswordEmpty) Then
            ' The student catgory is empty but the teacher category has a password but not username
            MessageBox.Show("Please enter a value for the teacher username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (LoginAttempt.StudentUsernameEmpty And LoginAttempt.StudentPasswordEmpty) And (Not LoginAttempt.TeacherUsernameEmpty And LoginAttempt.TeacherPasswordEmpty) Then
            ' The student catgory is empty but the teacher category has a username but no password
            MessageBox.Show("Please enter a value for the the teacher password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (Not (LoginAttempt.StudentUsernameEmpty And LoginAttempt.StudentPasswordEmpty)) And (LoginAttempt.TeacherUsernameEmpty And LoginAttempt.TeacherPasswordEmpty) Then
            ' Both student fields are full, and neither of the teacher fields
            LoginAttempt.filename = "studentaccounts.txt"
            LoginAttempt.CorrectFieldsFilled = True
            LoginAttempt.Student = True
        ElseIf (LoginAttempt.StudentUsernameEmpty And LoginAttempt.StudentPasswordEmpty) And (Not (LoginAttempt.TeacherUsernameEmpty And LoginAttempt.TeacherPasswordEmpty)) Then
            ' Both teacher fields are full, and neither of the student fields
            LoginAttempt.filename = "teacheraccounts.txt"
            LoginAttempt.CorrectFieldsFilled = True
            LoginAttempt.Teacher = True
        Else : MessageBox.Show("Logic error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If LoginAttempt.CorrectFieldsFilled Then
            ' Take username & password input, assign them to respective varibles
            If LoginAttempt.Student Then
                LoginAttempt.username = txtStudentUsername.Text
                LoginAttempt.password = txtStudentPassword.Text
            ElseIf LoginAttempt.Teacher Then
                LoginAttempt.username = txtTeacherUsername.Text
                LoginAttempt.password = txtTeacherPassword.Text
            Else

            End If

            ' Read contents of file to check if input username & password are present
            Try
                Dim i As Integer = 1
                FileOpen(1, LoginAttempt.filename, OpenMode.Random, , , Len(UserLoginStructure))
                While Not EOF(1)
                    FileGet(1, UserLoginStructure, i)
                    LoginAttempt.DecryptedCiphertext = UserLoginStructure.Username.Trim
                    ' Decrypt username & password to compare with input
                    ASCIIDecryption(LoginAttempt.DecryptedCiphertext)
                    If LoginAttempt.username = LoginAttempt.DecryptedCiphertext Then
                        LoginAttempt.DecryptedCiphertext = UserLoginStructure.Password.Trim
                        ASCIIDecryption(LoginAttempt.DecryptedCiphertext)
                        ' Notify user of sucsessful login
                        If LoginAttempt.password = LoginAttempt.DecryptedCiphertext Then
                            MessageBox.Show("Successful login", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoginAttempt.LoginDetailsFound = True
                        End If
                    End If
                    i += 1
                End While
                ' Notify user that no match was found
                If Not LoginAttempt.LoginDetailsFound Then
                    MessageBox.Show("Login details not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                FileClose(1)
            Catch ex As Exception
                MessageBox.Show("An error occured whilst attempting to log you in. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        ClearFields()

        ' Display relevant homepage if login details correct
        If LoginAttempt.LoginDetailsFound Then
            If LoginAttempt.Teacher Then
                frmTeacherHomepage.Show()
                Me.Hide()
            Else
                frmStudentHomepage.Show()
                Me.Hide()
            End If
        End If

        ResetLoginStructureValues(LoginAttempt)
    End Sub

    Public Sub ASCIIDecryption(ByRef CiphertextToDecrypt As String)
        ' Take in the encoded ASCII value and convert back to plaintext
        Dim EncryptionFactor As Integer = 3
        Dim plaintext As String = ""
        For Each letter As String In CiphertextToDecrypt
            plaintext += (Chr(Asc(letter) - EncryptionFactor))
        Next
        CiphertextToDecrypt = plaintext
    End Sub

    Private Sub ClearFields()
        ' Clear contents of all textboxes
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub ResetLoginStructureValues(ByRef LoginAttempt As LoginValidation)
        ' Resests an instance of the LoginValidation structure 
        LoginAttempt.InputDataValid = False
        LoginAttempt.CorrectFieldsFilled = False
        LoginAttempt.StudentUsernameEmpty = False
        LoginAttempt.StudentPasswordEmpty = False
        LoginAttempt.TeacherUsernameEmpty = False
        LoginAttempt.TeacherPasswordEmpty = False
        LoginAttempt.Student = False
        LoginAttempt.Teacher = False
        LoginAttempt.LoginDetailsFound = False
        LoginAttempt.filename = ""
        LoginAttempt.username = ""
        LoginAttempt.password = ""
        LoginAttempt.DecryptedCiphertext = ""
    End Sub


End Class
