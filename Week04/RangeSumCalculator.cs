using System;
using System.Text;

class RangeSumCalculator
{
    static void Main(string[] args)
    {
        #region I/O
        // 콘솔의 입출력 인코딩을 UTF-8로 설정
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true };
        #endregion

        print.Write("시작값 입력: ");
        int startNum = Convert.ToInt32(read.ReadLine());
        
        print.Write("끝값 입력: ");
        int endNum = Convert.ToInt32(read.ReadLine());

        print.Write("증가값 입력: ");
        int increment = Convert.ToInt32(read.ReadLine());

        int sum = 0;
        int i = startNum;
        while (i <= endNum)
        {
            sum += i;
            i += increment;
        }

        print.Write($"{startNum}부터 {endNum}까지 {increment}씩 증가한 합계: {sum}");
    }
}