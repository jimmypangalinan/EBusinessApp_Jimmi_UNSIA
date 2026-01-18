' ========================================
' CUSTOMER CLASS
' Developer: Jimmi - UNSIA
' E-Business Customer Entity
' ========================================

Public Class Customer

    ' Properties
    Public Property CustomerID As String
    Public Property CustomerCode As String
    Public Property CustomerName As String
    Public Property CustomerType As String ' Individual, Corporate
    Public Property ContactPerson As String
    Public Property Email As String
    Public Property Phone As String
    Public Property Address As String
    Public Property City As String
    Public Property PostalCode As String
    Public Property CreditLimit As Decimal
    Public Property CurrentCredit As Decimal
    Public Property TotalPurchase As Decimal
    Public Property TotalTransactions As Integer
    Public Property IsActive As Boolean
    Public Property RegistrationDate As DateTime
    Public Property LastTransaction As DateTime

    ' Constructor
    Public Sub New()
        CustomerID = Guid.NewGuid().ToString()
        RegistrationDate = DateTime.Now
        LastTransaction = DateTime.Now
        IsActive = True
        TotalTransactions = 0
        TotalPurchase = 0
        CurrentCredit = 0
        CreditLimit = 10000000
    End Sub

    ' Constructor with parameters
    Public Sub New(code As String, name As String, type As String, email As String, phone As String)
        Me.New()
        Me.CustomerCode = code
        Me.CustomerName = name
        Me.CustomerType = type
        Me.Email = email
        Me.Phone = phone
    End Sub

    ' METHODS
    Public Function GetCustomerLevel() As String
        If TotalPurchase >= 100000000 Then
            Return "PLATINUM"
        ElseIf TotalPurchase >= 50000000 Then
            Return "GOLD"
        ElseIf TotalPurchase >= 20000000 Then
            Return "SILVER"
        Else
            Return "BRONZE"
        End If
    End Function

    Public Function GetAvailableCredit() As Decimal
        Return CreditLimit - CurrentCredit
    End Function

    Public Function CanPurchase(amount As Decimal) As Boolean
        Return GetAvailableCredit() >= amount
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1} ({2})", CustomerCode, CustomerName, CustomerType)
    End Function

End Class