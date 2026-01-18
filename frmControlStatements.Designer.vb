<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControlStatements
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCategoryResult = New System.Windows.Forms.Label()
        Me.btnCheckCategory = New System.Windows.Forms.Button()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDiscountResult = New System.Windows.Forms.Label()
        Me.btnCalculateDiscount = New System.Windows.Forms.Button()
        Me.nudPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblStatusResult = New System.Windows.Forms.Label()
        Me.btnCheckStatus = New System.Windows.Forms.Button()
        Me.chkPremiumMember = New System.Windows.Forms.CheckBox()
        Me.nudMemberYears = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudTotalPurchase = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudMemberYears, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTotalPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCategoryResult)
        Me.GroupBox1.Controls.Add(Me.btnCheckCategory)
        Me.GroupBox1.Controls.Add(Me.txtProductCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 260)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Category Checker - Jimmi UNSIA"
        '
        'lblCategoryResult
        '
        Me.lblCategoryResult.BackColor = System.Drawing.Color.White
        Me.lblCategoryResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCategoryResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryResult.Location = New System.Drawing.Point(10, 115)
        Me.lblCategoryResult.Name = "lblCategoryResult"
        Me.lblCategoryResult.Size = New System.Drawing.Size(350, 130)
        Me.lblCategoryResult.TabIndex = 3
        Me.lblCategoryResult.Text = "Enter product code above..."
        '
        'btnCheckCategory
        '
        Me.btnCheckCategory.BackColor = System.Drawing.Color.LightBlue
        Me.btnCheckCategory.Location = New System.Drawing.Point(10, 65)
        Me.btnCheckCategory.Name = "btnCheckCategory"
        Me.btnCheckCategory.Size = New System.Drawing.Size(350, 40)
        Me.btnCheckCategory.TabIndex = 2
        Me.btnCheckCategory.Text = "Check Category (SELECT CASE)"
        Me.btnCheckCategory.UseVisualStyleBackColor = False
        '
        'txtProductCode
        '
        Me.txtProductCode.Location = New System.Drawing.Point(120, 27)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(240, 20)
        Me.txtProductCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDiscountResult)
        Me.GroupBox2.Controls.Add(Me.btnCalculateDiscount)
        Me.GroupBox2.Controls.Add(Me.nudPrice)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.nudQuantity)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discount Calculator - IF Statements"
        '
        'lblDiscountResult
        '
        Me.lblDiscountResult.BackColor = System.Drawing.Color.White
        Me.lblDiscountResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscountResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountResult.Location = New System.Drawing.Point(10, 155)
        Me.lblDiscountResult.Name = "lblDiscountResult"
        Me.lblDiscountResult.Size = New System.Drawing.Size(350, 120)
        Me.lblDiscountResult.TabIndex = 5
        Me.lblDiscountResult.Text = "Enter quantity and price..."
        '
        'btnCalculateDiscount
        '
        Me.btnCalculateDiscount.BackColor = System.Drawing.Color.LightGreen
        Me.btnCalculateDiscount.Location = New System.Drawing.Point(10, 105)
        Me.btnCalculateDiscount.Name = "btnCalculateDiscount"
        Me.btnCalculateDiscount.Size = New System.Drawing.Size(350, 40)
        Me.btnCalculateDiscount.TabIndex = 4
        Me.btnCalculateDiscount.Text = "Calculate Discount (IF-ELSEIF)"
        Me.btnCalculateDiscount.UseVisualStyleBackColor = False
        '
        'nudPrice
        '
        Me.nudPrice.Location = New System.Drawing.Point(120, 62)
        Me.nudPrice.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudPrice.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPrice.Name = "nudPrice"
        Me.nudPrice.Size = New System.Drawing.Size(240, 20)
        Me.nudPrice.TabIndex = 3
        Me.nudPrice.ThousandsSeparator = True
        Me.nudPrice.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price/Unit:"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(120, 27)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(240, 20)
        Me.nudQuantity.TabIndex = 1
        Me.nudQuantity.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Quantity:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblStatusResult)
        Me.GroupBox3.Controls.Add(Me.btnCheckStatus)
        Me.GroupBox3.Controls.Add(Me.chkPremiumMember)
        Me.GroupBox3.Controls.Add(Me.nudMemberYears)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.nudTotalPurchase)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(400, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(380, 560)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Status Checker"
        '
        'lblStatusResult
        '
        Me.lblStatusResult.BackColor = System.Drawing.Color.White
        Me.lblStatusResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatusResult.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusResult.Location = New System.Drawing.Point(10, 190)
        Me.lblStatusResult.Name = "lblStatusResult"
        Me.lblStatusResult.Size = New System.Drawing.Size(350, 360)
        Me.lblStatusResult.TabIndex = 6
        Me.lblStatusResult.Text = "Click button to check status..."
        '
        'btnCheckStatus
        '
        Me.btnCheckStatus.BackColor = System.Drawing.Color.Orange
        Me.btnCheckStatus.Location = New System.Drawing.Point(10, 140)
        Me.btnCheckStatus.Name = "btnCheckStatus"
        Me.btnCheckStatus.Size = New System.Drawing.Size(350, 40)
        Me.btnCheckStatus.TabIndex = 5
        Me.btnCheckStatus.Text = "Check Customer Status (NESTED IF)"
        Me.btnCheckStatus.UseVisualStyleBackColor = False
        '
        'chkPremiumMember
        '
        Me.chkPremiumMember.AutoSize = True
        Me.chkPremiumMember.Location = New System.Drawing.Point(10, 100)
        Me.chkPremiumMember.Name = "chkPremiumMember"
        Me.chkPremiumMember.Size = New System.Drawing.Size(107, 17)
        Me.chkPremiumMember.TabIndex = 4
        Me.chkPremiumMember.Text = "Premium Member"
        Me.chkPremiumMember.UseVisualStyleBackColor = True
        '
        'nudMemberYears
        '
        Me.nudMemberYears.Location = New System.Drawing.Point(130, 62)
        Me.nudMemberYears.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudMemberYears.Name = "nudMemberYears"
        Me.nudMemberYears.Size = New System.Drawing.Size(230, 20)
        Me.nudMemberYears.TabIndex = 3
        Me.nudMemberYears.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Member Since (years):"
        '
        'nudTotalPurchase
        '
        Me.nudTotalPurchase.Location = New System.Drawing.Point(130, 27)
        Me.nudTotalPurchase.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudTotalPurchase.Name = "nudTotalPurchase"
        Me.nudTotalPurchase.Size = New System.Drawing.Size(230, 20)
        Me.nudTotalPurchase.TabIndex = 1
        Me.nudTotalPurchase.ThousandsSeparator = True
        Me.nudTotalPurchase.Value = New Decimal(New Integer() {50000000, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Purchase:"
        '
        'frmControlStatements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 578)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmControlStatements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control Statements - Jimmi (UNSIA)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudMemberYears, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTotalPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCategoryResult As Label
    Friend WithEvents btnCheckCategory As Button
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDiscountResult As Label
    Friend WithEvents btnCalculateDiscount As Button
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudTotalPurchase As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatusResult As Label
    Friend WithEvents btnCheckStatus As Button
    Friend WithEvents chkPremiumMember As CheckBox
    Friend WithEvents nudMemberYears As NumericUpDown
End Class
