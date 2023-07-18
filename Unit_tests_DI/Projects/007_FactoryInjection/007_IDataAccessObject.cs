// Внедрение зависимостей с помощью фабричного класса
namespace Projects._007_FactoryInjection;

public interface IDataAccessObject {
    List<string> GetFiles();
}