using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tr.Core.DTO_s;
using tr.Core.Models;
using tr.Core.Services;

namespace tr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService service;
        private readonly IMapper mapper;

        public PostController(IPostService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await service.GetAll();
            return Ok(posts);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostCreateDto postDto)
        {
            if (postDto == null)
            {
                return BadRequest();
            }
            var post = mapper.Map<Post>(postDto);
            var bPost = await service.Create(post);
            return Created("olusturuldu", bPost);
        }

        [HttpPut]

        public async Task<IActionResult> Put(UpdatePostRequestDto postdreq)
        {
            var post = await service.GetById(postdreq.Id);
            post.Title = postdreq.Title;
            post.Content = postdreq.Content;
            await service.Update(post);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var deletedItem = await service.GetById(id);
            await service.Delete(deletedItem);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var post = await service.GetById(id);
            return Ok(post);
        }

        [HttpGet("withUsers")]
        public async Task<IActionResult> GetPostsWithUsers()
        {
            var nevar = await service.GetPostsWithUsers();
            return Ok(nevar);
        }
    }
}

