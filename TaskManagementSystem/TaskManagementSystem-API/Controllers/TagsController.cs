using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem_BL.DTOs.TagDtos;
using TaskManagementSystem_BL.Services.Interfaces;

namespace TaskManagementSystem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController(ITagService _service) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateTagDto dto)
        {
            await _service.CreateAsync(dto);
            return Created();
        }
    }
}
