using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Models;

namespace tr.Core.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        public Task<List<Post>> GetPostsWithUsers();
    }

}
