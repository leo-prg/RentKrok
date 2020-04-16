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
    public class RenterService
    {
        public async Task<RenterRect[]> GetRentersAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Renters");
            return JsonConvert.DeserializeObject<RenterRect[]>(json);
        }

        public async Task<RenterRect> GetRenterDetailsAsync(string id)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Renters/"+id);
            return JsonConvert.DeserializeObject<RenterRect>(json);
        }

        public async Task<HttpResponseMessage> DeleteRenterAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{ConnectAPI.apiUri}/api/Renters?id={id}");
        }
        public async Task<HttpResponseMessage> NewRenterAsync(RenterRect renter)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{ConnectAPI.apiUri}api/students", getStringContentFromObject(renter));
        }

        public async Task<HttpResponseMessage> UpdateRenterAsync(RenterRect renter)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{ConnectAPI.apiUri}/api/Renters", getStringContentFromObject(renter));
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }

    }
}
