using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuernesCochesApiNuget.Models
{
    public class Coche
    {
        [JsonProperty("idcoche")]
        public int IdCoche { get; set; }
        [JsonProperty("marca")]
        public string Marca { get; set; }
        [JsonProperty("modelo")]
        public string Modelo { get; set; }
        [JsonProperty("conductor")]
        public string Conductor { get; set; }
        [JsonProperty("imagen")]
        public string Imagen { get; set; }
    }
}
