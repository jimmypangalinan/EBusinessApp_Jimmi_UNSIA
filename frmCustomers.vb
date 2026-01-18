' ========================================
' CUSTOMER MASTER FORM
' Developer: Jimmi - UNSIA
' Full CRUD Operations
' ========================================

Imports System.IO

Public Class frmCustomers

    Private customerList As New List(Of Customer)
    Private currentCustomer As Customer = Nothing
    Private isEditMode As Boolean = False

    Private dataFile As String = Path.Combine(Application.StartupPath, "Data", "Customers.dat")

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InitializeForm()
            LoadCustomers()
            RefreshCustomerList()
            SetFormMode(FormMode.View)

        Catch ex As Exception
            MessageBox.Show("Error loading:  " & ex.Message)
        End Try
    End Sub

    ' ============================================
    ' INITIALIZATION
    ' ============================================

    Private Sub InitializeForm()
        ' Setup ComboBox
        cboCustomerType.Items.Clear()
        cboCustomerType.Items.AddRange(New String() {"Individual", "Corporate"})

        ' Setup DataGridView
        dgvCustomers.AutoGenerateColumns = False
        dgvCustomers.Columns.Clear()

        dgvCustomers.Columns.Add("Code", "Code")
        dgvCustomers.Columns.Add("Name", "Customer Name")
        dgvCustomers.Columns.Add("Type", "Type")
        dgvCustomers.Columns.Add("Email", "Email")
        dgvCustomers.Columns.Add("Phone", "Phone")
        dgvCustomers.Columns.Add("Level", "Level")
        dgvCustomers.Columns.Add("TotalPurchase", "Total Purchase")

        dgvCustomers.Columns(0).Width = 100
        dgvCustomers.Columns(1).Width = 180
        dgvCustomers.Columns(2).Width = 100
        dgvCustomers.Columns(3).Width = 180
        dgvCustomers.Columns(4).Width = 120
        dgvCustomers.Columns(5).Width = 90
        dgvCustomers.Columns(6).Width = 150

        dgvCustomers.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

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
            txtCustomerCode.Text = GenerateCustomerCode()
            txtCustomerName.Focus()
            lblStatus.Text = "Adding new customer - Jimmi UNSIA"

        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message)
        End Try
    End Sub

    ' SAVE
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Not ValidateInput() Then Return

            If isEditMode Then
                ' UPDATE
                UpdateCustomer(currentCustomer)
                MessageBox.Show("Customer updated successfully!" & vbCrLf & "Jimmi - UNSIA", "Success")
            Else
                ' CREATE
                Dim newCustomer As New Customer()
                PopulateCustomer(newCustomer)

                ' Check duplicate
                If customerList.Any(Function(c) c.CustomerCode.ToUpper() = newCustomer.CustomerCode.ToUpper()) Then
                    MessageBox.Show("Customer code already exists!", "Error")
                    Return
                End If

                customerList.Add(newCustomer)
                MessageBox.Show("Customer added successfully!" & vbCrLf & "Jimmi - UNSIA", "Success")
            End If

            SaveCustomers()
            RefreshCustomerList()
            SetFormMode(FormMode.View)
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' EDIT
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If dgvCustomers.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a customer to edit!")
                Return
            End If

            Dim selectedIndex As Integer = dgvCustomers.SelectedRows(0).Index
            currentCustomer = customerList(selectedIndex)

            LoadCustomerToForm(currentCustomer)
            SetFormMode(FormMode.Edit)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' DELETE
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dgvCustomers.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a customer to delete!")
                Return
            End If

            Dim selectedIndex As Integer = dgvCustomers.SelectedRows(0).Index
            Dim customer As Customer = customerList(selectedIndex)

            Dim result As DialogResult = MessageBox.Show(
                "Delete this customer?" & vbCrLf & vbCrLf &
                "Code: " & customer.CustomerCode & vbCrLf &
                "Name: " & customer.CustomerName & vbCrLf &
                "Total Purchase:  Rp " & customer.TotalPurchase.ToString("N0") & vbCrLf & vbCrLf &
                "Jimmi - UNSIA",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                customerList.RemoveAt(selectedIndex)
                SaveCustomers()
                RefreshCustomerList()
                ClearForm()
                MessageBox.Show("Customer deleted!", "Success")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' ============================================
    ' HELPER METHODS
    ' ============================================

    Private Sub PopulateCustomer(ByVal customer As Customer)
        customer.CustomerCode = txtCustomerCode.Text.Trim().ToUpper()
        customer.CustomerName = txtCustomerName.Text.Trim()
        customer.CustomerType = cboCustomerType.Text
        customer.ContactPerson = txtContactPerson.Text.Trim()
        customer.Email = txtEmail.Text.Trim()
        customer.Phone = txtPhone.Text.Trim()
        customer.Address = txtAddress.Text.Trim()
        customer.City = txtCity.Text.Trim()
        customer.CreditLimit = nudCreditLimit.Value
        customer.IsActive = chkActive.Checked
    End Sub

    Private Sub UpdateCustomer(ByRef customer As Customer)
        customer.CustomerCode = txtCustomerCode.Text.Trim().ToUpper()
        customer.CustomerName = txtCustomerName.Text.Trim()
        customer.CustomerType = cboCustomerType.Text
        customer.ContactPerson = txtContactPerson.Text.Trim()
        customer.Email = txtEmail.Text.Trim()
        customer.Phone = txtPhone.Text.Trim()
        customer.Address = txtAddress.Text.Trim()
        customer.City = txtCity.Text.Trim()
        customer.CreditLimit = nudCreditLimit.Value
        customer.IsActive = chkActive.Checked
        customer.LastTransaction = DateTime.Now
    End Sub

    Private Sub LoadCustomerToForm(ByVal customer As Customer)
        txtCustomerCode.Text = customer.CustomerCode
        txtCustomerName.Text = customer.CustomerName
        cboCustomerType.Text = customer.CustomerType
        txtContactPerson.Text = customer.ContactPerson
        txtEmail.Text = customer.Email
        txtPhone.Text = customer.Phone
        txtAddress.Text = customer.Address
        txtCity.Text = customer.City
        nudCreditLimit.Value = customer.CreditLimit
        chkActive.Checked = customer.IsActive

        lblCreatedDate.Text = "Created: " & customer.RegistrationDate.ToString("yyyy-MM-dd HH:mm:ss")
        lblModifiedDate.Text = "Last Transaction: " & customer.LastTransaction.ToString("yyyy-MM-dd HH:mm:ss")
        lblCustomerInfo.Text = String.Format("Level: {0} | Total Purchase:  Rp {1:N0} | Transactions: {2}",
            customer.GetCustomerLevel(), customer.TotalPurchase, customer.TotalTransactions)
    End Sub

    Private Sub ClearForm()
        txtCustomerCode.Clear()
        txtCustomerName.Clear()
        cboCustomerType.SelectedIndex = -1
        txtContactPerson.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        nudCreditLimit.Value = 10000000
        chkActive.Checked = True
        lblCreatedDate.Text = "Created: -"
        lblModifiedDate.Text = "Modified: -"
        lblCustomerInfo.Text = ""
        currentCustomer = Nothing
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtCustomerCode.Text) Then
            MessageBox.Show("Customer code is required!")
            txtCustomerCode.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Customer name is required!")
            txtCustomerName.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(cboCustomerType.Text) Then
            MessageBox.Show("Please select customer type!")
            cboCustomerType.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email is required!")
            txtEmail.Focus()
            Return False
        End If

        If Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Invalid email format!")
            txtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    ' ============================================
    ' DATA GRID VIEW
    ' ============================================

    Private Sub RefreshCustomerList()
        Try
            dgvCustomers.Rows.Clear()

            For Each customer As Customer In customerList
                Dim rowIndex As Integer = dgvCustomers.Rows.Add()
                Dim row As DataGridViewRow = dgvCustomers.Rows(rowIndex)

                row.Cells(0).Value = customer.CustomerCode
                row.Cells(1).Value = customer.CustomerName
                row.Cells(2).Value = customer.CustomerType
                row.Cells(3).Value = customer.Email
                row.Cells(4).Value = customer.Phone
                row.Cells(5).Value = customer.GetCustomerLevel()
                row.Cells(6).Value = "Rp " & customer.TotalPurchase.ToString("N0")

                ' Color by level
                Select Case customer.GetCustomerLevel()
                    Case "PLATINUM"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(229, 228, 226)
                    Case "GOLD"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 223, 0)
                    Case "SILVER"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192)
                    Case "BRONZE"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50)
                End Select

                If Not customer.IsActive Then
                    row.DefaultCellStyle.ForeColor = Color.Gray
                End If
            Next

            UpdateStatistics()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateStatistics()
        Dim totalRevenue As Decimal = 0

        For Each customer As Customer In customerList
            totalRevenue += customer.TotalPurchase
        Next

        lblTotalCustomers.Text = "Total Customers: " & customerList.Count
        lblTotalRevenue.Text = "Total Revenue: Rp " & totalRevenue.ToString("N0")
    End Sub

    ' ============================================
    ' SEARCH
    ' ============================================

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

            If String.IsNullOrWhiteSpace(searchTerm) Then
                RefreshCustomerList()
                Return
            End If

            dgvCustomers.Rows.Clear()
            Dim foundCount As Integer = 0

            For Each customer As Customer In customerList
                If customer.CustomerCode.ToLower().Contains(searchTerm) OrElse
                   customer.CustomerName.ToLower().Contains(searchTerm) OrElse
                   customer.Email.ToLower().Contains(searchTerm) Then

                    Dim rowIndex As Integer = dgvCustomers.Rows.Add()
                    dgvCustomers.Rows(rowIndex).Cells(0).Value = customer.CustomerCode
                    dgvCustomers.Rows(rowIndex).Cells(1).Value = customer.CustomerName
                    dgvCustomers.Rows(rowIndex).Cells(2).Value = customer.CustomerType
                    dgvCustomers.Rows(rowIndex).Cells(3).Value = customer.Email
                    dgvCustomers.Rows(rowIndex).Cells(4).Value = customer.Phone
                    dgvCustomers.Rows(rowIndex).Cells(5).Value = customer.GetCustomerLevel()
                    dgvCustomers.Rows(rowIndex).Cells(6).Value = "Rp " & customer.TotalPurchase.ToString("N0")

                    foundCount += 1
                End If
            Next

            lblStatus.Text = "Found:  " & foundCount & " customer(s) - Jimmi UNSIA"

        Catch ex As Exception
            MessageBox.Show("Error:  " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        RefreshCustomerList()
        lblStatus.Text = "Refreshed - Jimmi UNSIA"
    End Sub

    ' ============================================
    ' FILE OPERATIONS
    ' ============================================

    Private Sub LoadCustomers()
        Try
            If Not File.Exists(dataFile) Then
                LoadSampleData()
                Return
            End If

            customerList.Clear()
            Dim lines() As String = File.ReadAllLines(dataFile)

            For Each line As String In lines
                If line.StartsWith("#") OrElse String.IsNullOrWhiteSpace(line) Then Continue For

                Dim parts() As String = line.Split("|"c)
                If parts.Length >= 15 Then
                    Dim customer As New Customer() With {
                        .CustomerID = parts(0),
                        .CustomerCode = parts(1),
                        .CustomerName = parts(2),
                        .CustomerType = parts(3),
                        .ContactPerson = parts(4),
                        .Email = parts(5),
                        .Phone = parts(6),
                        .Address = parts(7),
                        .City = parts(8),
                        .CreditLimit = CDec(parts(9)),
                        .CurrentCredit = CDec(parts(10)),
                        .TotalPurchase = CDec(parts(11)),
                        .TotalTransactions = CInt(parts(12)),
                        .IsActive = Boolean.Parse(parts(13)),
                        .RegistrationDate = DateTime.Parse(parts(14))
                    }
                    customerList.Add(customer)
                End If
            Next

        Catch ex As Exception
            LoadSampleData()
        End Try
    End Sub

    Private Sub SaveCustomers()
        Try
            Dim dirPath As String = Path.GetDirectoryName(dataFile)
            If Not Directory.Exists(dirPath) Then
                Directory.CreateDirectory(dirPath)
            End If

            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("# Customer Data - Jimmi UNSIA")
            sb.AppendLine("# Saved:  " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            sb.AppendLine("#")

            For Each customer As Customer In customerList
                sb.AppendLine(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}",
                    customer.CustomerID, customer.CustomerCode, customer.CustomerName,
                    customer.CustomerType, customer.ContactPerson, customer.Email, customer.Phone,
                    customer.Address, customer.City, customer.CreditLimit, customer.CurrentCredit,
                    customer.TotalPurchase, customer.TotalTransactions, customer.IsActive,
                    customer.RegistrationDate.ToString("yyyy-MM-dd HH:mm: ss")))
            Next

            File.WriteAllText(dataFile, sb.ToString())

        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSampleData()
        customerList.Clear()

        customerList.Add(New Customer("CUST001", "PT Teknologi Maju", "Corporate", "info@tekmaju.com", "021-12345678") With {
            .ContactPerson = "Budi Santoso", .City = "Jakarta", .TotalPurchase = 125000000, .TotalTransactions = 15
        })
        customerList.Add(New Customer("CUST002", "CV Digital Solusi", "Corporate", "contact@digital.com", "021-87654321") With {
            .ContactPerson = "Siti Rahayu", .City = "Jakarta", .TotalPurchase = 67500000, .TotalTransactions = 8
        })
        customerList.Add(New Customer("CUST003", "Toko Laptop Jaya", "Individual", "laptop@email.com", "021-11223344") With {
            .ContactPerson = "Ahmad Yani", .City = "Bandung", .TotalPurchase = 89250000, .TotalTransactions = 12
        })
        customerList.Add(New Customer("CUST004", "PT Mitra Elektronik", "Corporate", "mitra@elektro.com", "022-99887766") With {
            .ContactPerson = "Dewi Lestari", .City = "Surabaya", .TotalPurchase = 156800000, .TotalTransactions = 19
        })

        SaveCustomers()
    End Sub

    ' ============================================
    ' EXPORT
    ' ============================================

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Using sfd As New SaveFileDialog()
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.FileName = "Customers_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"

                If sfd.ShowDialog() = DialogResult.OK Then
                    Dim sb As New System.Text.StringBuilder()
                    sb.AppendLine("Code,Name,Type,Email,Phone,Level,TotalPurchase")

                    For Each customer In customerList
                        sb.AppendLine(String.Format("{0},{1},{2},{3},{4},{5},{6}",
                            customer.CustomerCode, customer.CustomerName, customer.CustomerType,
                            customer.Email, customer.Phone, customer.GetCustomerLevel(), customer.TotalPurchase))
                    Next

                    File.WriteAllText(sfd.FileName, sb.ToString())
                    MessageBox.Show("Exported successfully!" & vbCrLf & "Jimmi - UNSIA", "Success")
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
                txtCustomerCode.ReadOnly = True
                txtCustomerName.ReadOnly = True
                cboCustomerType.Enabled = False
                txtContactPerson.ReadOnly = True
                txtEmail.ReadOnly = True
                txtPhone.ReadOnly = True
                txtAddress.ReadOnly = True
                txtCity.ReadOnly = True
                nudCreditLimit.Enabled = False
                chkActive.Enabled = False

                btnNew.Enabled = True
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                dgvCustomers.Enabled = True
                isEditMode = False

            Case FormMode.Add
                txtCustomerCode.ReadOnly = False
                txtCustomerName.ReadOnly = False
                cboCustomerType.Enabled = True
                txtContactPerson.ReadOnly = False
                txtEmail.ReadOnly = False
                txtPhone.ReadOnly = False
                txtAddress.ReadOnly = False
                txtCity.ReadOnly = False
                nudCreditLimit.Enabled = True
                chkActive.Enabled = True

                btnNew.Enabled = False
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dgvCustomers.Enabled = False
                isEditMode = False

            Case FormMode.Edit
                txtCustomerCode.ReadOnly = True
                txtCustomerName.ReadOnly = False
                cboCustomerType.Enabled = True
                txtContactPerson.ReadOnly = False
                txtEmail.ReadOnly = False
                txtPhone.ReadOnly = False
                txtAddress.ReadOnly = False
                txtCity.ReadOnly = False
                nudCreditLimit.Enabled = True
                chkActive.Enabled = True

                btnNew.Enabled = False
                btnSave.Enabled = True
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                dgvCustomers.Enabled = False
                isEditMode = True
        End Select
    End Sub

    Private Function GenerateCustomerCode() As String
        Return "CUST" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub dgvCustomers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnEdit.PerformClick()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        MessageBox.Show("Print customer list" & vbCrLf & "Jimmi - UNSIA", "Info")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class