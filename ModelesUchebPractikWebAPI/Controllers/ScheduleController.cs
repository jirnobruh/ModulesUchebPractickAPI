using ModelesUchebPractikWebAPI.Data;
using ModelesUchebPractikWebAPI.Models;
using ModelesUchebPractikWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 

namespace ModelesUchebPractikWebAPI.Controllers;

[ApiController]
[Route("api/schedule")]
public class ScheduleController : ControllerBase
{
    private readonly IScheduleService _service;
    public ScheduleController(IScheduleService service, AppDbContext db)
    {
        _service = service;
    }

    [HttpGet("group/{groupName}")]
    public async Task<IActionResult> GetSchedule(string groupName, DateTime start, DateTime end)
    {
        var result = await _service.GetScheduleForGroup(groupName, start, end);
        
        return Ok(result);
    }
    
    [HttpGet("groups")]
    public async Task<IActionResult> GetGroups()
    {
        var groups = await _service.GetAllGroups();
        return Ok(groups);
    }
}