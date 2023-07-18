// Техника внедрения зависимостей через свойства
using Projects._003_PropertyInjection;
namespace Tests_003;

[TestFixture]
public class FileManagerTest {
    [Test]
    public void FindLogFileTest3() {
        FileManager mgr = new FileManager();
        mgr.DataAccessObject = new StubFileDataObject();
        Assert.IsTrue(mgr.FindLogFile("file2.log"));
    }
}