using System;
using System.Text;

class Car
{
    public string Color;
    public int Speed;
    int _maxSpeed = 200;

    public void UpSpeed(int value)
    {
        Speed = (_maxSpeed >= (Speed + value)) ? (Speed + value) : 200;
    }

    public void DownSpeed(int value)
    {
        Speed = (0 <= (Speed - value)) ? (Speed - value) : 0;
    }
}

class CarSpeedController
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

        Car car1 = new Car();
        car1.Color = "빨강";
        car1.Speed = 0;

        Car car2 = new Car();
        car2.Color = "파랑";
        car2.Speed = 0;

        Car car3 = new Car();
        car3.Color = "노랑";
        car3.Speed = 0;

        car1.UpSpeed(30);
        print.WriteLine($"자동차 1의 색상은 {car1.Color}이며, 현재 속도는 {car1.Speed}km 입니다.");

        car2.UpSpeed(60);
        print.WriteLine($"자동차 2의 색상은 {car2.Color}이며, 현재 속도는 {car2.Speed}km 입니다.");

        car3.UpSpeed(0);
        print.WriteLine($"자동차 3의 색상은 {car3.Color}이며, 현재 속도는 {car3.Speed}km 입니다.");

        car3.DownSpeed(100);
        print.WriteLine($"자동차 3의 색상은 {car3.Color}이며, 현재 속도는 {car3.Speed}km 입니다.");

        car3.UpSpeed(2500);
        print.WriteLine($"자동차 3의 색상은 {car3.Color}이며, 현재 속도는 {car3.Speed}km 입니다.");
    }
}