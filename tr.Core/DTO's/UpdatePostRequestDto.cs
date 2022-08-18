using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr.Core.DTO_s
{
    public class UpdatePostRequestDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }


    }
}
