using DomainDrivenDesign.Domains.Money.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domains.Money.Repository
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetAllCurrency();
        void DeleteCurrency(int id);
        Currency GetCurrency(int id); 
    }
}
