using Projects;
namespace TestsPassword;

[TestClass]
public class PasswordStrengthChekerTests {

    [TestMethod]
    public void GetPasswordStrength_AllChars_5Points() {
        // Arrange
        string password = "P2ssWor%Ld";
        int expected = 5;

        // Act
        int actual = PasswordStrengthCheker.GetPasswordStrength(password);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetPasswordStrength_UpperCase_3Points() {
        // Arrange
        string password = "Password";
        int expected = 3;

        // Act
        int actual = PasswordStrengthCheker.GetPasswordStrength(password);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetPasswordStrength_ContainsNumber_0_4Points() {
        // Arrange
        string password = "Passw0rd";
        int expected = 4;

        // Act
        int actual = PasswordStrengthCheker.GetPasswordStrength(password);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetPasswordStrength_ContainsNumber_1_4Points() {
        // Arrange
        string password = "Passw1rd";
        int expected = 4;

        // Act
        int actual = PasswordStrengthCheker.GetPasswordStrength(password);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetPasswordStrength_ContainsSpecialChar_at_5Points() {
        // Arrange
        string password = "Passw0rd@";
        int expected = 5;

        // Act
        int actual = PasswordStrengthCheker.GetPasswordStrength(password);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}