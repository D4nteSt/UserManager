using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public class RecordRepository : IRecordRepository
{
    private readonly DatabaseContext _context;

    public RecordRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Record>> GetRecordsAsync()
    {
        return await _context.Records.ToListAsync();
    }

    public async Task<Record> GetRecordByIdAsync(int recordId)
    {
        return await _context.Records.FirstOrDefaultAsync(r => r.RecordId == recordId );
    }

    public async Task<Record> AddRecordAsync(Record record)
    {
        await _context.Records.AddAsync(record);
        await _context.SaveChangesAsync();
        return record;
    }

    public async Task<Record> UpdateRecordAsync(Record record)
    {
        _context.Records.Update(record);
        await _context.SaveChangesAsync();
        return record;
    }

    public async Task<Record> DeleteRecordAsync(int recordId)
    {
        var record = await _context.Records.FirstOrDefaultAsync(r => r.RecordId == recordId);
        if (record != null)
        {
            _context.Records.Remove(record);
            await _context.SaveChangesAsync();
        }
        return record;
    }
}