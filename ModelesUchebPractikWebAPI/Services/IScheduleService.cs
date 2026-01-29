using ModelesUchebPractikWebAPI.DTO; 

namespace ModelesUchebPractikWebAPI.Services;

public interface IScheduleService
{
    Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime startDate, DateTime endDate);
} 