using System;
using System.Text;

class FloatSumAndAverageCalculator
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

        float[] nums = new float[100];
        int idx = 0;
        while (true)
        {
            print.Write("실수를 입력하세요(Enter는 종료) : ");
            string num = read.ReadLine();
            if (string.IsNullOrWhiteSpace(num) || num == "0")
                break;

            nums[idx++] = Convert.ToSingle(num);
        }

        print.WriteLine($"합계 ==> {nums.Sum()}");
        print.WriteLine($"평균 ==> {(nums.Sum() > 0 ? nums.Sum() / idx : 0)}");
    }
}