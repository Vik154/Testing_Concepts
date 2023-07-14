// Источник - https://learn.microsoft.com/ru-ru/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022
using BankAccountNS;

/* Напишем методы модульного теста для проверки поведения метода Debit класса BankAccount.
 * Существует по крайней мере три поведения, которые требуется проверить:
 * Метод создает исключение ArgumentOutOfRangeException , если сумма по дебету превышает баланс.
 * Метод создает исключение ArgumentOutOfRangeException, если сумма по дебету меньше нуля.
 * Если значение дебета допустимо, то метод вычитает сумму дебета из баланса счета.
 */

namespace Unit_Test {

    [TestClass]
    public class BankAccountTest {

        /// <summary>
        /// Тест проверяет, снимается ли со счета нужная сумма при допустимом размере кредита
        /// (со значением меньшим, чем баланс счета, и большим, чем ноль). 
        /// </summary>
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance() {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange() {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange() {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            try {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e) {
                // Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                // return;
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        /*
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange() {
            // Arrange
            double beginningBalance = 11.99;
            // double debitAmount = 5.00;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        */
    }
}