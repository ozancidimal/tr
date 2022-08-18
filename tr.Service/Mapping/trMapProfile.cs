using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.DTO_s;
using tr.Core.Models;

namespace tr.Service.Mapping
{
    public class trMapProfile : Profile
    {
        public trMapProfile()
        {
            CreateMap<User, UserCreateDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<Post, PostCreateDto>();
            CreateMap<PostCreateDto, Post>();
            CreateMap<UpdatePostRequestDto, Post>();
            CreateMap<Post, UpdatePostRequestDto>();

        }
    }
}
