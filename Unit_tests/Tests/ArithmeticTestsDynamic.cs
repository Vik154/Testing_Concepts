using Projects;
namespace Tests;

[TestClass]
public class ArithmeticTestsDynamic {

    [DataTestMethod]
    [DynamicData(nameof(AddData), DynamicDataSourceType.Method)]
    public void Add(int x, int y, int expected) {
        int r = Arithmetic.add(x, y);
        Assert.AreEqual(r, expected);
    }

    [DataTestMethod]
    [DynamicData(nameof(SubData), DynamicDataSourceType.Method)]
    public void Sub(int x, int y, int expected) {
        int r = Arithmetic.sub(x, y);
        Assert.AreEqual(r, expected);
    }

    [DataTestMethod]
    [DynamicData(nameof(MulData), DynamicDataSourceType.Method)]
    public void Mul(int x, int y, int expected) {
        int r = Arithmetic.mul(x, y);
        Assert.AreEqual(r, expected);
    }

    [DataTestMethod]
    [DynamicData(nameof(DivData), DynamicDataSourceType.Method)]
    public void Div(int x, int y, int expected) {
        int r = Arithmetic.div(x, y);
        Assert.AreEqual(r, expected);
    }

    private static IEnumerable<object[]> AddData() {
        return new[] {
            new object[] { 1, 2, 3 },
            new object[] { 2, 2, 4 },
            new object[] { -1, 4, 3 }
        };
    }

    private static IEnumerable<object[]> SubData() {
        return new[] {
            new object[] { 1, 2, -1 },
            new object[] { 2, 2, 0 },
            new object[] { 3, 2, 1 }
        };
    }

    private static IEnumerable<object[]> MulData() {
        return new[] {
            new object[] { 9, 3, 27 },
            new object[] { 3, 3, 9 },
            new object[] { -3, -3, 9 }
        };
    }

    private static IEnumerable<object[]> DivData() {
        return new[] {
            new object[] { 9, 3, 3 },
            new object[] { 3, 3, 1 },
            new object[] { 8, 2, 4 }
        };
    }
}