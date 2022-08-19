using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tr.Core.Models;
using tr.Core.Services;

namespace tr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<Post> service;
        public UserController(IService<Post> service)
        {
            this.service = service;
            
        }
    }
}
