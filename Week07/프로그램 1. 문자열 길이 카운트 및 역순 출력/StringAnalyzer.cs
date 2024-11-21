using System;
using System.Text;

public class StringAnalyzer
{
    public static void Main()
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        print.Write("문자열 입력 ==> ");
        string str = read.ReadLine();

        int lowerCount = 0;
        int upperCount = 0;
        int numCount = 0;
        int koreanCount = 0;
        int count = 0;

        foreach (var c in str)
        {
            if (char.IsLower(c))
                lowerCount++;
            else if (char.IsUpper(c))
                upperCount++;
            else if (char.IsNumber(c))
                numCount++;
            else if ((0xAC00 <= c && c <= 0xD7A3) || (0x3131 <= c && c <= 0x318E))
                koreanCount++;
            else
                count++;
        }

        print.WriteLine($"소문자:{lowerCount}, 대문자:{upperCount}, 숫자:{numCount}, 한글:{koreanCount}, 기타:{count}\n");
        print.Write($"거꾸로 출력 ==> {new string(str.Reverse().ToArray())}");
    }
}
