using System;
using System.Text;

class FileLineViewer
{
    static void Main()
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        # endregion

        print.Write("파일명을 입력하세요 : ");
        string fileName = read.ReadLine();  // C:/Windows/win.ini

        var inStrAry = File.ReadAllLines(fileName);

        int row = 1;
        foreach (string inStr in inStrAry)
            print.WriteLine($"{row++}/{inStrAry.Length}행 : {inStr}");
    }
}