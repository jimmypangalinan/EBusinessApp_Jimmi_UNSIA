<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArraysCollections
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchArray = New System.Windows.Forms.Button()
        Me.btnReverseArray = New System.Windows.Forms.Button()
        Me.btnSortArray = New System.Windows.Forms.Button()
        Me.btnPopulateArray = New System.Windows.Forms.Button()
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtNewItem = New System.Windows.Forms.TextBox()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.btnRemoveFromList = New System.Windows.Forms.Button()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.lstCollection = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnHashSet = New System.Windows.Forms.Button()
        Me.btnStack = New System.Windows.Forms.Button()
        Me.btnQueue = New System.Windows.Forms.Button()
        Me.btnDictionary = New System.Windows.Forms.Button()
        Me.lstDictionary = New System.Windows.Forms.ListBox()
        Me.tabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        Me.tabMain.Size = New System.Drawing.Size(884, 608)
        Me.tabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.btnSearchArray)
        Me.TabPage1.Controls.Add(Me.btnReverseArray)
        Me.TabPage1.Controls.Add(Me.btnSortArray)
        Me.TabPage1.Controls.Add(Me.btnPopulateArray)
        Me.TabPage1.Controls.Add(Me.lstArray)
        Me.TabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(876, 582)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Arrays"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Array Operations - Jimmi UNSIA"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(420, 210)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(430, 20)
        Me.txtSearch.TabIndex = 5
        '
        'btnSearchArray
        '
        Me.btnSearchArray.Location = New System.Drawing.Point(420, 160)
        Me.btnSearchArray.Name = "btnSearchArray"
        Me.btnSearchArray.Size = New System.Drawing.Size(430, 40)
        Me.btnSearchArray.TabIndex = 4
        Me.btnSearchArray.Text = "Search in Array"
        Me.btnSearchArray.UseVisualStyleBackColor = True
        '
        'btnReverseArray
        '
        Me.btnReverseArray.Location = New System.Drawing.Point(420, 110)
        Me.btnReverseArray.Name = "btnReverseArray"
        Me.btnReverseArray.Size = New System.Drawing.Size(430, 40)
        Me.btnReverseArray.TabIndex = 3
        Me.btnReverseArray.Text = "Reverse Array"
        Me.btnReverseArray.UseVisualStyleBackColor = True
        '
        'btnSortArray
        '
        Me.btnSortArray.Location = New System.Drawing.Point(420, 60)
        Me.btnSortArray.Name = "btnSortArray"
        Me.btnSortArray.Size = New System.Drawing.Size(430, 40)
        Me.btnSortArray.TabIndex = 2
        Me.btnSortArray.Text = "Sort Array (Ascending)"
        Me.btnSortArray.UseVisualStyleBackColor = True
        '
        'btnPopulateArray
        '
        Me.btnPopulateArray.BackColor = System.Drawing.Color.LightBlue
        Me.btnPopulateArray.Location = New System.Drawing.Point(420, 10)
        Me.btnPopulateArray.Name = "btnPopulateArray"
        Me.btnPopulateArray.Size = New System.Drawing.Size(430, 40)
        Me.btnPopulateArray.TabIndex = 1
        Me.btnPopulateArray.Text = "Populate Array"
        Me.btnPopulateArray.UseVisualStyleBackColor = False
        '
        'lstArray
        '
        Me.lstArray.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.ItemHeight = 15
        Me.lstArray.Location = New System.Drawing.Point(10, 10)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(400, 514)
        Me.lstArray.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNewItem)
        Me.TabPage2.Controls.Add(Me.btnClearList)
        Me.TabPage2.Controls.Add(Me.btnRemoveFromList)
        Me.TabPage2.Controls.Add(Me.btnAddToList)
        Me.TabPage2.Controls.Add(Me.lstCollection)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(876, 582)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Collections (List)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtNewItem
        '
        Me.txtNewItem.Location = New System.Drawing.Point(420, 110)
        Me.txtNewItem.Name = "txtNewItem"
        Me.txtNewItem.Size = New System.Drawing.Size(430, 20)
        Me.txtNewItem.TabIndex = 4
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(420, 60)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(430, 40)
        Me.btnClearList.TabIndex = 3
        Me.btnClearList.Text = "Clear All"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'btnRemoveFromList
        '
        Me.btnRemoveFromList.BackColor = System.Drawing.Color.LightCoral
        Me.btnRemoveFromList.Location = New System.Drawing.Point(640, 10)
        Me.btnRemoveFromList.Name = "btnRemoveFromList"
        Me.btnRemoveFromList.Size = New System.Drawing.Size(210, 40)
        Me.btnRemoveFromList.TabIndex = 2
        Me.btnRemoveFromList.Text = "Remove Selected"
        Me.btnRemoveFromList.UseVisualStyleBackColor = False
        '
        'btnAddToList
        '
        Me.btnAddToList.BackColor = System.Drawing.Color.LightGreen
        Me.btnAddToList.Location = New System.Drawing.Point(420, 10)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(210, 40)
        Me.btnAddToList.TabIndex = 1
        Me.btnAddToList.Text = "Add Item to List"
        Me.btnAddToList.UseVisualStyleBackColor = False
        '
        'lstCollection
        '
        Me.lstCollection.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCollection.FormattingEnabled = True
        Me.lstCollection.ItemHeight = 15
        Me.lstCollection.Location = New System.Drawing.Point(10, 10)
        Me.lstCollection.Name = "lstCollection"
        Me.lstCollection.Size = New System.Drawing.Size(400, 514)
        Me.lstCollection.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnHashSet)
        Me.TabPage3.Controls.Add(Me.btnStack)
        Me.TabPage3.Controls.Add(Me.btnQueue)
        Me.TabPage3.Controls.Add(Me.btnDictionary)
        Me.TabPage3.Controls.Add(Me.lstDictionary)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(876, 582)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dictionary & Others"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnHashSet
        '
        Me.btnHashSet.Location = New System.Drawing.Point(650, 470)
        Me.btnHashSet.Name = "btnHashSet"
        Me.btnHashSet.Size = New System.Drawing.Size(200, 40)
        Me.btnHashSet.TabIndex = 4
        Me.btnHashSet.Text = "HashSet Demo"
        Me.btnHashSet.UseVisualStyleBackColor = True
        '
        'btnStack
        '
        Me.btnStack.Location = New System.Drawing.Point(440, 470)
        Me.btnStack.Name = "btnStack"
        Me.btnStack.Size = New System.Drawing.Size(200, 40)
        Me.btnStack.TabIndex = 3
        Me.btnStack.Text = "Stack Demo (LIFO)"
        Me.btnStack.UseVisualStyleBackColor = True
        '
        'btnQueue
        '
        Me.btnQueue.Location = New System.Drawing.Point(220, 470)
        Me.btnQueue.Name = "btnQueue"
        Me.btnQueue.Size = New System.Drawing.Size(200, 40)
        Me.btnQueue.TabIndex = 2
        Me.btnQueue.Text = "Queue Demo (FIFO)"
        Me.btnQueue.UseVisualStyleBackColor = True
        '
        'btnDictionary
        '
        Me.btnDictionary.Location = New System.Drawing.Point(10, 470)
        Me.btnDictionary.Name = "btnDictionary"
        Me.btnDictionary.Size = New System.Drawing.Size(200, 40)
        Me.btnDictionary.TabIndex = 1
        Me.btnDictionary.Text = "Dictionary Demo"
        Me.btnDictionary.UseVisualStyleBackColor = True
        '
        'lstDictionary
        '
        Me.lstDictionary.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDictionary.FormattingEnabled = True
        Me.lstDictionary.ItemHeight = 15
        Me.lstDictionary.Location = New System.Drawing.Point(10, 10)
        Me.lstDictionary.Name = "lstDictionary"
        Me.lstDictionary.Size = New System.Drawing.Size(840, 439)
        Me.lstDictionary.TabIndex = 0
        '
        'frmArraysCollections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 608)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "frmArraysCollections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrays & Collections - Jimmi (UNSIA)"
        Me.tabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnSortArray As Button
    Friend WithEvents btnPopulateArray As Button
    Friend WithEvents lstArray As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearchArray As Button
    Friend WithEvents btnReverseArray As Button
    Friend WithEvents lstCollection As ListBox
    Friend WithEvents txtNewItem As TextBox
    Friend WithEvents btnClearList As Button
    Friend WithEvents btnRemoveFromList As Button
    Friend WithEvents btnAddToList As Button
    Friend WithEvents lstDictionary As ListBox
    Friend WithEvents btnQueue As Button
    Friend WithEvents btnDictionary As Button
    Friend WithEvents btnHashSet As Button
    Friend WithEvents btnStack As Button
End Class
