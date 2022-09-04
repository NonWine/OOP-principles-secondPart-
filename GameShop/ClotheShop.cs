using System;
class ClotheShop: IShop
{
    public IClothes Clothe {get;set;}

    public void AddProduct()
    {
        Console.WriteLine("Product was added:\n" + "Name: " + Clothe.Name + "\n" + "Price: " + Clothe.Price + "$" +
                          "\nAbout  Product: \n" +
                          "Name: " + Clothe.Name + "\n" + "Size " + Clothe.Size + "\n"
                          + "Material " + Clothe.Material);
    }

    public void Sell()
    {
        Console.WriteLine(Clothe.Name + " was sold for " + Clothe.Price + "$");
    }
}
