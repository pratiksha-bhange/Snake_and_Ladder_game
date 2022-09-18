using System;

namespace Snake_and_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Constants
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;

            int position = 0;
            Random random = new Random();


            while (position <= 100)
            {
                int noOnDie = random.Next(1, 7);
                Console.WriteLine($"No on die : {noOnDie}");

                int options = random.Next(1, 4);
                switch (options)
                {
                    case LADDER:
                        position += noOnDie;
                        break;
                    case SNAKE:
                        position -= noOnDie;
                        position = position < 0 ? 0 : position;
                        break;
                    case NOPLAY:
                        Console.WriteLine("POSITION " + position);
                        break;
                }
            }
            Console.WriteLine("POSITION " + position);
        }
        Console.WriteLine("POSITION " + position);
        }
    }
}
