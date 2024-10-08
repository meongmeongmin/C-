using System;
using System.Text;

class MoneyExchange
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

        print.Write("지폐로 교환할 돈은 얼마 ? ");
        int money = Convert.ToInt32(read.ReadLine());

        print.WriteLine($"오만원짜리 => {money / 50000}장");
        print.WriteLine($"만원짜리 => {(money %= 50000) / 10000}장");
        print.WriteLine($"오천원짜리 => {(money %= 10000) / 5000}장");
        print.WriteLine($"천원짜리 => {(money %= 5000) / 1000}장");
        print.Write($"지폐로 바꾸지 못한 돈 => {money %= 1000}원");
    }
}