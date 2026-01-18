' ========================================
' PRODUCT MASTER FORM
' Developer: Jimmi - UNSIA
' Full CRUD Operations with File Persistence
' ========================================

Imports System.IO

Public Class frmProducts

    ' Collection untuk menyimpan products (simulasi database)
    Private productList As New List(Of Product)
    Private currentProduct As Product = Nothing
    Private isEditMode As Boolean = False

    ' File path untuk persistence
    Private dataFile As String = Path.Combine(Application.StartupPath, "Data", "Products.dat")

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitializeForm()
            LoadProducts()
            RefreshProductList()
            SetFormMode(FormMode.View)

        Catch ex As Exception
            MessageBox.Show("Error loading form: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' INITIALIZATION
    ' ============================================

    Private Sub InitializeForm()
        ' Setup ComboBox categories
        cboCategory.Items.Clear()
        cboCategory.Items.AddRange(New String() {
            "Electronics", "Accessories", "Software",
            "Networking", "Audio", "Monitors",
            "Storage", "Components"
        })

        ' Setup DataGridView
        dgvProducts.AutoGenerateColumns = False
        dgvProducts.Columns.Clear()

        dgvProducts.Columns.Add("Code", "Code")
        dgvProducts.Columns.Add("Name", "Product Name")
        dgvProducts.Columns.Add("Category", "Category")
        dgvProducts.Columns.Add("Price", "Price")
        dgvProducts.Columns.Add("Stock", "Stock")
        dgvProducts.Columns.Add("Status", "Status")

        dgvProducts.Columns(0).Width = 100
        dgvProducts.Columns(1).Width = 200
        dgvProducts.Columns(2).Width = 120
        dgvProducts.Columns(3).Width = 130
        dgvProducts.Columns(4).Width = 80
        dgvProducts.Columns(5).Width = 100

        dgvProducts.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvProducts.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        lblStatus.Text = "Ready - Developer: Jimmi - UNSIA"
    End Sub

    ' ============================================
    ' CRUD OPERATIONS
    ' ============================================

    ' NEW
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            ClearForm()
            SetFormMode(FormMode.Add)
            txtProductCode.Text = GenerateProductCode()
            txtProductName.Focus()
            lblStatus.Text = "Adding new product - Jimmi UNSIA"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' SAVE
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Validate
            If Not ValidateInput() Then Return

            If isEditMode Then
                ' UPDATE
                UpdateProduct(currentProduct)
                MessageBox.Show("Product updated successfully!" & vbCrLf & "Jimmi - UNSIA", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' CREATE
                Dim newProduct As New Product()
                PopulateProduct(newProduct)

                ' Check duplicate
                If productList.Any(Function(p) p.ProductCode.ToUpper() = newProduct.ProductCode.ToUpper()) Then
                    MessageBox.Show("Product code already exists!", "Error")
                    txtProductCode.Focus()
                    Return
                End If

                productList.Add(newProduct)
                MessageBox.Show("Product added successfully!" & vbCrLf & "Jimmi - UNSIA", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            SaveProducts()
            RefreshProductList()
            SetFormMode(FormMode.View)
            ClearForm()
            lblStatus.Text = "Product saved - Jimmi UNSIA"

        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message)
        End Try
    End Sub

    ' EDIT
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If dgvProducts.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to edit!", "Warning")
                Return
            End If

            Dim selectedIndex As Integer = dgvProducts.SelectedRows(0).Index
            currentProduct = productList(selectedIndex)

            LoadProductToForm(currentProduct)
            SetFormMode(FormMode.Edit)
            lblStatus.Text = "Editing product:  " & currentProduct.ProductCode & " - Jimmi UNSIA"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dgvProducts.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to delete!", "Warning")
                Return
            End If

            Dim selectedIndex As Integer = dgvProducts.SelectedRows(0).Index
            Dim product As Product = productList(selectedIndex)

            Dim result As DialogResult = MessageBox.Show(
                "Delete this product?" & vbCrLf & vbCrLf &
                "Code: " & product.ProductCode & vbCrLf &
                "Name: " & product.ProductName & vbCrLf &
                "Stock Value: Rp " & product.GetStockValue().ToString("N0") & vbCrLf & vbCrLf &
                "This action cannot be undone!" & vbCrLf & vbCrLf &
                "Developer: Jimmi - UNSIA",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                productList.RemoveAt(selectedIndex)
                SaveProducts()
                RefreshProductList()
                ClearForm()
                MessageBox.Show("Product deleted successfully!", "Success")
                lblStatus.Text = "Product deleted - Jimmi UNSIA"
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ============================================
    ' HELPER METHODS (ByVal & ByRef Examples)
    ' ============================================

    Private Sub PopulateProduct(ByVal product As Product)
        product.ProductCode = txtProductCode.Text.Trim().ToUpper()
        product.ProductName = txtProductName.Text.Trim()
        product.Category = cboCategory.Text
        product.Price = nudPrice.Value
        product.Stock = CInt(nudStock.Value)
        product.MinStock = CInt(nudMinStock.Value)
        product.Supplier = txtSupplier.Text.Trim()
        product.Description = txtDescription.Text.Trim()
        product.IsActive = chkActive.Checked
    End Sub

    Private Sub UpdateProduct(ByRef product As Product)
        product.ProductCode = txtProductCode.Text.Trim().ToUpper()
        product.ProductName = txtProductName.Text.Trim()
        product.Category = cboCategory.Text
        product.Price = nudPrice.Value
        product.Stock = CInt(nudStock.Value)
        product.MinStock = CInt(nudMinStock.Value)
        product.Supplier = txtSupplier.Text.Trim()
        product.Description = txtDescription.Text.Trim()
        product.IsActive = chkActive.Checked
        product.LastModified = DateTime.Now
    End Sub

    Private Sub LoadProductToForm(ByVal product As Product)
        txtProductCode.Text = product.ProductCode
        txtProductName.Text = product.ProductName
        cboCategory.Text = product.Category
        nudPrice.Value = product.Price
        nudStock.Value = product.Stock
        nudMinStock.Value = product.MinStock
        txtSupplier.Text = product.Supplier
        txtDescription.Text = product.Description
        chkActive.Checked = product.IsActive

        lblCreatedDate.Text = "Created: " & product.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss")
        lblModifiedDate.Text = "Modified: " & product.LastModified.ToString("yyyy-MM-dd HH:mm:ss")
        lblRecordInfo.Text = String.Format("Stock Value: Rp {0:N0} | Status: {1}",
            product.GetStockValue(), product.GetStockStatus())
    End Sub

    Private Sub ClearForm()
        txtProductCode.Clear()
        txtProductName.Clear()
        cboCategory.SelectedIndex = -1
        nudPrice.Value = 0
        nudStock.Value = 0
        nudMinStock.Value = 10
        txtSupplier.Clear()
        txtDescription.Clear()
        chkActive.Checked = True
        lblCreatedDate.Text = "Created: -"
        lblModifiedDate.Text = "Modified: -"
        lblRecordInfo.Text = ""
        currentProduct = Nothing
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then
            MessageBox.Show("Product code is required!", "Validation")
            txtProductCode.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtProductName.Text) Then
            MessageBox.Show("Product name is required!", "Validation")
            txtProductName.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(cboCategory.Text) Then
            MessageBox.Show("Please select a category!", "Validation")
            cboCategory.Focus()
            Return False
        End If

        If nudPrice.Value <= 0 Then
            MessageBox.Show("Price must be greater than zero!", "Validation")
            nudPrice.Focus()
            Return False
        End If

        Return True
    End Function

    ' ============================================
    ' DATA GRID VIEW
    ' ============================================

    Private Sub RefreshProductList()
        Try
            dgvProducts.Rows.Clear()

            For Each product As Product In productList
                Dim rowIndex As Integer = dgvProducts.Rows.Add()
                Dim row As DataGridViewRow = dgvProducts.Rows(rowIndex)

                row.Cells(0).Value = product.ProductCode
                row.Cells(1).Value = product.ProductName
                row.Cells(2).Value = product.Category
                row.Cells(3).Value = "Rp " & product.Price.ToString("N0")
                row.Cells(4).Value = product.Stock
                row.Cells(5).Value = product.GetStockStatus()

                ' Color coding by stock status
                Select Case product.GetStockStatus()
                    Case "OUT OF STOCK"
                        row.DefaultCellStyle.BackColor = Color.LightCoral
                    Case "LOW STOCK"
                        row.DefaultCellStyle.BackColor = Color.LightYellow
                    Case "NORMAL"
                        row.DefaultCellStyle.BackColor = Color.LightBlue
                    Case "SUFFICIENT"
                        row.DefaultCellStyle.BackColor = Color.LightGreen
                End Select

                If Not product.IsActive Then
                    row.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

            UpdateStatistics()

        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateStatistics()
        Dim totalValue As Decimal = 0

        For Each product As Product In productList
            totalValue += product.GetStockValue()
        Next

        lblTotalProducts.Text = "Total Products: " & productList.Count
        lblTotalValue.Text = "Total Stock Value: Rp " & totalValue.ToString("N0")
    End Sub

    ' ============================================
    ' SEARCH
    ' ============================================

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

            If String.IsNullOrWhiteSpace(searchTerm) Then
                RefreshProductList()
                Return
            End If

            dgvProducts.Rows.Clear()
            Dim foundCount As Integer = 0

            For Each product As Product In productList
                If product.ProductCode.ToLower().Contains(searchTerm) OrElse
                   product.ProductName.ToLower().Contains(searchTerm) OrElse
                   product.Category.ToLower().Contains(searchTerm) Then

                    Dim rowIndex As Integer = dgvProducts.Rows.Add()
                    Dim row As DataGridViewRow = dgvProducts.Rows(rowIndex)

                    row.Cells(0).Value = product.ProductCode
                    row.Cells(1).Value = product.ProductName
                    row.Cells(2).Value = product.Category
                    row.Cells(3).Value = "Rp " & product.Price.ToString("N0")
                    row.Cells(4).Value = product.Stock
                    row.Cells(5).Value = product.GetStockStatus()

                    foundCount += 1
                End If
            Next

            lblStatus.Text = "Found:  " & foundCount & " product(s) - Jimmi UNSIA"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        RefreshProductList()
        lblStatus.Text = "Refreshed - Jimmi UNSIA"
    End Sub

    ' ============================================
    ' FILE OPERATIONS
    ' ============================================

    Private Sub LoadProducts()
        Try
            If Not File.Exists(dataFile) Then
                LoadSampleData()
                Return
            End If

            productList.Clear()
            Dim lines() As String = File.ReadAllLines(dataFile)

            For Each line As String In lines
                If line.StartsWith("#") OrElse String.IsNullOrWhiteSpace(line) Then Continue For

                Dim parts() As String = line.Split("|"c)
                If parts.Length >= 12 Then
                    Dim product As New Product() With {
                        .ProductID = parts(0),
                        .ProductCode = parts(1),
                        .ProductName = parts(2),
                        .Category = parts(3),
                        .Price = CDec(parts(4)),
                        .Stock = CInt(parts(5)),
                        .MinStock = CInt(parts(6)),
                        .Supplier = parts(7),
                        .Description = parts(8),
                        .IsActive = Boolean.Parse(parts(9)),
                        .CreatedDate = DateTime.Parse(parts(10)),
                        .LastModified = DateTime.Parse(parts(11))
                    }
                    productList.Add(product)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading: " & ex.Message)
            LoadSampleData()
        End Try
    End Sub

    Private Sub SaveProducts()
        Try
            Dim dirPath As String = Path.GetDirectoryName(dataFile)
            If Not Directory.Exists(dirPath) Then
                Directory.CreateDirectory(dirPath)
            End If

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("# Product Data - E-Business")
            sb.AppendLine("# Developer: Jimmi - UNSIA")
            sb.AppendLine("# Saved: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            sb.AppendLine("#")

            For Each product As Product In productList
                sb.AppendLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}",
                    product.ProductID, product.ProductCode, product.ProductName,
                    product.Category, product.Price, product.Stock, product.MinStock,
                    product.Supplier, product.Description, product.IsActive,
                    product.CreatedDate.ToString("yyyy-MM-dd HH: mm:ss"),
                    product.LastModified.ToString("yyyy-MM-dd HH:mm:ss")))
            Next

            File.WriteAllText(dataFile, sb.ToString())

        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSampleData()
        productList.Clear()

        productList.Add(New Product("LAP001", "Dell XPS 13", "Electronics", 15000000, 45) With {.Supplier = "Dell Indonesia", .MinStock = 10})
        productList.Add(New Product("ACC001", "Logitech MX Master", "Accessories", 1200000, 120) With {.Supplier = "Logitech", .MinStock = 20})
        productList.Add(New Product("MON001", "Samsung 27 inch", "Monitors", 3500000, 67) With {.Supplier = "Samsung", .MinStock = 15})
        productList.Add(New Product("AUD001", "Sony WH-1000XM4", "Audio", 4200000, 78) With {.Supplier = "Sony", .MinStock = 12})
        productList.Add(New Product("NET001", "TP-Link AX3000", "Networking", 1300000, 5) With {.Supplier = "TP-Link", .MinStock = 20})

        SaveProducts()
    End Sub

    ' ============================================
    ' EXPORT
    ' ============================================

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Using sfd As New SaveFileDialog()
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.FileName = "Products_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim sb As New System.Text.StringBuilder()
                    sb.AppendLine("Code,Name,Category,Price,Stock,Status,Supplier")

                    For Each product In productList
                        sb.AppendLine(String.Format("{0},{1},{2},{3},{4},{5},{6}",
                            product.ProductCode, product.ProductName, product.Category,
                            product.Price, product.Stock, product.GetStockStatus(), product.Supplier))
                    Next

                    File.WriteAllText(sfd.FileName, sb.ToString())
                    MessageBox.Show("Exported successfully!" & vbCrLf & "Jimmi - UNSIA", "Success")
                    lblStatus.Text = "Exported to: " & sfd.FileName
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ============================================
    ' FORM MODE
    ' ============================================

    Private Enum FormMode
        View
        Add
        Edit
    End Enum

    Private Sub SetFormMode(mode As FormMode)
        Select Case mode
            Case FormMode.View
                txtProductCode.ReadOnly = True
                txtProductName.ReadOnly = True
                cboCategory.Enabled = False
                nudPrice.Enabled = False
                nudStock.Enabled = False
                nudMinStock.Enabled = False
                txtSupplier.ReadOnly = True
                txtDescription.ReadOnly = True
                chkActive.Enabled = False

                btnNew.Enabled = True
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                dgvProducts.Enabled = True
                isEditMode = False

            Case FormMode.Add
                txtProductCode.ReadOnly = False
                txtProductName.ReadOnly = False
                cboCategory.Enabled = True
                nudPrice.Enabled = True
                nudStock.Enabled = True
                nudMinStock.Enabled = True
                txtSupplier.ReadOnly = False
                txtDescription.ReadOnly = False
                chkActive.Enabled = True

                btnNew.Enabled = False
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dgvProducts.Enabled = False
                isEditMode = False

            Case FormMode.Edit
                txtProductCode.ReadOnly = True
                txtProductName.ReadOnly = False
                cboCategory.Enabled = True
                nudPrice.Enabled = True
                nudStock.Enabled = True
                nudMinStock.Enabled = True
                txtSupplier.ReadOnly = False
                txtDescription.ReadOnly = False
                chkActive.Enabled = True

                btnNew.Enabled = False
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dgvProducts.Enabled = False
                isEditMode = True
        End Select
    End Sub

    Private Function GenerateProductCode() As String
        Return "PRD" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub dgvProducts_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnEdit.PerformClick()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        MessageBox.Show("Print product list" & vbCrLf & "Jimmi - UNSIA", "Info")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class