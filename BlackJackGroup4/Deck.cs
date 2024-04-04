using System;
using System.Collections.Generic;
using System.Drawing;

namespace BlackJackGroup4
{
    // Enum to represent card suits
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    // Enum to represent card ranks
    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    // Class to represent individual playing cards
    public class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }
        public Image Image { get; }

        public Card(Suit suit, Rank rank, Image image)
        {
            Suit = suit;
            Rank = rank;
            Image = image;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    // Class to represent a deck of playing cards
    public class Deck
    {
        private List<Card> cards;

        // Create a standard deck of cards
        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
        }

        // Initialize deck with 52 cards
        private void InitializeDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
        // Load image from resources using suit and rank
                    string imageName = $"{suit.ToString().ToLower()}_{rank.ToString().ToLower()}";
                    Image image = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

        // Create a card with the suit, rank, and associated image
                    Card card = new Card(suit, rank, image);
                    cards.Add(card);
                }
            }
        }

        // Shuffle the deck
        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        // Deal a card from the deck
        public Card Deal()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("The deck is empty.");
            }

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        // Reset to full standard deck
        public void Reset()
        {
            cards.Clear();
            InitializeDeck();
        }

        // Display remaining cards in deck (for debugging)
        public void DisplayRemainingCards()
        {
            foreach (var card in cards)
            {
                Console.WriteLine(card);
            }
        }
        public bool IsEmpty()
        {
            return cards.Count == 0;
        }
    }
}
