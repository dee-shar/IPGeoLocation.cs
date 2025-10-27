# IPGeoLocation.cs
Web-API for [ipgeolocation.io](https://ipgeolocation.io) Free IP Geolocation API and Accurate IP Lookup Database an free IP API that provides country, city, state, province, local currency, latitude, longitude and etc

## Example
```cs
using IPGeoLocationIoApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new IPGeoLocation();
            api.SetApiKey("apiKey");
            string ipInfo = await api.GetMyIp();
            Console.WriteLine(ipInfo);
        }
    }
}
```
