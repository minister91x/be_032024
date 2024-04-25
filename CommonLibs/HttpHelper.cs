using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibs
{
    public static class HttpHelper
    {
        public static async Task<string> SendPost(string url, string baserUrl, string jsonData)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //POST Method
                    
                    StringContent queryString = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(baserUrl, queryString);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }

                    return string.Empty;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public static async Task<string> SendGET(string url, string baserUrl)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //GET Method

                    var response = await client.GetAsync(baserUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("Internal server Error");
                    }

                    return string.Empty;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
