using System;
using System.Text;

class Program
{
    static void ArrayCircularCopy()
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        int[] aa = new int[100];
        int[] bb = new int[100];

        for (int i = 0; i < aa.Length; i++)
            aa[i] = (i + 1) * 3;

        for (int i = 0; i < bb.Length; i++)
            bb[i] = aa[(i + 50) % aa.Length];

        print.Write($"bb[0]는 {bb[0]}, bb[99]는 {bb[99]} 입력됨.");
    }
}