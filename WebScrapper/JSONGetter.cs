using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace SWApiCaller.Data
{
    public class JSONGetter
    {

        public JSONGetter()
        {

        }
        public enum HttpVerbs
        {
            GET,
            PUT,
            POST,
            DELETE
        }

        public HttpVerbs HttpMethod { get; set; }

        /// <summary>
        /// makes a http GET request to the provided endpoint 
        /// </summary>
        /// <param name="endPoint">The URI for the API method</param>
        /// <returns>String response value</returns>
        public string MakeRequest(string endPoint)
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request =  (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = HttpMethod.ToString();

            using (HttpWebResponse response =(HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code " + response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using StreamReader reader = new StreamReader(responseStream);
                        strResponseValue = reader.ReadToEnd();
                    }
                }//end of use of responseStream 
            }
            return strResponseValue;
        }
    }
}
