// Тестирование с помощью Mock-объектов
namespace Projects._008_Mocks;

public class MockLogService : ILogService {
    public string lastError;

    public void LogError(string error) {
        lastError = error;
    }
}