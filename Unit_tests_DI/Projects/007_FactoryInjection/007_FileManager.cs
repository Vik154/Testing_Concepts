// Внедрение зависимостей с помощью фабричного класса
namespace Projects._007_FactoryInjection;

public class FileManager {
    IDataAccessObject dataAccessObject;

    public FileManager() {
        dataAccessObject = FactoryClass.CreateDataAccessObject();
    }

    public bool FindLogFile(string fileName) {
        List<string> files = dataAccessObject.GetFiles();

        foreach (var file in files) {
            if (file.Contains(fileName)) {
                return true;
            }
        }
        return false;
    }
}