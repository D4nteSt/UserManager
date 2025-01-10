using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public class ActivityLogRepository : IActivityLogRepository
{
    private readonly DatabaseContext _context;

    public ActivityLogRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ActivityLog>> GetActivityLogsAsync()
    {
        return await _context.ActivityLogs.ToListAsync();
    }

    public async Task<ActivityLog> GetActivityLogByIdAsync(int logId)
    {
        return await _context.ActivityLogs.FirstOrDefaultAsync(log => log.LogId == logId);
    }

    public async Task<ActivityLog> AddActivityLogAsync(ActivityLog activityLog)
    {
        await _context.ActivityLogs.AddAsync(activityLog);
        await _context.SaveChangesAsync();
        return activityLog;
    }

    public async Task<ActivityLog> UpdateActivityLogAsync(ActivityLog activityLog)
    {
        _context.ActivityLogs.Update(activityLog);
        await _context.SaveChangesAsync();
        return activityLog;
    }

    public async Task<ActivityLog> DeleteActivityLogAsync(int logId)
    {
        var activityLog = await _context.ActivityLogs.FirstOrDefaultAsync(log => log.LogId == logId);
        if (activityLog != null)
        {
            _context.ActivityLogs.Remove(activityLog);
            await _context.SaveChangesAsync();
        }
        return activityLog;
    }
}