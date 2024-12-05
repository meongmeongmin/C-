using System;
using System.Text;

interface ICar
{
    void Run();
}

interface ICannon
{
    void Fire();
}

interface IMachineGun
{
    void Shoot();
}

class Tank : ICar, ICannon, IMachineGun
{
    public void Run()
    {
        Console.WriteLine("탱크가 앞으로 굴러갑니다.");
    }

    public void Fire()
    {
        Console.WriteLine("탱크에서 대포를 발사합니다.");
    }

    public void Shoot()
    {
        Console.WriteLine("탱크에서 기관총을 쏩니다.");
    }
}

public class TankInterfaceExample
{
    public static void Main()
    {
        Tank tank1 = new Tank();
        tank1.Run();
        tank1.Fire();
        tank1.Shoot();
    }
}
