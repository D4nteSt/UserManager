using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class SubscriptionService : ISubscriptionService
{
    private readonly ISubscriptionRepository _subscriptionRepository;

    public SubscriptionService(ISubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
    }

    // Получение всех подписок
    public async Task<IEnumerable<Subscription>> GetSubscriptionsAsync()
    {
        return await _subscriptionRepository.GetSubscriptionsAsync();
    }

    // Получение подписки по ID
    public async Task<Subscription> GetSubscriptionByIdAsync(int subscriptionId)
    {
        return await _subscriptionRepository.GetSubscriptionByIdAsync(subscriptionId);
    }

    // Добавление новой подписки
    public async Task<Subscription> AddSubscriptionAsync(Subscription subscription)
    {
        var existingSubscription = await _subscriptionRepository.GetSubscriptionByIdAsync(subscription.SubscriptionId);
        if (existingSubscription != null)
        {
            throw new Exception("Подписка уже существует");
        }
        return await _subscriptionRepository.AddSubscriptionAsync(subscription);
    }

    // Обновление подписки
    public async Task<Subscription> UpdateSubscriptionAsync(Subscription subscription)
    {
        return await _subscriptionRepository.UpdateSubscriptionAsync(subscription);
    }

    // Удаление подписки
    public async Task<Subscription> DeleteSubscriptionAsync(int subscriptionId)
    {
        var subscription = await _subscriptionRepository.GetSubscriptionByIdAsync(subscriptionId);
        if (subscription == null)
        {
            throw new Exception("Подписка не найдена.");
        }

        return await _subscriptionRepository.DeleteSubscriptionAsync(subscriptionId);
    }

    // Получение подписок пользователя
    public async Task<IEnumerable<Subscription>> GetSubscriptionsByUserIdAsync(int userId)
    {
        return await _subscriptionRepository.GetSubscriptionsByUserIdAsync(userId);
    }
}