// Проблема тестирования с внешней зависимостью 
using Projects._001_Problem;
namespace Tests_001;

[TestFixture]
public class FileManagerTest {

    [Test]
    public void FindLogFileTest1() {
        FileManager mgr = new FileManager();
        Assert.IsTrue(mgr.FindLogFile("file2.log"));
    }
}