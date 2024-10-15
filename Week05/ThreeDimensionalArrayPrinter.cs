using System;
using System.Text;

class ThreeDimensionalArrayPrinter
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

        int[,,] ary = new int[3, 4, 3]; // 행, 열, 면
        int value = 1;

        for (int depth = 0; depth < ary.GetLength(2); depth++)
        {
            for (int row = 0; row < ary.GetLength(0); row++)
            {
                for (int col = 0; col < ary.GetLength(1); col++)
                {
                    ary[row, col, depth] = value++;
                    print.Write($"{ary[row, col, depth],3:D}");
                }

                print.WriteLine();
            }

            print.WriteLine();
        }
    }
}
