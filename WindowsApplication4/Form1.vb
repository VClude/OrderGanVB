Imports System.Net
Imports System.Text
Imports System.IO
Public Class Form1
    Dim logincookie As CookieContainer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Srvaddr()
    End Sub



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim postData As String = "username=" & MetroTextBox1.Text & "&password=" & MetroTextBox2.Text & ""
        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)

        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create(server + "/ci/login/makeLogin"), HttpWebRequest)
        postReq.Method = "POST"
        Srvaddr()
        postReq.KeepAlive = True
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "application/x-www-form-urlencoded"
        postReq.Referer = server + "/ci/login/makeLogin"
        postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
        postReq.ContentLength = byteData.Length

        Dim postreqstream As Stream = postReq.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()
        Dim postresponse As HttpWebResponse
        Try
            postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
            MsgBox("Login Berhasil")
            Dim awe As New Form2
            awe.LabelNama.Text = MetroTextBox1.Text
            awe.Show()
            Hide()

            ''Dim postreqreader As New StreamReader(postresponse.GetResponseStream())
            ''Dim thepage As String = postreqreader.ReadToEnd
            ''WebBrowser1.DocumentText = thepage
        Catch ex As WebException
            postresponse = DirectCast(ex.Response, HttpWebResponse)
            MetroLabel1.Text = "Invalid Password"
        End Try


    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim result As Integer = MessageBox.Show("Exit Application ?", "OrderGan", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        ElseIf result = DialogResult.No Then

        End If

    End Sub
End Class
