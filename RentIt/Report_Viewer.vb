Imports CrystalDecisions.CrystalReports.Engine
Public Class Report_Viewer
    Public ReprtType As String
    Public OrderBy As String

    Public Sub ldata()
        Try
            Dim orpt As New ReportDocument
            Dim ReptFile As New Object

            If ReprtType = "Sales" Then
                Select Case (OrderBy)
                    Case "Date"
                        ReptFile = New Sales_Report_by_Date()
                    Case "Customer"
                        ReptFile = New Sales_Report_by_Customer()
                    Case "No Grouping"
                        ReptFile = New Sales_Report_No_Group()
                End Select
            ElseIf ReprtType = "Purchase" Then
                Select Case (OrderBy)
                    Case "Date"
                        ReptFile = New Purchase_Report_by_Date()
                    Case "Vendor"
                        ReptFile = New Purchase_Report_by_Vendor()
                    Case "No Grouping"
                        ReptFile = New Purchase_Report_no_Group()
                End Select
            End If

            ReptFile.Load()
            orpt.Load(ReptFile.FileName)
            orpt.Refresh()
            orpt.SetDataSource(dsReprt.Tables(0))
            CrystalReportViewer1.ReportSource = orpt

            'Emp_nme is a public String of DataShareAndMore Module
            'It is initialized at login with the name of the user

            orpt.SetParameterValue("EmpName", Emp_nme)

            BringToFront()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bill_Print_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldata()
    End Sub
End Class