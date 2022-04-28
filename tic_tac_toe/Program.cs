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
                    EnterXorO(player, input);
                }
                    
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                SetField();
                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field!: ");
                    input = Convert.ToInt32(Console.ReadLine());

                } while (!inputCorrect);
                  

               
            } while (true);

           
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
        }

        public static void EnterXorO(int player, int input )
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';

            {
            }
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