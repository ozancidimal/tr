using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tr.Core.Models;

namespace tr.Core.DTO_s
{
    public class PostWitUserDto
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
