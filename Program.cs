using System;

namespace blood_and_bounce
{
    class Program
    {
        public static int Number_Of_Win = 20;

        public static void SetOfWinNumbwr()
        {
            Console.WriteLine("Введите победдное число:");
            Number_Of_Win = int.Parse(Console.ReadLine());

            Game();
        }
        public static void Game()
        {
            var runGame = true;
            Console.WriteLine("Игра началась!");
            var random = new Random();
            var firstGamer = new Gamer 
            {
                Name = "Anatoliy",
                Check = 0
            };
            var secondGamer = new Gamer
            {
                Name = "Egorka",
                Check = 0
            };
            while (runGame)
            {
                Console.WriteLine($"Бросает игрок {firstGamer.Name}");
                System.Threading.Thread.Sleep(1000);

                var firstCheck = random.Next(1,6);
                firstGamer.Check = firstGamer.Check + firstCheck;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Результат броска {firstGamer.Name}: {firstCheck}, его счет {firstGamer.Check}");
                Console.ResetColor();

                if (firstGamer.Check >= Number_Of_Win)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Игрок {firstGamer.Name} виграл со счетом: {firstGamer.Check}");
                    Console.ResetColor();

                    break;
                }
                Console.WriteLine($"Бросает игрок {secondGamer.Name}");
                System.Threading.Thread.Sleep(1000);

                var secondCheck = random.Next(1, 6);
                secondGamer.Check = secondGamer.Check + secondCheck;

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Результат броска {secondGamer.Name}: {secondCheck}, его счет {secondGamer.Check}");
                Console.ResetColor();
                if (secondGamer.Check >= Number_Of_Win)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Игрок {secondGamer.Name} виграл со счетом: {secondGamer.Check}");
                    Console.ResetColor();

                    break;
                }
            }
                
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Игра в кости1!!");
            System.Threading.Thread.Sleep(600);

            while (true)
            {
                Console.WriteLine("Выбирете пункт меню:");
                Console.WriteLine("1. Выбрать победное число");
                Console.WriteLine("2. Начать игру");
                Console.WriteLine("3. Закончить игру");

                var answer_of_user = int.Parse(Console.ReadLine());

                switch (answer_of_user)
                {
                    case 1:
                        SetOfWinNumbwr();
                        break;
                    case 2:
                        Game();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Выберите цифру из пункта меню!!!");
                        Console.ResetColor();
                        break;
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(2000);
            }
            

        }
    }
}
