using System.Net.Http;
using System.Net.Http.Headers;

namespace IPGeoLocationApi
{
    public class IPGeoLocation
    {
        private string apiKey;
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.ipgeolocation.io";
        public IPGeoLocation()
        {

            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void SetApiKey(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<string> GetIpInfo(string ip)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ipgeo?apiKey={apiKey}&ip={ip}");
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> GetMyIp()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/ipgeo?apiKey={apiKey}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
