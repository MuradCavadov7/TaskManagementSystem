using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem_BL.DTOs.TagDtos
{
    public class CreateTagDto
    {
        public string Name {  get; set; }
        public List<int> AssigmentId { get; set; }
    }
}
