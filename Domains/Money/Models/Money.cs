using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domains.Money.Models
{
    public class Money
    {
        private readonly Currency currency;
        private readonly double amount;

        private Money()
        {

        }

        public Money(Currency currency, double amount)
        {
            this.currency = currency;
            this.amount = amount;
        }

        public Currency GetCurrency()
        {
            return currency;
        }

        public double GetAmount()
        {
            return amount;
        }
    }
}
