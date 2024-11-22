using System;
using System.Text;

class Car
{
    int _maxSpeed = 200;
    int _speed = 0;
    public int Speed
    {
        get { return _speed; }
        set
        {
            if (_speed != value)
                _speed = value;
        }
    }

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

        Car car = new Car();
        car.Speed = 0;

        car.UpSpeed(30);
        print.WriteLine($"현재 속도 ==> {car.Speed}");
    }
}