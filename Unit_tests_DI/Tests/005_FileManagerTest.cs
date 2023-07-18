// Техника локального фабричного метода для внедрения зависимости
using Projects._005_LocalAbstractMethod;

namespace Tests_005 {

    public class FileManagerUnderTest : FileManager {
        protected override IDataAccessObject LocalFactoryMethod() {
            return new StubFileDataObject();
        }
    }

    [TestFixture]
    public class FileManagerTest {
        [Test]
        public void FindLogFileTest9() {
            var mgr = new FileManagerUnderTest();

            var result = mgr.FindLogFile("file1.txt");

            Assert.IsTrue(result);
        }
    }
}