using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ExamenVuelingLuisVallespin.Services.Mapper;
using ExamenVuelingLuisVallespin.Services.Repository;

namespace ExamenVuelingLuisVallespin.Services.Products
{
    public class SumOfAllProducts : ISumOfAllProducts
    {
        private readonly ITransactionRepository _repository;

        public SumOfAllProducts()
        {

        }

        public SumOfAllProducts(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<Dictionary<string, decimal>> Get()
        {
            var list = new Dictionary<string, decimal>();
            var allTransactions = await _repository.GetAll();
            var allProducts = allTransactions
                .GroupBy(item => item.Sku);
            Dictionary<string,decimal> dictionary = new Dictionary<string, decimal>();
            

            foreach (var product in allProducts)
            {
                decimal amount = 0;
                foreach (var  transaction in product)
                {
                    amount += transaction.Amount;
                }
                dictionary.Add(product.Key, amount);
            }
            return dictionary;
        }
    }
}