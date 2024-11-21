using System;
using System.Text;

class ReverseMultiplicationTable02
{
    static void Main(string[] args)
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        for (int i = 9; i > 0; i--)
            print.Write($" #{i}단# ");

        print.WriteLine();

        for (int i = 9; i > 0; i--)
        {
            for (int j = 9; j > 0; j--)
                print.Write($"{j}X{i}={(j * i).ToString().PadLeft(2)} ");

            print.WriteLine();
        }
    }
}