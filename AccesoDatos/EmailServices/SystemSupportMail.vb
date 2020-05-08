Public Class SystemSupportMail
    Inherits MasterEmailServer

    Public Sub New()
        senderMail = "soportefcialeod@gmail.com"
        password = "@FciaLD1234"
        host = "smtp.gmail.com"
        port = 587
        ssl = True
        initializeSmtpClient()

    End Sub
End Class
