Public Class frmDateTimeDemo

    Private Sub frmDateTimeDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default values
        dtpStart.Value = DateTime.Now
        dtpEnd.Value = DateTime.Now.AddDays(7)

        txtResults.Text = "Select dates above and click buttons to perform operations" & vbCrLf & "Developer: Jimmi - UNSIA"
        txtCurrentInfo.Text = "Click buttons above to see date/time information"
    End Sub

    ' ============================================
    ' TIMESPAN CALCULATION
    ' ============================================
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            ' Get dates from DateTimePickers
            Dim startDate As DateTime = dtpStart.Value
            Dim endDate As DateTime = dtpEnd.Value

            ' Calculate TimeSpan difference
            Dim difference As TimeSpan = endDate - startDate

            ' SET BREAKPOINT HERE (Press F9) - Watch:  startDate, endDate, difference

            ' Build result string
            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("   TIMESPAN CALCULATION")
            result.AppendLine("   Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("Start Date : " & startDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
            result.AppendLine("End Date   : " & endDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"))
            result.AppendLine("")
            result.AppendLine("DIFFERENCE:")
            result.AppendLine("Days    : " & difference.Days)
            result.AppendLine("Hours   : " & difference.TotalHours.ToString("N2"))
            result.AppendLine("Minutes : " & difference.TotalMinutes.ToString("N2"))
            result.AppendLine("Seconds : " & difference.TotalSeconds.ToString("N0"))
            result.AppendLine("")

            ' IF STATEMENT - Check if future or past
            If difference.TotalDays > 0 Then
                result.AppendLine("Status: FUTURE date (" & difference.Days & "days from now)")
            ElseIf difference.TotalDays < 0 Then
                result.AppendLine("Status: PAST date (" & Math.Abs(difference.Days) & "days ago)")
            Else
                result.AppendLine("Status: SAME DAY")
            End If

            txtResults.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message & vbCrLf & "Jimmi - UNSIA", "Error")
        End Try
    End Sub

    ' ============================================
    ' ADD DAYS OPERATION
    ' ============================================
    Private Sub btnAddDays_Click(sender As Object, e As EventArgs) Handles btnAddDays.Click
        Try
            Dim orderDate As DateTime = dtpStart.Value

            ' Add 30 days
            Dim deliveryDate As DateTime = orderDate.AddDays(30)

            ' Build result
            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("ADD DAYS OPERATION")
            result.AppendLine("E-Business:  Delivery Date Calculator")
            result.AppendLine("Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("Order Date     : " & orderDate.ToString("dd MMMM yyyy"))
            result.AppendLine("Delivery Date  : " & deliveryDate.ToString("dd MMMM yyyy"))
            result.AppendLine("Day of Week    : " & deliveryDate.ToString("dddd"))
            result.AppendLine("")
            result.AppendLine("Other Operations:")
            result.AppendLine("Add 7 days   : " & orderDate.AddDays(7).ToString("dd/MM/yyyy"))
            result.AppendLine("Add 1 month  : " & orderDate.AddMonths(1).ToString("dd/MM/yyyy"))
            result.AppendLine("Add 1 year   : " & orderDate.AddYears(1).ToString("dd/MM/yyyy"))
            result.AppendLine("Add 5 hours  : " & orderDate.AddHours(5).ToString("dd/MM/yyyy HH:mm"))

            txtResults.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' DATE FORMATTING EXAMPLES
    ' ============================================
    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        Try
            Dim currentDate As DateTime = dtpStart.Value

            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("DATE FORMATTING EXAMPLES")
            result.AppendLine("Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("Original Date: " & currentDate.ToString())
            result.AppendLine("")
            result.AppendLine("STANDARD FORMATS:")
            result.AppendLine("Short Date (d)    : " & currentDate.ToString("d"))
            result.AppendLine("Long Date (D)     : " & currentDate.ToString("D"))
            result.AppendLine("Short Time (t)    : " & currentDate.ToString("t"))
            result.AppendLine("Long Time (T)     : " & currentDate.ToString("T"))
            result.AppendLine("Full DateTime (F) : " & currentDate.ToString("F"))
            result.AppendLine("")
            result.AppendLine("CUSTOM FORMATS:")
            result.AppendLine("dd/MM/yyyy        : " & currentDate.ToString("dd/MM/yyyy"))
            result.AppendLine("MM/dd/yyyy        : " & currentDate.ToString("MM/dd/yyyy"))
            result.AppendLine("yyyy-MM-dd        : " & currentDate.ToString("yyyy-MM-dd"))
            result.AppendLine("MMMM dd, yyyy     : " & currentDate.ToString("MMMM dd, yyyy"))
            result.AppendLine("dddd, dd MMM yyyy : " & currentDate.ToString("dddd, dd MMM yyyy"))
            result.AppendLine("HH:mm:ss          : " & currentDate.ToString("HH:mm:ss"))
            result.AppendLine("")
            result.AppendLine("COMPONENTS:")
            result.AppendLine("Year   : " & currentDate.Year)
            result.AppendLine("Month  : " & currentDate.Month)
            result.AppendLine("Day    : " & currentDate.Day)
            result.AppendLine("Hour   : " & currentDate.Hour)
            result.AppendLine("Minute : " & currentDate.Minute)
            result.AppendLine("Second : " & currentDate.Second)

            txtResults.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' BUSINESS DAYS CALCULATION (FUNCTION DEMO)
    ' ============================================
    Private Sub btnBusinessDays_Click(sender As Object, e As EventArgs) Handles btnBusinessDays.Click
        Try
            Dim startDate As DateTime = dtpStart.Value
            Dim endDate As DateTime = dtpEnd.Value

            ' Call FUNCTION to calculate business days
            Dim businessDays As Integer = CalculateBusinessDays(startDate, endDate)

            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("BUSINESS DAYS CALCULATION")
            result.AppendLine("Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("Start Date      : " & startDate.ToString("dd/MM/yyyy (dddd)"))
            result.AppendLine("End Date        : " & endDate.ToString("dd/MM/yyyy (dddd)"))
            result.AppendLine("")
            result.AppendLine("Total Days      : " & (endDate - startDate).Days & " days")
            result.AppendLine("Business Days   : " & businessDays & " days")
            result.AppendLine("")
            result.AppendLine("Note: Business days exclude weekends (Saturday & Sunday)")

            txtResults.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' FUNCTION:  Calculate Business Days
    ' Excludes weekends
    ' ============================================
    Private Function CalculateBusinessDays(startDate As DateTime, endDate As DateTime) As Integer
        Dim days As Integer = 0
        Dim currentDate As DateTime = startDate

        ' WHILE LOOP - iterate through dates
        While currentDate <= endDate
            ' IF STATEMENT - check if not weekend
            If currentDate.DayOfWeek <> DayOfWeek.Saturday AndAlso
               currentDate.DayOfWeek <> DayOfWeek.Sunday Then
                days += 1
            End If

            currentDate = currentDate.AddDays(1)
        End While

        Return days
    End Function

    ' ============================================
    ' SHOW CURRENT DATE/TIME
    ' ============================================
    Private Sub btnShowCurrent_Click(sender As Object, e As EventArgs) Handles btnShowCurrent.Click
        Try
            Dim now As DateTime = DateTime.Now

            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("CURRENT DATE & TIME")
            result.AppendLine("Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("DateTime.Now    : " & now.ToString("F"))
            result.AppendLine("DateTime.Today  : " & DateTime.Today.ToString("D"))
            result.AppendLine("DateTime.UtcNow : " & DateTime.UtcNow.ToString("F"))
            result.AppendLine("")
            result.AppendLine("Day of Week     : " & now.DayOfWeek.ToString())
            result.AppendLine("Day of Year     : " & now.DayOfYear)
            result.AppendLine("")
            result.AppendLine("Is Leap Year    : " & DateTime.IsLeapYear(now.Year))
            result.AppendLine("Days in Month   : " & DateTime.DaysInMonth(now.Year, now.Month))
            result.AppendLine("")
            result.AppendLine("Time of Day     : " & now.TimeOfDay.ToString())
            result.AppendLine("Ticks           : " & now.Ticks.ToString("N0"))

            txtCurrentInfo.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' SHOW TIME COMPONENTS
    ' ============================================
    Private Sub btnTimeComponents_Click(sender As Object, e As EventArgs) Handles btnTimeComponents.Click
        Try
            Dim now As DateTime = DateTime.Now

            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("TIME COMPONENTS")
            result.AppendLine("Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("Full DateTime :  " & now.ToString("yyyy-MM-dd HH:mm:ss. fff"))
            result.AppendLine("")
            result.AppendLine("DATE COMPONENTS:")
            result.AppendLine("Year        : " & now.Year)
            result.AppendLine("Month       : " & now.Month & " (" & now.ToString("MMMM") & ")")
            result.AppendLine("Day         : " & now.Day)
            result.AppendLine("Day of Week : " & now.DayOfWeek & " (" & now.ToString("dddd") & ")")
            result.AppendLine("Day of Year : " & now.DayOfYear)
            result.AppendLine("")
            result.AppendLine("TIME COMPONENTS:")
            result.AppendLine("Hour        : " & now.Hour & " (24-hour format)")
            result.AppendLine("Minute      : " & now.Minute)
            result.AppendLine("Second      : " & now.Second)
            result.AppendLine("Millisecond : " & now.Millisecond)
            result.AppendLine("")
            result.AppendLine("FORMATTED:")
            result.AppendLine("12-hour     : " & now.ToString("hh:mm:ss tt"))
            result.AppendLine("24-hour     : " & now.ToString("HH:mm:ss"))

            txtCurrentInfo.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

End Class