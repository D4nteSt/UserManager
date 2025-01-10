using UserManager.Models;

namespace UserManager.Services;

public interface ISubscriptionService
{
    Task<IEnumerable<Subscription>> GetSubscriptionsAsync();
    Task<Subscription> GetSubscriptionByIdAsync(int subscriptionId);
    Task<Subscription> AddSubscriptionAsync(Subscription subscription);
    Task<Subscription> UpdateSubscriptionAsync(Subscription subscription);
    Task<Subscription> DeleteSubscriptionAsync(int subscriptionId);
    Task<IEnumerable<Subscription>> GetSubscriptionsByUserIdAsync(int userId);
}