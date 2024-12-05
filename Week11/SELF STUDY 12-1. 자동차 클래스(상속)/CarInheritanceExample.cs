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
    }

    public void DownSpeed(int value)
    {
        Speed -= value;
    }
}

class Sedan : Car
{
    public int SeatNum { get; set; }
}

class Truck : Car
{
    public int Capacity { get; set; }
}

class Electric : Car
{
    public int Mileage { get; set; }

    public int GetMileage() { return Mileage; } // 원래라면 getter를 사용하겠지만, 문제에서 메서드를 추가해서 풀이하라고 했다
}

class CarInheritanceExample
{
    static void Main()
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        Sedan sedan1 = new Sedan();
        Truck truck1 = new Truck();
        Electric electric = new Electric();

        sedan1.UpSpeed(150);
        truck1.UpSpeed(100);
        electric.UpSpeed(200);

        sedan1.SeatNum = 5;
        truck1.Capacity = 50;
        electric.Mileage = 500;

        print.WriteLine($"승용차 속도는 {sedan1.Speed}km, 좌석수는 {sedan1.SeatNum}개 입니다 ");
        print.WriteLine($"트럭 속도는 {truck1.Speed}km, 적재량은 {truck1.Capacity}톤 입니다 ");
        print.Write($"전기차 속도는 {electric.Speed}km, 주행거리는 {electric.GetMileage()}km 입니다 ");
    }
}