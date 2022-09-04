using System;
    class Program
    {
        static void Main(string[] args)
        {
        ComputerShop XAKER = new ComputerShop();
        ClotheShop FIVE = new ClotheShop();
        FIVE.Clothe = new Jacket();
        XAKER.Comp = new CPhilips();
        Console.WriteLine("Computers shop");
        XAKER.AddProduct();
        XAKER.Sell();
        Console.WriteLine("Clothes shop");
        FIVE.AddProduct();
        FIVE.Sell();
        }
    }
