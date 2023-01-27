using JuernesCochesApiNuget.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JuernesCochesApiNuget
{
    public class CochesContext
    {
        public async Task<List<Coche>> GetCochesAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string urlApi = "https://apicochespaco.azurewebsites.net/webresources/coches";
            string json =
                await client.DownloadStringTaskAsync(urlApi);
            List<Coche> coches =
                JsonConvert.DeserializeObject<List<Coche>>(json);
            return coches;
        }
    }
}
