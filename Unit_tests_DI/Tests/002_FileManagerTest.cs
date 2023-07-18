// Внедрение зависимостей через конструктор
using Projects._002_ConstructorInjection;

namespace Tests_002;

[TestFixture]
public class FileManagerTest {

    [Test]
    public void FindLogFileTest2() {
        FileManager mgr = new FileManager(new StubFileDataObject());
        Assert.IsTrue(mgr.FindLogFile("file2.log"));
    }
}