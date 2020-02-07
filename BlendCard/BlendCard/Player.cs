using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlendCard
{
    class Player
    {
        List<Card> Hand = new List<Card>();
        string name;

        public Player(string _name)
        {
            name = _name;
        }

        public void draw(Card card)
        {
            Hand.Add(card);
        }

        public void draw(params Card[] cards)
        {
            if (Hand.Count != 0) {
                Hand.InsertRange(Hand.Count - 1, cards);
            }
            else
            {
                Hand.InsertRange(0,cards);
            }
        }
    }
}
