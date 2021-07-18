using System;

namespace Rougelike
{
    class Program
    {
        private static Player player = new Player("Stranger","Vagabond"); // creating def Player for user
        private static GameMap map = new GameMap();
        static void Main(string[] args)
        {
            theBegining();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            map.printMap();
            map.avatarPlacement();
           

        }

        private static void theBegining()
        {
            Console.WriteLine("Say your name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                player.setName("Stranger");
                Console.WriteLine("You will be known as Stranger then");
            }
            else
            {
                player.setName(name);
                Console.WriteLine("Welcome, " + player.getName());
            }

            Console.WriteLine("Choose your profession: ");
            Console.WriteLine("1 - Vagabond");
            Console.WriteLine("2 - Miner");
            Console.WriteLine("3 - Mushroom breeder");
            
            bool condition = false;

            while (!condition) {
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        player.setProfession("Vagabond");
                        condition = true;
                        break;
                    case "2":
                        player.setProfession("Miner");
                        condition = true;
                        break;
                    case "3":
                        player.setProfession("Mushroom breeder");
                        condition = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                        break;
                }
            }

            Console.WriteLine(player.getName() + " the " + player.getProfession() + ", welcome. Your journey is about to begin.");
        }

    }
}
