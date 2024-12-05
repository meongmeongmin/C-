using System;
using System.Drawing;
using System.Text;

class Car
{
    public Color Color;
    public int Speed;

    public void UpSpeed(int value)
    {
        Speed += value;
        Console.WriteLine($"현재 속도(기본 클래스) : {Speed}km");
    }

    public void DownSpeed(int value)
    {
        Speed -= value;
        Console.WriteLine($"현재 속도(기본 클래스) : {Speed}km");
    }
}

class Sedan : Car
{
    int _maxSpeed = 150;

    public void UpSpeed(int value)
    {
        Speed = (Speed + value) > _maxSpeed ? _maxSpeed : (Speed + value);
        Console.WriteLine($"승용차({value} 증가) ---> 현재 속도(파생 클래스) : {Speed}km");
    }

    public void DownSpeed(int value)
    {
        Speed = (Speed - value) >= 0 ? (Speed - value) : 0;
        Console.WriteLine($"승용차({value} 감소) ---> 현재 속도(파생 클래스) : {Speed}km");
    }
}

class Truck : Car
{
    public void UpSpeed(int value)
    {
        Console.Write($"트럭({value} 증가) ---> ");
        base.UpSpeed(value);
    }

    public void DownSpeed(int value)
    {
        Console.Write($"트럭({value} 감소) ---> ");
        base.DownSpeed(value);
    }
}

class CarInheritanceExample
{
    static void Main()
    {
        Sedan sedan1 = new Sedan();
        Truck truck1 = new Truck();

        sedan1.UpSpeed(200);
        sedan1.DownSpeed(300);
        truck1.UpSpeed(200);
        truck1.DownSpeed(300);
    }
}