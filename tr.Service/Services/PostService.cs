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
    public class PostService : Service<Post>, IPostService
    {
        public PostService(IRepository<Post> repository) : base(repository)
        {
        }
    }
}
