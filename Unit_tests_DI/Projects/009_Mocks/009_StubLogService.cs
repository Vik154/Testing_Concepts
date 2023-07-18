// Одновременное использование Mock и Stub объектов
namespace Projects._009_Mocks;

public class StubLogService : ILogService {
    public void LogError(string error) {
        throw new Exception(error);
    }
}