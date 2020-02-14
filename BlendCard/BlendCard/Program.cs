using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlendCard
{
    class Program
    {
        public static Random rng = new Random();

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            
            for(int i = 0; i < 54; i++)
            {
                cards.Add(new Card(i));
            }

            Stack<Card> listBlend = Blend(cards);
            Player playerOne = new Player("playerOne");

            playerOne.draw(listBlend.Pop(),listBlend.Pop(),listBlend.Pop(),listBlend.Pop(),listBlend.Pop(),listBlend.Pop());


        }


        static Stack<Card> Blend(List<Card> listCards)
        {
            Stack<Card> listBlend = new Stack<Card>();

            while (listCards.Count != 0)
            {
                int random = rng.Next(0,listCards.Count);
                listBlend.Push(listCards[random]);
                listCards.RemoveAt(random);
            }

            return listBlend;
        }
    }
}
