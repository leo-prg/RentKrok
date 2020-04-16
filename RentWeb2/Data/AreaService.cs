using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RentLibrary;

namespace RentWeb2.Data
{
    public class AreaService
    {
        public async Task<RenterRect> GetAreaRenterAsync(int areaId)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Areas/"+areaId.ToString());
            return JsonConvert.DeserializeObject<RenterRect>(json);
        }

        public async Task<HttpResponseMessage> NoRentAreaAsync(string areaName)
        {
            var client = new HttpClient();
            return await client.PostAsync(ConnectAPI.apiUri + "/api/Areas/NoRenter?name="+areaName,null);
        }

        public async Task<HttpResponseMessage> SetRenterAreaAsync(string areaName, int id)
        {
            var client = new HttpClient();
            return await client.PutAsync(ConnectAPI.apiUri + "/api/Areas/AddRenter?name=" + areaName + "&id=" + id.ToString(), null);
        }

        public async Task<HttpResponseMessage> UpdateAreaAsync(AreaRect area)
        {
            var client = new HttpClient();
            return await client.PutAsync(ConnectAPI.apiUri + "/api/Areas/", getStringContentFromObject(area));
        }

        public async Task<AreaRect> GetAreaByPointAsync(string id_layer, int x, int y)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Areas?id=" + id_layer + "&x=" + x.ToString() + "&y=" + y.ToString());
            return JsonConvert.DeserializeObject<AreaRect>(json);
        }
        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
