using System;
class ComputerShop : IShop
{
    public IComputer Comp { get; set; }
    public void AddProduct()
    {

        Console.WriteLine("Product was added:\n" + "Name: " + Comp.Name + "\n" + "Price: "  + Comp.Price + "$" +
                          "\nAbout  Product: \n" +
                         "Name: "+ Comp.Name + "\n" + "Power of Proccessor " + Comp.PowerOfProcessor + "\n"
                         + "Power of VideoCard " +Comp.PowerOfVideoCard + "\n" + "Memory: " + Comp.CountofMemory);   
    }
    public void Sell()
    {
        Console.WriteLine(Comp.Name + " was sold for " + Comp.Price + "$");
    }
}
