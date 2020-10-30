using GMSClient.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GMSClient.Extension
{
    public static class Extensions
    {

        public static string SucceedMessage = @"با موفقیت انجام شد";

        public static string GetBackendErrorMsg(this string json)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<ErrorEntity[]>(json);
                if (data != null && data[0] != null && data[0].Result.ToStringEmpty().ToLower().Contains("error") && !string.IsNullOrWhiteSpace(data[0].Txt))
                {
                    return data[0].Txt;
                }
                else
                    return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string ToStringEmpty(this object str)
        {
            try
            {
                return Convert.ToString(str);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static long ToLong(this object str)
        {
            try
            {
                return Convert.ToInt64(str);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool ToBool(this object str)
        {
            try
            {
                return Convert.ToBoolean(str);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
