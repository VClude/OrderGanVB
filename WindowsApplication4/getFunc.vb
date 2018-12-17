Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Data.Odbc
Public Class getFunc
    Public Sub getCart()
        Dim request As WebRequest = WebRequest.Create(serverapi + "/cart/liat")
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
            Dim u, d, c As String
            For Each item As JProperty In data
                item.CreateReader()
                Select Case item.Name
                    Case "cart"
                        output += "cart:" + vbCrLf
                        For Each comment As JObject In item.Values
                            u = comment("id_cart")
                            d = comment("nama_hidangan")
                            c = comment("qty")
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
