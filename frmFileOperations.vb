' ========================================
' FILE OPERATIONS & MY NAMESPACE
' Developer: Jimmi - UNSIA
' Demonstrates: Files, Directories, My Namespace
' ========================================

Imports System.IO

Public Class frmFileOperations

    Private Sub frmFileOperations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFileResults.Text = "Click buttons above to perform file operations" & vbCrLf & "Developer: Jimmi - UNSIA"
        lstDirectoryResults.Items.Add("Click buttons to see directory operations")
        txtMyNamespaceInfo.Text = "Click buttons to explore My Namespace" & vbCrLf & "Jimmi - UNSIA"
    End Sub

    ' ============================================
    ' FILE OPERATIONS
    ' ============================================

    ' BROWSE FILE
    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
        Try
            Using ofd As New OpenFileDialog()
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                ofd.Title = "Select File - Jimmi (UNSIA)"

                If ofd.ShowDialog() = DialogResult.OK Then
                    txtFilePath.Text = ofd.FileName
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' CREATE FILE
    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        Try
            Dim filePath As String = txtFilePath.Text

            ' Create directory if not exists
            Dim dirPath As String = Path.GetDirectoryName(filePath)
            If Not Directory.Exists(dirPath) Then
                Directory.CreateDirectory(dirPath)
            End If

            ' Create file with header
            Dim content As String =
                "========================================" & vbCrLf &
                "E-BUSINESS SYSTEM - FILE DEMO" & vbCrLf &
                "Developer: Jimmi - UNSIA" & vbCrLf &
                "Created: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf &
                "========================================" & vbCrLf &
                "" & vbCrLf &
                "This is a test file for file operations demo." & vbCrLf

            File.WriteAllText(filePath, content)

            txtFileResults.Text =
                "FILE CREATED SUCCESSFULLY!" & vbCrLf &
                "Path: " & filePath & vbCrLf &
                "Size: " & New FileInfo(filePath).Length & " bytes" & vbCrLf &
                "" & vbCrLf &
                "Developer: Jimmi - UNSIA"

            MessageBox.Show("File created successfully!", "Success")

        Catch ex As Exception
            txtFileResults.Text = "ERROR: " & ex.Message
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' WRITE TO FILE
    Private Sub btnWriteFile_Click(sender As Object, e As EventArgs) Handles btnWriteFile.Click
        Try
            Dim filePath As String = txtFilePath.Text
            Dim content As String = txtFileContent.Text

            If String.IsNullOrWhiteSpace(content) Then
                MessageBox.Show("Please enter content to write!")
                Return
            End If

            ' Write content (overwrites existing)
            File.WriteAllText(filePath, content)

            txtFileResults.Text =
                "CONTENT WRITTEN!" & vbCrLf &
                "File: " & filePath & vbCrLf &
                "Characters: " & content.Length & vbCrLf &
                "" & vbCrLf &
                "Jimmi - UNSIA"

            MessageBox.Show("Content written successfully!", "Success")

        Catch ex As Exception
            txtFileResults.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' READ FROM FILE
    Private Sub btnReadFile_Click(sender As Object, e As EventArgs) Handles btnReadFile.Click
        Try
            Dim filePath As String = txtFilePath.Text

            If Not File.Exists(filePath) Then
                MessageBox.Show("File does not exist!")
                Return
            End If

            ' Read file content
            Dim content As String = File.ReadAllText(filePath)
            txtFileContent.Text = content

            txtFileResults.Text =
                "FILE READ SUCCESSFULLY!" & vbCrLf &
                "File: " & filePath & vbCrLf &
                "Characters: " & content.Length & vbCrLf &
                "Lines: " & content.Split(vbCrLf.ToCharArray()).Length & vbCrLf &
                "" & vbCrLf &
                "Developer: Jimmi - UNSIA"

        Catch ex As Exception
            txtFileResults.Text = "ERROR:  " & ex.Message
        End Try
    End Sub

    ' APPEND TO FILE
    Private Sub btnAppendFile_Click(sender As Object, e As EventArgs) Handles btnAppendFile.Click
        Try
            Dim filePath As String = txtFilePath.Text

            Dim appendText As String = InputBox("Enter text to append:", "Append - Jimmi (UNSIA)", "")

            If String.IsNullOrWhiteSpace(appendText) Then Return

            ' Append to file
            Dim logEntry As String = String.Format(
                "[{0:yyyy-MM-dd HH: mm:ss}] {1}" & vbCrLf,
                DateTime.Now, appendText)

            File.AppendAllText(filePath, logEntry)

            txtFileResults.Text =
                "TEXT APPENDED!" & vbCrLf &
                "Appended: " & appendText & vbCrLf &
                "" & vbCrLf &
                "Jimmi - UNSIA"

            MessageBox.Show("Text appended successfully!", "Success")

        Catch ex As Exception
            txtFileResults.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' DELETE FILE
    Private Sub btnDeleteFile_Click(sender As Object, e As EventArgs) Handles btnDeleteFile.Click
        Try
            Dim filePath As String = txtFilePath.Text

            If Not File.Exists(filePath) Then
                MessageBox.Show("File does not exist!")
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
                "Delete this file?" & vbCrLf & filePath & vbCrLf & vbCrLf & "Jimmi - UNSIA",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                File.Delete(filePath)
                txtFileContent.Clear()
                txtFileResults.Text = "FILE DELETED!" & vbCrLf & "Jimmi - UNSIA"
                MessageBox.Show("File deleted successfully!", "Success")
            End If

        Catch ex As Exception
            txtFileResults.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' FILE INFO (Dates & Times)
    Private Sub btnFileInfo_Click(sender As Object, e As EventArgs) Handles btnFileInfo.Click
        Try
            Dim filePath As String = txtFilePath.Text

            If Not File.Exists(filePath) Then
                MessageBox.Show("File does not exist!")
                Return
            End If

            ' Get file info
            Dim fileInfo As New FileInfo(filePath)

            Dim info As New System.Text.StringBuilder()
            info.AppendLine("========================================")
            info.AppendLine("   FILE INFORMATION")
            info.AppendLine("   Developer: Jimmi - UNSIA")
            info.AppendLine("========================================")
            info.AppendLine("")
            info.AppendLine("File Name   : " & fileInfo.Name)
            info.AppendLine("Full Path   : " & fileInfo.FullName)
            info.AppendLine("Directory   : " & fileInfo.DirectoryName)
            info.AppendLine("Extension   : " & fileInfo.Extension)
            info.AppendLine("Size        : " & fileInfo.Length.ToString("N0") & " bytes")
            info.AppendLine("")
            info.AppendLine("=== FILE DATES & TIMES ===")
            info.AppendLine("Created     : " & fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss"))
            info.AppendLine("Modified    : " & fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"))
            info.AppendLine("Accessed    : " & fileInfo.LastAccessTime.ToString("yyyy-MM-dd HH:mm: ss"))
            info.AppendLine("")
            info.AppendLine("=== ATTRIBUTES ===")
            info.AppendLine("Read Only   : " & ((fileInfo.Attributes And FileAttributes.ReadOnly) = FileAttributes.ReadOnly))
            info.AppendLine("Hidden      : " & ((fileInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden))
            info.AppendLine("Archive     :  " & ((fileInfo.Attributes And FileAttributes.Archive) = FileAttributes.Archive))

            txtFileResults.Text = info.ToString()

        Catch ex As Exception
            txtFileResults.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' ============================================
    ' DIRECTORY OPERATIONS
    ' ============================================

    ' BROWSE DIRECTORY
    Private Sub btnBrowseDir_Click(sender As Object, e As EventArgs) Handles btnBrowseDir.Click
        Try
            Using fbd As New FolderBrowserDialog()
                fbd.Description = "Select Directory - Jimmi (UNSIA)"

                If fbd.ShowDialog() = DialogResult.OK Then
                    txtDirPath.Text = fbd.SelectedPath
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' CREATE DIRECTORY
    Private Sub btnCreateDir_Click(sender As Object, e As EventArgs) Handles btnCreateDir.Click
        Try
            Dim dirPath As String = txtDirPath.Text

            If Directory.Exists(dirPath) Then
                MessageBox.Show("Directory already exists!")
                Return
            End If

            ' Create directory
            Directory.CreateDirectory(dirPath)

            ' Create subdirectories
            Directory.CreateDirectory(Path.Combine(dirPath, "Documents"))
            Directory.CreateDirectory(Path.Combine(dirPath, "Images"))
            Directory.CreateDirectory(Path.Combine(dirPath, "Logs"))

            lstDirectoryResults.Items.Clear()
            lstDirectoryResults.Items.Add("DIRECTORY CREATED!")
            lstDirectoryResults.Items.Add("Path: " & dirPath)
            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add("Subdirectories created:")
            lstDirectoryResults.Items.Add("  - Documents")
            lstDirectoryResults.Items.Add("  - Images")
            lstDirectoryResults.Items.Add("  - Logs")
            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add("Developer: Jimmi - UNSIA")

            MessageBox.Show("Directory created successfully!", "Success")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' DELETE DIRECTORY
    Private Sub btnDeleteDir_Click(sender As Object, e As EventArgs) Handles btnDeleteDir.Click
        Try
            Dim dirPath As String = txtDirPath.Text

            If Not Directory.Exists(dirPath) Then
                MessageBox.Show("Directory does not exist!")
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
                "Delete directory and all contents?" & vbCrLf & dirPath & vbCrLf & vbCrLf & "Jimmi - UNSIA",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Directory.Delete(dirPath, True)
                lstDirectoryResults.Items.Clear()
                lstDirectoryResults.Items.Add("DIRECTORY DELETED!")
                lstDirectoryResults.Items.Add("Jimmi - UNSIA")
                MessageBox.Show("Directory deleted!", "Success")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' LIST FILES
    Private Sub btnListFiles_Click(sender As Object, e As EventArgs) Handles btnListFiles.Click
        Try
            Dim dirPath As String = txtDirPath.Text

            If Not Directory.Exists(dirPath) Then
                MessageBox.Show("Directory does not exist!")
                Return
            End If

            lstDirectoryResults.Items.Clear()
            lstDirectoryResults.Items.Add("========================================")
            lstDirectoryResults.Items.Add("   DIRECTORY CONTENTS")
            lstDirectoryResults.Items.Add("   Developer: Jimmi - UNSIA")
            lstDirectoryResults.Items.Add("========================================")
            lstDirectoryResults.Items.Add("Path: " & dirPath)
            lstDirectoryResults.Items.Add("")

            ' List directories
            lstDirectoryResults.Items.Add("--- SUBDIRECTORIES ---")
            Dim directories() As String = Directory.GetDirectories(dirPath)

            For Each dir As String In directories
                Dim dirInfo As New DirectoryInfo(dir)
                lstDirectoryResults.Items.Add(String.Format("  [DIR] {0} (Created: {1:yyyy-MM-dd})",
                    dirInfo.Name, dirInfo.CreationTime))
            Next

            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add("--- FILES ---")

            ' List files
            Dim files() As String = Directory.GetFiles(dirPath)

            For Each file As String In files
                Dim fileInfo As New FileInfo(file)
                lstDirectoryResults.Items.Add(String.Format("  {0} ({1:N0} bytes)",
                    fileInfo.Name, fileInfo.Length))
            Next

            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add(String.Format("Total: {0} directories, {1} files",
                directories.Length, files.Length))

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' DIRECTORY INFO
    Private Sub btnDirInfo_Click(sender As Object, e As EventArgs) Handles btnDirInfo.Click
        Try
            Dim dirPath As String = txtDirPath.Text

            If Not Directory.Exists(dirPath) Then
                MessageBox.Show("Directory does not exist!")
                Return
            End If

            Dim dirInfo As New DirectoryInfo(dirPath)

            lstDirectoryResults.Items.Clear()
            lstDirectoryResults.Items.Add("========================================")
            lstDirectoryResults.Items.Add("   DIRECTORY INFORMATION")
            lstDirectoryResults.Items.Add("   Jimmi - UNSIA")
            lstDirectoryResults.Items.Add("========================================")
            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add("Name      : " & dirInfo.Name)
            lstDirectoryResults.Items.Add("Full Path :  " & dirInfo.FullName)
            lstDirectoryResults.Items.Add("Parent    : " & If(dirInfo.Parent IsNot Nothing, dirInfo.Parent.Name, "None"))
            lstDirectoryResults.Items.Add("Root      : " & dirInfo.Root.FullName)
            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add("Created   : " & dirInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss"))
            lstDirectoryResults.Items.Add("Modified  : " & dirInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"))
            lstDirectoryResults.Items.Add("Accessed  : " & dirInfo.LastAccessTime.ToString("yyyy-MM-dd HH:mm:ss"))

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' SEARCH FILES
    Private Sub btnSearchFiles_Click(sender As Object, e As EventArgs) Handles btnSearchFiles.Click
        Try
            Dim dirPath As String = txtDirPath.Text
            Dim pattern As String = txtSearchPattern.Text

            If Not Directory.Exists(dirPath) Then
                MessageBox.Show("Directory does not exist!")
                Return
            End If

            Dim files() As String = Directory.GetFiles(dirPath, pattern, SearchOption.AllDirectories)

            lstDirectoryResults.Items.Clear()
            lstDirectoryResults.Items.Add("=== SEARCH RESULTS ===")
            lstDirectoryResults.Items.Add("Pattern: " & pattern)
            lstDirectoryResults.Items.Add("Found:  " & files.Length & " file(s)")
            lstDirectoryResults.Items.Add("")

            For Each file In files
                lstDirectoryResults.Items.Add("  " & file)
            Next

            lstDirectoryResults.Items.Add("")
            lstDirectoryResults.Items.Add("Jimmi - UNSIA")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ============================================
    ' MY NAMESPACE
    ' ============================================

    ' MY. COMPUTER
    Private Sub btnMyComputer_Click(sender As Object, e As EventArgs) Handles btnMyComputer.Click
        Try
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("========================================")
            sb.AppendLine("   MY. COMPUTER INFORMATION")
            sb.AppendLine("   Developer: Jimmi - UNSIA")
            sb.AppendLine("========================================")
            sb.AppendLine("")
            sb.AppendLine("Computer Name:  " & My.Computer.Name)
            sb.AppendLine("")
            sb.AppendLine("=== OPERATING SYSTEM ===")
            sb.AppendLine("OS Name    : " & My.Computer.Info.OSFullName)
            sb.AppendLine("OS Platform:  " & My.Computer.Info.OSPlatform)
            sb.AppendLine("OS Version : " & My.Computer.Info.OSVersion)
            sb.AppendLine("")
            sb.AppendLine("=== MEMORY ===")
            sb.AppendLine(String.Format("Total Memory     : {0:N0} bytes ({1:N2} GB)",
                My.Computer.Info.TotalPhysicalMemory,
                My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024))
            sb.AppendLine(String.Format("Available Memory :  {0:N0} bytes ({1:N2} GB)",
                My.Computer.Info.AvailablePhysicalMemory,
                My.Computer.Info.AvailablePhysicalMemory / 1024 / 1024 / 1024))
            sb.AppendLine("")
            sb.AppendLine("=== SCREEN ===")
            sb.AppendLine(String.Format("Resolution:  {0} x {1}",
                My.Computer.Screen.PrimaryScreen.Bounds.Width,
                My.Computer.Screen.PrimaryScreen.Bounds.Height))
            sb.AppendLine("Screens:  " & My.Computer.Screen.AllScreens.Length)
            sb.AppendLine("")
            sb.AppendLine("=== CLOCK ===")
            sb.AppendLine("Local Time:  " & My.Computer.Clock.LocalTime.ToString("yyyy-MM-dd HH:mm:ss"))
            sb.AppendLine("GMT Time  : " & My.Computer.Clock.GmtTime.ToString("yyyy-MM-dd HH: mm:ss"))

            txtMyNamespaceInfo.Text = sb.ToString()

        Catch ex As Exception
            txtMyNamespaceInfo.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' MY.APPLICATION
    Private Sub btnMyApplication_Click(sender As Object, e As EventArgs) Handles btnMyApplication.Click
        Try
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("========================================")
            sb.AppendLine("   MY.APPLICATION INFORMATION")
            sb.AppendLine("   Developer: Jimmi - UNSIA")
            sb.AppendLine("========================================")
            sb.AppendLine("")
            sb.AppendLine("Product Name: " & My.Application.Info.ProductName)
            sb.AppendLine("Version     : " & My.Application.Info.Version.ToString())
            sb.AppendLine("Company     : " & My.Application.Info.CompanyName)
            sb.AppendLine("")
            sb.AppendLine("=== PATHS ===")
            sb.AppendLine("Directory   : " & My.Application.Info.DirectoryPath)
            sb.AppendLine("Executable  : " & Application.ExecutablePath)
            sb.AppendLine("")
            sb.AppendLine("=== CULTURE ===")
            sb.AppendLine("Culture     : " & My.Application.Culture.Name)
            sb.AppendLine("UI Culture  : " & My.Application.UICulture.Name)

            txtMyNamespaceInfo.Text = sb.ToString()

        Catch ex As Exception
            txtMyNamespaceInfo.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' MY.USER
    Private Sub btnMyUser_Click(sender As Object, e As EventArgs) Handles btnMyUser.Click
        Try
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("========================================")
            sb.AppendLine("   MY.USER INFORMATION")
            sb.AppendLine("   Developer: Jimmi - UNSIA")
            sb.AppendLine("========================================")
            sb.AppendLine("")
            sb.AppendLine("User Name       : " & My.User.Name)
            sb.AppendLine("Is Authenticated:  " & My.User.IsAuthenticated.ToString())
            sb.AppendLine("")
            sb.AppendLine("Environment User: " & Environment.UserName)
            sb.AppendLine("User Domain     :  " & Environment.UserDomainName)
            sb.AppendLine("Machine Name    : " & Environment.MachineName)
            sb.AppendLine("")
            sb.AppendLine("=== SPECIAL FOLDERS ===")
            sb.AppendLine("Desktop     : " & Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
            sb.AppendLine("My Documents:  " & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
            sb.AppendLine("AppData     : " & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

            txtMyNamespaceInfo.Text = sb.ToString()

        Catch ex As Exception
            txtMyNamespaceInfo.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    ' MY.SETTINGS
    Private Sub btnMySettings_Click(sender As Object, e As EventArgs) Handles btnMySettings.Click
        txtMyNamespaceInfo.Text =
            "========================================" & vbCrLf &
            "   MY.SETTINGS INFORMATION" & vbCrLf &
            "   Developer:  Jimmi - UNSIA" & vbCrLf &
            "========================================" & vbCrLf &
            "" & vbCrLf &
            "My. Settings is used to store application" & vbCrLf &
            "settings and user preferences." & vbCrLf &
            "" & vbCrLf &
            "Example Usage:" & vbCrLf &
            "  My.Settings.LastUser = ""Jimmi""" & vbCrLf &
            "  My.Settings.Save()" & vbCrLf &
            "" & vbCrLf &
            "To configure:" & vbCrLf &
            "  1. Project → Properties" & vbCrLf &
            "  2. Settings tab" & vbCrLf &
            "  3. Add settings" & vbCrLf &
            "" & vbCrLf &
            "Common E-Business uses:" & vbCrLf &
            "  - Last logged user" & vbCrLf &
            "  - Window preferences" & vbCrLf &
            "  - Connection strings" & vbCrLf &
            "  - Report settings"
    End Sub

    ' MY.FORMS
    Private Sub btnMyForms_Click(sender As Object, e As EventArgs) Handles btnMyForms.Click
        txtMyNamespaceInfo.Text =
            "MY.FORMS - Access to application forms" & vbCrLf &
            "Developer: Jimmi - UNSIA" & vbCrLf &
            "" & vbCrLf &
            "Example:  My.Forms.frmMain. Show()"
    End Sub

    ' MY.RESOURCES
    Private Sub btnMyResources_Click(sender As Object, e As EventArgs) Handles btnMyResources.Click
        txtMyNamespaceInfo.Text =
            "MY.RESOURCES - Access to embedded resources" & vbCrLf &
            "Developer:  Jimmi - UNSIA" & vbCrLf &
            "" & vbCrLf &
            "Example: My.Resources.AppIcon"
    End Sub

End Class