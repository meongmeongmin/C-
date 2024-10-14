using System;
using System.Text;

class GCDandLCMCalculator
{
    static int Gcd(int num1, int num2)
    {
        int remainder;
        int tmp;

        if (num1 < num2)
        {
            tmp = num1;
            num1 = num2;
            num2 = tmp;
        }

        if (num2 == 0)
            return num1;

        while (true)
        {
            remainder = num1 % num2;
            if (remainder == 0)
                return num2;

            num1 = num2;
            num2 = remainder;
        }
    }

    static void Main(string[] args)
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        int num1 = Convert.ToInt32(read.ReadLine());
        int num2 = Convert.ToInt32(read.ReadLine());

        var result = (num1 * num2) / Gcd(num1, num2);
        print.Write(result);
    }
}