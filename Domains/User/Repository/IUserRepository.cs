using DomainDrivenDesign.Domains.Money.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Domains.User.Repository
{
    public interface IUserRepository
    {
        IEnumerable<Models.User> GetAllUser();
        void DeleteUser(int id);
        Models.User GetUser(int id);
        int CreateUser(string username, Balance balance);
    }
}
