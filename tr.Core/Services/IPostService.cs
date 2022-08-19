using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.DTO_s;
using tr.Core.Models;

namespace tr.Core.Services
{
    public interface IPostService: IService<Post>
    {
        public Task<List<PostWitUserDto>> GetPostsWithUsers();
    }
}
