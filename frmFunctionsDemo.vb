Public Class frmFunctionsDemo

    Private Sub frmFunctionsDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text =
            "BYVAL vs BYREF EXPLANATION" & vbCrLf &
            "Developer: Jimmi - UNSIA" & vbCrLf &
            "" & vbCrLf &
            "ByVal:  Passes a COPY" & vbCrLf &
            "ByRef:  Passes REFERENCE" & vbCrLf &
            "Try buttons above!"
    End Sub

    ' BYVAL TEST
    Private Sub btnTestByVal_Click(sender As Object, e As EventArgs) Handles btnTestByVal.Click
        Try
            Dim originalValue As Integer = CInt(txtByValOriginal.Text)
            Dim beforeValue As Integer = originalValue

            ModifyByVal(originalValue)

            lblByValResult.Text =
                "Before: " & beforeValue & vbCrLf &
                "After: " & originalValue & vbCrLf &
                "Changed?  " & (beforeValue <> originalValue).ToString() & vbCrLf &
                "Jimmi - UNSIA"

            lblByValResult.BackColor = Color.LightGreen
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ModifyByVal(ByVal value As Integer)
        value = value * 2
        value = value + 100
    End Sub

    ' BYREF TEST
    Private Sub btnTestByRef_Click(sender As Object, e As EventArgs) Handles btnTestByRef.Click
        Try
            Dim originalValue As Integer = CInt(txtByRefOriginal.Text)
            Dim beforeValue As Integer = originalValue

            ModifyByRef(originalValue)

            lblByRefResult.Text =
                "Before: " & beforeValue & vbCrLf &
                "After: " & originalValue & vbCrLf &
                "Changed?  " & (beforeValue <> originalValue).ToString() & vbCrLf &
                "Jimmi - UNSIA"

            lblByRefResult.BackColor = Color.Orange
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ModifyByRef(ByRef value As Integer)
        value = value * 2
        value = value + 100
    End Sub

    ' CALCULATE
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim qty As Integer = CInt(nudQty.Value)
            Dim price As Decimal = nudUnitPrice.Value
            Dim tax As Decimal = nudTaxRate.Value

            Dim subtotal As Decimal = qty * price
            Dim taxAmount As Decimal = subtotal * (tax / 100)
            Dim total As Decimal = subtotal + taxAmount

            lblCalcResult.Text =
                "Qty: " & qty & vbCrLf &
                "Price:  Rp " & price.ToString("N0") & vbCrLf &
                "Subtotal: Rp " & subtotal.ToString("N0") & vbCrLf &
                "Tax: Rp " & taxAmount.ToString("N0") & vbCrLf &
                "TOTAL: Rp " & total.ToString("N0") & vbCrLf &
                "Jimmi - UNSIA"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' FUNCTION STRING
    Private Sub btnFunctionString_Click(sender As Object, e As EventArgs) Handles btnFunctionString.Click
        Dim result As String = GetGreeting("Jimmi")
        lstFunctionResults.Items.Clear()
        lstFunctionResults.Items.Add("Function returns STRING:")
        lstFunctionResults.Items.Add(result)
        lstFunctionResults.Items.Add("Developer: Jimmi - UNSIA")
    End Sub

    Private Function GetGreeting(ByVal name As String) As String
        Return "Hello, " & name & "!  Welcome to E-Business."
    End Function

    ' FUNCTION INTEGER
    Private Sub btnFunctionInteger_Click(sender As Object, e As EventArgs) Handles btnFunctionInteger.Click
        Dim result As Integer = GetRandomNumber(1, 100)
        lstFunctionResults.Items.Clear()
        lstFunctionResults.Items.Add("Function returns INTEGER:")
        lstFunctionResults.Items.Add("Random:  " & result)
        lstFunctionResults.Items.Add("Jimmi - UNSIA")
    End Sub

    Private Function GetRandomNumber(ByVal min As Integer, ByVal max As Integer) As Integer
        Return New Random().Next(min, max + 1)
    End Function

    ' FUNCTION DECIMAL
    Private Sub btnFunctionDecimal_Click(sender As Object, e As EventArgs) Handles btnFunctionDecimal.Click
        Dim price As Decimal = 1250000
        Dim disc As Decimal = CalculateDiscount(price, 15)
        lstFunctionResults.Items.Clear()
        lstFunctionResults.Items.Add("Function returns DECIMAL:")
        lstFunctionResults.Items.Add("Price: Rp " & price.ToString("N0"))
        lstFunctionResults.Items.Add("Discount: Rp " & disc.ToString("N0"))
        lstFunctionResults.Items.Add("Jimmi - UNSIA")
    End Sub

    Private Function CalculateDiscount(ByVal price As Decimal, ByVal percent As Decimal) As Decimal
        Return price * (percent / 100)
    End Function

    ' FUNCTION BOOLEAN
    Private Sub btnFunctionBoolean_Click(sender As Object, e As EventArgs) Handles btnFunctionBoolean.Click
        Dim stock As Integer = 5
        Dim result As Boolean = IsLowStock(stock, 10)
        lstFunctionResults.Items.Clear()
        lstFunctionResults.Items.Add("Function returns BOOLEAN:")
        lstFunctionResults.Items.Add("Stock: " & stock)
        lstFunctionResults.Items.Add("Is Low?  " & result.ToString())
        lstFunctionResults.Items.Add("Jimmi - UNSIA")
    End Sub

    Private Function IsLowStock(ByVal current As Integer, ByVal min As Integer) As Boolean
        Return current <= min
    End Function

    ' PARAMARRAY - SUM
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Try
            Dim numbers() As Decimal = ParseNumbers(txtNumbers.Text)
            If numbers.Length = 0 Then
                MessageBox.Show("Enter valid numbers!")
                Return
            End If

            Dim result As Decimal = SumNumbers(numbers)

            lstParamResults.Items.Clear()
            lstParamResults.Items.Add("=== SUM CALCULATION ===")
            lstParamResults.Items.Add("Developer: Jimmi - UNSIA")
            lstParamResults.Items.Add("")

            For i As Integer = 0 To numbers.Length - 1
                lstParamResults.Items.Add("[" & i & "] = " & numbers(i).ToString("N2"))
            Next

            lstParamResults.Items.Add("")
            lstParamResults.Items.Add("Total: " & result.ToString("N2"))
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' PARAMARRAY - AVERAGE
    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Try
            Dim numbers() As Decimal = ParseNumbers(txtNumbers.Text)
            If numbers.Length = 0 Then Return

            Dim avg As Decimal = CalculateAverage(numbers)

            lstParamResults.Items.Clear()
            lstParamResults.Items.Add("=== AVERAGE ===")
            lstParamResults.Items.Add("Average: " & avg.ToString("N2"))
            lstParamResults.Items.Add("Jimmi - UNSIA")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' PARAMARRAY - MAX
    Private Sub btnFindMax_Click(sender As Object, e As EventArgs) Handles btnFindMax.Click
        Try
            Dim numbers() As Decimal = ParseNumbers(txtNumbers.Text)
            If numbers.Length = 0 Then Return

            Dim maxVal As Decimal = FindMaximum(numbers)

            lstParamResults.Items.Clear()
            lstParamResults.Items.Add("=== MAXIMUM ===")
            lstParamResults.Items.Add("Max: " & maxVal.ToString("N2"))
            lstParamResults.Items.Add("Jimmi - UNSIA")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' PARAMARRAY - MIN
    Private Sub btnFindMin_Click(sender As Object, e As EventArgs) Handles btnFindMin.Click
        Try
            Dim numbers() As Decimal = ParseNumbers(txtNumbers.Text)
            If numbers.Length = 0 Then Return

            Dim minVal As Decimal = FindMinimum(numbers)

            lstParamResults.Items.Clear()
            lstParamResults.Items.Add("=== MINIMUM ===")
            lstParamResults.Items.Add("Min: " & minVal.ToString("N2"))
            lstParamResults.Items.Add("Jimmi - UNSIA")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' HELPER FUNCTIONS
    Private Function ParseNumbers(ByVal input As String) As Decimal()
        Try
            Dim parts() As String = input.Split(","c)
            Dim result As New List(Of Decimal)

            For Each part As String In parts
                Dim num As Decimal
                If Decimal.TryParse(part.Trim(), num) Then
                    result.Add(num)
                End If
            Next

            Return result.ToArray()
        Catch
            Return New Decimal() {}
        End Try
    End Function

    Private Function SumNumbers(ParamArray numbers() As Decimal) As Decimal
        Dim total As Decimal = 0
        For Each num As Decimal In numbers
            total += num
        Next
        Return total
    End Function

    Private Function CalculateAverage(ParamArray numbers() As Decimal) As Decimal
        If numbers.Length = 0 Then Return 0
        Return SumNumbers(numbers) / numbers.Length
    End Function

    Private Function FindMaximum(ParamArray numbers() As Decimal) As Decimal
        If numbers.Length = 0 Then Return 0
        Dim max As Decimal = numbers(0)
        For Each num As Decimal In numbers
            If num > max Then max = num
        Next
        Return max
    End Function

    Private Function FindMinimum(ParamArray numbers() As Decimal) As Decimal
        If numbers.Length = 0 Then Return 0
        Dim min As Decimal = numbers(0)
        For Each num As Decimal In numbers
            If num < min Then min = num
        Next
        Return min
    End Function

End Class