Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim req As HttpWebRequest = HttpWebRequest.CreateHttp("http://125.166.114.8/ci/login/logout")
        Dim resp As HttpWebResponse
        Try
            resp = DirectCast(req.GetResponse(), HttpWebResponse)
            MsgBox("Logout Sukses")
            Dim awe As New Form1
            awe.Show()
            Close()
        Catch ex As WebException
            resp = DirectCast(ex.Response, HttpWebResponse)
            MsgBox("Logout Gagal")

        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim request As WebRequest = WebRequest.Create("http://125.166.114.8:8000/cart/liat")
        request.Method = "POST"
        Dim postData As String
        postData = "dataretrieve=all"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        If responseFromServer = "401" Then
            MsgBox("Unauthorized")
        Else
            Dim json As String = responseFromServer
            Dim ser As JObject = JObject.Parse(json)
            Dim data As List(Of JToken) = ser.Children().ToList
            Dim output As String = ""

            For Each item As JProperty In data
                item.CreateReader()
                Select Case item.Name
                    Case "cart"
                        output += "cart:" + vbCrLf
                        For Each comment As JObject In item.Values
                            Dim u As String = comment("id_cart")
                            Dim d As String = comment("nama_hidangan")
                            Dim c As String = comment("qty")
                            output += u + vbTab + d + vbTab + c + vbCrLf
                        Next

                End Select
            Next
            MsgBox(output)
        End If
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub
End Class