using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.classes
{
    class Card
    {
        /// <summary>
        /// This is going to be the suit. It'll be hearts, clubs, spades, diamonds, all in lowercase
        /// </summary>
        public string Suit { get; }
        ///<summary>
        ///store jack as 11, queen as 12, king as 13, aces are 1
        /// </summary>
        public int Value { get; }

        public bool IsFaceUp { get; private set; }

        public void Flip()
        {
            // Is FaceUp = !IsFaceUp
            if (IsFaceUp)//if it's face up flip it over
                IsFaceUp = false;
            else
                IsFaceUp = true;
        }


        public Card(int Value, string suit)
        {
            //value = Value; not this
            Value = value;
            Suit = suit;
            IsFaceUp = isFaceUp = false; //this is default. Adding this line improves readability and maintainability
        }

        public Card(int value, string suit, bool isFaceUp)
        {
            Value = value;
            Suit = suit;
            IsFaceUp = isFaceUp;

        }

        public string ToString()
        {
            if(isFaceUp)
            {

                string strVal = Value.ToSTring();]

                return Value + "of" + Suit;
            }
            else
            {
                return "back of card"
            }
        }
            
    
    }
}
