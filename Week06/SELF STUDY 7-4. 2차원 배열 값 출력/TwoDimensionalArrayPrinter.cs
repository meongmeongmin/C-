using System;
using System.Text;

class TwoDimensionalArrayPrinter
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

        int[,] ary = new int[3, 4];
        int value = 1;

        for (int i = 0; i < ary.GetLength(0); i++)
        {
            for (int j = 0; j < ary.GetLength(1); j++)
            {
                ary[i, j] = value;
                value += 2;
            }
        }

        print.WriteLine("ary[2, 3]부터 ary[0, 0]까지 출력");

        for (int i = ary.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = ary.GetLength(1) - 1; j >= 0; j--)
                print.Write($"{ary[i, j],3:D}");

            print.WriteLine();
        }
    }
}