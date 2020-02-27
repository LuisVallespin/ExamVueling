using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.Converter
{
    public interface IConverter
    {
        Task<decimal> Convert(decimal amount, string from, string to);
    }
}
