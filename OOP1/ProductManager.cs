﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            /* product.ProductName = "Pomodoro";*/
            Console.WriteLine(product.ProductName+" eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }

        
    }
}
