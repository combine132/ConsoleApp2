using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main() {
            bool loop = true;
            do {
                Console.Title = $"The Game - Current Wins: {Games.winsTotal}";
                Console.WriteLine($"Welcome to the GAME\nSelect a game below\n--------------------------\n" +
                    $"  - 1. Guess a number\n" +
                    $"  - 2. Rock Paper Scissors\n" +
                    $"  - 3. Roll The Dice\n" +
                    $"  - 4. Mini DND - WIP\n" +
                    $"  - 5. 200 IQ Super Quiz\n" +
                    $"  - 6. Random Math Questions\n" +
                    $"  - 7. \n" +
                    $"  - 8. \n" +
                    $"  - 9. Heads or Tails\n" +
                    $"  - 0. Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input) {
                    case 1:
                        Console.Clear();
                        Games.GuessingGame();
                        break;
                    case 2:
                        Console.Clear();
                        Games.RockPaperScissor();
                        break;
                    case 3:
                        Console.Clear();
                        Games.RollTheDice();
                        break;
                    case 4:
                        Console.Clear();
                        Games.MiniDND();
                        break;
                    case 5:
                        Console.Clear();
                        Games.The200IQSuperQuiz();
                        break;
                    case 6:
                        Console.Clear();
                        Games.MathGame();
                        break;
                    case 7:
                        Console.Clear();
                        Games.Game7();
                        break;
                    case 8:
                        Console.Clear();
                        Games.Game8();
                        break;
                    case 9:
                        Games.CoinFlip();
                        Console.Clear();
                        break;
                    case 0:
                        loop = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            } while (loop);
        }
    }
}
