using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public class HostingPlanRepository : IHostingPlanRepository
{ 
    private readonly DatabaseContext _context;

    public HostingPlanRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<HostingPlan>> GetHostingPlansAsync()
    {
        return await _context.HostingPlans.ToListAsync();
    }

    public async Task<HostingPlan> GetHostingPlanByIdAsync(int planId)
    {
        return await _context.HostingPlans.FirstOrDefaultAsync(plan => plan.PlanID == planId );
    }

    public async Task<HostingPlan> AddHostingPlanAsync(HostingPlan hostingPlan)
    {
        await _context.HostingPlans.AddAsync(hostingPlan);
        await _context.SaveChangesAsync();
        return hostingPlan;
    }

    public async Task<HostingPlan> UpdateHostingPlanAsync(HostingPlan hostingPlan)
    {
        _context.HostingPlans.Update(hostingPlan);
        await _context.SaveChangesAsync();
        return hostingPlan;
    }

    public async Task<HostingPlan> DeleteHostingPlanAsync(int planId)
    {  
        var hostingPlan = await _context.HostingPlans.FirstOrDefaultAsync(plan => plan.PlanID == planId);
        if (hostingPlan != null)
        {
            _context.HostingPlans.Remove(hostingPlan);
            await _context.SaveChangesAsync();
        }
        return hostingPlan;
    }
    
}