<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintingDemo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintingDemo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.btnPageSetup = New System.Windows.Forms.Button()
        Me.btnPrinterSetup = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.chkPrintHeader = New System.Windows.Forms.CheckBox()
        Me.chkPrintFooter = New System.Windows.Forms.CheckBox()
        Me.chkPageNumbers = New System.Windows.Forms.CheckBox()
        Me.chkPrintBorder = New System.Windows.Forms.CheckBox()
        Me.chkPrintDate = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbSimpleReport = New System.Windows.Forms.RadioButton()
        Me.rbInvoice = New System.Windows.Forms.RadioButton()
        Me.rbProductList = New System.Windows.Forms.RadioButton()
        Me.rbSalesReport = New System.Windows.Forms.RadioButton()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAlignLeft = New System.Windows.Forms.Button()
        Me.btnAlignCenter = New System.Windows.Forms.Button()
        Me.btnAlignRight = New System.Windows.Forms.Button()
        Me.btnAlignColumns = New System.Windows.Forms.Button()
        Me.btnCalculateText = New System.Windows.Forms.Button()
        Me.lblAlignmentDemo = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPreview = New System.Windows.Forms.TextBox()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.printPreviewDlg = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDlg = New System.Windows.Forms.PrintDialog()
        Me.pageSetupDlg = New System.Windows.Forms.PageSetupDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPrintDate)
        Me.GroupBox1.Controls.Add(Me.chkPrintBorder)
        Me.GroupBox1.Controls.Add(Me.chkPageNumbers)
        Me.GroupBox1.Controls.Add(Me.chkPrintFooter)
        Me.GroupBox1.Controls.Add(Me.chkPrintHeader)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnPrinterSetup)
        Me.GroupBox1.Controls.Add(Me.btnPageSetup)
        Me.GroupBox1.Controls.Add(Me.btnPrintPreview)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Print Configuration - Jimmi UNSIA"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.Color.LightBlue
        Me.btnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.Location = New System.Drawing.Point(10, 30)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(200, 40)
        Me.btnPrintPreview.TabIndex = 0
        Me.btnPrintPreview.Text = "Print Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'btnPageSetup
        '
        Me.btnPageSetup.BackColor = System.Drawing.Color.LightGreen
        Me.btnPageSetup.Location = New System.Drawing.Point(220, 30)
        Me.btnPageSetup.Name = "btnPageSetup"
        Me.btnPageSetup.Size = New System.Drawing.Size(200, 40)
        Me.btnPageSetup.TabIndex = 1
        Me.btnPageSetup.Text = "Page Setup"
        Me.btnPageSetup.UseVisualStyleBackColor = False
        '
        'btnPrinterSetup
        '
        Me.btnPrinterSetup.BackColor = System.Drawing.Color.LightYellow
        Me.btnPrinterSetup.Location = New System.Drawing.Point(430, 30)
        Me.btnPrinterSetup.Name = "btnPrinterSetup"
        Me.btnPrinterSetup.Size = New System.Drawing.Size(200, 40)
        Me.btnPrinterSetup.TabIndex = 2
        Me.btnPrinterSetup.Text = "Printer Setup"
        Me.btnPrinterSetup.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Orange
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(640, 30)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(210, 40)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print Document"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'chkPrintHeader
        '
        Me.chkPrintHeader.AutoSize = True
        Me.chkPrintHeader.Checked = True
        Me.chkPrintHeader.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintHeader.Location = New System.Drawing.Point(10, 85)
        Me.chkPrintHeader.Name = "chkPrintHeader"
        Me.chkPrintHeader.Size = New System.Drawing.Size(85, 17)
        Me.chkPrintHeader.TabIndex = 4
        Me.chkPrintHeader.Text = "Print Header"
        Me.chkPrintHeader.UseVisualStyleBackColor = True
        '
        'chkPrintFooter
        '
        Me.chkPrintFooter.AutoSize = True
        Me.chkPrintFooter.Checked = True
        Me.chkPrintFooter.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintFooter.Location = New System.Drawing.Point(150, 85)
        Me.chkPrintFooter.Name = "chkPrintFooter"
        Me.chkPrintFooter.Size = New System.Drawing.Size(80, 17)
        Me.chkPrintFooter.TabIndex = 5
        Me.chkPrintFooter.Text = "Print Footer"
        Me.chkPrintFooter.UseVisualStyleBackColor = True
        '
        'chkPageNumbers
        '
        Me.chkPageNumbers.AutoSize = True
        Me.chkPageNumbers.Checked = True
        Me.chkPageNumbers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPageNumbers.Location = New System.Drawing.Point(290, 85)
        Me.chkPageNumbers.Name = "chkPageNumbers"
        Me.chkPageNumbers.Size = New System.Drawing.Size(96, 17)
        Me.chkPageNumbers.TabIndex = 6
        Me.chkPageNumbers.Text = "Page Numbers"
        Me.chkPageNumbers.UseVisualStyleBackColor = True
        '
        'chkPrintBorder
        '
        Me.chkPrintBorder.AutoSize = True
        Me.chkPrintBorder.Checked = True
        Me.chkPrintBorder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintBorder.Location = New System.Drawing.Point(430, 85)
        Me.chkPrintBorder.Name = "chkPrintBorder"
        Me.chkPrintBorder.Size = New System.Drawing.Size(81, 17)
        Me.chkPrintBorder.TabIndex = 7
        Me.chkPrintBorder.Text = "Print Border"
        Me.chkPrintBorder.UseVisualStyleBackColor = True
        '
        'chkPrintDate
        '
        Me.chkPrintDate.AutoSize = True
        Me.chkPrintDate.Checked = True
        Me.chkPrintDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintDate.Location = New System.Drawing.Point(570, 85)
        Me.chkPrintDate.Name = "chkPrintDate"
        Me.chkPrintDate.Size = New System.Drawing.Size(101, 17)
        Me.chkPrintDate.TabIndex = 8
        Me.chkPrintDate.Text = "Print Date/Time"
        Me.chkPrintDate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGenerateReport)
        Me.GroupBox2.Controls.Add(Me.rbSalesReport)
        Me.GroupBox2.Controls.Add(Me.rbProductList)
        Me.GroupBox2.Controls.Add(Me.rbInvoice)
        Me.GroupBox2.Controls.Add(Me.rbSimpleReport)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Report Type"
        '
        'rbSimpleReport
        '
        Me.rbSimpleReport.AutoSize = True
        Me.rbSimpleReport.Checked = True
        Me.rbSimpleReport.Location = New System.Drawing.Point(10, 30)
        Me.rbSimpleReport.Name = "rbSimpleReport"
        Me.rbSimpleReport.Size = New System.Drawing.Size(115, 17)
        Me.rbSimpleReport.TabIndex = 0
        Me.rbSimpleReport.TabStop = True
        Me.rbSimpleReport.Text = "Simple Text Report"
        Me.rbSimpleReport.UseVisualStyleBackColor = True
        '
        'rbInvoice
        '
        Me.rbInvoice.AutoSize = True
        Me.rbInvoice.Location = New System.Drawing.Point(10, 60)
        Me.rbInvoice.Name = "rbInvoice"
        Me.rbInvoice.Size = New System.Drawing.Size(95, 17)
        Me.rbInvoice.TabIndex = 1
        Me.rbInvoice.TabStop = True
        Me.rbInvoice.Text = "Invoice Report"
        Me.rbInvoice.UseVisualStyleBackColor = True
        '
        'rbProductList
        '
        Me.rbProductList.AutoSize = True
        Me.rbProductList.Location = New System.Drawing.Point(10, 90)
        Me.rbProductList.Name = "rbProductList"
        Me.rbProductList.Size = New System.Drawing.Size(116, 17)
        Me.rbProductList.TabIndex = 2
        Me.rbProductList.TabStop = True
        Me.rbProductList.Text = "Product List Report"
        Me.rbProductList.UseVisualStyleBackColor = True
        '
        'rbSalesReport
        '
        Me.rbSalesReport.AutoSize = True
        Me.rbSalesReport.Location = New System.Drawing.Point(10, 120)
        Me.rbSalesReport.Name = "rbSalesReport"
        Me.rbSalesReport.Size = New System.Drawing.Size(86, 17)
        Me.rbSalesReport.TabIndex = 3
        Me.rbSalesReport.TabStop = True
        Me.rbSalesReport.Text = "Sales Report"
        Me.rbSalesReport.UseVisualStyleBackColor = True
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.LightGreen
        Me.btnGenerateReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Location = New System.Drawing.Point(220, 30)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(180, 120)
        Me.btnGenerateReport.TabIndex = 4
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblAlignmentDemo)
        Me.GroupBox3.Controls.Add(Me.btnCalculateText)
        Me.GroupBox3.Controls.Add(Me.btnAlignColumns)
        Me.GroupBox3.Controls.Add(Me.btnAlignRight)
        Me.GroupBox3.Controls.Add(Me.btnAlignCenter)
        Me.GroupBox3.Controls.Add(Me.btnAlignLeft)
        Me.GroupBox3.Location = New System.Drawing.Point(440, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 180)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Text Alignment Examples"
        '
        'btnAlignLeft
        '
        Me.btnAlignLeft.Location = New System.Drawing.Point(10, 30)
        Me.btnAlignLeft.Name = "btnAlignLeft"
        Me.btnAlignLeft.Size = New System.Drawing.Size(130, 40)
        Me.btnAlignLeft.TabIndex = 0
        Me.btnAlignLeft.Text = "Left Align"
        Me.btnAlignLeft.UseVisualStyleBackColor = True
        '
        'btnAlignCenter
        '
        Me.btnAlignCenter.Location = New System.Drawing.Point(150, 30)
        Me.btnAlignCenter.Name = "btnAlignCenter"
        Me.btnAlignCenter.Size = New System.Drawing.Size(130, 40)
        Me.btnAlignCenter.TabIndex = 1
        Me.btnAlignCenter.Text = "Center Align"
        Me.btnAlignCenter.UseVisualStyleBackColor = True
        '
        'btnAlignRight
        '
        Me.btnAlignRight.Location = New System.Drawing.Point(290, 30)
        Me.btnAlignRight.Name = "btnAlignRight"
        Me.btnAlignRight.Size = New System.Drawing.Size(130, 40)
        Me.btnAlignRight.TabIndex = 2
        Me.btnAlignRight.Text = "Right Align"
        Me.btnAlignRight.UseVisualStyleBackColor = True
        '
        'btnAlignColumns
        '
        Me.btnAlignColumns.Location = New System.Drawing.Point(10, 80)
        Me.btnAlignColumns.Name = "btnAlignColumns"
        Me.btnAlignColumns.Size = New System.Drawing.Size(200, 40)
        Me.btnAlignColumns.TabIndex = 3
        Me.btnAlignColumns.Text = "Column Alignment"
        Me.btnAlignColumns.UseVisualStyleBackColor = True
        '
        'btnCalculateText
        '
        Me.btnCalculateText.Location = New System.Drawing.Point(220, 80)
        Me.btnCalculateText.Name = "btnCalculateText"
        Me.btnCalculateText.Size = New System.Drawing.Size(200, 40)
        Me.btnCalculateText.TabIndex = 4
        Me.btnCalculateText.Text = "Calculate Text Size"
        Me.btnCalculateText.UseVisualStyleBackColor = True
        '
        'lblAlignmentDemo
        '
        Me.lblAlignmentDemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlignmentDemo.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.lblAlignmentDemo.Location = New System.Drawing.Point(10, 130)
        Me.lblAlignmentDemo.Name = "lblAlignmentDemo"
        Me.lblAlignmentDemo.Size = New System.Drawing.Size(420, 40)
        Me.lblAlignmentDemo.TabIndex = 5
        Me.lblAlignmentDemo.Text = "Click buttons above to see alignment"
        Me.lblAlignmentDemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPreview)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(870, 320)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Document Preview"
        '
        'txtPreview
        '
        Me.txtPreview.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtPreview.Location = New System.Drawing.Point(10, 25)
        Me.txtPreview.Multiline = True
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.ReadOnly = True
        Me.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPreview.Size = New System.Drawing.Size(850, 285)
        Me.txtPreview.TabIndex = 0
        '
        'printPreviewDlg
        '
        Me.printPreviewDlg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDlg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDlg.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDlg.Enabled = True
        Me.printPreviewDlg.Icon = CType(resources.GetObject("printPreviewDlg.Icon"), System.Drawing.Icon)
        Me.printPreviewDlg.Name = "printPreviewDlg"
        Me.printPreviewDlg.Visible = False
        '
        'printDlg
        '
        Me.printDlg.UseEXDialog = True
        '
        'frmPrintingDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 698)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrintingDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing Demo - Jimmi (UNSIA)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPrinterSetup As Button
    Friend WithEvents btnPageSetup As Button
    Friend WithEvents btnPrintPreview As Button
    Friend WithEvents chkPrintDate As CheckBox
    Friend WithEvents chkPrintBorder As CheckBox
    Friend WithEvents chkPageNumbers As CheckBox
    Friend WithEvents chkPrintFooter As CheckBox
    Friend WithEvents chkPrintHeader As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbInvoice As RadioButton
    Friend WithEvents rbSimpleReport As RadioButton
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents rbSalesReport As RadioButton
    Friend WithEvents rbProductList As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAlignRight As Button
    Friend WithEvents btnAlignCenter As Button
    Friend WithEvents btnAlignLeft As Button
    Friend WithEvents lblAlignmentDemo As Label
    Friend WithEvents btnCalculateText As Button
    Friend WithEvents btnAlignColumns As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtPreview As TextBox
    Friend WithEvents printDoc As Printing.PrintDocument
    Friend WithEvents printPreviewDlg As PrintPreviewDialog
    Friend WithEvents printDlg As PrintDialog
    Friend WithEvents pageSetupDlg As PageSetupDialog
End Class
