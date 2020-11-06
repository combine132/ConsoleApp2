using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Games
    {
        public static int winsTotal = 0;

        public static void GuessingGame() {
            Random rng = new Random();

            int number = rng.Next(1, 101);
            int guesses = 0;
            bool win = false;

            Console.WriteLine($"Guess a number between 1-100");
            do {
                try {
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number) {
                        Console.WriteLine($"Number is lower than {guess}");
                        guesses++;
                    }
                    else if (guess < number) {
                        Console.WriteLine($"Number is higher than {guess}");
                        guesses++;
                    }
                    else if (guess == number) {
                        guesses++;
                        Console.WriteLine($"Correct! Number was {number}!\nGuesses used: {guesses}");
                        winsTotal++;
                        win = true;
                        Console.WriteLine($"Press any key to return");
                    }
                    else {
                        Console.WriteLine("Error");
                        win = true;
                    }
                }
                catch (FormatException) {

                    Console.WriteLine("Input has to be a number");
                }

            } while (win != true);
            Console.ReadKey();
            Console.Clear();
        }

        public static void RockPaperScissor() {
            Console.WriteLine($"Choose one;\n - 1. Rock\n - 2. Paper\n - 3. Scissors");

            bool win = false;

            do {
                try {

                    Random rng = new Random();

                    int enemyChoice = rng.Next(1, 4);

                    int input = Convert.ToInt32(Console.ReadLine());

                    if (enemyChoice == 1) {
                        if (input == 1) {
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("It is a tie.");
                        }
                        else if (input == 2) {
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("You win.");
                            winsTotal++;
                        }
                        else if (input == 3) {
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("You lose.");
                        }
                    }
                    else if (enemyChoice == 2) {
                        if (input == 1) {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("You lose.");
                        }
                        else if (input == 2) {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("It is a tie.");
                        }
                        else if (input == 3) {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("You win.");
                            winsTotal++;
                        }
                    }
                    else if (enemyChoice == 3) {
                        if (input == 1) {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("You win.");
                            winsTotal++;
                        }
                        else if (input == 2) {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("You lose.");
                        }
                        else if (input == 3) {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("It is a tie.");
                        }
                    }
                }
                catch (FormatException) {

                    Console.WriteLine("Exiting..");
                    win = true;
                }
            } while (win != true);

            Console.ReadKey();
            Console.Clear();
        }

        public static void RollTheDice() {
            Random random = new Random();
            bool loop = true;

            do {
                int dice = random.Next(1,7);
                Console.WriteLine($"Dice: {dice}\nType 'n' to exit, or any key to roll again.");

                string inp = Console.ReadLine();
                if (inp != "n") {
                    continue;
                }
                else
                    loop = false;
            } while (loop);
            Console.Clear();
        }

        public static void MiniDND() {
            Console.WriteLine($"You enter the cave and encounter a large goblin.\nYou both have 100 health.");
            bool win = false;
            int turn = 1;
            Random random = new Random();
            Random hit = new Random();
            int playerHealth = 100;
            int monsterHealth = 100;
            do {
                int dmgPly = hit.Next(1, 10);
                int dmgMon = hit.Next(1, 10);
                int d20Ply = random.Next(1, 21);
                int d20Mon = random.Next(1, 21);

                if (turn == 2) {
                    Console.Clear();
                    Console.WriteLine($"You rolled {d20Ply}");
                    if (d20Ply < 10) {
                        Console.WriteLine("You missed!");
                    }
                    else {
                        Console.WriteLine("You hit!");
                        monsterHealth = monsterHealth - dmgPly;
                        Console.WriteLine($"You deal {dmgPly} to the goblin! He has {monsterHealth} remaining.");
                    }
                    turn--;
                }
                Console.ReadKey();
                if (turn == 1) {
                    Console.Clear();
                    Console.WriteLine($"Goblin rolled {d20Mon}");
                    if (d20Mon < 10) {
                        Console.WriteLine("It missed!");
                    }
                    else {
                        Console.WriteLine("It hit!");
                        playerHealth = playerHealth - dmgMon;
                        Console.WriteLine($"Goblin deals {dmgMon} to you! You have {playerHealth} remaining.");
                    }
                    turn++;
                }
                if (playerHealth <= 0) {
                    Console.WriteLine("You Lose!");
                    Console.ReadKey();
                    break;
                }
                else if (monsterHealth <= 0) {
                    Console.WriteLine("You Win!");
                    win = true;
                    winsTotal++;
                }
                Console.ReadKey();
            } while (!win);

            Console.Clear();
        }

        public static void The200IQSuperQuiz() {
            Console.WriteLine($"Welcome, lucky contestant, to the 200 IQ Super Quiz!\n" +
                $"The rules are as follows\n" +
                $"1. Answer the question right to move on to the next.\n" +
                $"2. You will be given 3 lives. If you use all your lives, you get no points\n" +
                $"3. Answer incorrectly and you will lose a life.\n" +
                $"4. You answer with 1, 2, 3 and 4\n" +
                $"Simple right? Lets get started then.\n" +
                $"We will start off easy.\n");

            int lives = 3;
            int questions = 1;
            do {
                switch (questions) {

                    case 1:
                        Console.WriteLine($"How many days are there in a week?\n" +
                            "1. 5 days\n" +
                            "2. 6 days\n" +
                            "3. 7 days\n" +
                            "4. 8 days");
                        int input = Convert.ToInt32(Console.ReadLine());

                        switch (input) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"What is Bilbo Baggins?\n" +
                            "1. An Elf\n" +
                            "2. A Dwarf\n" +
                            "3. A Human\n" +
                            "4. A Hobbit");
                        int input2 = Convert.ToInt32(Console.ReadLine());

                        switch (input2) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"What is the music of life?\n" +
                            "1. Um... the lute? No, drums!\n" +
                            "2. Silence, my brother.\n" +
                            "3. Screaming?\n" +
                            "4. Some kind of choir. With chanting.");
                        int input3 = Convert.ToInt32(Console.ReadLine());

                        switch (input3) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine($"When was Half-Life first released?\n" +
                            "1. November 4th, 1998\n" +
                            "2. November 8th, 1998\n" +
                            "3. November 15th, 1998\n" +
                            "4. November 19th, 1998");
                        int input4 = Convert.ToInt32(Console.ReadLine());

                        switch (input4) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine($"What is the correct way to print/write a line in C#?\n" +
                            "1. Console.WriteLine(\"\");\n" +
                            "2. print(\"\")\n" +
                            "3. cout << \"\";\n" +
                            "4. System.out.println(\"\");");
                        int input5 = Convert.ToInt32(Console.ReadLine());

                        switch (input5) {
                            case 1:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine($"How many stars are on the US flag?\n" +
                            "1. 52\n" +
                            "2. 50\n" +
                            "3. 53\n" +
                            "4. 51");
                        int input6 = Convert.ToInt32(Console.ReadLine());

                        switch (input6) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine($"What does a geiger counter measure?\n" +
                            "1. Radon\n" +
                            "2. Geiger\n" +
                            "3. Radiation\n" +
                            "4. Microwave");
                        int input7 = Convert.ToInt32(Console.ReadLine());

                        switch (input7) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 8:
                        Console.WriteLine($"How many months have 28 days?\n" +
                            "1. 1\n" +
                            "2. 12\n" +
                            "3. 4\n" +
                            "4. 7");
                        int input8 = Convert.ToInt32(Console.ReadLine());

                        switch (input8) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine($"Connor's father had three children. The first named April, the second named May. What was the third child named?\n" +
                            "1. June\n" +
                            "2. John\n" +
                            "3. August\n" +
                            "4. Connor");
                        int input9 = Convert.ToInt32(Console.ReadLine());

                        switch (input9) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                goto TheWin;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (lives > 0);
            if (lives == 0) {
                questions = 0;
                Console.WriteLine("You lost. No points gained.");
            }
            TheWin:
            {
                Console.WriteLine($"Congratulations!\nYou've gained points for every question, and one for winning.\nYou have {lives} live(s) left\nPress any key to return.");
                winsTotal = winsTotal + questions;
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void Game6() {

        }

        public static void Game7() {

        }

        public static void Game8() {

        }

        public static void CoinFlip() {
            Random rng = new Random();
            Console.WriteLine($"Press 1 to flip a coin.");
            bool loop = true;

            do {
                int r = rng.Next(101);

                int i = Convert.ToInt32(Console.ReadLine());

                if (i == 1) {
                    if (r < 50) {
                        Console.WriteLine("Heads");
                        Console.WriteLine($"Press 1 to flip another coin.");
                    }
                    else {
                        Console.WriteLine("Tails");
                        Console.WriteLine($"Press 1 to flip another coin.");
                    }
                }
                else
                    loop = false;

            } while (loop);

        }
    }
}
