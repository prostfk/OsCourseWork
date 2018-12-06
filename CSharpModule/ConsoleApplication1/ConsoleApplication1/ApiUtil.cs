using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApplication1
{
    [Guid("8C034F6A-1D3F-4DB8-BC99-B73873D8C297")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class ApiUtil : IJsonRequest
    {
        public string GetJsonFromUrl(string url)
        {
            HttpWebRequest request =
                (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 ....";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            return output.ToString();
        }
    }
    [Guid("364C5E66-4412-48E3-8BD8-7B2BF09E8922")]
    [ComVisible(true)]
    interface IJsonRequest
    {
        string GetJsonFromUrl(string url);
    }

}