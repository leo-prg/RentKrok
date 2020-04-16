using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RentLibrary;

namespace RentWeb2.Data
{
    public class ObjectService
    {
        public async Task<ObjectRect[]> GetObjectsAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Objects");
            return JsonConvert.DeserializeObject<ObjectRect[]>(json);
        }

        public async Task<AreaRect[]> GetObjectsAreasAsync(string areaId)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Objects"+areaId);
            return JsonConvert.DeserializeObject<AreaRect[]>(json);
        }

    }
}
