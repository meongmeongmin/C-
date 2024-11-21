using System;
using System.Text;

class ParkingLotManager
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

        char[] parking = new char[5];
        int top = 0;

        parking[top] = 'A';
        print.WriteLine($"{parking[top++]} 자동차가 주차장에 들어감");

        parking[top] = 'B';
        print.WriteLine($"{parking[top++]} 자동차가 주차장에 들어감");

        parking[top] = 'C';
        print.WriteLine($"{parking[top++]} 자동차가 주차장에 들어감\n");

        print.WriteLine($"{parking[--top]} 자동차가 주차장에 빠져나감");
        parking[top] = ' ';

        print.WriteLine($"{parking[--top]} 자동차가 주차장에 빠져나감");
        parking[top] = ' ';

        print.WriteLine($"{parking[--top]} 자동차가 주차장에 빠져나감");
        parking[top] = ' ';
    }
}