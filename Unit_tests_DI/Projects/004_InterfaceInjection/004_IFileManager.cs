// Техника внедрения зависимостей через интерфейс
namespace Projects._004_InterfaceInjection;

public interface IFileManager {
    bool FindLogFile(string fileName, IDataAccessObject dataAccessObject);
}