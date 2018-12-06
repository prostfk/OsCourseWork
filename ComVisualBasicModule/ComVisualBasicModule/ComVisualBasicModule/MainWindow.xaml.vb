Imports Newtonsoft.Json.Linq
Imports OsLib

Class MainWindow

    Private Sub MainButton_Click(sender As Object, e As RoutedEventArgs)
        Dim city = Me.CityTextBox.Text
        Dim str = JsonUtil.GetJsonFromUrl("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=a94df725636c9b73d516e473151ba6b9")
        Me.Output.Text = ParseJson(str)

    End Sub

    Private Function ParseJson(str As String) As String
        Dim json = JObject.Parse(str)
        json.GetValue("name")
        ParseJson = "City: " + CStr(json("name")) + ", Main:  " + CStr(json("weather")(0)("main")) + ", Description: " +
                          CStr(json("weather")(0)("description")) + ", Temp: " +
                          CStr(json("main")("temp")) + ", Pressure:  " + CStr(json("main")("pressure ")) + ", Humidity: " +
                          CStr(json("main")("humidity"))
    End Function


End Class
