using System.ComponentModel.DataAnnotations.Schema;

namespace UserManager.Models;

public class Subscription
{
    public int SubscriptionId { get; set; }
    public int UserId { get; set; }
    public int PlanId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
    
    public User User { get; set; }
    public HostingPlan HostingPlan { get; set; }
    
    [NotMapped]
    public bool IsExpired => EndDate < DateTime.Now;
}