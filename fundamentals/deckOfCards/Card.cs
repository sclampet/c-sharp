using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Card 
    {
        public string stringVal;
        public int _val;
        public int _suit;
        public string[] suitArray = {"Clubs", "Spades", "Hearts", "Diamonds"};
        public string Suit 
        {
            get { return suitArray[_suit]; }
        }

        public string Value
        {
            get
            {
                switch(_val)
                {
                    case 1:
                        return "Ace";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return _val.ToString();
                }
            }
        }

        public Card(int val, int suit)
        {
            _val = val;
            _suit = suit;
        }

    }
    public class Deck 
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            for(int sym = 0; sym < 4; sym++)
            {
                for(int i = 1; i < 14; i++)
                {
                    Card card = new Card(i, sym);
                    cards.Add(card);
                }
            }
        }
        public Card Deal()
        {
            Card dealtCard = cards[0];
            cards.RemoveAt(0);
            return dealtCard;
        }
        public void Reset()
        {
            
        }
        public void Shuffle()
        {
            int idx;
            Random rand = new Random();

            for(int i = 0; i < cards.Count; i++)
            {
                idx = rand.Next(cards.Count);

                Card card = cards[i];
                cards[i] = cards[idx];
                cards[idx] = cards[i];
            }

        }

        public class Player
        {
            public string _name;
            public List<Card> hand = new List<Card>();

            public Player(string name)
            {
                _name = name;
            }
            public Card Draw(Deck fromDeck)
            {
                Card newCard = fromDeck.Deal();
                hand.Add(newCard);
                return newCard;
            }
            public Card Discard(Card card)
            {
                for(int i = 0; i < hand.Count; i++)
                {
                    if(hand[i] == card)
                    {
                        hand.Remove(hand[i]);
                        System.Console.WriteLine($"Discarded {card} !");
                    }
                }
                return card;
            }
        }
    }
}