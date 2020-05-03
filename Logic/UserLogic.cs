using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Helpers;
using TimeTracker.Infrastructure.Database;
using TimeTracker.Models.Domain;

namespace TimeTracker.Logic
{
    public class UserLogic
    {
        DatabaseContext _db;
        public UserLogic(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<User>AuthenticateUser(String username, String password)
        {
            username = username.ToLowerInvariant();
               var passwordHash = Encryption.GenerateHash(password, 1000);
            return await _db.Users.FirstOrDefaultAsync(x => x.Username == username && x.Password == passwordHash);
        }
    }
}
