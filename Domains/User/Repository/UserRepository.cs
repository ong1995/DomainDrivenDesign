using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainDrivenDesign.Domains.Money.Models;

namespace DomainDrivenDesign.Domains.User.Repository
{
    public class UserRepository : IUserRepository
    {
        public int CreateUser(string username, Balance balance)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Models.User GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
