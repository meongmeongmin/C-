using System;
using System.Text;

public class StringTransformer
{
    static string Change(string str)
    {
        string resultStr = null;
        for (int i = 0; i < str.Length; i++)
            resultStr += (i % 2 != 0) ? '$' : str[i];

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
        # endregion
        
        print.Write("문자열 입력 ==> ");
        string str = read.ReadLine();
        print.Write($"출력 문자열 ==> {Change(str)}");
    }
}
