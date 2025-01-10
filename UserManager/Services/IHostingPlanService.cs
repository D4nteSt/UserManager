using UserManager.Models;

namespace UserManager.Services;

public interface IHostingPlanService
{
    Task<IEnumerable<HostingPlan>> GetHostingPlansAsync();
    Task<HostingPlan> GetHostingPlanByIdAsync(int planId);
    Task<HostingPlan> AddHostingPlanAsync(HostingPlan hostingPlan);
    Task<HostingPlan> UpdateHostingPlanAsync(HostingPlan hostingPlan);
    Task<HostingPlan> DeleteHostingPlanAsync(int planId);
}