using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ExamenVuelingLuisVallespin.Services.Converter;
using ExamenVuelingLuisVallespin.Services.Exception;
using ExamenVuelingLuisVallespin.Services.Mapper;
using ExamenVuelingLuisVallespin.Services.Repository;

namespace ExamenVuelingLuisVallespin.Services.Products
{
    public class SumOfAllProducts : ISumOfAllProducts
    {
        private readonly ITransactionRepository _repository;
        private readonly IConverter _converter;

        public SumOfAllProducts()
        {

        }

        public SumOfAllProducts(ITransactionRepository repository, IConverter converter)
        {
            _repository = repository;
            _converter = converter;
        }

        public async Task<Dictionary<string, decimal>> Get()
        {
            try
            {
                var list = new Dictionary<string, decimal>();
                var allTransactions = await _repository.GetAll();
                var allProducts = allTransactions
                    .GroupBy(item => item.Sku);
                Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();
                foreach (var product in allProducts)
                {
                    var totalAmount = 0m;
                    var amount = 0m;
                    foreach (var transaction in product)
                    {

                        switch (transaction.Currency)
                        {
                            case "EUR":
                                amount = transaction.Amount;
                                break;
                            default:
                                amount = await _converter.Convert(transaction.Amount, transaction.Currency, "EUR");
                                break;
                        }

                        totalAmount += amount;
                    }

                    dictionary.Add(product.Key, totalAmount);
                }

                return dictionary;
            }
            catch (System.Exception ex)
            {
                throw new SumOfAllProductsExceptions("Fallo en SumOfAllProducts al hacer el cálculo", ex);
            }
            
        }
    }
}