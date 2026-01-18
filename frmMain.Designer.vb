<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemonstrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StringMethodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArraysCollectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlStatementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoopsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebuggingToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelHeader.SuspendLayout()
        Me.menuMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.Controls.Add(Me.lblDeveloper)
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 31)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1184, 80)
        Me.panelHeader.TabIndex = 1
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.Location = New System.Drawing.Point(25, 55)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(293, 17)
        Me.lblDeveloper.TabIndex = 1
        Me.lblDeveloper.Text = "Developer: Jimmi | UNSIA (Universitas Siber Asia)"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(800, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "E-BUSINESS SYSTEM - UNSIA"
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.DemonstrationsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(1184, 31)
        Me.menuMain.TabIndex = 2
        Me.menuMain.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.CustomersToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(115, 27)
        Me.MasterDataToolStripMenuItem.Text = "&Master Data"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.CustomersToolStripMenuItem.Text = "&Customers"
        '
        'DemonstrationsToolStripMenuItem
        '
        Me.DemonstrationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StringMethodsToolStripMenuItem, Me.DateTimeToolStripMenuItem, Me.ArraysCollectionsToolStripMenuItem, Me.ControlStatementsToolStripMenuItem, Me.LoopsToolStripMenuItem, Me.FunctionsToolStripMenuItem, Me.FileOperationsToolStripMenuItem, Me.PrintingToolStripMenuItem, Me.DebuggingToolsToolStripMenuItem})
        Me.DemonstrationsToolStripMenuItem.Name = "DemonstrationsToolStripMenuItem"
        Me.DemonstrationsToolStripMenuItem.Size = New System.Drawing.Size(143, 27)
        Me.DemonstrationsToolStripMenuItem.Text = "&Demonstrations"
        '
        'StringMethodsToolStripMenuItem
        '
        Me.StringMethodsToolStripMenuItem.Name = "StringMethodsToolStripMenuItem"
        Me.StringMethodsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.StringMethodsToolStripMenuItem.Text = "&String Methods"
        '
        'DateTimeToolStripMenuItem
        '
        Me.DateTimeToolStripMenuItem.Name = "DateTimeToolStripMenuItem"
        Me.DateTimeToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.DateTimeToolStripMenuItem.Text = "&Date && Time"
        '
        'ArraysCollectionsToolStripMenuItem
        '
        Me.ArraysCollectionsToolStripMenuItem.Name = "ArraysCollectionsToolStripMenuItem"
        Me.ArraysCollectionsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.ArraysCollectionsToolStripMenuItem.Text = "&Arrays && Collections"
        '
        'ControlStatementsToolStripMenuItem
        '
        Me.ControlStatementsToolStripMenuItem.Name = "ControlStatementsToolStripMenuItem"
        Me.ControlStatementsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.ControlStatementsToolStripMenuItem.Text = "&Control Statements"
        '
        'LoopsToolStripMenuItem
        '
        Me.LoopsToolStripMenuItem.Name = "LoopsToolStripMenuItem"
        Me.LoopsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.LoopsToolStripMenuItem.Text = "&Loops"
        '
        'FunctionsToolStripMenuItem
        '
        Me.FunctionsToolStripMenuItem.Name = "FunctionsToolStripMenuItem"
        Me.FunctionsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.FunctionsToolStripMenuItem.Text = "&Functions"
        '
        'FileOperationsToolStripMenuItem
        '
        Me.FileOperationsToolStripMenuItem.Name = "FileOperationsToolStripMenuItem"
        Me.FileOperationsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.FileOperationsToolStripMenuItem.Text = "&File Operations"
        '
        'PrintingToolStripMenuItem
        '
        Me.PrintingToolStripMenuItem.Name = "PrintingToolStripMenuItem"
        Me.PrintingToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.PrintingToolStripMenuItem.Text = "&Printing"
        '
        'DebuggingToolsToolStripMenuItem
        '
        Me.DebuggingToolsToolStripMenuItem.Name = "DebuggingToolsToolStripMenuItem"
        Me.DebuggingToolsToolStripMenuItem.Size = New System.Drawing.Size(234, 28)
        Me.DebuggingToolsToolStripMenuItem.Text = "Debugging Tools"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(69, 27)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblUser, Me.lblVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1184, 28)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 23)
        Me.lblStatus.Text = "Ready"
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(953, 23)
        Me.lblUser.Spring = True
        Me.lblUser.Text = "User: Jimmi"
        '
        'lblVersion
        '
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(160, 23)
        Me.lblVersion.Text = "Version 1.0 - UNSIA"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 658)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.menuMain)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(20, 25)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Business System - Jimmi (UNSIA)"
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemonstrationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StringMethodsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArraysCollectionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlStatementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoopsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunctionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileOperationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents lblVersion As ToolStripStatusLabel
    Friend WithEvents DebuggingToolsToolStripMenuItem As ToolStripMenuItem
End Class
