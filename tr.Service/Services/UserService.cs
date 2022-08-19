using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Models;
using tr.Core.Repositories;
using tr.Core.Services;

namespace tr.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IRepository<User> repository) : base(repository)
        {
        }
    }
}
