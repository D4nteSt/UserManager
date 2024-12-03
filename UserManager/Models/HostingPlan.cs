namespace UserManager.Models;

public class HostingPlan
{
    public int PlanID { get; set; }
    public string PlanName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int DurationMonths { get; set; }
    
    public ICollection<Subscription> Subscriptions { get; set; }
}