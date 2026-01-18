' ========================================
' DEBUGGING DEMONSTRATION
' Developer: Jimmi - UNSIA
' Demonstrates:  Watch Window, Breakpoints, Exception Handling
' ========================================

Public Class frmDebuggingDemo

    Private Sub frmDebuggingDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBreakpointLog.Items.Add("Click buttons to test breakpoints - Developer: Jimmi - UNSIA")
        txtExceptionLog.Text = "Click buttons to test exception handling" & vbCrLf & "Developer: Jimmi - UNSIA"
    End Sub

    ' ============================================
    ' WATCH WINDOW DEMONSTRATION
    ' ============================================

    ' INSTRUCTIONS FOR STUDENTS:
    ' 1. Set BREAKPOINT on line:  Dim sum As Integer = value1 + value2
    ' 2. Press F9 on that line (red dot will appear)
    ' 3. Run program (F5)
    ' 4. Click "Calculate" button
    ' 5. Program will PAUSE at breakpoint
    ' 6. Open Watch Window:  Debug → Windows → Watch → Watch 1
    ' 7. In Watch Window, type: value1, value2, sum, difference, product
    ' 8. Press F10 (Step Over) to execute line by line
    ' 9. Watch the values change in Watch Window!

    Private Sub btnWatchDemo_Click(sender As Object, e As EventArgs) Handles btnWatchDemo.Click
        Try
            ' Get values from form
            Dim value1 As Integer = CInt(nudValue1.Value)
            Dim value2 As Integer = CInt(nudValue2.Value)

            ' ==========================================
            ' SET BREAKPOINT ON NEXT LINE (Press F9)
            ' ADD TO WATCH WINDOW:  value1, value2
            ' ==========================================
            Dim sum As Integer = value1 + value2

            ' WATCH:  sum (see value appear)
            Dim difference As Integer = value1 - value2

            ' WATCH: difference
            Dim product As Integer = value1 * value2

            ' WATCH: product
            Dim quotient As Decimal = If(value2 <> 0, CDec(value1) / value2, 0)

            ' WATCH: quotient
            Dim average As Decimal = (value1 + value2) / 2

            ' WATCH: average
            Dim modulus As Integer = If(value2 <> 0, value1 Mod value2, 0)

            ' Display results
            lblWatchResult.Text = String.Format(
                "Value1={0} | Value2={1} | Sum={2} | Diff={3} | Product={4} | Quotient={5:N2} | Avg={6:N2} | Mod={7} | Jimmi-UNSIA",
                value1, value2, sum, difference, product, quotient, average, modulus)

            lblWatchResult.BackColor = Color.LightGreen

            ' Log to Debug Output Window (View → Output)
            Debug.WriteLine("========================================")
            Debug.WriteLine("WATCH WINDOW DEMO - Jimmi UNSIA")
            Debug.WriteLine("========================================")
            Debug.WriteLine("Value1 = " & value1)
            Debug.WriteLine("Value2 = " & value2)
            Debug.WriteLine("Sum = " & sum)
            Debug.WriteLine("Product = " & product)
            Debug.WriteLine("Average = " & average)
            Debug.WriteLine("========================================")

        Catch ex As Exception
            HandleException(ex, "Watch Demo")
        End Try
    End Sub

    ' ============================================
    ' BREAKPOINTS DEMONSTRATION
    ' ============================================

    ' SIMPLE BREAKPOINT
    Private Sub btnSimpleBreakpoint_Click(sender As Object, e As EventArgs) Handles btnSimpleBreakpoint.Click
        Try
            lstBreakpointLog.Items.Clear()
            lstBreakpointLog.Items.Add("========================================")
            lstBreakpointLog.Items.Add("   SIMPLE BREAKPOINT DEMO")
            lstBreakpointLog.Items.Add("   Developer: Jimmi - UNSIA")
            lstBreakpointLog.Items.Add("========================================")
            lstBreakpointLog.Items.Add("")
            lstBreakpointLog.Items.Add("INSTRUCTIONS:")
            lstBreakpointLog.Items.Add("1. Set BREAKPOINT inside the loop below")
            lstBreakpointLog.Items.Add("2. Press F9 on line: Dim message As String")
            lstBreakpointLog.Items.Add("3. Run (F5) and watch iteration by iteration")
            lstBreakpointLog.Items.Add("")

            ' Loop demonstration
            For i As Integer = 1 To 10
                ' ==========================================
                ' SET BREAKPOINT HERE (Press F9)
                ' ADD 'i' TO WATCH WINDOW
                ' Press F5 to continue to next iteration
                ' ==========================================
                Dim message As String = String.Format("Iteration {0} - Processing order #{0}", i)
                lstBreakpointLog.Items.Add(message)

                ' Simulate processing
                Dim total As Decimal = i * 1000000

                Debug.WriteLine("Loop iteration: " & i & " - Total:  Rp " & total.ToString("N0"))
            Next

            lstBreakpointLog.Items.Add("")
            lstBreakpointLog.Items.Add("Loop completed!  - Jimmi UNSIA")

        Catch ex As Exception
            HandleException(ex, "Simple Breakpoint")
        End Try
    End Sub

    ' CONDITIONAL BREAKPOINT
    Private Sub btnConditionalBreakpoint_Click(sender As Object, e As EventArgs) Handles btnConditionalBreakpoint.Click
        Try
            lstBreakpointLog.Items.Clear()
            lstBreakpointLog.Items.Add("========================================")
            lstBreakpointLog.Items.Add("   CONDITIONAL BREAKPOINT DEMO")
            lstBreakpointLog.Items.Add("   Developer: Jimmi - UNSIA")
            lstBreakpointLog.Items.Add("========================================")
            lstBreakpointLog.Items.Add("")
            lstBreakpointLog.Items.Add("INSTRUCTIONS:")
            lstBreakpointLog.Items.Add("1. Set BREAKPOINT on line: Dim status As String")
            lstBreakpointLog.Items.Add("2. RIGHT-CLICK breakpoint → Conditions...")
            lstBreakpointLog.Items.Add("3. Set condition: amount > 5000000")
            lstBreakpointLog.Items.Add("4. Breakpoint will ONLY trigger when amount > 5M!")
            lstBreakpointLog.Items.Add("")

            ' Sample transaction amounts
            Dim transactions() As Decimal = {
                1000000, 3000000, 7000000, 2000000, 9000000,
                500000, 6500000, 1500000, 8000000, 4000000
            }

            For i As Integer = 0 To transactions.Length - 1
                Dim amount As Decimal = transactions(i)

                ' ==========================================
                ' SET CONDITIONAL BREAKPOINT HERE
                ' Right-click breakpoint → Conditions...
                ' Set:  amount > 5000000
                ' ==========================================
                Dim status As String = If(amount > 5000000, "HIGH VALUE ⚠️", "Normal")

                lstBreakpointLog.Items.Add(String.Format(
                    "Transaction {0,2}:  Rp {1,12:N0} - {2}",
                    i + 1, amount, status))
            Next

            lstBreakpointLog.Items.Add("")
            lstBreakpointLog.Items.Add("Total transactions: " & transactions.Length)
            lstBreakpointLog.Items.Add("Developer: Jimmi - UNSIA")

        Catch ex As Exception
            HandleException(ex, "Conditional Breakpoint")
        End Try
    End Sub

    ' LOOP BREAKPOINT
    Private Sub btnLoopBreakpoint_Click(sender As Object, e As EventArgs) Handles btnLoopBreakpoint.Click
        Try
            lstBreakpointLog.Items.Clear()
            lstBreakpointLog.Items.Add("========================================")
            lstBreakpointLog.Items.Add("   LOOP BREAKPOINT DEMO")
            lstBreakpointLog.Items.Add("   Developer: Jimmi - UNSIA")
            lstBreakpointLog.Items.Add("========================================")
            lstBreakpointLog.Items.Add("")

            Dim products() As String = {
                "Laptop Dell XPS 13",
                "Mouse Logitech MX",
                "Keyboard Mechanical",
                "Monitor Samsung 27",
                "Headset Sony WH-1000XM4",
                "Webcam Logitech C920",
                "SSD Samsung 1TB"
            }

            Dim prices() As Decimal = {
                15000000, 1200000, 850000, 3500000,
                4200000, 1800000, 2100000
            }

            For i As Integer = 0 To products.Length - 1
                ' ==========================================
                ' SET BREAKPOINT HERE
                ' Watch variables:  i, product, price
                ' Press F10 to step through
                ' ==========================================
                Dim product As String = products(i)
                Dim price As Decimal = prices(i)
                Dim stockValue As Decimal = price * 10

                lstBreakpointLog.Items.Add(String.Format(
                    "{0}. {1,-30} Rp {2,12:N0}",
                    i + 1, product, price))
            Next

            lstBreakpointLog.Items.Add("")
            lstBreakpointLog.Items.Add("Total products: " & products.Length)
            lstBreakpointLog.Items.Add("Jimmi - UNSIA")

        Catch ex As Exception
            HandleException(ex, "Loop Breakpoint")
        End Try
    End Sub

    ' ============================================
    ' EXCEPTION HANDLING DEMONSTRATIONS
    ' ============================================

    ' TRY-CATCH EXAMPLE
    Private Sub btnTryCatch_Click(sender As Object, e As EventArgs) Handles btnTryCatch.Click
        Dim log As New System.Text.StringBuilder()

        log.AppendLine("========================================")
        log.AppendLine("   TRY-CATCH EXAMPLE")
        log.AppendLine("   Developer: Jimmi - UNSIA")
        log.AppendLine("========================================")
        log.AppendLine("")
        log.AppendLine("Attempting division by zero...")
        log.AppendLine("")

        Try
            Dim a As Integer = 100
            Dim b As Integer = 0

            log.AppendLine("Code:  Dim result = " & a & " \ " & b)
            log.AppendLine("")

            ' Force exception
            If b = 0 Then
                Throw New DivideByZeroException("Attempted to divide by zero")
            End If

            Dim result As Integer = a \ b

            log.AppendLine("Result: " & result)

        Catch ex As DivideByZeroException
            log.AppendLine("✓ EXCEPTION CAUGHT!")
            log.AppendLine("")
            log.AppendLine("Exception Type: " & ex.GetType().Name)
            log.AppendLine("Message: " & ex.Message)
            log.AppendLine("")
            log.AppendLine("Program continues running after exception!")
            log.AppendLine("This is the power of exception handling.")

        End Try

        log.AppendLine("")
        log.AppendLine("Code after Try-Catch still executes normally.")
        log.AppendLine("Without Try-Catch, program would crash!")
        log.AppendLine("")
        log.AppendLine("Developer: Jimmi - UNSIA")

        txtExceptionLog.Text = log.ToString()
        txtExceptionLog.BackColor = Color.LightGreen
    End Sub

    ' SPECIFIC EXCEPTION TYPES
    Private Sub btnSpecificException_Click(sender As Object, e As EventArgs) Handles btnSpecificException.Click
        Dim log As New System.Text.StringBuilder()

        log.AppendLine("========================================")
        log.AppendLine("   SPECIFIC EXCEPTION TYPES")
        log.AppendLine("   Developer: Jimmi - UNSIA")
        log.AppendLine("========================================")
        log.AppendLine("")

        ' Test 1: Null Reference
        log.AppendLine("TEST 1: Null Reference Exception")
        log.AppendLine("----------------------------------------")
        Try
            Dim text As String = Nothing
            Dim length As Integer = text.Length
        Catch ex As NullReferenceException
            log.AppendLine("✓ Caught:  NullReferenceException")
            log.AppendLine("  Message: " & ex.Message)
        Catch ex As Exception
            log.AppendLine("✓ Caught: " & ex.GetType().Name)
            log.AppendLine("  Message: " & ex.Message)
        End Try

        log.AppendLine("")

        ' Test 2: Array Index Out of Range
        log.AppendLine("TEST 2: Array Index Out of Range")
        log.AppendLine("----------------------------------------")
        Try
            Dim arr() As Integer = {1, 2, 3}
            Dim value As Integer = arr(10)
        Catch ex As IndexOutOfRangeException
            log.AppendLine("✓ Caught: IndexOutOfRangeException")
            log.AppendLine("  Message: " & ex.Message)
        Catch ex As Exception
            log.AppendLine("✓ Caught: " & ex.GetType().Name)
            log.AppendLine("  Message: " & ex.Message)
        End Try

        log.AppendLine("")

        ' Test 3: Invalid Cast
        log.AppendLine("TEST 3: Invalid Cast Exception")
        log.AppendLine("----------------------------------------")
        Try
            Dim text As String = "Hello World"
            Dim number As Integer = CInt(text)
        Catch ex As InvalidCastException
            log.AppendLine("✓ Caught: InvalidCastException")
            log.AppendLine("  Message: " & ex.Message)
        Catch ex As Exception
            log.AppendLine("✓ Caught: " & ex.GetType().Name)
            log.AppendLine("  Message: " & ex.Message)
        End Try

        log.AppendLine("")

        ' Test 4: File Not Found
        log.AppendLine("TEST 4: File Not Found Exception")
        log.AppendLine("----------------------------------------")
        Try
            Dim content As String = System.IO.File.ReadAllText("C:\FileYangTidakAda.txt")
        Catch ex As System.IO.FileNotFoundException
            log.AppendLine("✓ Caught: FileNotFoundException")
            log.AppendLine("  Message: " & ex.Message)
        Catch ex As Exception
            log.AppendLine("✓ Caught: " & ex.GetType().Name)
            log.AppendLine("  Message: " & ex.Message)
        End Try

        log.AppendLine("")
        log.AppendLine("========================================")
        log.AppendLine("All 4 exceptions handled successfully!")
        log.AppendLine("Program continues running normally.")
        log.AppendLine("Developer: Jimmi - UNSIA")
        log.AppendLine("========================================")

        txtExceptionLog.Text = log.ToString()
        txtExceptionLog.BackColor = Color.LightYellow
    End Sub

    ' TRY-CATCH-FINALLY
    Private Sub btnFinallyBlock_Click(sender As Object, e As EventArgs) Handles btnFinallyBlock.Click
        Dim log As New System.Text.StringBuilder()

        log.AppendLine("========================================")
        log.AppendLine("   TRY-CATCH-FINALLY EXAMPLE")
        log.AppendLine("   Developer: Jimmi - UNSIA")
        log.AppendLine("========================================")
        log.AppendLine("")

        Dim fileOpened As Boolean = False
        Dim connectionOpened As Boolean = False

        Try
            log.AppendLine("→ TRY BLOCK executing...")
            log.AppendLine("")

            fileOpened = True
            log.AppendLine("  • Opening file...")

            connectionOpened = True
            log.AppendLine("  • Opening database connection...")
            log.AppendLine("")

            ' Simulate error
            log.AppendLine("  • Simulating error...")
            Throw New Exception("Simulated file error!")

        Catch ex As Exception
            log.AppendLine("")
            log.AppendLine("→ CATCH BLOCK executing...")
            log.AppendLine("")
            log.AppendLine("  ✓ Exception caught: " & ex.Message)

        Finally
            log.AppendLine("")
            log.AppendLine("→ FINALLY BLOCK executing...")
            log.AppendLine("")
            log.AppendLine("  ⚠️ This ALWAYS runs, even with exception!")
            log.AppendLine("")

            If fileOpened Then
                log.AppendLine("  • Closing file...")
            End If

            If connectionOpened Then
                log.AppendLine("  • Closing database connection...")
            End If

            log.AppendLine("  • Resources cleaned up.")
        End Try

        log.AppendLine("")
        log.AppendLine("========================================")
        log.AppendLine("FINALLY BLOCK USES:")
        log.AppendLine("  - Closing files")
        log.AppendLine("  - Releasing database connections")
        log.AppendLine("  - Disposing objects")
        log.AppendLine("  - Cleanup operations")
        log.AppendLine("")
        log.AppendLine("Developer: Jimmi - UNSIA")
        log.AppendLine("========================================")

        txtExceptionLog.Text = log.ToString()
        txtExceptionLog.BackColor = Color.LightBlue
    End Sub

    ' CUSTOM EXCEPTION HANDLER
    Private Sub btnCustomException_Click(sender As Object, e As EventArgs) Handles btnCustomException.Click
        Try
            ' Simulate random error
            Dim errorType As Integer = New Random().Next(1, 5)

            Select Case errorType
                Case 1
                    Throw New ArgumentException("Invalid argument provided to function!")
                Case 2
                    Throw New InvalidOperationException("Operation not allowed in current state!")
                Case 3
                    Throw New ApplicationException("Application-specific error occurred!")
                Case 4
                    Throw New NotImplementedException("Feature not yet implemented!")
            End Select

        Catch ex As Exception
            ' Use custom exception handler
            HandleException(ex, "Custom Exception Test")
        End Try
    End Sub

    ' ============================================
    ' CUSTOM EXCEPTION HANDLER METHOD
    ' ============================================
    Private Sub HandleException(ex As Exception, operation As String)
        Dim errorDetails As New System.Text.StringBuilder()

        errorDetails.AppendLine("========================================")
        errorDetails.AppendLine("   EXCEPTION DETAILS")
        errorDetails.AppendLine("   Developer: Jimmi - UNSIA")
        errorDetails.AppendLine("========================================")
        errorDetails.AppendLine("")
        errorDetails.AppendLine("Operation: " & operation)
        errorDetails.AppendLine("Timestamp: " & DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"))
        errorDetails.AppendLine("")
        errorDetails.AppendLine("Exception Type: " & ex.GetType().Name)
        errorDetails.AppendLine("Message: " & ex.Message)
        errorDetails.AppendLine("")
        errorDetails.AppendLine("Stack Trace:")
        errorDetails.AppendLine(ex.StackTrace)

        If ex.InnerException IsNot Nothing Then
            errorDetails.AppendLine("")
            errorDetails.AppendLine("Inner Exception:")
            errorDetails.AppendLine("  Type: " & ex.InnerException.GetType().Name)
            errorDetails.AppendLine("  Message: " & ex.InnerException.Message)
        End If

        errorDetails.AppendLine("")
        errorDetails.AppendLine("========================================")
        errorDetails.AppendLine("Error logged and handled gracefully.")
        errorDetails.AppendLine("Application continues running.")
        errorDetails.AppendLine("Developer: Jimmi - UNSIA")
        errorDetails.AppendLine("========================================")

        txtExceptionLog.Text = errorDetails.ToString()
        txtExceptionLog.BackColor = Color.LightCoral

        ' Also log to Debug Output
        Debug.WriteLine("========================================")
        Debug.WriteLine("ERROR LOG - Jimmi UNSIA")
        Debug.WriteLine("========================================")
        Debug.WriteLine("Operation: " & operation)
        Debug.WriteLine("Error: " & ex.Message)
        Debug.WriteLine("========================================")

        ' Show user-friendly message
        MessageBox.Show(
            "An error occurred in:  " & operation & vbCrLf & vbCrLf &
            "Error:  " & ex.Message & vbCrLf & vbCrLf &
            "Details logged in the form below." & vbCrLf & vbCrLf &
            "Developer: Jimmi - UNSIA",
            "Error Handler",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
    End Sub

End Class