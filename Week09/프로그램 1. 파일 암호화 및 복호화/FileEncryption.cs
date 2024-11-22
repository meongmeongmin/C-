using System;
using System.Resources;
using System.Security;
using System.Text;

class FileEncryption
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

        print.Write("1.암호화 2.암호해석 중 선택 : ");
        int secu = Convert.ToInt32(read.ReadLine());
        
        if (secu == 1)  // 암호화
            secu = 100;
        else if (secu == 2)
            secu = -100;    // 복호화

        string basePath = Path.Combine(Environment.CurrentDirectory, "Resources");

        // 암호화: Normal.txt
        // 복호화: Security.txt
        print.Write("입력 파일명을 입력하세요 : ");
        string inputFileName = read.ReadLine();
        inputFileName = Path.Combine(basePath, inputFileName);

        // 암호화: Security.txt
        // 복호화: Normal.txt
        print.Write("출력 파일명을 입력하세요 : ");
        string outputFileName = read.ReadLine();
        outputFileName = Path.Combine(basePath, outputFileName);

        StreamReader inFp = new StreamReader(inputFileName);
        StreamWriter outFp = new StreamWriter(outputFileName);
        string inStr;
        string outStr;

        while (true)
        {
            inStr = inFp.ReadLine();
            if (inStr == null)
                break;

            outStr = "";
            foreach (char ch in inStr)
            {
                int chNum = (int)ch;
                chNum += secu;

                char newCh = (char)chNum;
                outStr += newCh;
            }

            outFp.WriteLine(outStr);
        }

        print.Write($"{inputFileName} -> {outputFileName} 변환 완료");
    }
}
