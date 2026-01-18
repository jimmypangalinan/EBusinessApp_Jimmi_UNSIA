' ========================================
' PRODUCT CLASS
' Developer: Jimmi - UNSIA
' E-Business Product Entity
' ========================================

Public Class Product

    ' Properties
    Public Property ProductID As String
    Public Property ProductCode As String
    Public Property ProductName As String
    Public Property Category As String
    Public Property Price As Decimal
    Public Property Stock As Integer
    Public Property MinStock As Integer
    Public Property Supplier As String
    Public Property Description As String
    Public Property IsActive As Boolean
    Public Property CreatedDate As DateTime
    Public Property LastModified As DateTime

    ' Constructor (default)
    Public Sub New()
        ProductID = Guid.NewGuid().ToString()
        CreatedDate = DateTime.Now
        LastModified = DateTime.Now
        IsActive = True
        MinStock = 10
    End Sub

    ' Constructor with parameters
    Public Sub New(code As String, name As String, category As String, price As Decimal, stock As Integer)
        Me.New()
        Me.ProductCode = code
        Me.ProductName = name
        Me.Category = category
        Me.Price = price
        Me.Stock = stock
    End Sub

    ' METHODS
    Public Function GetStockStatus() As String
        If Stock <= 0 Then
            Return "OUT OF STOCK"
        ElseIf Stock <= MinStock Then
            Return "LOW STOCK"
        ElseIf Stock <= MinStock * 2 Then
            Return "NORMAL"
        Else
            Return "SUFFICIENT"
        End If
    End Function

    Public Function GetStockValue() As Decimal
        Return Price * Stock
    End Function

    Public Function NeedsReorder() As Boolean
        Return Stock <= MinStock
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1} (Stock: {2})", ProductCode, ProductName, Stock)
    End Function

End Class