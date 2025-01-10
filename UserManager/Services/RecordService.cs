using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class RecordService : IRecordService
{
    private readonly IRecordRepository _recordRepository;

    public RecordService(IRecordRepository recordRepository)
    {
        _recordRepository = recordRepository;
    }

    // Получение всех записей
    public async Task<IEnumerable<Record>> GetRecordsAsync()
    {
        return await _recordRepository.GetRecordsAsync();
    }

    // Получение записи по ID
    public async Task<Record> GetRecordByIdAsync(int recordId)
    {
        return await _recordRepository.GetRecordByIdAsync(recordId);
    }

    // Добавление новой записи
    public async Task<Record> AddRecordAsync(Record record)
    {
        var existingRecord = await _recordRepository.GetRecordByIdAsync(record.RecordId);
        if (existingRecord != null)
        {
            throw new Exception($"Запись с ID {record.RecordId} уже существует");
        }
        return await _recordRepository.AddRecordAsync(record);
    }

    // Обновление существующей записи
    public async Task<Record> UpdateRecordAsync(Record record)
    {
        return await _recordRepository.UpdateRecordAsync(record);
    }

    // Удаление записи
    public async Task<Record> DeleteRecordAsync(int recordId)
    {
        var record = await _recordRepository.GetRecordByIdAsync(recordId);
        if (record == null)
        {
            throw new Exception("Запись не найдена.");
        }

        return await _recordRepository.DeleteRecordAsync(recordId);
    }
}