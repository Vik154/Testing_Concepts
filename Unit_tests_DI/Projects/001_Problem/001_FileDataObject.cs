﻿// Проблема тестирования с внешней зависимостью 
namespace Projects._001_Problem; 

public class FileDataObject {
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