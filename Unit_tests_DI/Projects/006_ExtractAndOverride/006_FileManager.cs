// Внедрение зависимсотей с помощью виртуальных методов
namespace Projects._006_ExtractAndOverride;

public class FileManager {

    public FileManager() { }

    protected virtual List<string> FindLogFileExtension() {
        return new FileDataObject().GetFiles();
    }

    public bool FindLogFile(string fileName) {
        List<string> files = FindLogFileExtension();

        foreach (var file in files) {
            if (file.Contains(fileName)) {
                return true;
            }
        }
        return false;
    }
}