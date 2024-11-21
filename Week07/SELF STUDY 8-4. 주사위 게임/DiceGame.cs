using System;
using System.Text;

public class DiceGame
{
    static int[] SetDice()
    {
        Random random = new Random();
        int[] dice = new int[3];

        for (int i = 0; i < dice.Length; i++)
            dice[i] = random.Next(1, 7);

        return dice;
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

        int count = 1;
        while (true)
        {
            int[] dice = SetDice();
            print.WriteLine($"{count++}회 ==> {dice[0]} {dice[1]} {dice[2]}");

            if (dice[0] == dice[1] && dice[1] == dice[2])
                break;
        }
    }
}
