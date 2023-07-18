// Одновременное использование Mock и Stub объектов
using Projects._009_Mocks;
namespace MocksTests_002;

[TestFixture]
public class FileManagerTest {

    [Test]
    public static void FileManagerTest2() {
        var logService = new StubLogService();
        var mailService = new MockMailService();

        FileManager mgr = new FileManager(logService, mailService);

        string fileName = "SomeFile.log";

        mgr.Analize(fileName);

        Assert.AreEqual("FileExtension error: " + fileName, mailService.message);
    }
}