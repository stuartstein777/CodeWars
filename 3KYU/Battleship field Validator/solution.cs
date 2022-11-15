public enum ShipType
{
    BattleShip,
    Cruiser,
    Destroyer,
    Submarine,
    Invalid
}

public class BattleshipField
{
    private static void PrintFoundShip(ShipType shipType)
    {
        switch (shipType)
        {
            case ShipType.Cruiser:
                "Found Cruiser".Print();
                break;
            case ShipType.Destroyer:
                "Found Destroyer".Print();
                break;
            case ShipType.Submarine:
                "Found Submarine".Print();
                break;
            case ShipType.BattleShip:
                "Found BattleShip".Print();
                break;
            case ShipType.Invalid:
                "Invalid Layout".Print();
                break;
        }
    }
    
    public static bool ValidateBattlefield(int[,] field)
    {
        var shipTypeCounts = new Dictionary<ShipType, int>
        {
            { ShipType.BattleShip , 0},
            { ShipType.Cruiser , 0},
            { ShipType.Destroyer , 0},
            { ShipType.Submarine , 0}
        };
        
        for (var y = 0; y < 10; y++)
        {
          for (var x = 0; x < 10; x++)
          {
              if (field[y, x] == 1)
              {
                  field[y, x] = 2;
                  var shipType = GetShipType(field, y, x);
                  PrintFoundShip(shipType);
                  if (shipType == ShipType.Invalid || !shipTypeCounts.ContainsKey(shipType))
                      return false;

                  shipTypeCounts[shipType]++;
              }
          }
        }
        
        return shipTypeCounts[ShipType.Cruiser] == 2 &&
               shipTypeCounts[ShipType.Destroyer] == 3 &&
               shipTypeCounts[ShipType.BattleShip] == 1 &&
               shipTypeCounts[ShipType.Submarine] == 4;
    }

    /// <summary>
    /// We scan top to bottom and left to right.
    /// That means on each found square, we need to check if we are already
    /// touching a ship diagonally above us.
    /// When we find a ship, we need to check if it's a ship that goes left to right
    /// or up and down.
    /// It could also be a single square (submarine).
    /// </summary>
    /// <param name="field"></param>
    /// <param name="y"></param>
    /// <param name="x"></param>
    /// <returns></returns>
    private static ShipType GetShipType(int[,] field, int y, int x)
    {
        $"Found ship at ({y}, {x})".Print();
        var xIncrementer = 0;
        var yIncrementer = 0;
        var shipPiecesFound = 1;

        // We are touching a ship on our left or above, then return invalid ship
        // we also need to check diagonal right up, and diagonal left up.
        if (ExistingShipToLeft(field, y, x) ||
            ExistingShipAbove(field, y, x) ||
            ExistingShipTouchingDiagonallyAboveLeft(field, y, x) ||
            ExistingShipTouchingDiagonallyAboveRight(field, y, x))
            return ShipType.Invalid;
        
        if (x < 9 && field[y, x + 1] == 1)
            xIncrementer++;
        else if (y < 9 && field[y + 1, x] == 1)
            yIncrementer++;

        if (xIncrementer == 0 && yIncrementer == 0)
            return ShipType.Submarine;
        
        do
        {
            x += xIncrementer;
            y += yIncrementer;
            if (field[y, x] == 1)
            {
                shipPiecesFound++;
                field[y, x] = 2;
            }
            else if (field[y, x] == 2)
                return ShipType.Invalid;
        } while (field[y, x] != 0);
        
        return shipPiecesFound switch
        {
            1 => ShipType.Submarine,
            2 => ShipType.Destroyer,
            3 => ShipType.Cruiser,
            4 => ShipType.BattleShip,
            _ => ShipType.Invalid
        };
    }

    private static bool ExistingShipTouchingDiagonallyAboveRight(int[,] field, int y, int x)
        => y > 0 && x < 9 && field[y - 1, x + 1] == 2; 

    private static bool ExistingShipTouchingDiagonallyAboveLeft(int[,] field, int y, int x)
        => y > 0 && x > 0 && field[y - 1, x - 1] == 2;

    private static bool ExistingShipAbove(int[,] field, int y, int x)
        => y != 0 && field[y - 1, x] == 2;

    private static bool ExistingShipToLeft(int[,] field, int y, int x)
        => x != 0 && field[y, x - 1] == 2;
}