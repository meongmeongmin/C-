using System;
using System.Drawing;
using System.Text;

abstract class Car
{
    public int Speed = 0;

    public abstract void UpSpeed(int value);
}

class Sedan : Car
{
    int _maxSpeed = 150;

    public override void UpSpeed(int value)
    {
        Speed = (Speed + value) > _maxSpeed ? _maxSpeed : (Speed + value);
        Console.WriteLine($"승용차 속도({value}가속) ==> {Speed}");
    }
}

class Truck : Car
{
    int _maxSpeed = 130;

    public override void UpSpeed(int value)
    {
        Speed = (Speed + value) > _maxSpeed ? _maxSpeed : (Speed + value);
        Console.WriteLine($"트럭 속도({value}가속) ==> {Speed}");
    }
}

class AbstractCarExample
{
    static void Main()
    {
        Sedan sedan1 = new Sedan();
        Truck truck1 = new Truck();

        sedan1.UpSpeed(150);
        truck1.UpSpeed(300);
    }
}