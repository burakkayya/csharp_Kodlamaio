using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "T-shirt";
            product1.UnitPrice = 149.90;
            product1.UnitsInStock = 210;

            Product product2 = new Product { Id = 2, CategoryId = 2, ProductName = "Jean", 
                UnitPrice = 199.90, UnitsInStock = 80 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product2);
            productManager.Update(product1);



        }
    }
}
