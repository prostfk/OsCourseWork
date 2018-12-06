using System;
using System.Threading;
using System.Windows;
using System.Windows.Media.Media3D;
using Newtonsoft.Json.Linq;
using OsLib;

namespace ComCSharpModule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainButton_OnClick(object sender, RoutedEventArgs e)
        {
            var city = this.CityTextBox.Text;
            var jsonFromUrl = JsonUtil.GetJsonFromUrl("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=a94df725636c9b73d516e473151ba6b9");
            dynamic parsed = JObject.Parse(jsonFromUrl);

            Output.Text = "City: " + parsed.name + ", Main:  " + parsed.weather[0].main + ", Description: " +
                          parsed.weather[0].description + ", Temp: " +
                          parsed.main.temp + ", Pressure:  " + parsed.main.pressure + ", Humidity: " + 
                          parsed.main.humidity;
        }
        
        
    }
}