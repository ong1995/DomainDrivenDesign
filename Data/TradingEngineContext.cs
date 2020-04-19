using DomainDrivenDesign.Domains.Money.Models;
using DomainDrivenDesign.Domains.User.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Data
{
    public class TradingEngineContext : DbContext
    {
        public TradingEngineContext(DbContextOptions<TradingEngineContext> options)
            : base(options)
        {

        }

        public DbSet<Currency> Currencies;
        public DbSet<User> Users;
        public DbSet<DomainDrivenDesign.Domains.Money.Models.Currency> Currency { get; set; }
        public DbSet<DomainDrivenDesign.Domains.User.Models.User> User { get; set; }
    }
}
