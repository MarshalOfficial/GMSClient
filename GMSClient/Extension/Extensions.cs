using GMSClient.Data;
using Newtonsoft.Json;

namespace GMSClient.Extension
{
    public static class Extensions
    {
        public static string GetBackendErrorMsg(this string json)
        {
            var data = JsonConvert.DeserializeObject<ErrorEntity[]>(json);
            if (data != null && data[0] != null && !string.IsNullOrWhiteSpace(data[0].Txt))
            {
                return data[0].Txt;
            }
            else
                return string.Empty;
        }
    }
}
