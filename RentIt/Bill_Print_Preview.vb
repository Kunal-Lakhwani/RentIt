Imports CrystalDecisions.CrystalReports.Engine
Public Class Bill_Print_Preview
    Public ParamVals(7) As String

    Public Sub ldata()
        Try
            Dim orpt As New ReportDocument
            Dim d As New Bill_Print
            d.Load()
            orpt.Load(d.FileName)
            orpt.Refresh()
            orpt.SetDataSource(dsReprt.Tables(0))
            CrystalReportViewer1.ReportSource = orpt

            orpt.SetParameterValue("BillID", ParamVals(0))
            orpt.SetParameterValue("BillDate", ParamVals(1))
            orpt.SetParameterValue("CustName", ParamVals(2))
            orpt.SetParameterValue("CustNo", ParamVals(3))
            orpt.SetParameterValue("Subtot", ParamVals(4))
            orpt.SetParameterValue("disc", ParamVals(5))
            orpt.SetParameterValue("gtot", ParamVals(6))
            orpt.SetParameterValue("ShopName", ShopName)
            orpt.SetParameterValue("ShopContact", ShopContact)
            orpt.SetParameterValue("ShopAddr", ShopAddr)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReportingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BringToFront()
        ldata()
    End Sub

    Private Sub Bill_Print_Preview_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            CrystalReportViewer1.PrintReport()
        End If
    End Sub
End Class