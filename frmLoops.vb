Public Class frmLoops

    Private Sub frmLoops_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstForLoop.Items.Add("Click button to see FOR loop examples")
        lstForEach.Items.Add("Click button to see FOR EACH loop examples")
        lstWhile.Items.Add("Click button to see WHILE loop examples")
        lstDo.Items.Add("Click button to see DO loop examples")
    End Sub

    ' ============================================
    ' FOR LOOP
    ' ============================================
    Private Sub btnForLoop_Click(sender As Object, e As EventArgs) Handles btnForLoop.Click
        Try
            lstForLoop.Items.Clear()
            lstForLoop.Items.Add("========================================")
            lstForLoop.Items.Add("   FOR LOOP DEMONSTRATIONS")
            lstForLoop.Items.Add("   Developer: Jimmi - UNSIA")
            lstForLoop.Items.Add("========================================")
            lstForLoop.Items.Add("")

            ' Example 1: Basic FOR loop - Generate invoice numbers
            lstForLoop.Items.Add("Example 1: Generate 10 Invoice Numbers")
            lstForLoop.Items.Add(New String("-"c, 40))

            ' SET BREAKPOINT HERE (F9) - Watch: i
            For i As Integer = 1 To 10
                Dim invoiceNo As String = String.Format("INV-2026-{0:D4}", i)
                lstForLoop.Items.Add("  " & invoiceNo)
            Next

            lstForLoop.Items.Add("")

            ' Example 2: FOR loop with STEP
            lstForLoop.Items.Add("Example 2: Even Numbers (STEP 2)")
            lstForLoop.Items.Add(New String("-"c, 40))

            Dim evenNumbers As String = "  "
            For num As Integer = 0 To 20 Step 2
                evenNumbers &= num & " "
            Next
            lstForLoop.Items.Add(evenNumbers)

            lstForLoop.Items.Add("")

            ' Example 3: Reverse FOR loop (Countdown)
            lstForLoop.Items.Add("Example 3: Countdown (Reverse Loop)")
            lstForLoop.Items.Add(New String("-"c, 40))

            For countdown As Integer = 10 To 1 Step -1
                lstForLoop.Items.Add("  " & countdown & "...")
            Next
            lstForLoop.Items.Add("  🚀 Liftoff!")

            lstForLoop.Items.Add("")

            ' Example 4: Nested FOR loops - Multiplication table
            lstForLoop.Items.Add("Example 4: Multiplication Table (5x5)")
            lstForLoop.Items.Add(New String("-"c, 40))

            For row As Integer = 1 To 5
                Dim line As String = "  "
                For col As Integer = 1 To 5
                    line &= String.Format("{0,4}", row * col)
                Next
                lstForLoop.Items.Add(line)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' FOR EACH LOOP
    ' ============================================
    Private Sub btnForEach_Click(sender As Object, e As EventArgs) Handles btnForEach.Click
        Try
            lstForEach.Items.Clear()
            lstForEach.Items.Add("========================================")
            lstForEach.Items.Add("   FOR EACH LOOP DEMONSTRATIONS")
            lstForEach.Items.Add("   Developer: Jimmi - UNSIA")
            lstForEach.Items.Add("========================================")
            lstForEach.Items.Add("")

            ' Example 1: Array iteration
            lstForEach.Items.Add("Example 1: Iterate Through Array")
            lstForEach.Items.Add(New String("-"c, 40))

            Dim products() As String = {
                "Laptop", "Mouse", "Keyboard",
                "Monitor", "Headset", "Webcam"
            }

            ' FOR EACH loop - iterate array
            Dim index As Integer = 1
            For Each product As String In products
                lstForEach.Items.Add(String.Format("  {0}. {1}", index, product))
                index += 1
            Next

            lstForEach.Items.Add("")

            ' Example 2: List(Of T) iteration
            lstForEach.Items.Add("Example 2:  Iterate Through List")
            lstForEach.Items.Add(New String("-"c, 40))

            Dim categories As New List(Of String) From {
                "Electronics", "Accessories", "Software", "Networking"
            }

            For Each category As String In categories
                lstForEach.Items.Add("  ▪ " & category)
            Next

            lstForEach.Items.Add("")

            ' Example 3: Dictionary iteration
            lstForEach.Items.Add("Example 3: Iterate Dictionary")
            lstForEach.Items.Add(New String("-"c, 40))

            Dim stock As New Dictionary(Of String, Integer)
            stock.Add("Laptop", 45)
            stock.Add("Mouse", 120)
            stock.Add("Keyboard", 89)

            For Each item As KeyValuePair(Of String, Integer) In stock
                lstForEach.Items.Add(String.Format("  {0,-12}:  {1,3} units", item.Key, item.Value))
            Next

            lstForEach.Items.Add("")

            ' Example 4: Calculate sum using FOR EACH
            lstForEach.Items.Add("Example 4: Calculate Total")
            lstForEach.Items.Add(New String("-"c, 40))

            Dim prices() As Decimal = {15000000, 1200000, 850000, 3500000}
            Dim total As Decimal = 0

            For Each price As Decimal In prices
                total += price
            Next

            lstForEach.Items.Add("  Prices: " & String.Join(", ", prices.Select(Function(p) "Rp " & p.ToString("N0"))))
            lstForEach.Items.Add("  Total: Rp " & total.ToString("N0"))

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' WHILE LOOP
    ' ============================================
    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Try
            lstWhile.Items.Clear()
            lstWhile.Items.Add("========================================")
            lstWhile.Items.Add("   WHILE LOOP DEMONSTRATIONS")
            lstWhile.Items.Add("   Developer: Jimmi - UNSIA")
            lstWhile.Items.Add("========================================")
            lstWhile.Items.Add("")

            ' Example 1: Process queue
            lstWhile.Items.Add("Example 1: Order Queue Processing")
            lstWhile.Items.Add(New String("-"c, 40))

            Dim orderQueue As New Queue(Of String)
            orderQueue.Enqueue("Order #1001")
            orderQueue.Enqueue("Order #1002")
            orderQueue.Enqueue("Order #1003")
            orderQueue.Enqueue("Order #1004")
            orderQueue.Enqueue("Order #1005")

            Dim processedCount As Integer = 0

            ' WHILE loop - process until queue is empty
            While orderQueue.Count > 0
                Dim currentOrder As String = orderQueue.Dequeue()
                processedCount += 1
                lstWhile.Items.Add(String.Format("  {0}. {1} ✓", processedCount, currentOrder))
            End While

            lstWhile.Items.Add("")
            lstWhile.Items.Add("  Total Processed: " & processedCount)
            lstWhile.Items.Add("")

            ' Example 2: Stock depletion simulation
            lstWhile.Items.Add("Example 2: Stock Depletion")
            lstWhile.Items.Add(New String("-"c, 40))

            Dim stockLevel As Integer = 100
            Dim dayCounter As Integer = 1
            Dim rnd As New Random()

            While stockLevel > 0 AndAlso dayCounter <= 10
                Dim dailySales As Integer = rnd.Next(5, 15)
                stockLevel -= dailySales
                If stockLevel < 0 Then stockLevel = 0

                lstWhile.Items.Add(String.Format("  Day {0}:  Sold {1}, Remaining:  {2}",
                    dayCounter, dailySales, stockLevel))
                dayCounter += 1
            End While

            lstWhile.Items.Add("")

            If stockLevel = 0 Then
                lstWhile.Items.Add("  ⚠️ STOCK OUT on Day " & (dayCounter - 1))
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' DO LOOP (DO WHILE and DO UNTIL)
    ' ============================================
    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        Try
            lstDo.Items.Clear()
            lstDo.Items.Add("========================================")
            lstDo.Items.Add("   DO LOOP DEMONSTRATIONS")
            lstDo.Items.Add("   Developer: Jimmi - UNSIA")
            lstDo.Items.Add("========================================")
            lstDo.Items.Add("")

            ' Example 1: DO WHILE loop
            lstDo.Items.Add("Example 1: DO WHILE (Check After)")
            lstDo.Items.Add(New String("-"c, 40))

            Dim attempt As Integer = 1

            Do While attempt <= 5
                lstDo.Items.Add(String.Format("  Attempt {0}: Processing.. .", attempt))
                attempt += 1
            Loop

            lstDo.Items.Add("  Complete!")
            lstDo.Items.Add("")

            ' Example 2: DO UNTIL loop
            lstDo.Items.Add("Example 2: DO UNTIL (Accumulate)")
            lstDo.Items.Add(New String("-"c, 40))

            Dim balance As Decimal = 100000
            Dim transaction As Integer = 1
            Dim rnd As New Random()

            Do Until balance >= 200000
                Dim earning As Decimal = rnd.Next(10000, 30000)
                balance += earning
                lstDo.Items.Add(String.Format("  Trx {0}: +Rp {1:N0}, Balance: Rp {2:N0}",
                    transaction, earning, balance))
                transaction += 1

                ' Safety limit
                If transaction > 10 Then Exit Do
            Loop

            lstDo.Items.Add("")
            lstDo.Items.Add("  🎯 Target Reached!")
            lstDo.Items.Add("")

            ' Example 3: DO with EXIT condition
            lstDo.Items.Add("Example 3: DO with EXIT DO")
            lstDo.Items.Add(New String("-"c, 40))

            Dim searchAttempts As Integer = 0
            Dim found As Boolean = False
            Dim targetAttempt As Integer = rnd.Next(2, 6)

            Do
                searchAttempts += 1

                If searchAttempts = targetAttempt Then
                    found = True
                    lstDo.Items.Add(String.Format("  ✓ Item FOUND at attempt:  {0}", searchAttempts))
                    Exit Do
                Else
                    lstDo.Items.Add(String.Format("  ✗ Attempt {0}:  Not found, searching.. .", searchAttempts))
                End If

                If searchAttempts >= 5 Then
                    lstDo.Items.Add("  ⏱️ Search timeout")
                    Exit Do
                End If
            Loop

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

End Class