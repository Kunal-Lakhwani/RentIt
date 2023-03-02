Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            MessageBox.Show("An Instance of the Applicaiton already exists")
            CType(sender, Form).Close()
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim d As New daoclass
            Dim re As SqlClient.SqlDataReader
            re = d.getdata("Select * from shop_master")
            While re.Read
                'Initialize DataShareAndMore data members with shop details
                ShopContact = re.Item(0)
                ShopName = re.Item(1)
                ShopGSTNo = re.Item(2)
                ShopAddr = re.Item(3)
            End While
            d.closeconn()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show(
                "Something went wrong." & vbCrLf & "Please contact us for help"
            )

            Application.Log.WriteException(
                e.Exception,
                TraceEventType.Error,
                "Error in " & sender.Name & " page.")
        End Sub
    End Class
End Namespace
