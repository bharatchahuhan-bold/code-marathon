using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CodeMarathon.ResumeBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        static HttpClient client = new HttpClient();

        public HealthController()
        {
        }

        [HttpGet("Status")]
        public async Task<IActionResult> GetHealthStatus()
        {
            string authUrl = "https://www.linkedin.com/uas/oauth2/accessToken";
            var apiKey = "77utgl2wd203sw";
            var apiSecret = "lZr1CTKBbgOwXoHc";
            var redirectUrl = "http://127.0.0.1:5500/index.html";
            var code = "AQTtcNeU8ohcjsUGR-ZU2rqJaZmp7gNft2UYK-bj_vv3RbQLAgwyh3vcys-PNVMDCwEeztU6e_NwThBRNGYOe5I-FrQCsgNpsOK-UBVee3Mhx7V-59aEEfrXmcvNlA3md3Ky6HtFf0AiokCJKzG_Q6eLA3IaD939VYXLZTK9_zJPAHVY7t0ARykMZIhldgRVsuU2FMwyyGjmS1frLUA";
            var sign = "grant_type=authorization_code&code=" + HttpUtility.UrlEncode(code) + "&redirect_uri=" + HttpUtility.HtmlEncode(redirectUrl) + "&client_id=" + apiKey + "&client_secret=" + apiSecret;
            //byte[] byteArray = Encoding.UTF8.GetBytes(sign);

       /*     try
            {
                dynamic jresult;
                NameValueCollection parameters = new NameValueCollection {
                                                {"client_id", apiKey},
                                                {"client_secret", apiSecret},
                                                {"grant_type", "authorization_code"},
                                                {"redirect_uri", "http%3A%2F%2F127.0.0.1%3A5500%2Findex.html"},
                                                {"code", code}
                                            };
                WebClient client = new WebClient();
                byte[] result = client.UploadValues("https://www.linkedin.com/oauth/v2/accessToken", "POST", parameters);
                string response = System.Text.Encoding.Default.GetString(result);
                string accessToken = JsonConvert.DeserializeObject<dynamic>(response).access_token;

                WebRequest webReq = WebRequest.Create("https://api.linkedin.com/v1/people/~:(id,email-address,first-name,last-name)?format=json");
                webReq.Method = "GET";
                webReq.Headers.Add("Authorization", "Bearer " + accessToken);
                HttpWebResponse webResponse = (HttpWebResponse)webReq.GetResponse();
                using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    string objText = reader.ReadToEnd();
                    jresult = JsonConvert.DeserializeObject<dynamic>(objText);
                }

            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message.ToString());
            }
            




*/

         /*   try
            {
                HttpWebRequest webRequest = WebRequest.Create(authUrl + "?" + sign) as HttpWebRequest;
                webRequest.Method = "POST";
                webRequest.ContentType = "application/x-www-form-urlencoded";

                Stream dataStream = webRequest.GetRequestStream();

                String postData = String.Empty;
                byte[] postArray = Encoding.ASCII.GetBytes(postData);

                dataStream.Write(postArray, 0, postArray.Length);
                dataStream.Close();

                WebResponse response = webRequest.GetResponse();
                dataStream = response.GetResponseStream();


                StreamReader responseReader = new StreamReader(dataStream);
                String returnVal = responseReader.ReadToEnd().ToString();
                responseReader.Close();
                dataStream.Close();
                response.Close();
                Console.WriteLine(returnVal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
           */

            return Ok($"App is up at {DateTime.UtcNow}  UTC.");
        }
    }

    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
