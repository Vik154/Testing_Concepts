// Одновременное использование Mock и Stub объектов
namespace Projects._009_Mocks;

public class MockMailService : IMailService {
    public string message;
    public string destination;

    public void SendMail(string destination, string message) {
        this.message = message;
        this.destination = destination;
    }
}