// Пример использования атрибутов [TestInitialize] и [ClassInitialize]
// [TestInitialize] - используется для инициализации объектов перед запуском тестов
// [ClassInitialize] - настройка объектов, которые исрользуются всеми юнит тестами
namespace Projects;

[Serializable]
public class ShoppingCart : IDisposable {
    public List<Item> Items = new List<Item>();

    public int Count {
        get { return Items.Count; }
    }

    public void Add(Item item) {
        Items.Add(item);
    }

    public void Dispose() {
        // cleanup code
    }

    public void Remove(int index) {
        Items.RemoveAt(index);
    }
}

[Serializable]
public class Item {
    public string Name { get; set; }
    public int Quantity { get; set; }
}