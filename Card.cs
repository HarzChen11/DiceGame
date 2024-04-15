using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp6.大富翁.Program;

namespace ConsoleApp6.大富翁
{
    internal class Card
    {
        // 隨機獲得道具卡 moth
        public static magicCard CardResult()
        {
            Random rand = new Random();
            var Card = ((magicCard)rand.Next(1, 5));

            return Card;
        }

        // 道具卡功能
        public static int CardNumber(string CardName, int StepNum)
        {
            if ((CardName == "兔子卡") || (CardName == "天使卡"))
            {
                StepNum += 2;
            }
            if ((CardName == "烏龜卡") || (CardName == "惡魔卡"))
            {
                if (StepNum >= 3)
                {
                    StepNum -= 2;
                }
                if (StepNum < 3)
                {
                    StepNum = 1;
                }
            }
            return StepNum;
        }
    }
}
