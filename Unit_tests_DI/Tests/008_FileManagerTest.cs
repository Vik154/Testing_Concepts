using Projects._008_Mocks;
namespace MocksTests_001;

[TestFixture]
public class FileManagerTest {

    [Test]
    public static void FileManagerTest1() {
        MockLogService mockService = new MockLogService();

        FileManager mgr = new FileManager(mockService);

        mgr.Analize("SomeFile.log");

        Assert.AreEqual("FileExtension error: SomeFile.log", mockService.lastError);
    }
}