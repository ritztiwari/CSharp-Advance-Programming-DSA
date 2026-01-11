using System;

internal class Program
{
    internal static void Main(string[] args)
    {
        //    InventoryManagementSystem manager = new InventoryManagementSystem();

        //    manager.AddProduct(101, new Clothing());
        //    manager.AddProduct(102, new Electronics());

        //    IProduct product = manager.GetProduct(101);
        //    product?.GetDetails();

        //    product = manager.GetProduct(102);
        //    product?.GetDetails();

        //AuthSystem auth = new AuthSystem();
        //auth.AssignRole("admin1", new Admin());
        //auth.AssignRole("user1", new User());
        //Console.WriteLine(auth.HasAccess("admin1", "DELETE"));
        //Console.WriteLine(auth.HasAccess("user1", "DELETE"));
        //Console.WriteLine(auth.HasAccess("user1", "READ"));


        //GradeBook g = new GradeBook();
        //g.AddStudent("rishabh", new CBSE());
        //g.AddStudent("uday", new GPA());
        //g.ShowGrade("rishabh", 91);
        //g.ShowGrade("uday", 89);

        StorageAdd s = new StorageAdd();

        s.Save("github.com", "https://github.com");
        s.Save("bridgelab.com", "https://bridgelabz.com");

        s.GetUrl("bridgelab.com");
        s.GetUrl("github.com");


    }
}
