<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringDemo
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUpper = New System.Windows.Forms.Button()
        Me.btnLower = New System.Windows.Forms.Button()
        Me.btnLength = New System.Windows.Forms.Button()
        Me.btnSubstring = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnTrim)
        Me.GroupBox1.Controls.Add(Me.btnReplace)
        Me.GroupBox1.Controls.Add(Me.btnSubstring)
        Me.GroupBox1.Controls.Add(Me.btnLength)
        Me.GroupBox1.Controls.Add(Me.btnLower)
        Me.GroupBox1.Controls.Add(Me.btnUpper)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 380)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "String Operations - Jimmi UNSIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Text:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(100, 27)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(340, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnUpper
        '
        Me.btnUpper.Location = New System.Drawing.Point(10, 70)
        Me.btnUpper.Name = "btnUpper"
        Me.btnUpper.Size = New System.Drawing.Size(140, 35)
        Me.btnUpper.TabIndex = 2
        Me.btnUpper.Text = "UPPER CASE"
        Me.btnUpper.UseVisualStyleBackColor = True
        '
        'btnLower
        '
        Me.btnLower.Location = New System.Drawing.Point(160, 70)
        Me.btnLower.Name = "btnLower"
        Me.btnLower.Size = New System.Drawing.Size(140, 35)
        Me.btnLower.TabIndex = 3
        Me.btnLower.Text = "lower case"
        Me.btnLower.UseVisualStyleBackColor = True
        '
        'btnLength
        '
        Me.btnLength.Location = New System.Drawing.Point(310, 70)
        Me.btnLength.Name = "btnLength"
        Me.btnLength.Size = New System.Drawing.Size(140, 35)
        Me.btnLength.TabIndex = 4
        Me.btnLength.Text = "Get Length"
        Me.btnLength.UseVisualStyleBackColor = True
        '
        'btnSubstring
        '
        Me.btnSubstring.Location = New System.Drawing.Point(10, 115)
        Me.btnSubstring.Name = "btnSubstring"
        Me.btnSubstring.Size = New System.Drawing.Size(140, 35)
        Me.btnSubstring.TabIndex = 5
        Me.btnSubstring.Text = "Substring"
        Me.btnSubstring.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(160, 115)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(140, 35)
        Me.btnReplace.TabIndex = 6
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(310, 115)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(140, 35)
        Me.btnTrim.TabIndex = 7
        Me.btnTrim.Text = "Trim Spaces"
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(10, 190)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(2, 18)
        Me.lblResult.TabIndex = 9
        '
        'frmStringDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 408)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStringDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Methods Demo - Jimmi (UNSIA)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLength As Button
    Friend WithEvents btnLower As Button
    Friend WithEvents btnUpper As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnTrim As Button
    Friend WithEvents btnReplace As Button
    Friend WithEvents btnSubstring As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
End Class
