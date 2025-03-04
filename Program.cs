using System;

class Car  // Temel (Base) sınıf
{
    public string Brand { get; set; }
    public virtual void Transmission() // Kalıtım ile ezilecek metot
    {
        Console.WriteLine($"{Brand} → Vites tipi belirtilmedi.");
    }
}

// Alt sınıflar (Derived Classes)
class BMW : Car
{
    public BMW() { Brand = "BMW"; }
    public override void Transmission()
    {
        Console.WriteLine($"{Brand} → Düz viteslidir.");
    }
}

class Porsche : Car
{
    public Porsche() { Brand = "Porsche"; }
    public override void Transmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

class Mercedes : Car
{
    public Mercedes() { Brand = "Mercedes"; }
    public override void Transmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

class Togg : Car
{
    public Togg() { Brand = "Togg"; }
    public override void Transmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

class Audi : Car
{
    public Audi() { Brand = "Audi"; }
    public override void Transmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

class Toyota : Car
{
    public Toyota() { Brand = "Toyota"; }
    public override void Transmission()
    {
        Console.WriteLine($"{Brand} → Düz viteslidir.");
    }
}

// Program Çalıştırma
class Program
{
    static void Main()
    {
        Car[] cars = { new BMW(), new Porsche(), new Mercedes(), new Togg(), new Audi(), new Toyota() };

        foreach (var car in cars)
        {
            car.Transmission();
        }
    }
}
