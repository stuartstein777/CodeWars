using System.Collections.Generic;
using System.Linq;
using System;

public static class Kata
{
    public static (string type, string[] ranks) Hand(string[] holeCards, string[] communityCards)
    {
        return HandSolver.SolveKata(holeCards, communityCards);
    }
}

public class BestHand
{
    public Hands HandType { get; }
    public IEnumerable<Card> Hand { get; }
    public IEnumerable<Card> Kickers { get; }

    public BestHand(Hands handType,
                    IEnumerable<Card> hand,
                    IEnumerable<Card> kickers)
    {
        HandType = handType;
        Hand = hand;
        Kickers = kickers;
    }
}

public sealed class Card : IEquatable<Card>
{
    public Suit Suit { get; }
    public int Value { get; }

    public Card(Suit suit, int value)
    {
        Suit = suit;
        Value = value;
    }

    public override string ToString() =>
        Value switch
        {
            11 => "J",
            12 => "Q",
            13 => "K",
            14 => "A",
            _ => Value.ToString()
        };

    public static Card From(string s)
        => s.Length == 2
            ? new Card(s[1].GetSuite(), s[0].ToString().GetValue())
            : new Card(s[2].GetSuite(), s[..2].GetValue());

    public bool Equals(Card other)
        => other is not null && Suit == other.Suit && Value == other.Value;

    public override bool Equals(object obj)
        => Equals(obj as Card);
    
    public override int GetHashCode()
        => HashCode.Combine((int)Suit, Value);
}

public static class Extensions
{
    public static Suit GetSuite(this char c) =>
        c switch
        {
            '♠' => Suit.Spades,
            '♥' => Suit.Hearts,
            '♣' => Suit.Clubs,
            '♦' => Suit.Diamonds,
            _ => throw new ArgumentException("invalid suit")
        };

    public static int GetValue(this string c) =>
        c switch
        {
            "2" => 2,
            "3" => 3,
            "4" => 4,
            "5" => 5,
            "6" => 6,
            "7" => 7,
            "8" => 8,
            "9" => 9,
            "10" => 10,
            "J" => 11,
            "Q" => 12,
            "K" => 13,
            "A" => 14,
            _ => throw new ArgumentException("Invalid card value")
        };

    public static string HandToString(this Hands hand) =>
        hand switch
        {
            Hands.Flush => "flush",
            Hands.Nothing => "nothing",
            Hands.Pair => "pair",
            Hands.Straight => "straight",
            Hands.FullHouse => "full house",
            Hands.StraightFlush => "straight-flush",
            Hands.TwoPair => "two pair",
            Hands.FourOfAKind => "four-of-a-kind",
            Hands.ThreeOfAKind => "three-of-a-kind"
        };
}

public static class HandResolver
{
    private static Dictionary<Hands, int> HandScores
        = new()
        {
            { Hands.Nothing, 1 },
            { Hands.Pair, 2 },
            { Hands.TwoPair, 3 },
            { Hands.ThreeOfAKind, 4 },
            { Hands.Straight, 5 },
            { Hands.Flush, 6 },
            { Hands.FullHouse, 7 },
            { Hands.FourOfAKind, 8 },
            { Hands.StraightFlush, 9 }
        };

    public static int ResolveHands(IEnumerable<(int PlayerId, BestHand Hand)> players)
    {
        players.OrderByDescending(c => HandScores[c.Hand.HandType]);
        
        
        throw new NotImplementedException();
    }
}

public enum Hands
{
    StraightFlush,
    FourOfAKind,
    FullHouse,
    Flush,
    Straight,
    ThreeOfAKind,
    TwoPair,
    Pair,
    Nothing
}

public enum Suit
{
    Hearts,
    Clubs,
    Spades,
    Diamonds
}

public static class HandSolver
{
    private static Suit[] Suits = new[]{Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades};

    public static (string, string[]) SolveKata(string[] holeCards, string[] communityCards)
    {
        var bestHand = GetBestHand(holeCards.Select(Card.From), communityCards.Select(Card.From));
        var ranks = bestHand.HandType switch
        {
            Hands.StraightFlush => bestHand.Hand.OrderByDescending(c => c.Value).Select(c => c.ToString()).ToArray(),
            Hands.FourOfAKind => new []{bestHand.Hand.First().ToString(), bestHand.Kickers.First().ToString()},
            Hands.FullHouse => new []{bestHand.Hand.First().ToString(), bestHand.Hand.ElementAt(3).ToString()},
            Hands.Flush => bestHand.Hand.OrderByDescending(c => c.Value).Select(c => c.ToString()).ToArray(),
            Hands.Straight => bestHand.Hand.OrderByDescending(c => c.Value).Select(c => c.ToString()).ToArray(),
            Hands.ThreeOfAKind => new []{bestHand.Hand.First().ToString()}.Concat(bestHand.Kickers.OrderByDescending(c => c.Value).Take(2).Select(c => c.ToString())).ToArray(),
            Hands.TwoPair => new []
            {
                bestHand.Hand.First().ToString(), bestHand.Hand.ElementAt(2).ToString(),
                bestHand.Kickers.OrderByDescending(c => c.Value).First().ToString()
            },
            Hands.Pair => new []
            {
                bestHand.Hand.First().ToString()
            }.Concat(bestHand.Kickers
                             .OrderByDescending(c => c.Value)
                             .Take(3)
                             .Select(c => c.ToString())).ToArray(),
            Hands.Nothing => new []{bestHand.Hand.First().ToString()}
                            .Concat(bestHand.Kickers
                                            .OrderByDescending(c => c.Value)
                                            .Select(c => c.ToString()))
                            .ToArray()
        };
        return (bestHand.HandType.HandToString(), ranks);
    }
    
    public static BestHand GetBestHand(IEnumerable<Card> holeCards, IEnumerable<Card> communityCards)
    {
        var cards = holeCards.Concat(communityCards).ToArray();

        return HasStraightFlush(cards) ??
               HasFourOfAKind(cards) ??
               HasFullHouse(cards) ??
               HasFlush(cards) ??
               HasStraight(cards) ??
               HasThreeOfAKind(cards) ??
               HasTwoPair(cards) ??
               HasPair(cards) ??
               new BestHand(Hands.Nothing,
                            new List<Card> { cards.MaxBy(c => c.Value) },
                            cards.OrderByDescending(c => c.Value).Skip(1).Take(4));
    }

    private static BestHand HasPair(IEnumerable<Card> cards)
    {
        var pairs = cards.GroupBy(c => c.Value)
                         .Where(g => g.Count() == 2)
                         .OrderByDescending(g => g.Count())
                         .ThenBy(g => g.Key);
        
        return pairs.Any()
            ? new BestHand(Hands.Pair, pairs.First(), cards.OrderByDescending(g => g.Value)
                                                           .Except(pairs.First())
                                                           .Take(3))
            : null;
    }

    private static BestHand HasTwoPair(IEnumerable<Card> cards)
    {
        var groups = cards.GroupBy(c => c.Value).OrderByDescending(g => g.Key).Where(g => g.Count() >= 2);

        if (groups.Count(g => g.Count() >= 2) >= 2)
        {
            var hand = groups.ElementAt(0).Concat(groups.ElementAt(1));
            var kickers = cards.Except(hand).OrderByDescending(c => c.Value).Take(1);
            return new BestHand(Hands.TwoPair, hand, kickers);
        }
        return null;
    }
    
    private static BestHand HasThreeOfAKind(IEnumerable<Card> cards)
    {
        var groups = cards.GroupBy(c => c.Value).OrderByDescending(g => g.Key).Where(g => g.Count() == 3);
        if (!groups.Any(g => g.Count() == 3))
            return null;
        var hand = groups.First();
        var kickers = cards.Except(hand).OrderByDescending(c => c.Value).Take(2);
        return new BestHand(Hands.ThreeOfAKind, hand, kickers);
    }
    
    private static BestHand HasStraight(IEnumerable<Card> cards)
    {
        var descCards = cards.OrderByDescending(c => c.Value).DistinctBy(c => c.Value).ToList();
        for (var i = 0; i < descCards.Count() - 4; i++)
        {
            var ci = descCards[i].Value;
            if (descCards[i + 1].Value == ci - 1 &&
                descCards[i + 2].Value == ci - 2 &&
                descCards[i + 3].Value == ci - 3 &&
                descCards[i + 4].Value == ci - 4)
            {
                return new BestHand(Hands.Straight, descCards.Skip(i).Take(5), Enumerable.Empty<Card>());
            }
        }
        return null;
    }

    private static BestHand HasFullHouse(Card[] cards)
    {
        var groups = cards.OrderBy(c => c.Value).GroupBy(c => c.Value);
        if (groups.Any(g => g.Count() >= 3))
        {
            var highestThreeOfAKind = groups.Where(g => g.Count() == 3).OrderByDescending(g => g.Key).First();
            var highestPair = groups.Where(g => g.Count() >= 2 && g.Key != highestThreeOfAKind.Key)
                                    .MaxBy(g => g.Key);
            
            if (highestPair != null)
                return new BestHand(Hands.FullHouse,
                                    highestThreeOfAKind.Concat(highestPair.Take(2)),
                                    Enumerable.Empty<Card>());
        }
        return null;
    }

    private static BestHand HasFourOfAKind(Card[] cards)
    {
        var groups = cards.GroupBy(c => c.Value).Where(g => g.Count() == 4);

        if (groups.Any())
        {
            return new BestHand(Hands.FourOfAKind,
                groups.First(),
                new[]
                {
                    cards.OrderByDescending(c => c.Value)
                        .First(c => c.Value != groups.First().First().Value)
                });

        }
        return null;
    }
  
    private static BestHand HasFlush(IEnumerable<Card> cards)
    {
        var sortedCards = cards.OrderBy(c => c.Value);
        foreach (var suit in Suits)
        {
            var cardsWithSuit = sortedCards.Where(c => c.Suit == suit).ToList();
            if (cardsWithSuit.Count < 5)
                continue;

            return new BestHand(Hands.Flush,
                                cardsWithSuit.OrderByDescending(c => c.Value).Take(5),
                                Enumerable.Empty<Card>());
        }

        return null;
    }
    
    private static BestHand HasStraightFlush(Card[] cards)
    {
        var sortedCards = cards.OrderBy(c => c.Value);
        foreach (var suit in Suits)
        {
            var cardsWithSuit = sortedCards.Where(c => c.Suit == suit).ToList();
            if (cardsWithSuit.Count < 5)
                continue;
            
            // we have a flush.
            // if the cards contain an ace, add another "high ace"
            if (cardsWithSuit[0].Value == 1)
                cardsWithSuit.Add(new Card(suit, 14));

            var cnt = cardsWithSuit.Count;

            for (var i = cnt - 1; i >= 4; i--)
            {
                // look at last card and go back 4
                // if that card is 4 less than the high card,
                // its a straight (Straight Flush).
                if (cardsWithSuit[i].Value - cardsWithSuit[i - 4].Value == 4)
                {
                    return new BestHand(Hands.StraightFlush,
                                        cardsWithSuit.GetRange(i - 4, 5),
                                        Enumerable.Empty<Card>());
                }
            }
        }
        return null;
    }
}