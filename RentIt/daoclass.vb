Imports System.Data.SqlClient
Public Class daoclass
    Dim conn As New SqlConnection

    Sub New()
        conn.ConnectionString = "Data Source=HP-PC\SQLEXPRESS;Initial Catalog=RentIt_DB;Integrated Security=True"
    End Sub

    Public Function getConnection() As SqlConnection
        Return conn
    End Function

    Public Sub closeconn()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub createlog(ByVal Msg As String)
        Dim v(5), p(5) As String
        v = {Emp_nme, User_type, Msg, Today.ToString("yyyy/MM/dd"), Now.ToString("hh:mm tt")}
        p = {"@nme", "@role", "@rec", "@dte", "@tme"}
        Dim qry As String = "Insert into Logs_Master(Log_Emp,Log_Role,Log_action,Log_date,Log_time) values(@nme,@role,@rec,@dte,@tme)"
        Dim cmd As New SqlCommand(qry, conn)
        For i = 0 To v.Length - 1
            cmd.Parameters.AddWithValue(p(i), v(i))
        Next
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function getdata(ByVal qry As String, ByVal p() As String, ByVal v() As String) As SqlDataReader
        Dim obj As SqlDataReader
        Dim cmd As New SqlCommand(qry, conn)
        For i = 0 To v.Length - 1
            cmd.Parameters.AddWithValue(p(i), v(i))
        Next
        conn.Open()
        obj = cmd.ExecuteReader
        Return obj
    End Function

    Public Function getdata(ByVal qry As String) As SqlDataReader
        Dim obj As SqlDataReader
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        obj = cmd.ExecuteReader
        Return obj
    End Function

    Public Function editdata(ByVal qry As String, ByVal p() As String, ByVal v() As String) As Integer
        Dim num As Integer
        Dim cmd As New SqlCommand(qry, conn)
        For i = 0 To v.Length - 1
            cmd.Parameters.AddWithValue(p(i), v(i))
        Next
        conn.Open()
        num = cmd.ExecuteNonQuery()
        conn.Close()
        Return num
    End Function


    'To be used when performing DML with SQLTransaction object.
    Public Function Transaceditdata(ByVal qry As String, ByVal p() As String, ByVal v() As String, ByVal Transac As SqlTransaction) As Integer
        Dim num As Integer
        Dim cmd As New SqlCommand(qry, conn, Transac)
        For i = 0 To v.Length - 1
            cmd.Parameters.AddWithValue(p(i), v(i))
        Next
        num = cmd.ExecuteNonQuery()
        Return num
    End Function

    Public Function editdata(ByVal qry As String) As Integer
        Dim num As Integer
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        num = cmd.ExecuteNonQuery
        conn.Close()
        Return num
    End Function

    Public Function dataAvail(ByVal qry As String) As Boolean
        Dim obj As SqlDataReader
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        obj = cmd.ExecuteReader
        Dim check As Boolean = False
        While obj.Read
            If obj.Item(0) <> "" Then
                check = True
            End If
        End While
        conn.Close()
        Return check
    End Function

    Public Function datasetfill(ByVal qry As String) As Data.DataSet
        Dim da As New SqlDataAdapter(qry, conn)
        Dim ds As New DataSet
        conn.Open()
        da.SelectCommand.ExecuteReader()
        conn.Close()
        da.Fill(ds)
        Return ds
    End Function

    Public Sub update_Cust_Balance(ByVal contact As Object, ByVal balchange As Integer)
        Dim CustBal As Integer
        Dim Cust As String = ""
        Dim re As SqlDataReader = getdata("Select c_opBal,c_nme from Customer_master where c_contact = " & contact)
        While re.Read
            CustBal = re.Item(0)
            Cust = re.Item(1)
        End While
        closeconn()
        If Cust <> "" Then
            Dim newbal As Integer = CustBal + balchange
            editdata("Update Customer_master set c_opBal = " & newbal & " where c_contact = " & contact)
            createlog(IIf(newbal > CustBal, "Debited", "Credited") & " Rs. " & Math.Abs(balchange) & " on account of " & Cust)
        End If
    End Sub

    Public Function gettot(ByVal qry As String) As Double
        Dim tot As Double = 0
        Dim cmd As New SqlCommand(qry, conn)
        conn.Open()
        tot = cmd.ExecuteScalar
        conn.Close()
        Return tot
    End Function

    Public Function alphanuvalidate(c As Char, hc As Integer) As Boolean
        Return Not (IsNumeric(c) Or LCase(c) >= "a" AndAlso LCase(c) <= "z" OrElse hc = 524296 OrElse hc = 2097184)
    End Function

    Public Function mailvalidate(c As Char, hc As Integer) As Boolean
        Return Not (IsNumeric(c) Or LCase(c) >= "a" AndAlso LCase(c) <= "z" OrElse hc = 524296 OrElse hc = 2097184 OrElse hc = 3014702 OrElse hc = 4194368)
    End Function

    Public Function charvalidate(c As Char, hc As Integer) As Boolean
        Return Not ((LCase(c) >= "a" AndAlso LCase(c) <= "z") AndAlso hc <> 2555943 OrElse (hc = 524296 OrElse hc = 2097184))
    End Function

    Public Function pwdvalidate(c As Char, hc As Integer) As Boolean
        Return Not ((LCase(c) >= "a" AndAlso LCase(c) <= "z") OrElse hc <> 2555943)
    End Function

    Public Function numvalidate(c As Char, hc As Integer) As Boolean
        Return Not (c <> "" AndAlso IsNumeric(c) OrElse hc = 524296)
    End Function

    Friend Function addressvalidate(c As Char, hc As Integer) As Boolean
        Return Not ((LCase(c) >= "a" AndAlso LCase(c) <= "z") OrElse hc <> 2555943 OrElse (hc = 2883268 OrElse hc = 2949165))
    End Function
End Class