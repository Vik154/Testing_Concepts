using Projects;
using Microsoft.VisualStudio.TestTools;


namespace UserTests;

[TestClass]
public class UserManagerTests {

    // Data Driven Test - тест, который позволяет использовать для запуска данные из внешнего источника.
    // Тест запускается по одному разу на каждую запись из источника данных. Это позволяет проверить разные входные данных 
    // используя один метод.
    // TestContext - для net framework
    public TestContext TestContext { get; set; }
    private UserManager manager = new UserManager();

    // DataSource - определение источника данных.
    // 1 параметр - имя провайдера 
    // 2 параметр - строка подключения или путь к файлу
    // 3 параметр - имя таблицы или элемента в XML
    // 4 параметр - как происходит доступ к записям из источника данных
    /* -- Для Net.Framework -- в Net.Core не поддерживается, парсер некогда писать
    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        "UserManagerTestData.xml",
        "User",
        DataAccessMethod.Sequential)]
    */
    [TestMethod]
    [DataRow("Jonson", "+7 8888 999 00 00", "Jons@mail.com")]
    [DataRow("Jonny", "+7 8888 759 70 00", "Jonny@mail.com")]
    public void UserManager_Add_FromXML(string id, string tel, string mail) {
        string userId = id;
        string telephone = tel;
        string email = mail;

        bool result = manager.Add(userId, telephone, email);

        Assert.IsTrue(result, "Пользователь не может быть создан");
    }
}