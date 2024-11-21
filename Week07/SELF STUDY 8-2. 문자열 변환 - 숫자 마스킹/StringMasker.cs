using System;
using System.Text;

public class StringMasker
{
    static string Change(string str)
    {
        string resultStr = null;
        foreach (char ch in str)
            resultStr += (ch >= '0' && ch <= '9') ? '*' : ch;

        return resultStr;
    }

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
        print.Write($"출력 문자열 ==> {Change(str)}");
    }
}