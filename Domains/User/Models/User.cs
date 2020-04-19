using DomainDrivenDesign.Domains.Money.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domains.User.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        [NotMapped]
        public Balance Balance { get; set; }

        public User(long id, string username, Balance balance)
        {
            this.Id = id;
            this.Username = username;
            this.Balance = balance;
        }

        private User()
        {

        }
    }
}
