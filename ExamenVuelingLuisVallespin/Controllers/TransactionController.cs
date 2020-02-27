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
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _repository;
        private readonly IUrlChecker _urlChecker;
        private readonly IGenericDeserializer<TransactionJson.Class1> _deserializer;
        private readonly ITransactionMapper _mapper;

        private readonly string _url = @"http://quiet-stone-2094.herokuapp.com/transactions.json";

        public TransactionController()  
        {

        }
        public TransactionController(ITransactionRepository repository, IUrlChecker urlChecker,
            IGenericDeserializer<TransactionJson.Class1> deserializer, ITransactionMapper mapper)
        {
            _repository = repository;
            _urlChecker = urlChecker;
            _deserializer = deserializer;
            _mapper = mapper;
        }

        // GET: Transaction
        public async Task<string> Index()
        {
            var transactionList = new List<Transaction>();
            if (await _urlChecker.Check(_url))
            {
                var toMapTransactionList = await _deserializer.Deserialize(_url);
                transactionList = ((List<Transaction>)await _mapper.Map(toMapTransactionList));
                await _repository.Empty();
                await _repository.AddAll(transactionList);
            }
            else
            {
                transactionList = ((List<Transaction>)await _repository.GetAll());
            }

            return JsonConvert.SerializeObject(transactionList);
        }
        
    }
}
