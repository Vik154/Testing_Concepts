// Data-Driven Testing (DDT) — тестирование, управляемое данными;
// подход к архитектуре автоматизированных тестов, при котором тестовые данные
// хранятся отдельно от тестов (в файле или базе данных).
// Алгоритм DDT. Часть тестовых данных извлекается из хранилища.
// Выполняется скрипт, в котором вызывается обычный тест с извлечёнными тестовыми данными.

namespace Projects; 

public class UserManager {

    public bool Add(string userID, string phone, string email) {
        if (userID.Length < 4)
            throw new Exception("UserID должен быть больше 4 символов");
        if (phone.Contains("a"))
            throw new Exception("Телефон должен содержать только цифры");
        if (!email.Contains("@"))
            throw new Exception("Ошибка в email адресе");
        
        /*-- Условная логика --*/
        return true;
    }
}