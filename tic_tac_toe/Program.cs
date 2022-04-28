using System;

namespace tic_tac_toe
{
    internal class Program
    {
        static char[,] playField =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };

       
        private static int turns = 0;
        public static void Main(string[] args)
        {
            int player = 2; // player 1 start
            int input = 0;
            bool inputCorrect = true;


            // run as long as program runs
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }

                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                SetField();
                //check wining condition
                char[] playerChars = { 'X', 'O' };
                foreach (char playerChar in playerChars)
                {
                    player = player == 2 ? 1 : 2;
                    if ((playField[0, 0] == playerChar && playField[0, 1] == playerChar &&
                         playField[0, 2] == playerChar)
                        || (playField[1, 0] == playerChar && playField[1, 1] == playerChar &&
                            playField[1, 2] == playerChar)
                        || (playField[2, 0] == playerChar && playField[2, 1] == playerChar &&
                            playField[2, 2] == playerChar)
                        || (playField[0, 0] == playerChar && playField[1, 0] == playerChar &&
                            playField[2, 0] == playerChar)
                        || (playField[0, 1] == playerChar && playField[1, 1] == playerChar &&
                            playField[2, 1] == playerChar)
                        || (playField[0, 2] == playerChar && playField[1, 2] == playerChar &&
                            playField[2, 2] == playerChar)
                        || (playField[0, 0] == playerChar && playField[1, 1] == playerChar &&
                            playField[2, 2] == playerChar)
                        || (playField[0, 2] == playerChar && playField[1, 1] == playerChar &&
                            playField[2, 0] == playerChar)
                       )

                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine($" Player 2 is the winner");
                        }
                        else
                        {
                            Console.WriteLine($" Player 1 is the winner");
                        }

                        Console.WriteLine("Press any key to resent the game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                    // no winnder
                    else if(turns == 10)
                    {
                        Console.WriteLine("Draw NO Winner");
                        Console.WriteLine("Press any key to resent the game!");
                        Console.ReadKey();
                        ResetField();
                    }
                }

                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field!: ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a Number");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorrect input! please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);
        }

        public static void ResetField()
        {
             char[,] playFieldInial =
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' },
            };

            playField = playFieldInial;
            turns = 0;
            SetField();
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |      |    ");
            Console.WriteLine("  {0}  |  {1}   | {2}   ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("____ | ____ | ____    ");
            Console.WriteLine("  {0}  |  {1}   | {2}   ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("____ | ____ | ____    ");
            Console.WriteLine("  {0}  |  {1}   | {2}   ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |      |    ");
            turns++;
        }

        public static void EnterXorO(char playerSign, int input)
        {
           
          
            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
            }
        }
    }
}