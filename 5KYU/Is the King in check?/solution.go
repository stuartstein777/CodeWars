package kata

func KingInCheckNeDiagonal(board [8][8]rune, x int, y int) bool {
  x+=1
  y-=1
  
  for {
    if x == 8 || y == -1 {
      return false
    }
    if(board[y][x] != ' ') {
        if(board[y][x] == '♔') {
           return true;
        } else {
           return false;
        }
     }
     x++;
     y--;
  }
  return false
}

func KingInCheckNwDiagonal(board [8][8]rune, x int,y int) bool {
  x-=1
  y-=1
  
  for {
    if x == -1  || y == -1 {
      return false
    }
    if board[y][x] != ' ' {
      if board[y][x] == '♔'{
        return true
      } else {
        return false
      }
    }
    x-=1
    y-=1
  }
}

func KingInCheckSeDiagonal(board [8][8]rune, x int, y int) bool {
  x+=1
  y+=1
  
  for {
    if x == 8 || y == 8 {
      break
    } else {
      if board[y][x] != ' ' {
         if board[y][x] == '♔' {
              return true
            } else {
              return false
            }
        }
      }
    
    x+=1
    y+=1
  }
  return false
}

func KingInCheckSwDiagonal(board [8][8]rune, x int, y int) bool {
  x -= 1
  y += 1
  
  for {
    if x == -1 || y == 8 {
      return false
    }
    
    if board[y][x] != ' ' {
      if board[y][x] == '♔' {
        return true
      } else {
        return false
      }
    }
    x -= 1
    y += 1
  }
}

func PawnChecks(board [8][8]rune, x int, y int) bool {
  if y+1 > 7 || x + 1 > 7 || x - 1 < 0 {
    return false
  }
  
  if board[y+1][x+1] == '♔' ||
     board[y+1][x-1] == '♔' {
       return true
  } else {
       return false
     }
}

func KingInCheckSouth(board [8][8]rune, x, y int) bool {
    y -=1
  
    for {
      if y < 0 {
         break
      }
      
      if board[y][x] != ' ' {
         if board[y][x] == '♔' {
              return true
            } else {
              return false
            }
      }
      y -= 1
    }
    return false
}

func KingInCheckNorth(board [8][8]rune, x int, y int) bool {
    y+=1
  
  for {
    if(y == 8) {
      break
    }
    
    if board[y][x] != ' ' {
      if board[y][x] == '♔' {
        return true
      } else {
        return false
      }
      
    }
    y+=1
  }
  return false
}

func KingInCheckEast(board [8][8]rune, x int, y int) bool {
  x += 1
  
  for {
    if x == 8 {
      break
    }
    
    if board[y][x] != ' ' {
      if board[y][x] == '♔' {
        return true
      } else {
        return false
      }
    } 
    x+=1
  }
  
  return false
}

func KingInCheckWest(board [8][8]rune, x int, y int) bool {
  x -= 1
  
  for {
    if x < 0 {
      break
    }

    if board[y][x] != ' ' {
      if board[y][x] == '♔' {
        return true
      } else {
        return false
      }
    }
    x-=1
  }
  
  return false
}

func RookChecks(board [8][8]rune, rank int, file int) bool {
   if KingInCheckSouth(board, rank, file) || KingInCheckNorth(board, rank, file) ||
      KingInCheckEast(board, rank, file) || KingInCheckWest(board, rank, file) {
        return true
  } else {
      return false        
  }
}

func BishopChecks(board [8][8]rune, rank int, file int) bool {
  if KingInCheckSwDiagonal(board, rank, file) || KingInCheckNeDiagonal(board, rank, file) ||
     KingInCheckSeDiagonal(board, rank, file) || KingInCheckNwDiagonal(board, rank, file) {
       return true
     }
  return false
}

func KnightChecks(board [8][8]rune, x int, y int) bool {
    knightMoves := [8][2]int{
        {1, -2},
        {-1, -2},
        {-2, -1},
        {-2, 1},
        {-1, 2},
        {1, 2},
        {2, 1},
        {2, -1}}
  
  for _, knightMove := range knightMoves {
     xΔ := knightMove[0]
     yΔ := knightMove[1]
    
    xn := x +  xΔ
    yn := y +  yΔ
    
    if xn >= 0 && xn < 8 && yn >= 0 && yn < 8 && board[yn][xn] == '♔' {
      return true
    }
  }
  
  return false
}

func QueenChecks(board [8][8]rune, rank int, file int) bool {
  if KingInCheckSwDiagonal(board, rank, file) || KingInCheckSeDiagonal(board, rank, file) ||
     KingInCheckNwDiagonal(board, rank, file) || KingInCheckNeDiagonal(board, rank, file) ||
     KingInCheckSouth(board, rank, file) || KingInCheckNorth(board, rank, file) ||
     KingInCheckEast(board, rank, file) || KingInCheckWest(board, rank, file) {
       return true
     }
  return false
}

func KingIsInCheck(board [8][8]rune) bool {
  
  for rank := 0; rank < 8; rank ++ {
    for file := 0; file < 8; file++ {
      if (board[file][rank] == '♟' && PawnChecks(board, rank, file)) || 
         (board[file][rank] == '♜' && RookChecks(board, rank, file)) ||
         (board[file][rank] == '♝' && BishopChecks(board, rank, file)) ||
         (board[file][rank] == '♞' && KnightChecks(board, rank, file)) ||
         (board[file][rank] == '♛' && QueenChecks(board, rank, file)) {
        return true
      }
    }
  }
  return false
}
