using System;

namespace Solution
{
    public partial class Kata
    {
        public static string DefineSuit(string card)
            => card[^1] switch
               {
                   '♣' => "clubs",
                   '♦' => "diamonds",
                   '♠' => "spades",
                   '♥' => "hearts"
               };
     }
}