using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rougelike
{
    class GameMap
    {
        string[] level = { 
        "###############",
        "#     #  #    #",
        "####        # #",
        "#      # #   ##",
        "#  #     #    #",
        "#     #       #",
        "#  #     #    #",
        "###############"
        };

        public void printMap()
        {
            Console.Clear();
            foreach (string row in level)
            {                
                Console.WriteLine(row);
            }
        }

        public void avatarPlacement()
        {
            int playerColumn = 2;
            int playerRow = 3;
            bool flag = true;

            while (flag == true)
            {
                Console.SetCursorPosition(playerColumn, playerRow);
                Console.Write("@");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                Console.SetCursorPosition(playerColumn, playerRow);
                char currentCell = level[playerRow][playerColumn];
                Console.Write(currentCell);

                int targetColumn = playerColumn;
                int targetRow = playerRow;
                
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        /*Console.SetCursorPosition(playerColumn, playerRow);
                        Console.Write(" ");
                        playerColumn--;*/
                        targetColumn = playerColumn - 1;
                        break;

                    case ConsoleKey.RightArrow:
                        /*Console.SetCursorPosition(playerColumn, playerRow);
                        Console.Write(" ");
                        playerColumn++;*/
                        targetColumn = playerColumn + 1;
                        break;

                    case ConsoleKey.UpArrow:
                        /*Console.SetCursorPosition(playerColumn, playerRow);
                        Console.Write(" ");
                        playerRow--;*/
                        targetRow = playerRow - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        /* Console.SetCursorPosition(playerColumn, playerRow);
                         Console.Write(" ");
                         playerRow++;*/
                        targetRow = playerRow + 1;
                        break;

                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                }

                if (targetColumn >= 0 && targetColumn < level[playerRow].Length && level[playerRow][targetColumn] != '#') 
                {
                    playerColumn = targetColumn;
                }
                


                if (targetRow >= 0 && targetRow < level.Length && level[targetRow][playerColumn] != '#')
                {
                    playerRow = targetRow;
                }
                
            }

            Console.SetCursorPosition(0, level.Length);
        }


    }
}
