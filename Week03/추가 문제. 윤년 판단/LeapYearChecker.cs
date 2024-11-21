using System;
using System.Text;

class LeapYearChecker
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

        print.Write("연도를 입력하세요 : ");
        int year = Convert.ToInt32(read.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            print.Write($"{year}년은 윤년입니다.");
        else
            print.Write($"{year}년은 윤년이 아닙니다.");
    }
}