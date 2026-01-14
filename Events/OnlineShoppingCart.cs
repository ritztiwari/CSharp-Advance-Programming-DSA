//Online Shopping Cart

//When an item is added:
//Update total price
//Apply discount
//Send notification
//(Use events)

using System;

class CartItem
{
    public string itemName { get; }
    public decimal price { get; }

    public CartItem(string itemName, decimal price)
    {
        this.itemName = itemName;
        this.price = price;
    }
}

class ItemAddEventArgs : EventArgs
{
    public CartItem Item { get; }

    public ItemAddEventArgs(CartItem item)
    {
        Item = item;
    }
}

internal class OnlineShoppingCart
{
    private readonly List<CartItem> list = new List<CartItem>();

    private decimal total;

    public event EventHandler<ItemAddEventArgs> ItemAdded;

    public void AddItem(CartItem item)
    {
        list.Add(item);
        OnItemAdded(item);
    }

    protected virtual void OnItemAdded(CartItem item)
    {
        ItemAdded?.Invoke(this, new ItemAddEventArgs(item));
    }

    public void UpdateTotal(decimal amount)
    {
        total += amount;
        Console.WriteLine($"Total Updated: {total}");
    }

    public void ApplyDiscount()
    {
        if(total > 100)
        {
            decimal discount = total * 0.10m;
            total -= discount;
            Console.WriteLine($"Discount Applied: {discount}");
        }
    }

    public void SendNotification(CartItem item)
    {
        Console.WriteLine($"{item.itemName} added to the cart");
    }

}