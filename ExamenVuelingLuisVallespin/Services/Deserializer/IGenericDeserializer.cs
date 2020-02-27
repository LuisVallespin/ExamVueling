using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Deserializer
{
    public interface IGenericDeserializer<T> where T : class
    {
        Task<IEnumerable<T>> Deserialize(string url);
    }
}
