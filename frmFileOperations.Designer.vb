<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileOperations
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
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowseFile = New System.Windows.Forms.Button()
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.btnWriteFile = New System.Windows.Forms.Button()
        Me.btnReadFile = New System.Windows.Forms.Button()
        Me.btnAppendFile = New System.Windows.Forms.Button()
        Me.btnDeleteFile = New System.Windows.Forms.Button()
        Me.btnFileInfo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileContent = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFileResults = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDirPath = New System.Windows.Forms.TextBox()
        Me.btnBrowseDir = New System.Windows.Forms.Button()
        Me.btnCreateDir = New System.Windows.Forms.Button()
        Me.btnDeleteDir = New System.Windows.Forms.Button()
        Me.btnListFiles = New System.Windows.Forms.Button()
        Me.btnDirInfo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchPattern = New System.Windows.Forms.TextBox()
        Me.btnSearchFiles = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstDirectoryResults = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnMyComputer = New System.Windows.Forms.Button()
        Me.btnMyApplication = New System.Windows.Forms.Button()
        Me.btnMyUser = New System.Windows.Forms.Button()
        Me.btnMySettings = New System.Windows.Forms.Button()
        Me.btnMyForms = New System.Windows.Forms.Button()
        Me.btnMyResources = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtMyNamespaceInfo = New System.Windows.Forms.TextBox()
        Me.tabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(884, 658)
        Me.tabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(876, 632)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File Operations"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(876, 632)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Directory Operations"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(876, 632)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "My Namespace"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFileContent)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnFileInfo)
        Me.GroupBox1.Controls.Add(Me.btnDeleteFile)
        Me.GroupBox1.Controls.Add(Me.btnAppendFile)
        Me.GroupBox1.Controls.Add(Me.btnReadFile)
        Me.GroupBox1.Controls.Add(Me.btnWriteFile)
        Me.GroupBox1.Controls.Add(Me.btnCreateFile)
        Me.GroupBox1.Controls.Add(Me.btnBrowseFile)
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Management - Jimmi UNSIA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Path:"
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(80, 27)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(650, 20)
        Me.txtFilePath.TabIndex = 1
        Me.txtFilePath.Text = "C:\Temp\TestFile_Jimmi_UNSIA.txt"
        '
        'btnBrowseFile
        '
        Me.btnBrowseFile.Location = New System.Drawing.Point(740, 27)
        Me.btnBrowseFile.Name = "btnBrowseFile"
        Me.btnBrowseFile.Size = New System.Drawing.Size(90, 25)
        Me.btnBrowseFile.TabIndex = 2
        Me.btnBrowseFile.Text = "Browse..."
        Me.btnBrowseFile.UseVisualStyleBackColor = True
        '
        'btnCreateFile
        '
        Me.btnCreateFile.BackColor = System.Drawing.Color.LightGreen
        Me.btnCreateFile.Location = New System.Drawing.Point(10, 70)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(130, 35)
        Me.btnCreateFile.TabIndex = 3
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = False
        '
        'btnWriteFile
        '
        Me.btnWriteFile.BackColor = System.Drawing.Color.LightBlue
        Me.btnWriteFile.Location = New System.Drawing.Point(150, 70)
        Me.btnWriteFile.Name = "btnWriteFile"
        Me.btnWriteFile.Size = New System.Drawing.Size(130, 35)
        Me.btnWriteFile.TabIndex = 4
        Me.btnWriteFile.Text = "Write to File"
        Me.btnWriteFile.UseVisualStyleBackColor = False
        '
        'btnReadFile
        '
        Me.btnReadFile.BackColor = System.Drawing.Color.LightYellow
        Me.btnReadFile.Location = New System.Drawing.Point(290, 70)
        Me.btnReadFile.Name = "btnReadFile"
        Me.btnReadFile.Size = New System.Drawing.Size(130, 35)
        Me.btnReadFile.TabIndex = 5
        Me.btnReadFile.Text = "Read File"
        Me.btnReadFile.UseVisualStyleBackColor = False
        '
        'btnAppendFile
        '
        Me.btnAppendFile.BackColor = System.Drawing.Color.LightCyan
        Me.btnAppendFile.Location = New System.Drawing.Point(430, 70)
        Me.btnAppendFile.Name = "btnAppendFile"
        Me.btnAppendFile.Size = New System.Drawing.Size(130, 35)
        Me.btnAppendFile.TabIndex = 6
        Me.btnAppendFile.Text = "Append to File"
        Me.btnAppendFile.UseVisualStyleBackColor = False
        '
        'btnDeleteFile
        '
        Me.btnDeleteFile.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteFile.Location = New System.Drawing.Point(570, 70)
        Me.btnDeleteFile.Name = "btnDeleteFile"
        Me.btnDeleteFile.Size = New System.Drawing.Size(130, 35)
        Me.btnDeleteFile.TabIndex = 7
        Me.btnDeleteFile.Text = "Delete File"
        Me.btnDeleteFile.UseVisualStyleBackColor = False
        '
        'btnFileInfo
        '
        Me.btnFileInfo.BackColor = System.Drawing.Color.Orange
        Me.btnFileInfo.Location = New System.Drawing.Point(710, 70)
        Me.btnFileInfo.Name = "btnFileInfo"
        Me.btnFileInfo.Size = New System.Drawing.Size(130, 35)
        Me.btnFileInfo.TabIndex = 8
        Me.btnFileInfo.Text = "File Info (Dates/Times)"
        Me.btnFileInfo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "File Content:"
        '
        'txtFileContent
        '
        Me.txtFileContent.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileContent.Location = New System.Drawing.Point(10, 140)
        Me.txtFileContent.Multiline = True
        Me.txtFileContent.Name = "txtFileContent"
        Me.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileContent.Size = New System.Drawing.Size(820, 130)
        Me.txtFileContent.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFileResults)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(850, 270)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results / Information"
        '
        'txtFileResults
        '
        Me.txtFileResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileResults.Location = New System.Drawing.Point(10, 25)
        Me.txtFileResults.Multiline = True
        Me.txtFileResults.Name = "txtFileResults"
        Me.txtFileResults.ReadOnly = True
        Me.txtFileResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFileResults.Size = New System.Drawing.Size(820, 245)
        Me.txtFileResults.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSearchFiles)
        Me.GroupBox3.Controls.Add(Me.txtSearchPattern)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnDirInfo)
        Me.GroupBox3.Controls.Add(Me.btnListFiles)
        Me.GroupBox3.Controls.Add(Me.btnDeleteDir)
        Me.GroupBox3.Controls.Add(Me.btnCreateDir)
        Me.GroupBox3.Controls.Add(Me.btnBrowseDir)
        Me.GroupBox3.Controls.Add(Me.txtDirPath)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(850, 200)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Directory Management"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Directory Path:"
        '
        'txtDirPath
        '
        Me.txtDirPath.Location = New System.Drawing.Point(110, 27)
        Me.txtDirPath.Name = "txtDirPath"
        Me.txtDirPath.Size = New System.Drawing.Size(620, 20)
        Me.txtDirPath.TabIndex = 1
        Me.txtDirPath.Text = "C:\Temp\TestDir_Jimmi_UNSIA"
        '
        'btnBrowseDir
        '
        Me.btnBrowseDir.Location = New System.Drawing.Point(740, 27)
        Me.btnBrowseDir.Name = "btnBrowseDir"
        Me.btnBrowseDir.Size = New System.Drawing.Size(90, 25)
        Me.btnBrowseDir.TabIndex = 2
        Me.btnBrowseDir.Text = "Browse..."
        Me.btnBrowseDir.UseVisualStyleBackColor = True
        '
        'btnCreateDir
        '
        Me.btnCreateDir.BackColor = System.Drawing.Color.LightGreen
        Me.btnCreateDir.Location = New System.Drawing.Point(10, 70)
        Me.btnCreateDir.Name = "btnCreateDir"
        Me.btnCreateDir.Size = New System.Drawing.Size(200, 40)
        Me.btnCreateDir.TabIndex = 3
        Me.btnCreateDir.Text = "Create Directory"
        Me.btnCreateDir.UseVisualStyleBackColor = False
        '
        'btnDeleteDir
        '
        Me.btnDeleteDir.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteDir.Location = New System.Drawing.Point(220, 70)
        Me.btnDeleteDir.Name = "btnDeleteDir"
        Me.btnDeleteDir.Size = New System.Drawing.Size(200, 40)
        Me.btnDeleteDir.TabIndex = 4
        Me.btnDeleteDir.Text = "Delete Directory"
        Me.btnDeleteDir.UseVisualStyleBackColor = False
        '
        'btnListFiles
        '
        Me.btnListFiles.BackColor = System.Drawing.Color.LightBlue
        Me.btnListFiles.Location = New System.Drawing.Point(430, 70)
        Me.btnListFiles.Name = "btnListFiles"
        Me.btnListFiles.Size = New System.Drawing.Size(200, 40)
        Me.btnListFiles.TabIndex = 5
        Me.btnListFiles.Text = "List Files & Folders"
        Me.btnListFiles.UseVisualStyleBackColor = False
        '
        'btnDirInfo
        '
        Me.btnDirInfo.BackColor = System.Drawing.Color.LightYellow
        Me.btnDirInfo.Location = New System.Drawing.Point(640, 70)
        Me.btnDirInfo.Name = "btnDirInfo"
        Me.btnDirInfo.Size = New System.Drawing.Size(190, 40)
        Me.btnDirInfo.TabIndex = 6
        Me.btnDirInfo.Text = "Directory Info"
        Me.btnDirInfo.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search Pattern:"
        '
        'txtSearchPattern
        '
        Me.txtSearchPattern.Location = New System.Drawing.Point(120, 122)
        Me.txtSearchPattern.Name = "txtSearchPattern"
        Me.txtSearchPattern.Size = New System.Drawing.Size(200, 20)
        Me.txtSearchPattern.TabIndex = 8
        Me.txtSearchPattern.Text = "*.*"
        '
        'btnSearchFiles
        '
        Me.btnSearchFiles.Location = New System.Drawing.Point(330, 122)
        Me.btnSearchFiles.Name = "btnSearchFiles"
        Me.btnSearchFiles.Size = New System.Drawing.Size(120, 25)
        Me.btnSearchFiles.TabIndex = 9
        Me.btnSearchFiles.Text = "Search Files"
        Me.btnSearchFiles.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox4.Controls.Add(Me.lstDirectoryResults)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 220)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(850, 360)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Files & Directories List"
        '
        'lstDirectoryResults
        '
        Me.lstDirectoryResults.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDirectoryResults.FormattingEnabled = True
        Me.lstDirectoryResults.ItemHeight = 15
        Me.lstDirectoryResults.Location = New System.Drawing.Point(10, 25)
        Me.lstDirectoryResults.Name = "lstDirectoryResults"
        Me.lstDirectoryResults.Size = New System.Drawing.Size(820, 319)
        Me.lstDirectoryResults.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnMyResources)
        Me.GroupBox5.Controls.Add(Me.btnMyForms)
        Me.GroupBox5.Controls.Add(Me.btnMySettings)
        Me.GroupBox5.Controls.Add(Me.btnMyUser)
        Me.GroupBox5.Controls.Add(Me.btnMyApplication)
        Me.GroupBox5.Controls.Add(Me.btnMyComputer)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(850, 120)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "My Namespace Demonstrations - Jimmi UNSIA"
        '
        'btnMyComputer
        '
        Me.btnMyComputer.BackColor = System.Drawing.Color.LightBlue
        Me.btnMyComputer.Location = New System.Drawing.Point(10, 30)
        Me.btnMyComputer.Name = "btnMyComputer"
        Me.btnMyComputer.Size = New System.Drawing.Size(200, 40)
        Me.btnMyComputer.TabIndex = 0
        Me.btnMyComputer.Text = "My.Computer"
        Me.btnMyComputer.UseVisualStyleBackColor = False
        '
        'btnMyApplication
        '
        Me.btnMyApplication.BackColor = System.Drawing.Color.LightGreen
        Me.btnMyApplication.Location = New System.Drawing.Point(220, 30)
        Me.btnMyApplication.Name = "btnMyApplication"
        Me.btnMyApplication.Size = New System.Drawing.Size(200, 40)
        Me.btnMyApplication.TabIndex = 1
        Me.btnMyApplication.Text = "My.Application"
        Me.btnMyApplication.UseVisualStyleBackColor = False
        '
        'btnMyUser
        '
        Me.btnMyUser.BackColor = System.Drawing.Color.LightYellow
        Me.btnMyUser.Location = New System.Drawing.Point(430, 30)
        Me.btnMyUser.Name = "btnMyUser"
        Me.btnMyUser.Size = New System.Drawing.Size(200, 40)
        Me.btnMyUser.TabIndex = 2
        Me.btnMyUser.Text = "My.User"
        Me.btnMyUser.UseVisualStyleBackColor = False
        '
        'btnMySettings
        '
        Me.btnMySettings.BackColor = System.Drawing.Color.LightCoral
        Me.btnMySettings.Location = New System.Drawing.Point(640, 30)
        Me.btnMySettings.Name = "btnMySettings"
        Me.btnMySettings.Size = New System.Drawing.Size(190, 40)
        Me.btnMySettings.TabIndex = 3
        Me.btnMySettings.Text = "My.Settings Info"
        Me.btnMySettings.UseVisualStyleBackColor = False
        '
        'btnMyForms
        '
        Me.btnMyForms.Location = New System.Drawing.Point(10, 80)
        Me.btnMyForms.Name = "btnMyForms"
        Me.btnMyForms.Size = New System.Drawing.Size(200, 30)
        Me.btnMyForms.TabIndex = 4
        Me.btnMyForms.Text = "My.Forms"
        Me.btnMyForms.UseVisualStyleBackColor = True
        '
        'btnMyResources
        '
        Me.btnMyResources.Location = New System.Drawing.Point(220, 80)
        Me.btnMyResources.Name = "btnMyResources"
        Me.btnMyResources.Size = New System.Drawing.Size(200, 30)
        Me.btnMyResources.TabIndex = 5
        Me.btnMyResources.Text = "My.Resources"
        Me.btnMyResources.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtMyNamespaceInfo)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 140)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(850, 140)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Information Display"
        '
        'txtMyNamespaceInfo
        '
        Me.txtMyNamespaceInfo.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyNamespaceInfo.Location = New System.Drawing.Point(10, 25)
        Me.txtMyNamespaceInfo.Multiline = True
        Me.txtMyNamespaceInfo.Name = "txtMyNamespaceInfo"
        Me.txtMyNamespaceInfo.ReadOnly = True
        Me.txtMyNamespaceInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMyNamespaceInfo.Size = New System.Drawing.Size(820, 405)
        Me.txtMyNamespaceInfo.TabIndex = 0
        '
        'frmFileOperations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 658)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmFileOperations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Operations - Jimmi (UNSIA)"
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
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCreateFile As Button
    Friend WithEvents btnBrowseFile As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFileInfo As Button
    Friend WithEvents btnDeleteFile As Button
    Friend WithEvents btnAppendFile As Button
    Friend WithEvents btnReadFile As Button
    Friend WithEvents btnWriteFile As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtFileResults As TextBox
    Friend WithEvents txtFileContent As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBrowseDir As Button
    Friend WithEvents txtDirPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearchFiles As Button
    Friend WithEvents txtSearchPattern As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDirInfo As Button
    Friend WithEvents btnListFiles As Button
    Friend WithEvents btnDeleteDir As Button
    Friend WithEvents btnCreateDir As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lstDirectoryResults As ListBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnMyApplication As Button
    Friend WithEvents btnMyComputer As Button
    Friend WithEvents btnMyUser As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtMyNamespaceInfo As TextBox
    Friend WithEvents btnMyResources As Button
    Friend WithEvents btnMyForms As Button
    Friend WithEvents btnMySettings As Button
End Class
