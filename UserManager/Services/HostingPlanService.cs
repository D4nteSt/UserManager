using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class HostingPlanService : IHostingPlanService
{
    private readonly IHostingPlanRepository _hostingPlanRepository;

    public HostingPlanService(IHostingPlanRepository hostingPlanRepository)
    {
        _hostingPlanRepository = hostingPlanRepository;
    }

    // Получение всех хостинг-планов
    public async Task<IEnumerable<HostingPlan>> GetHostingPlansAsync()
    {
        return await _hostingPlanRepository.GetHostingPlansAsync();
    }

    // Получение хостинг-плана по ID
    public async Task<HostingPlan> GetHostingPlanByIdAsync(int planId)
    {
        return await _hostingPlanRepository.GetHostingPlanByIdAsync(planId);
    }

    // Добавление нового хостинг-плана
    public async Task<HostingPlan> AddHostingPlanAsync(HostingPlan hostingPlan)
    {
        return await _hostingPlanRepository.AddHostingPlanAsync(hostingPlan);
    }

    // Обновление существующего хостинг-плана
    public async Task<HostingPlan> UpdateHostingPlanAsync(HostingPlan hostingPlan)
    {
        return await _hostingPlanRepository.UpdateHostingPlanAsync(hostingPlan);
    }

    // Удаление хостинг-плана
    public async Task<HostingPlan> DeleteHostingPlanAsync(int planId)
    {
        var hostingPlan = await _hostingPlanRepository.GetHostingPlanByIdAsync(planId);
        if (hostingPlan == null)
        {
            throw new Exception("Hosting plan not found.");
        }

        return await _hostingPlanRepository.DeleteHostingPlanAsync(planId);
    }
}