using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Models;
using tr.Core.Repositories;
using tr.Repository.AppDbContext;

namespace tr.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(trDbContext context) : base(context)
        {
        }
    }
}
