using Microsoft.AspNetCore.Identity;
using SimpleAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAuthorization.Services
{
    internal class AccountService
    {

        public void Register(string username, string password)
        {
            var user = new User { 
                Id = Guid.NewGuid().ToString(),
                UserName = username,
            };
            var passwordHash = new PasswordHasher<User>().HashPassword(user, password);
            user.PasswordHash = passwordHash;
        }

        public void Login(string username, string password) { 
        }
    }
}
