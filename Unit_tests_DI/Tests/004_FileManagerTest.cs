// Техника внедрения зависимостей через интерфейс
using Projects._004_InterfaceInjection;
namespace Tests_004;

[TestFixture]
public class FileManagerTest {

    [Test]
    public void FindLogFileTest4() {
        FileManager mgr = new FileManager();
        Assert.IsTrue(mgr.FindLogFile("file2.log", new StubFileDataObject()));
    }
}