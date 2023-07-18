// Одновременное использование Mock и Stub объектов
namespace Projects._009_Mocks;

public interface IMailService {
    void SendMail(string destination, string message);
}