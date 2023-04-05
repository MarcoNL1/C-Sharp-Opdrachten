public static class Shop{

    public static List<Item> Inventory = new();
    public const int MaxQuantity = 5;

    public static void AddItemToInventory(Item item){
        
        if (item == null) return;
        if (item.Quantity > MaxQuantity) return;
        foreach (var i in Inventory)
        {
            if (i.Name == item.Name && i.Quantity == item.Quantity) return;
        }
        Inventory.Add(item);
    }

    public static Item BuyItem(string name, int quantity, double amountPaid){
        foreach (Item item in Inventory)
        {
            if (name == item.Name && quantity == item.Quantity && item.GetTotalPrice() == amountPaid)
            {
                return item;
            }
        }
        return null;
    }
}