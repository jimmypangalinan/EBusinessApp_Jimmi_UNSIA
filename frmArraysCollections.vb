Public Class frmArraysCollections

    ' Module-level collections
    Private products() As String
    Private prices() As Decimal
    Private productList As New List(Of String)

    Private Sub frmArraysCollections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstArray.Items.Add("Click buttons to see array operations")
        lstCollection.Items.Add("Click buttons to manage list")
        lstDictionary.Items.Add("Click buttons to see different collection types")
    End Sub

    ' ============================================
    ' ARRAY OPERATIONS
    ' ============================================

    Private Sub btnPopulateArray_Click(sender As Object, e As EventArgs) Handles btnPopulateArray.Click
        Try
            ' Initialize ARRAY with E-Business products
            products = New String() {
                "Laptop Dell XPS 13",
                "Mouse Logitech MX Master",
                "Keyboard Mechanical RGB",
                "Monitor Samsung 27 inch",
                "Headset Sony WH-1000XM4",
                "Webcam Logitech C920",
                "SSD Samsung 1TB",
                "RAM Corsair 16GB",
                "Router TP-Link AX3000",
                "Printer Canon G3010"
            }

            prices = New Decimal() {
                15000000, 1200000, 850000, 3500000, 4200000,
                1800000, 2100000, 1500000, 1300000, 2800000
            }

            lstArray.Items.Clear()
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("ARRAY POPULATION")
            lstArray.Items.Add("Developer: Jimmi - UNSIA")
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("")

            ' FOR LOOP - Display array contents
            For i As Integer = 0 To products.Length - 1
                Dim item As String = String.Format("{0,2}. {1,-30} Rp {2,12:N0}",
                    i + 1, products(i), prices(i))
                lstArray.Items.Add(item)
            Next

            lstArray.Items.Add("")
            lstArray.Items.Add("Total Items: " & products.Length)

            MessageBox.Show("Array populated with" & products.Length & "items!" & vbCrLf & "Jimmi - UNSIA", "Success")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnSortArray_Click(sender As Object, e As EventArgs) Handles btnSortArray.Click
        Try
            If products Is Nothing OrElse products.Length = 0 Then
                MessageBox.Show("Please populate array first!", "Warning")
                Return
            End If

            ' SORT array alphabetically
            Array.Sort(products)

            lstArray.Items.Clear()
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("SORTED ARRAY (Ascending)")
            lstArray.Items.Add("Jimmi - UNSIA")
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("")

            ' FOREACH LOOP - Display sorted array
            Dim index As Integer = 1
            For Each product As String In products
                lstArray.Items.Add(String.Format("{0,2}. {1}", index, product))
                index += 1
            Next

            MessageBox.Show("Array sorted successfully!", "Success")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnReverseArray_Click(sender As Object, e As EventArgs) Handles btnReverseArray.Click
        Try
            If products Is Nothing Then
                MessageBox.Show("Please populate array first!", "Warning")
                Return
            End If

            ' REVERSE array
            Array.Reverse(products)

            lstArray.Items.Clear()
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("REVERSED ARRAY")
            lstArray.Items.Add("Developer: Jimmi - UNSIA")
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("")

            For i As Integer = 0 To products.Length - 1
                lstArray.Items.Add((i + 1) & ". " & products(i))
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnSearchArray_Click(sender As Object, e As EventArgs) Handles btnSearchArray.Click
        Try
            If products Is Nothing Then
                MessageBox.Show("Please populate array first!", "Warning")
                Return
            End If

            Dim searchTerm As String = txtSearch.Text.Trim().ToLower()

            If String.IsNullOrEmpty(searchTerm) Then
                MessageBox.Show("Please enter search term!", "Warning")
                Return
            End If

            lstArray.Items.Clear()
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("SEARCH RESULTS")
            lstArray.Items.Add("Search:  " & txtSearch.Text)
            lstArray.Items.Add("Jimmi - UNSIA")
            lstArray.Items.Add("========================================")
            lstArray.Items.Add("")

            Dim found As Boolean = False

            ' FOR LOOP with IF - Search array
            For i As Integer = 0 To products.Length - 1
                If products(i).ToLower().Contains(searchTerm) Then
                    lstArray.Items.Add("FOUND: " & products(i))
                    found = True
                End If
            Next

            If Not found Then
                lstArray.Items.Add("No products found matching:  " & txtSearch.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' LIST (COLLECTION) OPERATIONS
    ' ============================================

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        Try
            Dim newItem As String = txtNewItem.Text.Trim()

            If String.IsNullOrEmpty(newItem) Then
                MessageBox.Show("Please enter an item to add!", "Warning")
                Return
            End If

            ' ADD to List
            productList.Add(newItem)

            RefreshList()
            txtNewItem.Clear()

            MessageBox.Show("Item added!  Total:  " & productList.Count, "Success")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnRemoveFromList_Click(sender As Object, e As EventArgs) Handles btnRemoveFromList.Click
        Try
            If lstCollection.SelectedIndex < 3 Then ' Skip header lines
                MessageBox.Show("Please select an item to remove!", "Warning")
                Return
            End If

            Dim actualIndex As Integer = lstCollection.SelectedIndex - 4 ' Adjust for header

            If actualIndex >= 0 AndAlso actualIndex < productList.Count Then
                Dim item As String = productList(actualIndex)
                productList.RemoveAt(actualIndex)
                RefreshList()
                MessageBox.Show("Removed: " & item, "Success")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        productList.Clear()
        RefreshList()
        MessageBox.Show("List cleared!", "Info")
    End Sub

    Private Sub RefreshList()
        lstCollection.Items.Clear()
        lstCollection.Items.Add("========================================")
        lstCollection.Items.Add("LIST COLLECTION")
        lstCollection.Items.Add("Developer: Jimmi - UNSIA")
        lstCollection.Items.Add("========================================")

        If productList.Count = 0 Then
            lstCollection.Items.Add("(List is empty)")
        Else
            Dim count As Integer = 1
            For Each item As String In productList
                lstCollection.Items.Add(count & ". " & item)
                count += 1
            Next
        End If

        lstCollection.Items.Add("")
        lstCollection.Items.Add("Total:  " & productList.Count & " items")
    End Sub

    ' ============================================
    ' DICTIONARY DEMO
    ' ============================================

    Private Sub btnDictionary_Click(sender As Object, e As EventArgs) Handles btnDictionary.Click
        Try
            ' Create Dictionary (Key-Value pairs)
            Dim productDict As New Dictionary(Of String, Decimal)

            productDict.Add("LAPTOP001", 15000000)
            productDict.Add("MOUSE001", 1200000)
            productDict.Add("KEYB001", 850000)
            productDict.Add("MON001", 3500000)
            productDict.Add("HEAD001", 4200000)

            lstDictionary.Items.Clear()
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("DICTIONARY (Key-Value Pairs)")
            lstDictionary.Items.Add("Developer: Jimmi - UNSIA")
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add(String.Format("{0,-15} {1,15}", "Product Code", "Price"))
            lstDictionary.Items.Add(New String("-"c, 40))

            ' FOREACH with KeyValuePair
            For Each kvp As KeyValuePair(Of String, Decimal) In productDict
                lstDictionary.Items.Add(String.Format("{0,-15} Rp {1,12:N0}", kvp.Key, kvp.Value))
            Next

            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Total Items: " & productDict.Count)
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Dictionary allows fast lookup by KEY")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' QUEUE DEMO (FIFO - First In First Out)
    ' ============================================

    Private Sub btnQueue_Click(sender As Object, e As EventArgs) Handles btnQueue.Click
        Try
            Dim orderQueue As New Queue(Of String)

            ' Enqueue - add to queue
            orderQueue.Enqueue("Order #001 - Customer A")
            orderQueue.Enqueue("Order #002 - Customer B")
            orderQueue.Enqueue("Order #003 - Customer C")
            orderQueue.Enqueue("Order #004 - Customer D")

            lstDictionary.Items.Clear()
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("QUEUE (FIFO - First In First Out)")
            lstDictionary.Items.Add("E-Business:  Order Processing")
            lstDictionary.Items.Add("Developer: Jimmi - UNSIA")
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Orders in Queue:")

            For Each order In orderQueue
                lstDictionary.Items.Add(" - " & order)
            Next

            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Processing orders...")
            lstDictionary.Items.Add("")

            ' WHILE LOOP - Dequeue (process queue)
            While orderQueue.Count > 0
                Dim processed As String = orderQueue.Dequeue()
                lstDictionary.Items.Add("Processed: " & processed)
            End While

            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Queue is now empty!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' STACK DEMO (LIFO - Last In First Out)
    ' ============================================

    Private Sub btnStack_Click(sender As Object, e As EventArgs) Handles btnStack.Click
        Try
            Dim historyStack As New Stack(Of String)

            ' Push - add to stack
            historyStack.Push("Home Page")
            historyStack.Push("Products Page")
            historyStack.Push("Product Details")
            historyStack.Push("Shopping Cart")

            lstDictionary.Items.Clear()
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("STACK (LIFO - Last In First Out)")
            lstDictionary.Items.Add("E-Business: Navigation History")
            lstDictionary.Items.Add("Developer: Jimmi - UNSIA")
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Current Stack (top to bottom):")

            For Each page In historyStack
                lstDictionary.Items.Add("  - " & page)
            Next

            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Going back (Pop)...")
            lstDictionary.Items.Add("")

            ' DO LOOP - Pop items
            Dim counter As Integer = 0
            Do While historyStack.Count > 0 AndAlso counter < 2
                Dim previousPage As String = historyStack.Pop()
                lstDictionary.Items.Add("← Back to:  " & previousPage)
                counter += 1
            Loop

            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Remaining in stack: " & historyStack.Count)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' HASHSET DEMO
    ' ============================================

    Private Sub btnHashSet_Click(sender As Object, e As EventArgs) Handles btnHashSet.Click
        Try
            Dim categories As New HashSet(Of String)

            ' HashSet automatically removes duplicates
            categories.Add("Electronics")
            categories.Add("Accessories")
            categories.Add("Software")
            categories.Add("Electronics") ' Duplicate - will be ignored
            categories.Add("Networking")
            categories.Add("Accessories") ' Duplicate - will be ignored

            lstDictionary.Items.Clear()
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("HASHSET (Unique Items Only)")
            lstDictionary.Items.Add("Developer: Jimmi - UNSIA")
            lstDictionary.Items.Add("========================================")
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Attempted to add 6 items (with duplicates)")
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Unique Categories:")

            For Each cat In categories
                lstDictionary.Items.Add("  - " & cat)
            Next

            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("Total Unique:  " & categories.Count)
            lstDictionary.Items.Add("")
            lstDictionary.Items.Add("HashSet automatically removes duplicates!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class