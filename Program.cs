using System;
using System.Text;

namespace ConsoleApp14
{
    class Program
    {
        private static TicTacToe game = new TicTacToe();
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrintableState());
            while(game.GetWinner() == Winner.Unfinished)
            {
                int index = int.Parse(Console.ReadLine());
                int index2 = int.Parse(Console.ReadLine());

                game.Put(index, index2);

                Console.WriteLine();

                Console.WriteLine(GetPrintableState());
            }
            Console.WriteLine(game.GetWinner());
        }

        static string GetPrintableState()
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= 3 ; i++)
            {
                for (int j = 1; j == 1; j++)
                {
                    sb.AppendLine("    |    |    |    ")
                    .AppendLine($"{GetPrintableChar(i,j)}   | {GetPrintableChar(i, j + 1)}  |  {GetPrintableChar(i,j + 2)} |")
                    .AppendLine("____|____|____|");
                }
                
            }
            return sb.ToString();
        }

        static string GetPrintableChar(int index, int index2)
        {
            State state = game.GetState(index,index2);
            if (state == State.Unset)
            {
                return "-";
            }
            return state == State.Cross ? "X" : "O";
        }
    }
}
