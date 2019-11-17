using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace SKM_POC_Framework_Library
{
    public class Program
    {
        public async Task<string> MakeHttpCall()
        {
            return await Http.HttpGet();
        }

        public static string About()
        {
            return "Framework Library 4.5";
        }
    }

    class Http
    {

        public static async Task<string> HttpGet()
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://api.ipify.org/?format=json"),
                    Method = HttpMethod.Get
                };
                var response = client.SendAsync(request).Result;
                var responseString = await response.Content.ReadAsStringAsync();

                return $"API Call From: Framework Library.{Environment.NewLine}" +
                     $"API Call To url : {request.RequestUri.ToString()}.{Environment.NewLine}" +
                       $"API Response : {responseString}.{Environment.NewLine}";
            }
            catch (Exception ex)
            {
                return $"API Call From : Framework Library.{Environment.NewLine}" +
                    $"Error : {ex.Message} {Environment.NewLine} {ex.StackTrace}";
            }
        }

    }
    }
