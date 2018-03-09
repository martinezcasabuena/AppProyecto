using AppProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace AppProyecto.Utils
{

    public class MyHTTP
    {

        // Get new data rows
        public static async Task GetAllNewsAsync(Action<IEnumerable<EventPlan>> action)
        {

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("https://api.myjson.com/bins/5z61t");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<EventPlan>>(await response.Content.ReadAsStringAsync());
                action(list);
            }

        }
    }
}