
using SnakeAndLadder;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {   
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the snake and ladder game");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.GameStart \n2.Roll Dice  \n3.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                Game game = new Game();
                switch (options)
                {
                    case 1:
                        game.GameStart();
                        break;
                    case 2:
                        game.PlayerRollsDice();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}