using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApplication1
{
    public class ApiUtil
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
}