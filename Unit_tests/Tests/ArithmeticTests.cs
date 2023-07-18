using Projects;
namespace Tests;

[TestClass]
public class ArithmeticTests {

    [DataTestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(2, 2, 4)]
    [DataRow(-1, 4, 3)]
    public void Add(int x, int y, int expected) {
        int r = Arithmetic.add(x, y);
        Assert.AreEqual(r, expected);
    }

    [DataTestMethod]
    [DataRow(1, 2, -1)]
    [DataRow(2, 2, 0)]
    [DataRow(3, 2, 1)]
    public void Sub(int x, int y, int expected) {
        int r = Arithmetic.sub(x, y);
        Assert.AreEqual(r, expected);
    }

    [DataTestMethod]
    [DataRow(9, 3, 27)]
    [DataRow(3, 3, 9)]
    [DataRow(-3, -3, 9)]
    public void Mul(int x, int y, int expected) {
        int r = Arithmetic.mul(x, y);
        Assert.AreEqual(r, expected);
    }

    [DataTestMethod]
    [DataRow(9, 3, 3)]
    [DataRow(3, 3, 1)]
    [DataRow(8, 2, 4)]
    public void Div(int x, int y, int expected) {
        int r = Arithmetic.div(x, y);
        Assert.AreEqual(r, expected);
    }
}