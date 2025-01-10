using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public class SubscriptionRepository : ISubscriptionRepository
{
    private readonly DatabaseContext _context;

    public SubscriptionRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Subscription>> GetSubscriptionsAsync()
    {
        return await _context.Subscriptions.ToListAsync();
    }

    public async Task<Subscription> GetSubscriptionByIdAsync(int subscriptionId)
    {
        return await _context.Subscriptions.FirstOrDefaultAsync(s => s.SubscriptionId == subscriptionId);
    }

    public async Task<Subscription> AddSubscriptionAsync(Subscription subscription)
    {
        await _context.Subscriptions.AddAsync(subscription);
        await _context.SaveChangesAsync();
        return subscription;
    }

    public async Task<Subscription> UpdateSubscriptionAsync(Subscription subscription)
    {
        _context.Subscriptions.Update(subscription);
        await _context.SaveChangesAsync();
        return subscription;
    }

    public async Task<Subscription> DeleteSubscriptionAsync(int subscriptionId)
    {
        var subscription = await _context.Subscriptions.FirstOrDefaultAsync(s => s.SubscriptionId == subscriptionId);
        if (subscription != null)
        {
            _context.Subscriptions.Remove(subscription);
            await _context.SaveChangesAsync();
        }
        return subscription;
    }
    
    public async Task<IEnumerable<Subscription>> GetSubscriptionsByUserIdAsync(int userId)
    {
        return await _context.Subscriptions
            .Where(s => s.UserId == userId)
            .ToListAsync();
    }
}