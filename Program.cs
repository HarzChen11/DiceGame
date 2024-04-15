using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.大富翁
{
    internal class Program
    {
        public enum magicCard
        {
            None = 0, 兔子卡, 烏龜卡, 天使卡, 惡魔卡
        }
        static void Main(string[] args)
        {
            Player player = new Player("玩家");
            Player com = new Player("電腦");

            

            Random rand = new Random();

            while ((player.total < 100) && (com.total < 100))
            {
                Console.WriteLine("==================目前步數=================");

                #region 玩家局
                // 擲骰子獲得步數，並判斷是否有道具卡
                player.step = rand.Next(1, 7);
                player.RunDice(player.step, com);
                // 有/無 使用道具卡後的步數加總
                player.total += player.step;
                // 判斷是否獲得道具卡
                player.CheckOwnerCard();
                #endregion


                #region 電腦局

                // 擲骰子獲得步數，並判斷是否有道具卡
                com.step = rand.Next(1, 7);
                com.RunDice(com.step, player);
                // 有/無 使用道具卡後的步數加總
                com.total += com.step;
                // 判斷是否獲得道具卡
                com.CheckOwnerCard();
                #endregion

                // 顯示目前步數
                Console.WriteLine("玩家目前總共" + " " + player.total + " " + "步");
                Console.WriteLine("電腦目前總共" + " " + com.total + " " + "步");
                Console.WriteLine("=================本回合結束================");


                // 判斷勝負
                CheckWinner(player, com);
                Console.ReadKey();
            }
        }

        public static void CheckWinner(Player player,Player com)
        {
            if (player.total >= 100)
            {
                Console.WriteLine("遊戲結束");
                Console.WriteLine("玩家獲勝");
            }
            else if (com.total >= 100)
            {
                Console.WriteLine("遊戲結束");
                Console.WriteLine("電腦獲勝");
            }
        }
    }
}