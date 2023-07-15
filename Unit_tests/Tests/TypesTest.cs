using Projects;

namespace Unit_Test {

    [TestClass]
    public class TypesTest {

        private Types myClass = new Types();

        [TestMethod]
        public void return_string()  { Assert.AreEqual("string", myClass.test_string()); }

        [TestMethod]
        public void return_byte()    { Assert.IsTrue(myClass.test_byte() is byte); }

        [TestMethod]
        public void return_sbyte()   { Assert.IsTrue(myClass.test_sbyte() is sbyte); }

        [TestMethod]
        public void return_short()   { Assert.IsTrue(myClass.test_short() is short); }

        [TestMethod]
        public void return_ushort()  { Assert.IsTrue(myClass.test_ushort() is ushort); }

        [TestMethod]
        public void return_int()     { Assert.IsTrue(myClass.test_int() is int); }

        [TestMethod]
        public void return_uint()    { Assert.IsTrue(myClass.test_uint() is uint); }

        [TestMethod]
        public void return_long()    { Assert.IsTrue(myClass.test_long() is long); }

        [TestMethod]
        public void return_ulong()   { Assert.IsTrue(myClass.test_ulong() is ulong); }

        [TestMethod]
        public void return_float()   { Assert.IsTrue(myClass.test_float() is float); }

        [TestMethod]
        public void return_double()  { Assert.IsTrue(myClass.test_double() is double); }

        [TestMethod]
        public void return_decimal() { Assert.IsTrue(myClass.test_decimal() is decimal); }
    }
}