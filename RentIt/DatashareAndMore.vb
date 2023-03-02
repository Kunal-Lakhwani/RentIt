Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Module DatashareAndMore
    Public ShopName, ShopContact, ShopGSTNo, ShopAddr As String
    Public User_type, Emp_mailID As String
    Public Emp_nme As String
    Public dsReprt As DataSet
    Public payment As Integer
    Public stock As New StockManager
    Public BillHistory As New Bill_History
    Public dash As New Dashboard
    Public BillMaker As New Bill_Maker
    Public purchaseMaster As New purchase_master
    Public EmManager As New Employee_Manager
    Public LogsViewer As New Logs_master
    Public ItemReturn As New Item_Return
    Public ReportPage As New Reports
    'Public purchaseHistory As New Purchase_History
    Public AppSettings As New App_Settings
    Public Itemstbl As New DataTable


    Public Sub btngotfocus(ByVal btn As Object)
        btn.bordercolor = Color.FromArgb(152, 6, 58)
        btn.fillcolor = Color.White
        btn.forecolor = Color.FromArgb(152, 6, 58)
    End Sub

    Public Sub btnlostfocus(ByVal btn As Object)
        btn.bordercolor = Color.Transparent
        btn.fillcolor = Color.FromArgb(152, 6, 58)
        btn.forecolor = Color.White
    End Sub
    Public Function encrypt(ByVal str As String) As String
        Dim encr As String = ""
        Dim chrs() As Char = str
        For i = 0 To chrs.Length - 1
            Dim temp As String = Asc(chrs(i))
            If temp.Length < 3 Then
                temp = "0" & temp
            End If
            encr &= temp
            If i <> chrs.Length - 1 Then
                encr &= " "
            End If
        Next
        Return encr
    End Function
    Public Function decrypt(ByVal str As String) As String
        Dim decr As String = ""
        For Each s As String In str.Split(" ")
            Dim asci As Integer = Val(s)
            If Chr(asci) <> " " Then
                decr &= Chr(asci)
            End If
        Next
        Return decr
    End Function
End Module