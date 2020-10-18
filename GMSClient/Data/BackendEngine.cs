using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace GMSClient.Data
{
    public class BackendEngine
    {        
        public static TokenEntity Login(string username, string password)
        {
            try
            {
                var APIBackendBase = Startup.APIURL;

                string result;
                
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(APIBackendBase + "/token");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"" + username + "\"," +
                                  "\"password\":\"" + password + "\"}";

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                var token = JsonConvert.DeserializeObject<TokenEntity>(result);

                return token;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static string Call(string procname, string param, string jwt)
        {
            try
            {
                var APIBackendBase = Startup.APIURL;

                string result;

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(APIBackendBase + "/BackendEngineBody/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers.Add("Authorization", "Bearer " + jwt);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"procname\":\"" + procname + "\"," +
                                  "\"params\":\"" + param + "\"}";

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                var obj = JsonConvert.DeserializeObject<dynamic>(result);

                return obj;
            }
            catch (Exception ex)
            {
                return "[{\"Result\":\"Error\",\"Txt\":\"" + ex.Message + "\"}]";
            }
        }
    }
}