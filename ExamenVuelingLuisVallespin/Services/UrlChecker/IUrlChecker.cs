using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVuelingLuisVallespin.Services.UrlChecker
{
    public interface IUrlChecker
    {
        Task<bool> Check(string url);
    }
}
