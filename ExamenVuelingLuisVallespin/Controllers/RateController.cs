using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ExamenVuelingLuisVallespin.Models;
using ExamenVuelingLuisVallespin.Services.Deserializer;
using ExamenVuelingLuisVallespin.Services.Mapper;
using ExamenVuelingLuisVallespin.Services.Repository;
using ExamenVuelingLuisVallespin.Services.UrlChecker;
using Newtonsoft.Json;

namespace ExamenVuelingLuisVallespin.Controllers
{
    public class RateController : Controller
    {
        private readonly IGenericRepository<Rate> _repository;
        private readonly IUrlChecker _urlChecker;
        private readonly IGenericDeserializer<RateJson.Class1> _deserializer;
        private readonly IRateMapper _mapper;

        private readonly string _url = @"http://quiet-stone-2094.herokuapp.com/rates.json";

        public RateController()
        {

        }
        public RateController(IGenericRepository<Rate> repository, IUrlChecker urlChecker,
            IGenericDeserializer<RateJson.Class1> deserializer, IRateMapper mapper)
        {
            _repository = repository;
            _urlChecker = urlChecker;
            _deserializer = deserializer;
            _mapper = mapper;
        }

        // GET: Rate
        public async Task<string> Index()
        {
            var rateList = new List<Rate>();
            if (await _urlChecker.Check(_url))
            {
                var toMapRateList = await _deserializer.Deserialize(_url);
                rateList =  ((List<Rate>)await _mapper.Map(toMapRateList));
                await _repository.Empty();
                await _repository.AddAll(rateList);
            }
            else
            {
                rateList = ((List<Rate>)await _repository.GetAll());
            }

            return JsonConvert.SerializeObject(rateList);
        }
    }
}
