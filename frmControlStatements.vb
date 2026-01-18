Public Class frmControlStatements

    Private Sub frmControlStatements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set sample values
        txtProductCode.Text = "LAP001"
        nudQuantity.Value = 25
        nudPrice.Value = 1000000
        nudTotalPurchase.Value = 75000000
        nudMemberYears.Value = 3
    End Sub

    ' ============================================
    ' SELECT CASE STATEMENT
    ' ============================================
    Private Sub btnCheckCategory_Click(sender As Object, e As EventArgs) Handles btnCheckCategory.Click
        Try
            Dim productCode As String = txtProductCode.Text.Trim().ToUpper()

            If String.IsNullOrWhiteSpace(productCode) Then
                MessageBox.Show("Please enter product code!", "Warning")
                Return
            End If

            ' SET BREAKPOINT HERE (F9) - Watch:  productCode

            Dim category As String = ""
            Dim description As String = ""
            Dim color As Color = Color.White

            ' Get first 3 characters for category check
            Dim prefix As String = ""
            If productCode.Length >= 3 Then
                prefix = productCode.Substring(0, 3)
            End If

            ' SELECT CASE STATEMENT
            Select Case prefix
                Case "LAP"
                    category = "LAPTOPS & COMPUTERS"
                    description = "High-performance computing devices for business and personal use"
                    color = Color.LightBlue

                Case "ACC"
                    category = "ACCESSORIES"
                    description = "Computer peripherals, mouse, keyboards, and add-ons"
                    color = Color.LightGreen

                Case "MOB"
                    category = "MOBILE DEVICES"
                    description = "Smartphones, tablets, and mobile accessories"
                    color = Color.LightPink

                Case "AUD"
                    category = "AUDIO EQUIPMENT"
                    description = "Headsets, speakers, microphones, and audio devices"
                    color = Color.LightYellow

                Case "NET"
                    category = "NETWORKING"
                    description = "Routers, switches, cables, and network equipment"
                    color = Color.LightCoral

                Case "MON"
                    category = "MONITORS & DISPLAYS"
                    description = "Computer monitors, displays, and screen accessories"
                    color = Color.LightCyan

                Case "STO"
                    category = "STORAGE DEVICES"
                    description = "Hard drives, SSDs, flash drives, and storage solutions"
                    color = Color.LightSalmon

                Case Else
                    category = "UNKNOWN CATEGORY"
                    description = "Product code not recognized.  Please check the code."
                    color = Color.LightGray
            End Select

            ' Display result
            lblCategoryResult.BackColor = color
            lblCategoryResult.Text = String.Format(
                "Product Code: {0}" & vbCrLf &
                "" & vbCrLf &
                "Category: {1}" & vbCrLf &
                "" & vbCrLf &
                "Description:" & vbCrLf &
                "{2}" & vbCrLf &
                "" & vbCrLf &
                "Developer: Jimmi - UNSIA",
                productCode, category, description)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Jimmi - UNSIA", "Error")
        End Try
    End Sub

    ' ============================================
    ' IF-ELSEIF-ELSE STATEMENT
    ' ============================================
    Private Sub btnCalculateDiscount_Click(sender As Object, e As EventArgs) Handles btnCalculateDiscount.Click
        Try
            Dim quantity As Integer = CInt(nudQuantity.Value)
            Dim pricePerUnit As Decimal = nudPrice.Value
            Dim totalPrice As Decimal = quantity * pricePerUnit

            ' SET BREAKPOINT HERE - Watch: quantity, pricePerUnit, totalPrice

            Dim discountPercent As Decimal = 0
            Dim discountReason As String = ""
            Dim discountColor As Color = Color.White

            ' NESTED IF STATEMENTS - Complex discount logic
            If quantity >= 100 Then
                ' Large order discounts
                If totalPrice >= 50000000 Then
                    discountPercent = 25
                    discountReason = "SUPER BULK DISCOUNT" & vbCrLf & "(100+ items & Rp 50M+)"
                    discountColor = Color.LightGreen
                ElseIf totalPrice >= 20000000 Then
                    discountPercent = 20
                    discountReason = "BULK DISCOUNT" & vbCrLf & "(100+ items & Rp 20M+)"
                    discountColor = Color.LightYellow
                Else
                    discountPercent = 15
                    discountReason = "QUANTITY DISCOUNT" & vbCrLf & "(100+ items)"
                    discountColor = Color.LightBlue
                End If

            ElseIf quantity >= 50 Then
                discountPercent = 10
                discountReason = "MEDIUM ORDER" & vbCrLf & "(50-99 items)"
                discountColor = Color.LightCyan

            ElseIf quantity >= 20 Then
                discountPercent = 5
                discountReason = "SMALL ORDER" & vbCrLf & "(20-49 items)"
                discountColor = Color.LightYellow

            ElseIf quantity >= 10 Then
                discountPercent = 2
                discountReason = "STARTER DISCOUNT" & vbCrLf & "(10-19 items)"
                discountColor = Color.White

            Else
                discountPercent = 0
                discountReason = "NO DISCOUNT" & vbCrLf & "(Less than 10 items)"
                discountColor = Color.LightGray
            End If

            ' Additional bonus using AND/OR operators
            Dim additionalBonus As Decimal = 0
            If (quantity > 50 And totalPrice > 10000000) Or (quantity > 200) Then
                additionalBonus = 3
                discountReason &= vbCrLf & "+ 3% LOYALTY BONUS"
            End If

            Dim finalDiscountPercent As Decimal = discountPercent + additionalBonus
            Dim discountAmount As Decimal = totalPrice * (finalDiscountPercent / 100)
            Dim finalPrice As Decimal = totalPrice - discountAmount

            ' Display result
            lblDiscountResult.BackColor = discountColor
            lblDiscountResult.Text = String.Format(
                "Quantity :  {0} items" & vbCrLf &
                "Price/Unit:  Rp {1:N0}" & vbCrLf &
                "Subtotal  : Rp {2:N0}" & vbCrLf &
                "" & vbCrLf &
                "Discount  : {3}%" & vbCrLf &
                "{4}" & vbCrLf &
                "" & vbCrLf &
                "Saved     : Rp {5:N0}" & vbCrLf &
                "TOTAL     : Rp {6:N0}",
                quantity, pricePerUnit, totalPrice,
                finalDiscountPercent, discountReason,
                discountAmount, finalPrice)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ============================================
    ' NESTED IF STATEMENTS
    ' ============================================
    Private Sub btnCheckStatus_Click(sender As Object, e As EventArgs) Handles btnCheckStatus.Click
        Try
            Dim totalPurchase As Decimal = nudTotalPurchase.Value
            Dim memberYears As Integer = CInt(nudMemberYears.Value)
            Dim isPremium As Boolean = chkPremiumMember.Checked

            ' SET BREAKPOINT HERE - Watch all variables

            Dim customerLevel As String = ""
            Dim benefits As String = ""
            Dim specialOffer As String = ""
            Dim statusColor As Color = Color.White

            ' COMPLEX NESTED IF with multiple conditions
            If totalPurchase >= 100000000 Then
                ' PLATINUM LEVEL
                customerLevel = "PLATINUM"
                statusColor = Color.FromArgb(229, 228, 226)

                If isPremium Then
                    benefits = "✓ 30% Permanent Discount" & vbCrLf &
                              "✓ Free Shipping Lifetime" & vbCrLf &
                              "✓ Priority Support 24/7" & vbCrLf &
                              "✓ Exclusive Product Access" & vbCrLf &
                              "✓ Annual Gift Package"

                    If memberYears >= 5 Then
                        specialOffer = "🎁 SPECIAL:  10-Year Member Bonus!"
                    ElseIf memberYears >= 3 Then
                        specialOffer = "🎁 SPECIAL: Extended Warranty Free!"
                    End If
                Else
                    benefits = "✓ 25% Permanent Discount" & vbCrLf &
                              "✓ Free Shipping" & vbCrLf &
                              "✓ Priority Support" & vbCrLf &
                              "✓ Product Pre-Order Access"
                End If

            ElseIf totalPurchase >= 50000000 Then
                ' GOLD LEVEL
                customerLevel = "GOLD"
                statusColor = Color.FromArgb(255, 223, 0)

                If isPremium Then
                    benefits = "✓ 20% Permanent Discount" & vbCrLf &
                              "✓ Free Shipping" & vbCrLf &
                              "✓ Priority Email Support" & vbCrLf &
                              "✓ Birthday Voucher"

                    If memberYears >= 3 Then
                        specialOffer = "🎁 Eligible for Platinum Upgrade!"
                    End If
                Else
                    benefits = "✓ 15% Permanent Discount" & vbCrLf &
                              "✓ Reduced Shipping Fee" & vbCrLf &
                              "✓ Email Support"
                End If

            ElseIf totalPurchase >= 20000000 Then
                ' SILVER LEVEL
                customerLevel = "SILVER"
                statusColor = Color.FromArgb(192, 192, 192)

                If isPremium Then
                    benefits = "✓ 12% Permanent Discount" & vbCrLf &
                              "✓ Reduced Shipping Fee" & vbCrLf &
                              "✓ Email Support" & vbCrLf &
                              "✓ Monthly Deals"
                Else
                    benefits = "✓ 8% Permanent Discount" & vbCrLf &
                              "✓ Standard Shipping" & vbCrLf &
                              "✓ Email Support"
                End If

                If memberYears >= 2 Then
                    specialOffer = "🎁 Eligible for Gold Upgrade!"
                End If

            Else
                ' BRONZE LEVEL
                customerLevel = "BRONZE"
                statusColor = Color.FromArgb(205, 127, 50)

                If isPremium Then
                    benefits = "✓ 7% Permanent Discount" & vbCrLf &
                              "✓ Standard Shipping" & vbCrLf &
                              "✓ Email Support"
                Else
                    benefits = "✓ 5% Permanent Discount" & vbCrLf &
                              "✓ Standard Shipping"
                End If

                If totalPurchase >= 15000000 Then
                    specialOffer = "💰 Only Rp 5M more to Silver!"
                End If
            End If

            ' Build result display
            Dim result As New System.Text.StringBuilder()
            result.AppendLine("========================================")
            result.AppendLine("   CUSTOMER STATUS REPORT")
            result.AppendLine("   Developer: Jimmi - UNSIA")
            result.AppendLine("========================================")
            result.AppendLine("")
            result.AppendLine("LEVEL: " & customerLevel)
            result.AppendLine("")
            result.AppendLine("Total Purchase: Rp " & totalPurchase.ToString("N0"))
            result.AppendLine("Member Since  : " & memberYears & " years")
            result.AppendLine("Premium Member: " & If(isPremium, "YES", "NO"))
            result.AppendLine("")
            result.AppendLine("BENEFITS:")
            result.AppendLine(benefits)

            If Not String.IsNullOrEmpty(specialOffer) Then
                result.AppendLine("")
                result.AppendLine(specialOffer)
            End If

            result.AppendLine("")
            result.AppendLine("========================================")

            lblStatusResult.BackColor = statusColor
            lblStatusResult.Text = result.ToString()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

End Class