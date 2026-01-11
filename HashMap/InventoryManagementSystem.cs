//1.Inventory Management System
//Use Case: Maintain a mapping of product IDs to product information.
//OOP Concepts:
//● Interface: Product
//● Encapsulation: Inventory manager manages internal map.
//● Abstraction: Simple add(), get() interface.
//● Polymorphism: Products can be electronics, clothing, etc.

using System;

interface IProduct
{
    void GetDetails();
}

class Clothing : IProduct
{
    public void GetDetails()
    {
        Console.WriteLine("Clothing product details");
    }
}

class Electronics : IProduct
{
    public void GetDetails()
    {
        Console.WriteLine("Electronics product details");
    }
}

internal class InventoryManagementSystem
{
    Dictionary<int, IProduct> dict = new Dictionary<int, IProduct>();

    internal void AddProduct(int id,IProduct product)
    {
        dict[id] = product;
    }

    internal IProduct GetProduct(int id)
    {
        return dict.ContainsKey(id) ? dict[id] : null;
    }
}