namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    public class Kata
    {
        private static Dictionary<string, string> SquareColours = new Dictionary<string, string>
          {
            {"A1", "black"},{"A2", "white"},{"A3", "black"},{"A4", "white"},{"A5", "black"},{"A6", "white"},{"A7", "black"},{"A8", "white"},
            {"B1", "white"},{"B2", "black"},{"B3", "white"},{"B4", "black"},{"B5", "white"},{"B6", "black"},{"B7", "white"},{"B8", "black"},
            {"C1", "black"},{"C2", "white"},{"C3", "black"},{"C4", "white"},{"C5", "black"},{"C6", "white"},{"C7", "black"},{"C8", "white"},
            {"D1", "white"},{"D2", "black"},{"D3", "white"},{"D4", "black"},{"D5", "white"},{"D6", "black"},{"D7", "white"},{"D8", "black"},
            {"E1", "black"},{"E2", "white"},{"E3", "black"},{"E4", "white"},{"E5", "black"},{"E6", "white"},{"E7", "black"},{"E8", "white"},
            {"F1", "white"},{"F2", "black"},{"F3", "white"},{"F4", "black"},{"F5", "white"},{"F6", "black"},{"F7", "white"},{"F8", "black"},
            {"G1", "black"},{"G2", "white"},{"G3", "black"},{"G4", "white"},{"G5", "black"},{"G6", "white"},{"G7", "black"},{"G8", "white"},
            {"H1", "white"},{"H2", "black"},{"H3", "white"},{"H4", "black"},{"H5", "white"},{"H6", "black"},{"H7", "white"},{"H8", "black"}};
        public bool ChessBoardCellColor(string cell1, string cell2)
           => SquareColours[cell1] == SquareColours[cell2];
  }
}