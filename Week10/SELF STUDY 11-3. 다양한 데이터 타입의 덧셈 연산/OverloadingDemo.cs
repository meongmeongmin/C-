using System;
using System.Numerics;
using System.Text;

class Calc
{
    //public T AddValue<T>(T v1, T v2) where T : INumber<T> // 제네릭 활용도 되지만, 문제의 목적은 메서드 오버로딩 활용이므로 주석 처리했다 
    //{
    //    return v1 + v2;
    //}

    public int AddValue(int v1, int v2)
    {
        return v1 + v2;
    }

    public float AddValue(float v1, float v2)
    {
        return v1 + v2;
    }

    public double AddValue(double v1, double v2)
    {
        return v1 + v2;
    }

    public long AddValue(long v1, long v2)
    {
        return v1 + v2;
    }
}

class OverloadingDemo
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

        Calc calc = new Calc();
        print.WriteLine($"int값 계산 ==> {calc.AddValue(1, 1)}");
        print.WriteLine($"float값 계산 ==> {calc.AddValue(1.1f, 1.1f)}");
        print.WriteLine($"double값 계산 ==> {calc.AddValue(1.1, 1.1)}");
        print.WriteLine($"long값 계산 ==> {calc.AddValue(1L, 1L)}");
    }
}