// Внедрение зависимостей с помощью фабричного класса
namespace Projects._007_FactoryInjection;

public class FileDataObject : IDataAccessObject {
    public List<string> GetFiles() {
        string path = Directory.GetCurrentDirectory();

        List<string> list = new List<string>();

        DirectoryInfo d = new DirectoryInfo(path);

        FileInfo[] files = d.GetFiles();

        foreach (var file in files) {
            list.Add(file.Name);
        }
        return list;
    }
}