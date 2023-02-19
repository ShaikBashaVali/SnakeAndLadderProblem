
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
                Console.WriteLine("1.GameStart \n2.Roll Dice\n3.PlayerThenCheckOptions \n4.PlayerReachestheWinningPosition \n5.EnsurePlayerGetExcatWinningPosition \n6.ReportNumberOfTimesDicePlayedToWinGame \n7.FinalReportOf2PlayersWhichPlayerWonGame \n8.Exit");
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
                    case 3:
                        game.CheckOptions();
                        break;
                    case 4:
                        game.WinningPosition();
                        break;
                    case 5:
                        game.EnsurePlayerGetExcatWinningPosition();
                        break;
                    case 6:
                        game.ReportNumberOfTimesDicePlayedToWinGame();
                        break;
                    case 7:
                        game.GamePlayWithTwoPlayers();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}