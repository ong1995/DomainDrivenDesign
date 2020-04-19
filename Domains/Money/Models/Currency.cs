using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domains.Money.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        private string Name { get; set; }
        private decimal Ratio { get; set; }

        private Currency()
        {

        }

        public Currency(int id, string name, decimal ratio)
        {
            this.Id = id;
            this.Name = name;
            this.Ratio = ratio;
        }

        public string GetName()
        {
            return this.Name;
        }

        public decimal GetRation()
        {
            return this.Ratio;
        }
    }
}
