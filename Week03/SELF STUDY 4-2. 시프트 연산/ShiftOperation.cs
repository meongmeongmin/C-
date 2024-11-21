using System;
using System.Text;

class ShiftOperation
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

        print.Write("시프트할 숫자는 ? ");
        int num = Convert.ToInt32(read.ReadLine());

        print.Write("출력할 횟수는 ? ");
        int count = Convert.ToInt32(read.ReadLine());

        for (int i = 1; i <= count; i++)
            print.WriteLine($"{num} << {i} = {num << i}");

        for (int i = 1; i <= count; i++)
            print.WriteLine($"{num} >> {i} = {num >> i}");
    }
}