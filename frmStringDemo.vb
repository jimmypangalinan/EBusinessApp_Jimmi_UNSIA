Public Class frmStringDemo

    Private Sub frmStringDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "String Methods Demo - Jimmi (UNSIA)"
        lblResult.Text = "Enter text above and click buttons to test string methods" & vbCrLf & vbCrLf & "Developer: Jimmi - UNSIA"
    End Sub

    ' BUTTON:  UPPER CASE
    Private Sub btnUpper_Click(sender As Object, e As EventArgs) Handles btnUpper.Click
        Try
            If String.IsNullOrEmpty(txtInput.Text) Then
                MessageBox.Show("Please enter some text!", "Warning")
                Return
            End If

            ' STRING METHOD: ToUpper()
            Dim result As String = txtInput.Text.ToUpper()

            lblResult.Text = "=== UPPER CASE ===" & vbCrLf &
                           "Original: " & txtInput.Text & vbCrLf &
                           "Result: " & result & vbCrLf & vbCrLf &
                           "Developer: Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' BUTTON:  LOWER CASE
    Private Sub btnLower_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        Try
            If String.IsNullOrEmpty(txtInput.Text) Then
                MessageBox.Show("Please enter some text!", "Warning")
                Return
            End If

            ' STRING METHOD: ToLower()
            Dim result As String = txtInput.Text.ToLower()

            lblResult.Text = "=== LOWER CASE ===" & vbCrLf &
                           "Original: " & txtInput.Text & vbCrLf &
                           "Result:  " & result & vbCrLf & vbCrLf &
                           "Developer:  Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' BUTTON: LENGTH
    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        Try
            Dim text As String = txtInput.Text

            ' STRING METHOD: Length
            Dim length As Integer = text.Length

            lblResult.Text = "=== STRING LENGTH ===" & vbCrLf &
                           "Text: " & text & vbCrLf &
                           "Length: " & length & " characters" & vbCrLf & vbCrLf &
                           "Developer: Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' BUTTON: SUBSTRING
    Private Sub btnSubstring_Click(sender As Object, e As EventArgs) Handles btnSubstring.Click
        Try
            If String.IsNullOrEmpty(txtInput.Text) Then
                MessageBox.Show("Please enter some text!", "Warning")
                Return
            End If

            If txtInput.Text.Length < 5 Then
                MessageBox.Show("Text too short! Need at least 5 characters.", "Warning")
                Return
            End If

            ' STRING METHOD: Substring
            Dim result As String = txtInput.Text.Substring(0, 5)

            lblResult.Text = "=== SUBSTRING ===" & vbCrLf &
                           "Original: " & txtInput.Text & vbCrLf &
                           "Substring (0-5): " & result & vbCrLf & vbCrLf &
                           "Developer: Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' BUTTON: REPLACE
    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Try
            If String.IsNullOrEmpty(txtInput.Text) Then
                MessageBox.Show("Please enter some text!", "Warning")
                Return
            End If

            ' STRING METHOD:  Replace (spaces with underscore)
            Dim result As String = txtInput.Text.Replace(" ", "_")

            lblResult.Text = "=== REPLACE ===" & vbCrLf &
                           "Original: " & txtInput.Text & vbCrLf &
                           "Replaced (space → _): " & result & vbCrLf & vbCrLf &
                           "Developer: Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' BUTTON: TRIM
    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        Try
            Dim original As String = txtInput.Text

            ' STRING METHOD:  Trim
            Dim trimmed As String = original.Trim()

            lblResult.Text = "=== TRIM SPACES ===" & vbCrLf &
                           "Original Length: " & original.Length & vbCrLf &
                           "Trimmed Length: " & trimmed.Length & vbCrLf &
                           "Spaces Removed: " & (original.Length - trimmed.Length) & vbCrLf &
                           "Result: '" & trimmed & "'" & vbCrLf & vbCrLf &
                           "Developer: Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

End Class