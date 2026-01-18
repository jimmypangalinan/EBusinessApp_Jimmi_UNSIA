<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFunctionsDemo
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
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtByValOriginal = New System.Windows.Forms.TextBox()
        Me.btnTestByVal = New System.Windows.Forms.Button()
        Me.lblByValResult = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtByRefOriginal = New System.Windows.Forms.TextBox()
        Me.btnTestByRef = New System.Windows.Forms.Button()
        Me.lblByRefResult = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudQty = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudUnitPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudTaxRate = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCalcResult = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnFunctionString = New System.Windows.Forms.Button()
        Me.btnFunctionInteger = New System.Windows.Forms.Button()
        Me.btnFunctionDecimal = New System.Windows.Forms.Button()
        Me.btnFunctionBoolean = New System.Windows.Forms.Button()
        Me.lstFunctionResults = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnFindMax = New System.Windows.Forms.Button()
        Me.btnFindMin = New System.Windows.Forms.Button()
        Me.lstParamResults = New System.Windows.Forms.ListBox()
        Me.tabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.TabPage1)
        Me.tabMain.Controls.Add(Me.TabPage2)
        Me.tabMain.Controls.Add(Me.TabPage3)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(884, 678)
        Me.tabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblInfo)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(876, 652)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ByVal vs ByRef"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(876, 652)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Functions & Return"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(876, 652)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ParamArray"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.lblByValResult)
        Me.GroupBox1.Controls.Add(Me.btnTestByVal)
        Me.GroupBox1.Controls.Add(Me.txtByValOriginal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ByVal (Pass by VALUE) - Copy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Original Value:"
        '
        'txtByValOriginal
        '
        Me.txtByValOriginal.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtByValOriginal.Location = New System.Drawing.Point(120, 27)
        Me.txtByValOriginal.Name = "txtByValOriginal"
        Me.txtByValOriginal.Size = New System.Drawing.Size(270, 22)
        Me.txtByValOriginal.TabIndex = 1
        Me.txtByValOriginal.Text = "1000"
        '
        'btnTestByVal
        '
        Me.btnTestByVal.BackColor = System.Drawing.Color.Yellow
        Me.btnTestByVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestByVal.Location = New System.Drawing.Point(10, 70)
        Me.btnTestByVal.Name = "btnTestByVal"
        Me.btnTestByVal.Size = New System.Drawing.Size(370, 45)
        Me.btnTestByVal.TabIndex = 2
        Me.btnTestByVal.Text = "Test ByVal (Pass Copy)"
        Me.btnTestByVal.UseVisualStyleBackColor = False
        '
        'lblByValResult
        '
        Me.lblByValResult.BackColor = System.Drawing.Color.White
        Me.lblByValResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblByValResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblByValResult.Location = New System.Drawing.Point(10, 125)
        Me.lblByValResult.Name = "lblByValResult"
        Me.lblByValResult.Size = New System.Drawing.Size(370, 110)
        Me.lblByValResult.TabIndex = 3
        Me.lblByValResult.Text = "Click button to test..."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox2.Controls.Add(Me.lblByRefResult)
        Me.GroupBox2.Controls.Add(Me.btnTestByRef)
        Me.GroupBox2.Controls.Add(Me.txtByRefOriginal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(430, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " ByRef (Pass by REFERENCE) - Original"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Original Value:"
        '
        'txtByRefOriginal
        '
        Me.txtByRefOriginal.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtByRefOriginal.Location = New System.Drawing.Point(120, 27)
        Me.txtByRefOriginal.Name = "txtByRefOriginal"
        Me.txtByRefOriginal.Size = New System.Drawing.Size(270, 22)
        Me.txtByRefOriginal.TabIndex = 1
        Me.txtByRefOriginal.Text = "1000"
        '
        'btnTestByRef
        '
        Me.btnTestByRef.BackColor = System.Drawing.Color.Orange
        Me.btnTestByRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestByRef.Location = New System.Drawing.Point(10, 70)
        Me.btnTestByRef.Name = "btnTestByRef"
        Me.btnTestByRef.Size = New System.Drawing.Size(370, 45)
        Me.btnTestByRef.TabIndex = 2
        Me.btnTestByRef.Text = "Test ByRef (Pass Reference)"
        Me.btnTestByRef.UseVisualStyleBackColor = False
        '
        'lblByRefResult
        '
        Me.lblByRefResult.BackColor = System.Drawing.Color.White
        Me.lblByRefResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblByRefResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblByRefResult.Location = New System.Drawing.Point(10, 125)
        Me.lblByRefResult.Name = "lblByRefResult"
        Me.lblByRefResult.Size = New System.Drawing.Size(370, 110)
        Me.lblByRefResult.TabIndex = 3
        Me.lblByRefResult.Text = "Click button to test..."
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.LightYellow
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(10, 270)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(830, 300)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.Text = "Label3"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblCalcResult)
        Me.GroupBox3.Controls.Add(Me.btnCalculate)
        Me.GroupBox3.Controls.Add(Me.nudTaxRate)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.nudUnitPrice)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.nudQty)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 380)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " E-Business Price Calculator - Jimmi UNSIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Quantity:"
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(120, 27)
        Me.nudQty.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(280, 20)
        Me.nudQty.TabIndex = 1
        Me.nudQty.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Price/Unit:"
        '
        'nudUnitPrice
        '
        Me.nudUnitPrice.Location = New System.Drawing.Point(120, 62)
        Me.nudUnitPrice.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudUnitPrice.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudUnitPrice.Name = "nudUnitPrice"
        Me.nudUnitPrice.Size = New System.Drawing.Size(280, 20)
        Me.nudUnitPrice.TabIndex = 3
        Me.nudUnitPrice.ThousandsSeparator = True
        Me.nudUnitPrice.Value = New Decimal(New Integer() {500000, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tax Rate %:"
        '
        'nudTaxRate
        '
        Me.nudTaxRate.DecimalPlaces = 2
        Me.nudTaxRate.Location = New System.Drawing.Point(120, 97)
        Me.nudTaxRate.Name = "nudTaxRate"
        Me.nudTaxRate.Size = New System.Drawing.Size(280, 20)
        Me.nudTaxRate.TabIndex = 5
        Me.nudTaxRate.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightGreen
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(10, 145)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(390, 45)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Total (Using Functions)"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblCalcResult
        '
        Me.lblCalcResult.BackColor = System.Drawing.Color.White
        Me.lblCalcResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCalcResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcResult.Location = New System.Drawing.Point(10, 200)
        Me.lblCalcResult.Name = "lblCalcResult"
        Me.lblCalcResult.Size = New System.Drawing.Size(390, 170)
        Me.lblCalcResult.TabIndex = 7
        Me.lblCalcResult.Text = "Click Calculate..."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstFunctionResults)
        Me.GroupBox4.Controls.Add(Me.btnFunctionBoolean)
        Me.GroupBox4.Controls.Add(Me.btnFunctionDecimal)
        Me.GroupBox4.Controls.Add(Me.btnFunctionInteger)
        Me.GroupBox4.Controls.Add(Me.btnFunctionString)
        Me.GroupBox4.Location = New System.Drawing.Point(440, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(420, 380)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Function Return Types"
        '
        'btnFunctionString
        '
        Me.btnFunctionString.Location = New System.Drawing.Point(10, 30)
        Me.btnFunctionString.Name = "btnFunctionString"
        Me.btnFunctionString.Size = New System.Drawing.Size(390, 40)
        Me.btnFunctionString.TabIndex = 0
        Me.btnFunctionString.Text = "Function Returns STRING"
        Me.btnFunctionString.UseVisualStyleBackColor = True
        '
        'btnFunctionInteger
        '
        Me.btnFunctionInteger.Location = New System.Drawing.Point(10, 80)
        Me.btnFunctionInteger.Name = "btnFunctionInteger"
        Me.btnFunctionInteger.Size = New System.Drawing.Size(390, 40)
        Me.btnFunctionInteger.TabIndex = 1
        Me.btnFunctionInteger.Text = "Function Returns INTEGER"
        Me.btnFunctionInteger.UseVisualStyleBackColor = True
        '
        'btnFunctionDecimal
        '
        Me.btnFunctionDecimal.Location = New System.Drawing.Point(10, 130)
        Me.btnFunctionDecimal.Name = "btnFunctionDecimal"
        Me.btnFunctionDecimal.Size = New System.Drawing.Size(390, 40)
        Me.btnFunctionDecimal.TabIndex = 2
        Me.btnFunctionDecimal.Text = "Function Returns DECIMAL"
        Me.btnFunctionDecimal.UseVisualStyleBackColor = True
        '
        'btnFunctionBoolean
        '
        Me.btnFunctionBoolean.Location = New System.Drawing.Point(10, 180)
        Me.btnFunctionBoolean.Name = "btnFunctionBoolean"
        Me.btnFunctionBoolean.Size = New System.Drawing.Size(390, 40)
        Me.btnFunctionBoolean.TabIndex = 3
        Me.btnFunctionBoolean.Text = "Function Returns BOOLEAN"
        Me.btnFunctionBoolean.UseVisualStyleBackColor = True
        '
        'lstFunctionResults
        '
        Me.lstFunctionResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFunctionResults.FormattingEnabled = True
        Me.lstFunctionResults.ItemHeight = 15
        Me.lstFunctionResults.Location = New System.Drawing.Point(10, 230)
        Me.lstFunctionResults.Name = "lstFunctionResults"
        Me.lstFunctionResults.Size = New System.Drawing.Size(390, 139)
        Me.lstFunctionResults.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lstParamResults)
        Me.GroupBox5.Controls.Add(Me.btnFindMin)
        Me.GroupBox5.Controls.Add(Me.btnFindMax)
        Me.GroupBox5.Controls.Add(Me.btnAverage)
        Me.GroupBox5.Controls.Add(Me.btnSum)
        Me.GroupBox5.Controls.Add(Me.txtNumbers)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(845, 570)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ParamArray - Variable Parameters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Enter numbers (separated by commas):"
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(10, 55)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(820, 20)
        Me.txtNumbers.TabIndex = 1
        Me.txtNumbers.Text = "10, 20, 30, 40, 50, 60, 70, 80, 90, 100"
        '
        'btnSum
        '
        Me.btnSum.BackColor = System.Drawing.Color.LightBlue
        Me.btnSum.Location = New System.Drawing.Point(10, 95)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(200, 40)
        Me.btnSum.TabIndex = 2
        Me.btnSum.Text = "Sum All"
        Me.btnSum.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.LightGreen
        Me.btnAverage.Location = New System.Drawing.Point(220, 95)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(200, 40)
        Me.btnAverage.TabIndex = 3
        Me.btnAverage.Text = "Calculate Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'btnFindMax
        '
        Me.btnFindMax.BackColor = System.Drawing.Color.LightYellow
        Me.btnFindMax.Location = New System.Drawing.Point(430, 95)
        Me.btnFindMax.Name = "btnFindMax"
        Me.btnFindMax.Size = New System.Drawing.Size(200, 40)
        Me.btnFindMax.TabIndex = 4
        Me.btnFindMax.Text = "Find Maximum"
        Me.btnFindMax.UseVisualStyleBackColor = False
        '
        'btnFindMin
        '
        Me.btnFindMin.BackColor = System.Drawing.Color.LightCoral
        Me.btnFindMin.Location = New System.Drawing.Point(640, 95)
        Me.btnFindMin.Name = "btnFindMin"
        Me.btnFindMin.Size = New System.Drawing.Size(200, 40)
        Me.btnFindMin.TabIndex = 5
        Me.btnFindMin.Text = "Find Minimum"
        Me.btnFindMin.UseVisualStyleBackColor = False
        '
        'lstParamResults
        '
        Me.lstParamResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstParamResults.FormattingEnabled = True
        Me.lstParamResults.ItemHeight = 15
        Me.lstParamResults.Location = New System.Drawing.Point(10, 145)
        Me.lstParamResults.Name = "lstParamResults"
        Me.lstParamResults.Size = New System.Drawing.Size(820, 394)
        Me.lstParamResults.TabIndex = 6
        '
        'frmFunctionsDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 678)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmFunctionsDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Functions & Methods - Jimmi (UNSIA)"
        Me.tabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblByValResult As Label
    Friend WithEvents btnTestByVal As Button
    Friend WithEvents txtByValOriginal As TextBox
    Friend WithEvents lblByRefResult As Label
    Friend WithEvents btnTestByRef As Button
    Friend WithEvents txtByRefOriginal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents nudUnitPrice As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnFunctionString As Button
    Friend WithEvents lblCalcResult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents nudTaxRate As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents lstFunctionResults As ListBox
    Friend WithEvents btnFunctionBoolean As Button
    Friend WithEvents btnFunctionDecimal As Button
    Friend WithEvents btnFunctionInteger As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtNumbers As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lstParamResults As ListBox
    Friend WithEvents btnFindMin As Button
    Friend WithEvents btnFindMax As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnSum As Button
End Class
