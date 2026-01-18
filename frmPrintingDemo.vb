Imports System.Drawing.Printing

Public Class frmPrintingDemo

    ' Printing variables
    Private printLines As New List(Of String)
    Private currentLineIndex As Integer = 0
    Private currentPage As Integer = 0

    ' Fonts
    Private headerFont As New Font("Arial", 16, FontStyle.Bold)
    Private bodyFont As New Font("Courier New", 10, FontStyle.Regular)
    Private footerFont As New Font("Arial", 8, FontStyle.Italic)

    Private Sub frmPrintingDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup print components
        printPreviewDlg.Document = printDoc
        printDlg.Document = printDoc
        pageSetupDlg.Document = printDoc

        txtPreview.Text = "Click 'Generate Report' to create a document" & vbCrLf & "Developer: Jimmi - UNSIA"
    End Sub

    ' ============================================
    ' PRINT DIALOGS
    ' ============================================

    Private Sub btnPrinterSetup_Click(sender As Object, e As EventArgs) Handles btnPrinterSetup.Click
        Try
            If printDlg.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Printer: " & printDoc.PrinterSettings.PrinterName & vbCrLf & "Jimmi - UNSIA", "Success")
            End If
        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message)
        End Try
    End Sub

    Private Sub btnPageSetup_Click(sender As Object, e As EventArgs) Handles btnPageSetup.Click
        Try
            If pageSetupDlg.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Page settings configured!" & vbCrLf & "Jimmi - UNSIA", "Success")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        Try
            If printLines.Count = 0 Then
                MessageBox.Show("Please generate a report first!")
                Return
            End If

            currentLineIndex = 0
            currentPage = 0
            printPreviewDlg.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            If printLines.Count = 0 Then
                MessageBox.Show("Please generate a report first!")
                Return
            End If

            If printDlg.ShowDialog() = DialogResult.OK Then
                currentLineIndex = 0
                currentPage = 0
                printDoc.Print()
                MessageBox.Show("Document sent to printer!" & vbCrLf & "Jimmi - UNSIA", "Success")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ============================================
    ' GENERATE REPORTS
    ' ============================================

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            printLines.Clear()

            If rbSimpleReport.Checked Then
                GenerateSimpleReport()
            ElseIf rbInvoice.Checked Then
                GenerateInvoiceReport()
            ElseIf rbProductList.Checked Then
                GenerateProductListReport()
            ElseIf rbSalesReport.Checked Then
                GenerateSalesReport()
            End If

            ' Show preview
            txtPreview.Text = String.Join(vbCrLf, printLines)

            MessageBox.Show("Report generated!  " & printLines.Count & " lines" & vbCrLf & "Jimmi - UNSIA", "Success")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerateSimpleReport()
        printLines.Add(CenterText("E-BUSINESS SYSTEM", 80))
        printLines.Add(CenterText("SIMPLE REPORT", 80))
        printLines.Add(CenterText("Developer: Jimmi - UNSIA", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")
        printLines.Add("Date: " & DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"))
        printLines.Add("")
        printLines.Add("SALES SUMMARY")
        printLines.Add(RepeatChar("-", 80))
        printLines.Add("")

        ' Column headers with alignment
        printLines.Add(FormatColumns("Product", "Qty", "Price", "Total", 30, 10, 20, 20))
        printLines.Add(RepeatChar("-", 80))

        ' Data rows
        printLines.Add(FormatColumns("Laptop Dell XPS 13", "5", "15,000,000", "75,000,000", 30, 10, 20, 20))
        printLines.Add(FormatColumns("Mouse Logitech", "12", "1,200,000", "14,400,000", 30, 10, 20, 20))
        printLines.Add(FormatColumns("Keyboard RGB", "8", "850,000", "6,800,000", 30, 10, 20, 20))
        printLines.Add(FormatColumns("Monitor Samsung", "3", "3,500,000", "10,500,000", 30, 10, 20, 20))

        printLines.Add(RepeatChar("-", 80))
        printLines.Add(AlignRight("GRAND TOTAL:  Rp 106,700,000", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")
        printLines.Add(CenterText("--- End of Report ---", 80))
    End Sub

    Private Sub GenerateInvoiceReport()
        printLines.Add(RepeatChar("=", 80))
        printLines.Add(CenterText("I N V O I C E", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")
        printLines.Add("E-BUSINESS CORPORATION")
        printLines.Add("Developer: Jimmi - UNSIA")
        printLines.Add("Jl. Teknologi No. 123, Jakarta 12345")
        printLines.Add("Phone: (021) 1234-5678")
        printLines.Add(RepeatChar("-", 80))
        printLines.Add("")
        printLines.Add(AlignLeftRight("Invoice No: INV-2026-0001", "Date: " & DateTime.Now.ToString("dd/MM/yyyy"), 80))
        printLines.Add(AlignLeftRight("Customer:  PT.  TEKNOLOGI MAJU", "Terms: Net 30", 80))
        printLines.Add("")
        printLines.Add(RepeatChar("=", 80))

        printLines.Add(FormatColumns("No", "Item Description", "Qty", "Price", "Amount", 4, 35, 8, 15, 18))
        printLines.Add(RepeatChar("=", 80))

        printLines.Add(FormatColumns("1", "Laptop Dell XPS 13", "5", "15,000,000", "75,000,000", 4, 35, 8, 15, 18))
        printLines.Add(FormatColumns("2", "Mouse Logitech", "10", "1,200,000", "12,000,000", 4, 35, 8, 15, 18))
        printLines.Add(FormatColumns("3", "Keyboard RGB", "8", "850,000", "6,800,000", 4, 35, 8, 15, 18))

        printLines.Add(RepeatChar("-", 80))
        printLines.Add(AlignRight("Subtotal: Rp  94,600,000", 80))
        printLines.Add(AlignRight("Tax (11%): Rp  10,406,000", 80))
        printLines.Add(RepeatChar("-", 80))
        printLines.Add(AlignRight("TOTAL: Rp 105,006,000", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")
        printLines.Add("Payment:  Bank BCA 1234567890 A/N E-Business Corporation")
        printLines.Add("")
        printLines.Add(CenterText("Thank you for your business!", 80))
        printLines.Add(CenterText("Jimmi - UNSIA", 80))
    End Sub

    Private Sub GenerateProductListReport()
        printLines.Add(CenterText("PRODUCT CATALOG", 80))
        printLines.Add(CenterText("E-Business System - Jimmi (UNSIA)", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")
        printLines.Add("Generated:  " & DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"))
        printLines.Add("")
        printLines.Add(RepeatChar("-", 80))

        printLines.Add(FormatColumns("Code", "Product Name", "Category", "Stock", "Price", 10, 30, 15, 10, 15))
        printLines.Add(RepeatChar("-", 80))

        printLines.Add(FormatColumns("LAP001", "Dell XPS 13", "Laptops", "45", "15,000,000", 10, 30, 15, 10, 15))
        printLines.Add(FormatColumns("ACC001", "Logitech MX", "Accessories", "120", "1,200,000", 10, 30, 15, 10, 15))
        printLines.Add(FormatColumns("MON001", "Samsung 27", "Monitors", "67", "3,500,000", 10, 30, 15, 10, 15))
        printLines.Add(FormatColumns("AUD001", "Sony WH-1000XM4", "Audio", "78", "4,200,000", 10, 30, 15, 10, 15))

        printLines.Add(RepeatChar("-", 80))
        printLines.Add("Total Products: 4")
        printLines.Add("")
        printLines.Add(CenterText("Jimmi - UNSIA", 80))
    End Sub

    Private Sub GenerateSalesReport()
        printLines.Add(CenterText("MONTHLY SALES REPORT", 80))
        printLines.Add(CenterText("January 2026", 80))
        printLines.Add(CenterText("Developer: Jimmi - UNSIA", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")

        printLines.Add(FormatColumns("Date", "Invoice", "Customer", "Amount", 15, 20, 25, 20))
        printLines.Add(RepeatChar("-", 80))

        printLines.Add(FormatColumns("2026-01-15", "INV-001", "PT. Tech Maju", "75,000,000", 15, 20, 25, 20))
        printLines.Add(FormatColumns("2026-01-16", "INV-002", "CV. Digital", "45,000,000", 15, 20, 25, 20))
        printLines.Add(FormatColumns("2026-01-17", "INV-003", "UD. Komputer", "89,000,000", 15, 20, 25, 20))

        printLines.Add(RepeatChar("-", 80))
        printLines.Add(AlignRight("TOTAL SALES: Rp 209,000,000", 80))
        printLines.Add(RepeatChar("=", 80))
        printLines.Add("")
        printLines.Add(CenterText("Jimmi - UNSIA E-Business System", 80))
    End Sub

    ' ============================================
    ' TEXT ALIGNMENT FUNCTIONS
    ' ============================================

    Private Sub btnAlignLeft_Click(sender As Object, e As EventArgs) Handles btnAlignLeft.Click
        lblAlignmentDemo.Text = "LEFT ALIGNED TEXT - Jimmi UNSIA"
        lblAlignmentDemo.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub btnAlignCenter_Click(sender As Object, e As EventArgs) Handles btnAlignCenter.Click
        lblAlignmentDemo.Text = "CENTER ALIGNED - Jimmi UNSIA"
        lblAlignmentDemo.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub btnAlignRight_Click(sender As Object, e As EventArgs) Handles btnAlignRight.Click
        lblAlignmentDemo.Text = "RIGHT ALIGNED - Jimmi UNSIA"
        lblAlignmentDemo.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub btnAlignColumns_Click(sender As Object, e As EventArgs) Handles btnAlignColumns.Click
        Dim demo As String = FormatColumns("Product", "Qty", "Price", "Total", 20, 10, 20, 20)
        lblAlignmentDemo.Text = demo
        lblAlignmentDemo.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub btnCalculateText_Click(sender As Object, e As EventArgs) Handles btnCalculateText.Click
        Try
            Dim testText As String = "Jimmi - UNSIA E-Business System"
            Dim testFont As New Font("Arial", 12, FontStyle.Bold)

            ' Calculate text size
            Using g As Graphics = Me.CreateGraphics()
                Dim textSize As SizeF = g.MeasureString(testText, testFont)

                MessageBox.Show(
                    "TEXT SIZE CALCULATION" & vbCrLf &
                    "Developer: Jimmi - UNSIA" & vbCrLf &
                    "" & vbCrLf &
                    "Text: " & testText & vbCrLf &
                    "Font:  Arial, 12pt, Bold" & vbCrLf &
                    "" & vbCrLf &
                    "Width: " & textSize.Width.ToString("N2") & " pixels" & vbCrLf &
                    "Height:  " & textSize.Height.ToString("N2") & " pixels",
                    "Calculate Text Size")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Helper functions for text alignment
    Private Function CenterText(text As String, width As Integer) As String
        If text.Length >= width Then Return text
        Dim padding As Integer = (width - text.Length) \ 2
        Return Space(padding) & text
    End Function

    Private Function AlignRight(text As String, width As Integer) As String
        If text.Length >= width Then Return text
        Return Space(width - text.Length) & text
    End Function

    Private Function AlignLeftRight(leftText As String, rightText As String, width As Integer) As String
        Dim spaces As Integer = width - leftText.Length - rightText.Length
        If spaces < 0 Then spaces = 0
        Return leftText & Space(spaces) & rightText
    End Function

    Private Function RepeatChar(character As String, count As Integer) As String
        Return New String(character(0), count)
    End Function

    ' Format columns with specified widths
    Private Function FormatColumns(col1 As String, col2 As String, col3 As String, col4 As String,
                                   w1 As Integer, w2 As Integer, w3 As Integer, w4 As Integer) As String
        Return PadRight(col1, w1) & PadRight(col2, w2) & PadRight(col3, w3) & PadLeft(col4, w4)
    End Function

    Private Function FormatColumns(col1 As String, col2 As String, col3 As String, col4 As String, col5 As String,
                                   w1 As Integer, w2 As Integer, w3 As Integer, w4 As Integer, w5 As Integer) As String
        Return PadRight(col1, w1) & PadRight(col2, w2) & PadRight(col3, w3) & PadLeft(col4, w4) & PadLeft(col5, w5)
    End Function

    Private Function PadRight(text As String, width As Integer) As String
        If text.Length >= width Then Return text.Substring(0, width)
        Return text & Space(width - text.Length)
    End Function

    Private Function PadLeft(text As String, width As Integer) As String
        If text.Length >= width Then Return text.Substring(0, width)
        Return Space(width - text.Length) & text
    End Function

    ' ============================================
    ' PRINT DOCUMENT EVENT
    ' ============================================

    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Try
            Dim yPos As Single = e.MarginBounds.Top
            Dim leftMargin As Single = e.MarginBounds.Left
            Dim lineHeight As Single = bodyFont.GetHeight(e.Graphics)

            currentPage += 1

            ' Print header
            If chkPrintHeader.Checked Then
                e.Graphics.DrawString("E-BUSINESS SYSTEM - Jimmi (UNSIA)", headerFont, Brushes.Black, leftMargin, yPos)
                yPos += headerFont.GetHeight(e.Graphics) + 10
                e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos)
                yPos += 15
            End If

            ' Print date
            If chkPrintDate.Checked Then
                e.Graphics.DrawString(DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"), bodyFont, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight + 10
            End If

            ' Print body
            Dim linesPerPage As Integer = CInt((e.MarginBounds.Bottom - yPos - 50) / lineHeight)
            Dim linesPrinted As Integer = 0

            While currentLineIndex < printLines.Count AndAlso linesPrinted < linesPerPage
                e.Graphics.DrawString(printLines(currentLineIndex), bodyFont, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                currentLineIndex += 1
                linesPrinted += 1
            End While

            ' Print footer
            If chkPrintFooter.Checked Then
                yPos = e.MarginBounds.Bottom - 30
                e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos)
                yPos += 5

                e.Graphics.DrawString("Jimmi - UNSIA", footerFont, Brushes.Black, leftMargin, yPos)

                If chkPageNumbers.Checked Then
                    Dim pageText As String = "Page " & currentPage
                    Dim pageWidth As Single = e.Graphics.MeasureString(pageText, footerFont).Width
                    e.Graphics.DrawString(pageText, footerFont, Brushes.Black, e.MarginBounds.Right - pageWidth, yPos)
                End If
            End If

            ' Border
            If chkPrintBorder.Checked Then
                e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)
            End If

            ' Check if more pages
            e.HasMorePages = (currentLineIndex < printLines.Count)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            e.HasMorePages = False
        End Try
    End Sub

    Private Sub printDoc_BeginPrint(sender As Object, e As PrintEventArgs) Handles printDoc.BeginPrint
        currentLineIndex = 0
        currentPage = 0
    End Sub

End Class