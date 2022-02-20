Public Class frmCreateNewClass
    Structure AccountDetails
        <VBFixedString(20)> Public Username As String
        <VBFixedString(20)> Public Password As String
        <VBFixedString(20)> Public Forename As String
        <VBFixedString(20)> Public Surname As String
    End Structure

    Structure AddClass
        <VBFixedString(5)> Public ClassName As String
        <VBFixedString(3)> Public ClassSize As String
        <VBFixedString(150)> Public Students As String
    End Structure

    Structure SearchListBox
        Public SearchID As Integer
        Public FullStudentName As String
        Public DecryptedForename As String
        Public DecryptedSurname As String
        Public StudentAlreadyInList As Boolean
    End Structure

    Dim StudentInfo As AccountDetails
    Dim NewClassToAdd As AddClass
    Dim SearchStudents As SearchListBox

    Private Sub frmClassesOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        GetStudents()
    End Sub

    Private Sub ClearControls()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next
        lstStudents.Items.Clear()
    End Sub

    Private Sub GetStudents()
        ' Retrieve student names from textfile
        Try
            Dim DecryptedForename As String
            Dim DecryptedSurname As String
            Dim i As Integer = 1
            FileOpen(1, "studentaccounts.txt", OpenMode.Random, , , Len(StudentInfo))
            While Not EOF(1)
                FileGet(1, StudentInfo, i)
                DecryptedForename = StudentInfo.Forename.Trim
                DecryptedSurname = StudentInfo.Surname.Trim
                ' Decrypt contents of file
                ASCIIDecryption(DecryptedForename)
                ASCIIDecryption(DecryptedSurname)
                ' Add name to listbox
                lstStudents.Items.Add(i.ToString + ".  " + DecryptedForename + " " + DecryptedSurname)
                i += 1
            End While
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("An error occured whilst attempting to retrive your data. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ASCIIDecryption(ByRef CiphertextToDecrypt As String)
        ' Take in encoded ASCII value and convert back to plaintext
        Dim EncryptionFactor As Integer = 3
        Dim plaintext As String = ""
        For Each letter As String In CiphertextToDecrypt
            plaintext += (Chr(Asc(letter) - EncryptionFactor))
        Next
        CiphertextToDecrypt = plaintext
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Adds selected name from students list box to new class list box 
        Dim StudentAlreadyInList As Boolean = False
        If lstStudents.SelectedIndex > -1 Then
            ' Validation to ensure name isn't already added
            For n As Integer = 0 To lstNewClass.Items.Count - 1
                If lstNewClass.Items(n) = lstStudents.SelectedItem.Remove(0, 4) Then
                    StudentAlreadyInList = True
                End If
            Next
            If Not StudentAlreadyInList Then
                Dim StudentName As String = lstStudents.SelectedItem
                lstNewClass.Items.Add(StudentName.Remove(0, 4))
            End If
        End If
        lstStudents.SelectedIndex = -1
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        ' Remove selected name in students list box from new class list box
        Dim StudentAlreadyInList As Boolean = False
        If lstStudents.SelectedIndex > -1 Then
            ' Validation to ensure name to remove is present
            For n As Integer = 0 To lstNewClass.Items.Count - 1
                If lstNewClass.Items(n) = lstStudents.SelectedItem.Remove(0, 4) Then
                    StudentAlreadyInList = True
                End If
            Next
            If StudentAlreadyInList Then
                lstNewClass.Items.Remove(lstStudents.SelectedItem.Remove(0, 4))
            End If
        End If
        lstStudents.SelectedIndex = -1
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchStudents.StudentAlreadyInList = False

        ' Use id number of student to search for their name
        Try
            SearchStudents.SearchID = InputBox("Please enter the ID of the student you wish to search for")
            If SearchStudents.SearchID < 1 Or SearchStudents.SearchID > lstStudents.Items.Count Then
                MessageBox.Show("SearchID is out of range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            ' Search for student with the input id
            FileOpen(2, "studentaccounts.txt", OpenMode.Random, , , Len(StudentInfo))
            FileGet(2, StudentInfo, SearchStudents.SearchID)
            SearchStudents.DecryptedForename = StudentInfo.Forename.Trim
            SearchStudents.DecryptedSurname = StudentInfo.Surname.Trim
            ASCIIDecryption(SearchStudents.DecryptedForename)
            ASCIIDecryption(SearchStudents.DecryptedSurname)
            SearchStudents.FullStudentName = SearchStudents.DecryptedForename + " " + SearchStudents.DecryptedSurname
            FileClose(2)

            For n As Integer = 0 To lstNewClass.Items.Count - 1
                If lstNewClass.Items(n) = SearchStudents.FullStudentName Then
                    SearchStudents.StudentAlreadyInList = True
                End If
            Next
            If Not SearchStudents.StudentAlreadyInList Then
                lstNewClass.Items.Add(SearchStudents.FullStudentName)
            End If
            lstStudents.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("An error has occured whilst attempting to locate the student at the given id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox_Validate(sender As Object, e As EventArgs) Handles txtClassName.TextChanged
        ' Allow user to create class after classname has been entered
        If Not String.IsNullOrWhiteSpace(txtClassName.Text) Then btnCreateClass.Enabled = True
    End Sub

    Private Sub btnCreateClass_Click(sender As Object, e As EventArgs) Handles btnCreateClass.Click
        Dim NextRecord As Integer
        Dim Valid As Boolean = CheckInputValidity()

        ' Convert number of students to be added into string
        Dim strClassSize = CStr(lstNewClass.Items.Count)
        AddTrailingBackslashes(strClassSize)

        If Valid Then
            Try
                ' Retrieve values from form
                NewClassToAdd.ClassName = txtClassName.Text
                NewClassToAdd.ClassSize = strClassSize
                NewClassToAdd.Students = CombinelstStudentItemsToString()

                ' Write data to file
                FileOpen(1, "Classes.txt", OpenMode.Random, , , Len(NewClassToAdd))
                NextRecord = (LOF(1) / Len(NewClassToAdd)) + 1
                With NewClassToAdd
                    .ClassName = NewClassToAdd.ClassName
                    .ClassSize = NewClassToAdd.ClassSize
                    .Students = NewClassToAdd.Students
                End With
                FilePut(1, NewClassToAdd, NextRecord)
                FileClose(1)
                MessageBox.Show("Class " & NewClassToAdd.ClassName & " has been sucsessfully created")
            Catch ex As Exception
                MessageBox.Show("An error has occured whilst attempting to create a new class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function CombinelstStudentItemsToString()
        ' Combine student names in lstNewClass into a single string
        Dim Students = String.Empty
        For Each item In lstNewClass.Items
            If Students <> String.Empty Then
                Students &= ", "
            End If
            Students &= item
        Next
        Return Students
    End Function

    Private Sub AddTrailingBackslashes(ByRef strNum As String)
        ' Ensure that number string is exactly 3 characters long
        Select Case strNum.Length
            Case = 1
                strNum = strNum + "//"
            Case = 2
                strNum = strNum + "/"
            Case > 3
                strNum = strNum.Substring(0, 3)
            Case Else
        End Select
    End Sub

    Private Function CheckInputValidity()
        ' Validate that classname starts with 2 numbers and a backslash, and that at least one student has been selected
        Dim Valid As Boolean = False
        Dim Numbers As String = "1234567890"
        If txtClassName.Text.Length = 5 Then
            If Numbers.Contains(txtClassName.Text.Substring(0, 1)) And Numbers.Contains(txtClassName.Text.Substring(1, 1)) And txtClassName.Text.Substring(2, 1) = "/" Then
                If lstNewClass.Items.Count >= 1 Then
                    Valid = True
                Else
                    MessageBox.Show("Error: Could not create the class. At least 1 student must be added to the new class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Error: Could not create the class. Classname must begin with 2 numbers representing the year group, followed by a backslash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
                MessageBox.Show("Error: Could not create the class. Classname must be exactly 5 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return Valid
    End Function
End Class