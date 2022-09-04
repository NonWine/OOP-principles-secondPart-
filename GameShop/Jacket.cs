using System;
class Jacket : IClothes
{
    public Jacket()
    {
        Size = 50;
        Material = "leather";
        Name = "Nike";
        Price = 100;
    }
    public int Size { get; set;}
    public string Material { get; set; }
    public string Name { get; set; }
    public int Price { get; set;}
}

