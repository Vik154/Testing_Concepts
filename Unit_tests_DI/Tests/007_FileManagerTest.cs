// Внедрение зависимостей с помощью фабричного класса
using Projects._007_FactoryInjection;

namespace Tests_007 {

    [TestFixture]
    class FileManagerTest {
        [Test]
        public void FindLogFileTest7() {
            FactoryClass.SetDataAccessObject(new StubFileDataObject());

            FileManager mgr = new FileManager();

            Assert.IsTrue(mgr.FindLogFile("file1.txt"));
        }
    }
}