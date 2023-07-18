// Техника внедрения зависимостей через интерфейс
namespace Projects._004_InterfaceInjection;

public interface IDataAccessObject {
    List<string> GetFiles();
}