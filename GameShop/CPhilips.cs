using System;
class CPhilips : IComputer
{
    public CPhilips()
    {
        PowerOfProcessor = 3000;
        PowerOfVideoCard = 4400;
        CountofMemory = 12000;
        Name = "Philips Computer";
        Price = 300;
    }
    public int PowerOfProcessor { get; set; }
    public int PowerOfVideoCard { get; set;}
    public int CountofMemory { get; set;}
    public string Name { get; set;}
    public int Price { get; set;}
}
