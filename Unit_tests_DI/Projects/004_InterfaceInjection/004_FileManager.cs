// Техника внедрения зависимостей через интерфейс
namespace Projects._004_InterfaceInjection;

public class FileManager {
    public bool FindLogFile(string fileName, IDataAccessObject dataAccessObject) {
        if (dataAccessObject == null) {
            throw new ArgumentNullException("dataAccessObject", "Parameter dataAcessObject cannot be null");
        }

        List<string> files = dataAccessObject.GetFiles();

        foreach (var file in files) {
            if (file.Contains(fileName)) {
                return true;
            }
        }
        return false;
    }
}