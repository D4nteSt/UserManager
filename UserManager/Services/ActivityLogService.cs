using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class ActivityLogService : IActivityLogService
{
    private readonly IActivityLogRepository _activityLogRepository;

    public ActivityLogService(IActivityLogRepository activityLogRepository)
    {
        _activityLogRepository = activityLogRepository;
    }

    // Получение всех записей активности
    public async Task<IEnumerable<ActivityLog>> GetActivityLogsAsync()
    {
        return await _activityLogRepository.GetActivityLogsAsync();
    }

    // Получение записи активности по ID
    public async Task<ActivityLog> GetActivityLogByIdAsync(int logId)
    {
        return await _activityLogRepository.GetActivityLogByIdAsync(logId);
    }

    // Добавление новой записи активности
    public async Task<ActivityLog> AddActivityLogAsync(ActivityLog activityLog)
    {
        var existingActivityLog = await _activityLogRepository.GetActivityLogByIdAsync(activityLog.LogId);
        if (existingActivityLog != null)
        {
            throw new Exception($"Активность с ID: {activityLog.LogId} уже существует");
        }
        return await _activityLogRepository.AddActivityLogAsync(activityLog);
    }

    // Обновление записи активности
    public async Task<ActivityLog> UpdateActivityLogAsync(ActivityLog activityLog)
    {
        return await _activityLogRepository.UpdateActivityLogAsync(activityLog);
    }

    // Удаление записи активности
    public async Task<ActivityLog> DeleteActivityLogAsync(int logId)
    {
        var activityLog = await _activityLogRepository.GetActivityLogByIdAsync(logId);
        if (activityLog == null)
        {
            throw new Exception("Активность не найдена");
        }

        return await _activityLogRepository.DeleteActivityLogAsync(logId);
    }
}