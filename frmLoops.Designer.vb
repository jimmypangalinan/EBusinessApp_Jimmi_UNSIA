<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoops
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
        Me.lstForLoop = New System.Windows.Forms.ListBox()
        Me.btnForLoop = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstForEach = New System.Windows.Forms.ListBox()
        Me.btnForEach = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstWhile = New System.Windows.Forms.ListBox()
        Me.btnWhile = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstDo = New System.Windows.Forms.ListBox()
        Me.btnDo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnForLoop)
        Me.GroupBox1.Controls.Add(Me.lstForLoop)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 300)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FOR LOOP Demo"
        '
        'lstForLoop
        '
        Me.lstForLoop.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstForLoop.FormattingEnabled = True
        Me.lstForLoop.ItemHeight = 15
        Me.lstForLoop.Location = New System.Drawing.Point(10, 25)
        Me.lstForLoop.Name = "lstForLoop"
        Me.lstForLoop.Size = New System.Drawing.Size(410, 229)
        Me.lstForLoop.TabIndex = 0
        '
        'btnForLoop
        '
        Me.btnForLoop.Location = New System.Drawing.Point(10, 265)
        Me.btnForLoop.Name = "btnForLoop"
        Me.btnForLoop.Size = New System.Drawing.Size(410, 30)
        Me.btnForLoop.TabIndex = 1
        Me.btnForLoop.Text = "Run FOR Loop Examples"
        Me.btnForLoop.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnForEach)
        Me.GroupBox2.Controls.Add(Me.lstForEach)
        Me.GroupBox2.Location = New System.Drawing.Point(450, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 300)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FOR EACH LOOP Demo"
        '
        'lstForEach
        '
        Me.lstForEach.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstForEach.FormattingEnabled = True
        Me.lstForEach.ItemHeight = 15
        Me.lstForEach.Location = New System.Drawing.Point(10, 25)
        Me.lstForEach.Name = "lstForEach"
        Me.lstForEach.Size = New System.Drawing.Size(410, 229)
        Me.lstForEach.TabIndex = 0
        '
        'btnForEach
        '
        Me.btnForEach.BackColor = System.Drawing.Color.LightGreen
        Me.btnForEach.Location = New System.Drawing.Point(10, 265)
        Me.btnForEach.Name = "btnForEach"
        Me.btnForEach.Size = New System.Drawing.Size(410, 30)
        Me.btnForEach.TabIndex = 1
        Me.btnForEach.Text = "Run FOR EACH Loop Examples"
        Me.btnForEach.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnWhile)
        Me.GroupBox3.Controls.Add(Me.lstWhile)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 300)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "WHILE LOOP Demo"
        '
        'lstWhile
        '
        Me.lstWhile.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWhile.FormattingEnabled = True
        Me.lstWhile.ItemHeight = 15
        Me.lstWhile.Location = New System.Drawing.Point(10, 25)
        Me.lstWhile.Name = "lstWhile"
        Me.lstWhile.Size = New System.Drawing.Size(410, 229)
        Me.lstWhile.TabIndex = 0
        '
        'btnWhile
        '
        Me.btnWhile.BackColor = System.Drawing.Color.LightYellow
        Me.btnWhile.Location = New System.Drawing.Point(10, 265)
        Me.btnWhile.Name = "btnWhile"
        Me.btnWhile.Size = New System.Drawing.Size(410, 30)
        Me.btnWhile.TabIndex = 1
        Me.btnWhile.Text = "Run WHILE Loop Examples"
        Me.btnWhile.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDo)
        Me.GroupBox4.Controls.Add(Me.lstDo)
        Me.GroupBox4.Location = New System.Drawing.Point(450, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(430, 300)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DO LOOP Demo"
        '
        'lstDo
        '
        Me.lstDo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDo.FormattingEnabled = True
        Me.lstDo.ItemHeight = 15
        Me.lstDo.Location = New System.Drawing.Point(10, 25)
        Me.lstDo.Name = "lstDo"
        Me.lstDo.Size = New System.Drawing.Size(410, 229)
        Me.lstDo.TabIndex = 0
        '
        'btnDo
        '
        Me.btnDo.BackColor = System.Drawing.Color.LightCoral
        Me.btnDo.Location = New System.Drawing.Point(10, 265)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(410, 30)
        Me.btnDo.TabIndex = 1
        Me.btnDo.Text = "Run DO Loop Examples"
        Me.btnDo.UseVisualStyleBackColor = False
        '
        'frmLoops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 628)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLoops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loops Demo - Jimmi (UNSIA)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnForLoop As Button
    Friend WithEvents lstForLoop As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstForEach As ListBox
    Friend WithEvents btnForEach As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnWhile As Button
    Friend WithEvents lstWhile As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lstDo As ListBox
    Friend WithEvents btnDo As Button
End Class
