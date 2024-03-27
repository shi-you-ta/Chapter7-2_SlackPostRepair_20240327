Imports System.Net.Http

Public Class Form1
    Private Sub ButPost_Click(sender As Object, e As EventArgs) Handles ButPost.Click
        Dim strWebHookUrl = "https://hooks.slack.com/services/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"
        Dim strData = String.Format("{{'text':'{0}'}}", TxtPost.Text)
        'Dim client = New Net.WebClient()
        Dim cl = New Net.Http.HttpClient()

        'HttpClientクラスでリクエストヘッダーの追加
        cl.DefaultRequestHeaders.Add("ContentType", "application/json;charset=UTF-8")
        'WebClientクラスでリクエストヘッダーの追加
        'client.Headers.Add(Net.HttpRequestHeader.ContentType, "application/json;charset=UTF-8")

        'HttpClientクラスでリクエストデータのエンコーディングを設定
        'String値（strData）からhttpContenntに変換
        Dim content = New StringContent(strData, System.Text.Encoding.UTF8, "application/json")
        'WebClientクラスでリクエストデータのエンコーディングを設定
        'client.Encoding = System.Text.Encoding.UTF8

        'HttpClientクラスでPOSTリクエストの送信
        Dim response = cl.PostAsync(strWebHookUrl, content).Result
        'HttpClientクラスでレスポンスの読み取り
        Dim reply = response.Content.ReadAsStringAsync().Result
        'WebClientクラスでレスポンスの読み取り
        'Dim reply = client.UploadString(strWebHookUrl, strData)

        MessageBox.Show(reply)

    End Sub
End Class
