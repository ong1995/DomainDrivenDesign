using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainDrivenDesign.Domains.Money.Models;

namespace DomainDrivenDesign.Domains.Money.Repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        public void DeleteCurrency(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Currency> GetAllCurrency()
        {
            throw new NotImplementedException();
        }

        public Currency GetCurrency(int id)
        {
            throw new NotImplementedException();
        }
    }
}
