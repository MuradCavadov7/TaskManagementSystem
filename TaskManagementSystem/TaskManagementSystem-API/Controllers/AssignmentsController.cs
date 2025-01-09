using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem_BL.DTOs.AssignmentDtos;
using TaskManagementSystem_BL.DTOs.TopicDtos;
using TaskManagementSystem_BL.Services.Interfaces;

namespace TaskManagementSystem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController(IAssignmentService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var entity = await _service.GetAllAsync();
            return Ok(entity);
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Post(CreateAssignmentDto dto)
        {
            await _service.CreateAsync(dto);
            return Created();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateAssignmentDto dto)
        {
            await _service.UpdateAsync(id, dto);
            return Ok(dto);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}
