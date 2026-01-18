<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTimeDemo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnAddDays = New System.Windows.Forms.Button()
        Me.btnFormat = New System.Windows.Forms.Button()
        Me.btnBusinessDays = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnShowCurrent = New System.Windows.Forms.Button()
        Me.btnTimeComponents = New System.Windows.Forms.Button()
        Me.txtCurrentInfo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtResults)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBusinessDays)
        Me.GroupBox1.Controls.Add(Me.btnFormat)
        Me.GroupBox1.Controls.Add(Me.btnAddDays)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date & Time Operations - Jimmi UNSIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date:"
        '
        'dtpStart
        '
        Me.dtpStart.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStart.Location = New System.Drawing.Point(100, 27)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(300, 20)
        Me.dtpStart.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End Date:"
        '
        'dtpEnd
        '
        Me.dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnd.Location = New System.Drawing.Point(100, 62)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(300, 20)
        Me.dtpEnd.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightBlue
        Me.btnCalculate.Location = New System.Drawing.Point(10, 110)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(190, 40)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Difference (TimeSpan)"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnAddDays
        '
        Me.btnAddDays.BackColor = System.Drawing.Color.LightGreen
        Me.btnAddDays.Location = New System.Drawing.Point(210, 110)
        Me.btnAddDays.Name = "btnAddDays"
        Me.btnAddDays.Size = New System.Drawing.Size(190, 40)
        Me.btnAddDays.TabIndex = 5
        Me.btnAddDays.Text = "Add 30 Days"
        Me.btnAddDays.UseVisualStyleBackColor = False
        '
        'btnFormat
        '
        Me.btnFormat.BackColor = System.Drawing.Color.LightYellow
        Me.btnFormat.Location = New System.Drawing.Point(410, 110)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(190, 40)
        Me.btnFormat.TabIndex = 6
        Me.btnFormat.Text = "Date Format Examples"
        Me.btnFormat.UseVisualStyleBackColor = False
        '
        'btnBusinessDays
        '
        Me.btnBusinessDays.BackColor = System.Drawing.Color.LightCoral
        Me.btnBusinessDays.Location = New System.Drawing.Point(610, 110)
        Me.btnBusinessDays.Name = "btnBusinessDays"
        Me.btnBusinessDays.Size = New System.Drawing.Size(140, 40)
        Me.btnBusinessDays.TabIndex = 7
        Me.btnBusinessDays.Text = "Calculate Business Days"
        Me.btnBusinessDays.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Results:"
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(10, 185)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(740, 55)
        Me.txtResults.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCurrentInfo)
        Me.GroupBox2.Controls.Add(Me.btnTimeComponents)
        Me.GroupBox2.Controls.Add(Me.btnShowCurrent)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 270)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 270)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Date & Time Information"
        '
        'btnShowCurrent
        '
        Me.btnShowCurrent.BackColor = System.Drawing.Color.Orange
        Me.btnShowCurrent.Location = New System.Drawing.Point(10, 30)
        Me.btnShowCurrent.Name = "btnShowCurrent"
        Me.btnShowCurrent.Size = New System.Drawing.Size(200, 40)
        Me.btnShowCurrent.TabIndex = 0
        Me.btnShowCurrent.Text = "Show Current Date/Time"
        Me.btnShowCurrent.UseVisualStyleBackColor = False
        '
        'btnTimeComponents
        '
        Me.btnTimeComponents.Location = New System.Drawing.Point(220, 30)
        Me.btnTimeComponents.Name = "btnTimeComponents"
        Me.btnTimeComponents.Size = New System.Drawing.Size(200, 40)
        Me.btnTimeComponents.TabIndex = 1
        Me.btnTimeComponents.Text = "Show Time Components"
        Me.btnTimeComponents.UseVisualStyleBackColor = True
        '
        'txtCurrentInfo
        '
        Me.txtCurrentInfo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentInfo.Location = New System.Drawing.Point(10, 80)
        Me.txtCurrentInfo.Multiline = True
        Me.txtCurrentInfo.Name = "txtCurrentInfo"
        Me.txtCurrentInfo.ReadOnly = True
        Me.txtCurrentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCurrentInfo.Size = New System.Drawing.Size(740, 180)
        Me.txtCurrentInfo.TabIndex = 2
        '
        'frmDateTimeDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 558)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDateTimeDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date & Time Demo - Jimmi (UNSIA)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBusinessDays As Button
    Friend WithEvents btnFormat As Button
    Friend WithEvents btnAddDays As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents txtCurrentInfo As TextBox
    Friend WithEvents btnTimeComponents As Button
    Friend WithEvents btnShowCurrent As Button
End Class
