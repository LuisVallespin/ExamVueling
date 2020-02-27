using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using ExamenVuelingLuisVallespin.Services.Exception;
using Newtonsoft.Json;

namespace ExamenVuelingLuisVallespin.Services.Deserializer
{
    public class GenericDeserializer<T> : IGenericDeserializer<T> where T : class
    {
        public async Task<IEnumerable<T>> Deserialize(string url)
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    var json = wc.DownloadString(url);
                    return await Task.Run(() => JsonConvert.DeserializeObject<List<T>>(json));
                }
                catch (System.Exception ex)
                {
                    throw new DeserializerException("Problema al deserializar", ex);
                }
            }
        }
    }
}