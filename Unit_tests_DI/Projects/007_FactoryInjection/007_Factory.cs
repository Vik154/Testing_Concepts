// Внедрение зависимостей с помощью фабричного класса
namespace Projects._007_FactoryInjection;

// #define DEBUG
public class FactoryClass {
    static IDataAccessObject dataAcessObject;

    internal static IDataAccessObject CreateDataAccessObject() {
        if (dataAcessObject != null) {
            return dataAcessObject;
        }
        return new FileDataObject();
    }

#if DEBUG
    public static void SetDataAccessObject(IDataAccessObject customDataObject) {
        dataAcessObject = customDataObject;
    }
#endif
}