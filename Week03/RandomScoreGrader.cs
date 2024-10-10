using System;
using System.Text;

class RandomScoreGrader
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

        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            int score = random.Next(0, 101);
            if (score >= 95)
                print.WriteLine($"취득 점수 {score} => A+ 학점");
            else if (score >= 90)
                print.WriteLine($"취득 점수 {score} => A0 학점");
            else if (score >= 85)
                print.WriteLine($"취득 점수 {score} => B+ 학점");
            else if (score >= 80)
                print.WriteLine($"취득 점수 {score} => B0 학점");
            else if (score >= 75)
                print.WriteLine($"취득 점수 {score} => C+ 학점");
            else if (score >= 70)
                print.WriteLine($"취득 점수 {score} => C0 학점");
            else if (score >= 65)
                print.WriteLine($"취득 점수 {score} => D+ 학점");
            else if (score >= 60)
                print.WriteLine($"취득 점수 {score} => D0 학점");
            else
                print.WriteLine($"취득 점수 {score} => F 학점");
        }
    }
}