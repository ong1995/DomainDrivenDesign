using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domains.Money.Models
{
    public class Balance
    {
        private readonly Dictionary<Currency, double> currencies = new Dictionary<Currency, double>();

        public void AddMoney(Money money)
        {
            if (currencies.ContainsKey(money.GetCurrency()))
            {
                currencies[money.GetCurrency()] = currencies[money.GetCurrency()] + money.GetAmount();
            }
            else
            {
                currencies.Add(money.GetCurrency(), money.GetAmount());
            }
        }

        public void ChargeMoney(Money money)
        {
            if (currencies.ContainsKey(money.GetCurrency()))
            {
                currencies[money.GetCurrency()] = currencies[money.GetCurrency()] - money.GetAmount();
            }
            else
            {
                currencies.Add(money.GetCurrency(), -(money.GetAmount()));
            }
        }
    }
}
