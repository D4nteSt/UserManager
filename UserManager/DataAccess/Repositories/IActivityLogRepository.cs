using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public interface IActivityLogRepository
{
    Task<IEnumerable<ActivityLog>> GetActivityLogsAsync();
    Task<ActivityLog> GetActivityLogByIdAsync(int logId);
    Task<ActivityLog> AddActivityLogAsync(ActivityLog activityLog);
    Task<ActivityLog> UpdateActivityLogAsync(ActivityLog activityLog);
    Task<ActivityLog> DeleteActivityLogAsync(int logId);
}