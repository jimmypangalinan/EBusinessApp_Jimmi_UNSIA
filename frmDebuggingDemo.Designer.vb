<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebuggingDemo
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
        Me.nudValue1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudValue2 = New System.Windows.Forms.NumericUpDown()
        Me.btnWatchDemo = New System.Windows.Forms.Button()
        Me.lblWatchResult = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSimpleBreakpoint = New System.Windows.Forms.Button()
        Me.btnConditionalBreakpoint = New System.Windows.Forms.Button()
        Me.btnLoopBreakpoint = New System.Windows.Forms.Button()
        Me.lstBreakpointLog = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTryCatch = New System.Windows.Forms.Button()
        Me.btnSpecificException = New System.Windows.Forms.Button()
        Me.btnFinallyBlock = New System.Windows.Forms.Button()
        Me.btnCustomException = New System.Windows.Forms.Button()
        Me.txtExceptionLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudValue2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Controls.Add(Me.lblWatchResult)
        Me.GroupBox1.Controls.Add(Me.btnWatchDemo)
        Me.GroupBox1.Controls.Add(Me.nudValue2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nudValue1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Watch Window Demonstration - Jimmi UNSIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter two numbers:"
        '
        'nudValue1
        '
        Me.nudValue1.Location = New System.Drawing.Point(80, 62)
        Me.nudValue1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudValue1.Name = "nudValue1"
        Me.nudValue1.Size = New System.Drawing.Size(150, 20)
        Me.nudValue1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Value 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Value 2:"
        '
        'nudValue2
        '
        Me.nudValue2.Location = New System.Drawing.Point(320, 62)
        Me.nudValue2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudValue2.Name = "nudValue2"
        Me.nudValue2.Size = New System.Drawing.Size(150, 20)
        Me.nudValue2.TabIndex = 4
        Me.nudValue2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'btnWatchDemo
        '
        Me.btnWatchDemo.BackColor = System.Drawing.Color.Orange
        Me.btnWatchDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWatchDemo.Location = New System.Drawing.Point(10, 105)
        Me.btnWatchDemo.Name = "btnWatchDemo"
        Me.btnWatchDemo.Size = New System.Drawing.Size(850, 50)
        Me.btnWatchDemo.TabIndex = 5
        Me.btnWatchDemo.Text = "Calculate (SET BREAKPOINT & USE WATCH!)"
        Me.btnWatchDemo.UseVisualStyleBackColor = False
        '
        'lblWatchResult
        '
        Me.lblWatchResult.AutoSize = True
        Me.lblWatchResult.BackColor = System.Drawing.Color.White
        Me.lblWatchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWatchResult.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.lblWatchResult.Location = New System.Drawing.Point(10, 165)
        Me.lblWatchResult.Name = "lblWatchResult"
        Me.lblWatchResult.Size = New System.Drawing.Size(866, 19)
        Me.lblWatchResult.TabIndex = 6
        Me.lblWatchResult.Text = "Click button above.  Set BREAKPOINT (F9) in code, then use Watch Window (Debug → " &
    "Windows → Watch → Watch 1)"
        Me.lblWatchResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.lstBreakpointLog)
        Me.GroupBox2.Controls.Add(Me.btnLoopBreakpoint)
        Me.GroupBox2.Controls.Add(Me.btnConditionalBreakpoint)
        Me.GroupBox2.Controls.Add(Me.btnSimpleBreakpoint)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(870, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Breakpoints Demonstration"
        '
        'btnSimpleBreakpoint
        '
        Me.btnSimpleBreakpoint.BackColor = System.Drawing.Color.LightGreen
        Me.btnSimpleBreakpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpleBreakpoint.Location = New System.Drawing.Point(10, 30)
        Me.btnSimpleBreakpoint.Name = "btnSimpleBreakpoint"
        Me.btnSimpleBreakpoint.Size = New System.Drawing.Size(270, 50)
        Me.btnSimpleBreakpoint.TabIndex = 0
        Me.btnSimpleBreakpoint.Text = "Simple Breakpoint Demo"
        Me.btnSimpleBreakpoint.UseVisualStyleBackColor = False
        '
        'btnConditionalBreakpoint
        '
        Me.btnConditionalBreakpoint.BackColor = System.Drawing.Color.LightCoral
        Me.btnConditionalBreakpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConditionalBreakpoint.Location = New System.Drawing.Point(290, 30)
        Me.btnConditionalBreakpoint.Name = "btnConditionalBreakpoint"
        Me.btnConditionalBreakpoint.Size = New System.Drawing.Size(270, 50)
        Me.btnConditionalBreakpoint.TabIndex = 1
        Me.btnConditionalBreakpoint.Text = "Conditional Breakpoint Demo"
        Me.btnConditionalBreakpoint.UseVisualStyleBackColor = False
        '
        'btnLoopBreakpoint
        '
        Me.btnLoopBreakpoint.BackColor = System.Drawing.Color.LightCyan
        Me.btnLoopBreakpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoopBreakpoint.Location = New System.Drawing.Point(570, 30)
        Me.btnLoopBreakpoint.Name = "btnLoopBreakpoint"
        Me.btnLoopBreakpoint.Size = New System.Drawing.Size(290, 50)
        Me.btnLoopBreakpoint.TabIndex = 2
        Me.btnLoopBreakpoint.Text = "Loop Breakpoint Demo"
        Me.btnLoopBreakpoint.UseVisualStyleBackColor = False
        '
        'lstBreakpointLog
        '
        Me.lstBreakpointLog.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.lstBreakpointLog.FormattingEnabled = True
        Me.lstBreakpointLog.ItemHeight = 15
        Me.lstBreakpointLog.Location = New System.Drawing.Point(10, 90)
        Me.lstBreakpointLog.Name = "lstBreakpointLog"
        Me.lstBreakpointLog.Size = New System.Drawing.Size(850, 94)
        Me.lstBreakpointLog.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox3.Controls.Add(Me.txtExceptionLog)
        Me.GroupBox3.Controls.Add(Me.btnCustomException)
        Me.GroupBox3.Controls.Add(Me.btnFinallyBlock)
        Me.GroupBox3.Controls.Add(Me.btnSpecificException)
        Me.GroupBox3.Controls.Add(Me.btnTryCatch)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 450)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(870, 230)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exception Handling Examples - Jimmi UNSIA"
        '
        'btnTryCatch
        '
        Me.btnTryCatch.BackColor = System.Drawing.Color.LightGreen
        Me.btnTryCatch.Location = New System.Drawing.Point(10, 30)
        Me.btnTryCatch.Name = "btnTryCatch"
        Me.btnTryCatch.Size = New System.Drawing.Size(200, 40)
        Me.btnTryCatch.TabIndex = 0
        Me.btnTryCatch.Text = "Try-Catch Example"
        Me.btnTryCatch.UseVisualStyleBackColor = False
        '
        'btnSpecificException
        '
        Me.btnSpecificException.BackColor = System.Drawing.Color.LightYellow
        Me.btnSpecificException.Location = New System.Drawing.Point(220, 30)
        Me.btnSpecificException.Name = "btnSpecificException"
        Me.btnSpecificException.Size = New System.Drawing.Size(200, 40)
        Me.btnSpecificException.TabIndex = 1
        Me.btnSpecificException.Text = "Specific Exception Types"
        Me.btnSpecificException.UseVisualStyleBackColor = False
        '
        'btnFinallyBlock
        '
        Me.btnFinallyBlock.BackColor = System.Drawing.Color.LightBlue
        Me.btnFinallyBlock.Location = New System.Drawing.Point(430, 30)
        Me.btnFinallyBlock.Name = "btnFinallyBlock"
        Me.btnFinallyBlock.Size = New System.Drawing.Size(200, 40)
        Me.btnFinallyBlock.TabIndex = 2
        Me.btnFinallyBlock.Text = "Try-Catch-Finally"
        Me.btnFinallyBlock.UseVisualStyleBackColor = False
        '
        'btnCustomException
        '
        Me.btnCustomException.BackColor = System.Drawing.Color.Orange
        Me.btnCustomException.Location = New System.Drawing.Point(640, 30)
        Me.btnCustomException.Name = "btnCustomException"
        Me.btnCustomException.Size = New System.Drawing.Size(220, 40)
        Me.btnCustomException.TabIndex = 3
        Me.btnCustomException.Text = "Custom Error Handler"
        Me.btnCustomException.UseVisualStyleBackColor = False
        '
        'txtExceptionLog
        '
        Me.txtExceptionLog.BackColor = System.Drawing.Color.White
        Me.txtExceptionLog.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtExceptionLog.Location = New System.Drawing.Point(10, 80)
        Me.txtExceptionLog.Multiline = True
        Me.txtExceptionLog.Name = "txtExceptionLog"
        Me.txtExceptionLog.ReadOnly = True
        Me.txtExceptionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExceptionLog.Size = New System.Drawing.Size(850, 140)
        Me.txtExceptionLog.TabIndex = 4
        '
        'frmDebuggingDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 688)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDebuggingDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debugging Demo - Jimmi (UNSIA)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudValue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudValue2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nudValue1 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnWatchDemo As Button
    Friend WithEvents nudValue2 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWatchResult As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstBreakpointLog As ListBox
    Friend WithEvents btnLoopBreakpoint As Button
    Friend WithEvents btnConditionalBreakpoint As Button
    Friend WithEvents btnSimpleBreakpoint As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtExceptionLog As TextBox
    Friend WithEvents btnCustomException As Button
    Friend WithEvents btnFinallyBlock As Button
    Friend WithEvents btnSpecificException As Button
    Friend WithEvents btnTryCatch As Button
End Class
