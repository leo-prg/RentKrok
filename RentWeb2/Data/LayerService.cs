using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RentLibrary;

namespace RentWeb2.Data
{
    public class LayerService
    {
        public async Task<LayerRect[]> GetLayersOfObjectAsync(string objectName)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync(ConnectAPI.apiUri + "/api/Layers/"+objectName);
            return JsonConvert.DeserializeObject<LayerRect[]>(json);
        }
    }
}
