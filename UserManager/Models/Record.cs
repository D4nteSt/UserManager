namespace UserManager.Models;

public class Record
{
    public int RecordId { get; set; }
    public int UserId { get; set; }
    public string RecordType { get; set; }
    public string Details { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; } 
    
    public User User { get; set; }
}