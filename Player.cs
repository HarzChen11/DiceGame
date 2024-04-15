using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp6.大富翁.Program;

namespace ConsoleApp6.大富翁
{
    internal class Player
    {
        public String Name;

        public magicCard onerCard { get; set; } = magicCard.None;

        public int step { get; set; } = 0;

        public int total { get; set; } = 0;

        public Player(string Name)
        {

            this.Name = Name;
        }

        public void CheckOwnerCard()
        {
            if ((this.total != 0) && (this.total % 10 == 0))
            {
                this.onerCard = Card.CardResult();

                Console.WriteLine(this.Name + "獲得" + this.onerCard.ToString());
            }
        }

        public void RunDice(int step,Player people)
        {
            Console.WriteLine(people.Name+"增加" + " " + this.step + " " + "步");

            // 使用道具卡
            switch (this.onerCard)
            {
                case magicCard.兔子卡:
                    this.step = Card.CardNumber("兔子卡", this.step);
                    this.onerCard = magicCard.None;
                    break;
                case magicCard.烏龜卡:
                    this.step = Card.CardNumber("烏龜卡", this.step);
                    this.onerCard = magicCard.None;
                    break;
                    //default:
                    //    com.step += com.step;
                    //    break;
            }

            switch (people.onerCard)
            {
                case magicCard.天使卡:
                    this.step = Card.CardNumber("烏龜卡", this.step);
                    people.onerCard = magicCard.None;
                    break;
                case magicCard.惡魔卡:
                    this.step = Card.CardNumber("惡魔卡", this.step);
                    people.onerCard = magicCard.None;
                    break;
            }
        }

       
    }
}
