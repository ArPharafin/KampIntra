using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Id= 1;
            product1.CategoryId = 2;
            product1.ProductName = "Lamba";
            product1.UnitPrice = 325;
            product1.UnitsInStock = 2;

            Product product2 = new Product { Id = 2, CategoryId = 5,
                UnitsInStock = 5,ProductName="Kartus",UnitPrice=23};
            //pascal case  //Camel Case
            ProductManager productManager= new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //iint double,bool... deger tip
            //diziler,class,abstracts class,interface... referans tip
       
        }

        }
    }

