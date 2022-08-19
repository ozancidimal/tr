using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.DTO_s;
using tr.Core.Models;
using tr.Core.Repositories;
using tr.Core.Services;

namespace tr.Service.Services
{
    public class PostService : Service<Post>, IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper mapper;
        public PostService(IRepository<Post> repository, IPostRepository postRepository, IMapper mapper) : base(repository)
        {
            _postRepository = postRepository;
            this.mapper = mapper;
        }

        public async Task<List<PostWitUserDto>> GetPostsWithUsers()
        {
            var postUser = await _postRepository.GetPostsWithUsers();
            var postUserDto = mapper.Map<List<PostWitUserDto>>(postUser);
            return postUserDto;

        }
    }
}
