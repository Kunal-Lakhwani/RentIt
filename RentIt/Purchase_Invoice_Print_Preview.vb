Imports CrystalDecisions.CrystalReports.Engine
Public Class Purchase_Invoice_Print_Preview

    Public PurchaseDate As String = ""
    Public InvNo As Integer = 1

    Private Sub Purchase_Invoice_Print_Preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dao As New daoclass
        Dim orpt As New ReportDocument
        Dim d As New Purchase_Invoice_Print
        d.Load()
        orpt.Load(d.FileName)
        orpt.Refresh()

        'Fetch all details regarding the Purchase
        Dim ds As DataSet =
            dao.datasetfill(
                "Select * from purchase_Details det, purchase_Master p
                 where p.p_invno = det.pur_inv_no and p.p_invno = " & InvNo)

        'Fetch Supplier Contact no in seperate variable
        Dim SupplierContact As String = ds.Tables(0).Rows(0)("p_vendor_contact")

        orpt.SetDataSource(ds.Tables(0))
        CrystalReportViewer1.ReportSource = orpt

        'Load Shop Details from Settings
        orpt.SetParameterValue("ShopNme", My.Settings.Item("ClientShopName"))
        orpt.SetParameterValue("ShopContact", My.Settings.Item("ClientShopContact"))
        orpt.SetParameterValue("ShopGSTNo", My.Settings.Item("ClientShopGSTNo"))
        orpt.SetParameterValue("ShopAddr", My.Settings.Item("ClientShopAddress"))

        'Load Supplier Details using Contact no
        Dim Re As SqlClient.SqlDataReader =
            dao.getdata(
            "Select * from Vendor_Master where ven_contact = " & SupplierContact)
        While Re.Read
            orpt.SetParameterValue("SupplierNme", Re.Item(0))
            orpt.SetParameterValue("SupplierContact", Re.Item(1))
            orpt.SetParameterValue("SupplierAddr", Re.Item(2))
            orpt.SetParameterValue("SupplierGSTNo", Re.Item(3))
        End While
        dao.closeconn()

        'Invoice Details fill
        orpt.SetParameterValue("InvNo", InvNo)
        orpt.SetParameterValue("PurchaseDate", PurchaseDate)
        BringToFront()
    End Sub

    Private Sub Purchase_Invoice_Print_Preview_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            CrystalReportViewer1.PrintReport()
        End If
    End Sub
End Class