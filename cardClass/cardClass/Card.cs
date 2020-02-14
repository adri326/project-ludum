using System;
using System.Collections.Generic;
using System.Linq;

namespace cardClass
{
    class Card
    {
        public string ImgPath_Front { get; set; }
        public string ImgPath_Back { get; set; }
        public string Color { get; set; }
        public byte Number { get; set; }
        public byte Effect_Code { get; set; }

    }

    class Deck
    {
        private const byte DECK_NB_MAX_CARDS = 108; 
        private const byte DECK_NB_SPECIAL_BLACK_CARDS = 8;
        private const byte DECK_NB_CARDS_PER_RGBY = 10;
        private const byte DECK_NB_SPECIAL_CARDS_DRAW_TWO_PER_RGBY = 2;
        private const byte DECK_NB_SPECIAL_CARDS_SKIP_PER_RGBY = 2;
        private const byte DECK_NB_SPECIAL_CARDS_REVERSE_TWO_PER_RGBY = 2;
        private const byte DECK_NB_SPECIAL_CARDS_WILD_BLACK = 4;
        private const byte DECK_NB_SPECIAL_CARDS_WILD_DRAW_FOUR_BLACK = 4;

        private readonly string[] BACKGROUND_COLORS = new string[4] { "Red", "Green", "Yellow", "Blue"};
        private readonly string[] SPECIAL_CARDS_COLORS = new string[3] { "draw_2", "reverse", "skip"};
        private readonly byte[] SPECIAL_CARDS_NB_COLORS = new byte[3] { 2, 2, 2};
        private readonly string[] SPECIAL_CARDS_BLACK = new string[2] { "wild", "wild_draw_4" };
        private readonly byte[] SPECIAL_CARDS_NB_BLACK = new byte[2] { 4, 4 };
        

        public static Random rng = new Random();

        private List<Card> deckInitialized;

        public Stack<Card> Cards { get; set; }

        public Deck()
        {
            Initialize_Deck();

        }

        /// <summary>
        /// Draw a card from the deck and returns the obj
        /// </summary>
        /// <returns>Card drawn</returns>
        public Card Draw()
        {
            if(Cards.Count != 0) { return Cards.Pop(); }
            else { return null; }  
        }

        /// <summary>
        /// Create the deck with all the cards of a standard uno game structure
        /// </summary>
        private void Initialize_Deck()
        {
            deckInitialized = new List<Card>();

            //FULL DECK 108
            while (deckInitialized.Count < DECK_NB_MAX_CARDS)
            {
                //COLOR 4 RGBY
                for (byte clr = 0; clr < BACKGROUND_COLORS.Count(); clr++)
                {
                    //STANDAR CARD 0-9
                    for (byte i = 0; i < DECK_NB_CARDS_PER_RGBY; i++)
                    {
                        Card crd = new Card();
                        crd.Color = BACKGROUND_COLORS[clr];
                        crd.Number = Convert.ToByte(i + 1);
                        crd.Effect_Code = 0; //NO EFFECT (STANDARD)
                        crd.ImgPath_Front = $"card_front_num_{i}";
                        crd.ImgPath_Back = $"card_background_{BACKGROUND_COLORS[clr]}";

                        deckInitialized.Add(crd);
                        if (deckInitialized.Count >= DECK_NB_MAX_CARDS) { break; }

                    }
                    if (deckInitialized.Count >= DECK_NB_MAX_CARDS) { break; }


                    //COLOR SPECIAL CARDS +2, SKIP, REVERSE
                    for (byte i = 0; i < SPECIAL_CARDS_NB_COLORS.Count(); i++)
                    {
                        for (byte ii = 0; ii < SPECIAL_CARDS_NB_COLORS[i]; ii++)
                        {
                            Card crd = new Card();
                            crd.Color = BACKGROUND_COLORS[clr];
                            crd.Number = Convert.ToByte(10 + i);
                            crd.Effect_Code = i; //NO EFFECT (STANDARD)
                            crd.ImgPath_Front = $"card_special_{SPECIAL_CARDS_COLORS[i]}";
                            crd.ImgPath_Back = $"card_background_{BACKGROUND_COLORS[clr]}";

                            deckInitialized.Add(crd);
                        }

                        if (deckInitialized.Count >= DECK_NB_MAX_CARDS) { break; }
                    }
                    if (deckInitialized.Count >= DECK_NB_MAX_CARDS) { break; }

                }

                //BLACK
                for (byte i = 0; i < SPECIAL_CARDS_BLACK.Count(); i++)
                {
                    for (byte n = 0; n < SPECIAL_CARDS_NB_BLACK[i]; n++)
                    {
                        Card crd = new Card();
                        crd.Color = "Black";
                        crd.Number = Convert.ToByte(10 + i);
                        crd.Effect_Code = i; //NO EFFECT (STANDARD)
                        crd.ImgPath_Front = $"card_special_{SPECIAL_CARDS_BLACK[i]}";
                        crd.ImgPath_Back = $"card_background_Black";

                        deckInitialized.Add(crd);
                    }
                    if (deckInitialized.Count >= DECK_NB_MAX_CARDS) { break; }

                }
                if (deckInitialized.Count >= DECK_NB_MAX_CARDS) { break; }

            }
        }

        private void Blend()
        {
            Cards = new Stack<Card>();

            while (deckInitialized.Count != 0)
            {
                int random = rng.Next(0, deckInitialized.Count);
                Cards.Push(deckInitialized[random]);
                deckInitialized.RemoveAt(random);
            }
        }

    }


}
