using UserManager.Models;

namespace UserManager.Services;

public interface IRecordService
{
    Task<IEnumerable<Record>> GetRecordsAsync();
    Task<Record> GetRecordByIdAsync(int recordId);
    Task<Record> AddRecordAsync(Record record);
    Task<Record> UpdateRecordAsync(Record record);
    Task<Record> DeleteRecordAsync(int recordId);
}