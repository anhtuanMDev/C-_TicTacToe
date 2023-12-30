namespace TicTacToe
{
    internal class Program
    {
        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','3' },
            {'7','8','9' }
        };
        static int turn = 0;

        static void Main(string[] args)
        {
            int player = 1;
            bool inputCorrect = true;
            SetField();

            do
            {
                Console.WriteLine($"Current player: {player}");
                Console.WriteLine("Enter your number");
                string playerInput = Console.ReadLine();
                if (!int.TryParse(playerInput, out _) || playerInput.Length != 1)
                {
                    SetField();
                    Console.WriteLine("Error! Please enter number");
                    continue;
                };
                EnterSign(player, playerInput);
                if (Winner())
                {
                    inputCorrect = false;
                }
                if (player == 2) player = 1;
                else player = 2;
            } while (inputCorrect);
            Console.Read();
        }

        /// <summary>
        /// Create Tic Tac Toe play board.
        /// </summary>
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");

        }

        /// <summary>
        /// Input Sign 'X' or 'O' base on player turn, they can't mark on the
        /// already marked field by the previous player 
        /// </summary>
        /// <param name="player">Player turn</param>
        /// <param name="input">Field player choose to mark</param>
        public static void EnterSign(int player, string input)
        {
            char playerSign = ' ';
            if (player == 1) playerSign = 'X';
            else playerSign = 'O';

            switch (input)
            {
                case "1":
                    if (Char.IsNumber(playField[0, 0]))
                    {
                        playField[0, 0] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "2":
                    if (Char.IsNumber(playField[0, 1]))
                    {
                        playField[0, 1] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "3":
                    if (Char.IsNumber(playField[0, 2]))
                    {
                        playField[0, 2] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "4":
                    if (Char.IsNumber(playField[1, 0]))
                    {
                        playField[1, 0] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "5":
                    if (Char.IsNumber(playField[1, 1]))
                    {
                        playField[1, 1] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "6":
                    if (Char.IsNumber(playField[1, 2]))
                    {
                        playField[1, 2] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "7":
                    if (Char.IsNumber(playField[2, 0]))
                    {
                        playField[2, 0] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "8":
                    if (Char.IsNumber(playField[2, 1]))
                    {
                        playField[2, 1] = playerSign;
                        turn++;
                    }
                    else Console.WriteLine("Have been mark");
                    break;
                case "9":
                    {
                        if (Char.IsNumber(playField[2, 2]))
                            turn++;
                    }
                    playField[2, 2] = playerSign;
                    else Console.WriteLine("Have been mark");
                    break;
            }

            SetField();
        }

        /// <summary>
        /// Checking winner after every turn and declare draw after 10 turn
        /// </summary>
        /// <returns></returns>
        public static bool Winner()
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            map.Add('O', 2);
            map.Add('X', 1);
            char[] charSigns = { 'X', 'O' };

            if (turn == 10)
            {
                Console.WriteLine("Out of move");
                return true;
            }

            foreach (char c in charSigns)
            {
                if (playField[0, 0] == c && playField[1, 0] == c && playField[2, 0] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
                if (playField[0, 1] == c && playField[0, 1] == c && playField[0, 2] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
                if (playField[0, 0] == c && playField[1, 1] == c && playField[2, 2] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
                if (playField[1, 0] == c && playField[1, 1] == c && playField[1, 2] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
                if (playField[0, 2] == c && playField[1, 1] == c && playField[2, 0] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
                if (playField[0, 2] == c && playField[1, 2] == c && playField[2, 2] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
                if (playField[2, 0] == c && playField[2, 1] == c && playField[2, 2] == c)
                {
                    Console.WriteLine("The winner is {0}", map[c]);
                    return true;
                }
            }
            return false;
        }
    }
}
