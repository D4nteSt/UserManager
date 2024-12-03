namespace UserManager.Models;

public class ActivityLog
{
    public int LogId { get; set; }
    public int UserId { get; set; }
    public string Action { get; set; }
    public DateTime ActionDate { get; set; }
    public string DateType { get; set; }
    public string Details { get; set; }
    
    public User User { get; set; }
}