Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup form
        Me.Text = "E-Business System - Jimmi (UNSIA)"
        Me.WindowState = FormWindowState.Maximized

        'Update status
        lblStatus.Text = "Ready - System Loaded"
        lblUser.Text = "User: " & Environment.UserName
        lblVersion.Text = "Version 1.0.0 | Developer: Jimmi - UNSIA"

        'Show welcome
        MessageBox.Show("Welcome to E-Business System!" & vbCrLf & vbCrLf &
                       "Developer: Jimmi" & vbCrLf &
                       "Institution: UNSIA" & vbCrLf &
                       "Framework: .NET 4.8",
                       "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DemonstrationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemonstrationsToolStripMenuItem.Click

    End Sub

    Private Sub StringMethodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StringMethodsToolStripMenuItem.Click
        ' Buka form String Demo
        Dim formString As New frmStringDemo()
        formString.Show()
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click
        Dim formDateTime As New frmDateTimeDemo()
        formDateTime.Show()
    End Sub

    Private Sub ArraysCollectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArraysCollectionsToolStripMenuItem.Click
        Dim formArrays As New frmArraysCollections()
        formArrays.Show()
    End Sub

    Private Sub ControlStatementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlStatementsToolStripMenuItem.Click
        Dim formControl As New frmControlStatements()
        formControl.Show()
    End Sub

    Private Sub LoopsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopsToolStripMenuItem.Click
        Dim formLoops As New frmLoops()
        formLoops.Show()
    End Sub

    Private Sub FunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunctionsToolStripMenuItem.Click
        Dim formFunctions As New frmFunctionsDemo()
        formFunctions.Show()
    End Sub

    Private Sub FileOperationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileOperationsToolStripMenuItem.Click
        Dim formFile As New frmFileOperations()
        formFile.Show()
    End Sub

    Private Sub PrintingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintingToolStripMenuItem.Click
        Dim formPrint As New frmPrintingDemo()
        formPrint.Show()
    End Sub

    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click

    End Sub

    Private Sub DebuggingToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebuggingToolsToolStripMenuItem.Click
        Dim formDebug As New frmDebuggingDemo()
        formDebug.Show()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        Dim formProducts As New frmProducts()
        formProducts.Show()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dim formCustomers As New frmCustomers()
        formCustomers.Show()
    End Sub
End Class