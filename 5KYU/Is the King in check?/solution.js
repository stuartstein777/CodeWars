function kingIsInCheck (chessboard) {
    for(var rank = 0; rank < 8; rank++) {
      for(var file = 0; file < 8; file++) {
        //console.log(`(${rank},${file}) :: ${chessboard[file][rank]}`);
        if(chessboard[file][rank] == '♟' && pawnChecks(chessboard, rank, file))
            return true;
        if(chessboard[file][rank] == '♜' && rookChecks(chessboard, rank, file))
            return true;
        if(chessboard[file][rank] == '♝' && bishopChecks(chessboard, rank, file))
            return true;
        if(chessboard[file][rank] == '♛' && queenChecks(chessboard, rank, file))
            return true;
        if(chessboard[file][rank] == '♞' && knightChecks(chessboard, rank, file))
            return true;      
      }
    }
    return false;
  }
  
  function kingInCheckSwDiagonals(board, x, y){
     console.log(`Checking SW Diagonal: From (${y}, ${x})`)
     x--;
     y++;
     while(x != -1 && y != 8){
        console.log(`${y}, ${x} : "${board[y][x]}"`)
        if(board[y][x] !== ' ') {
            if(board[y][x] == '♔')
               return true;
            else
               return false;
         }
         x--;
         y++;
     }
     return false;
  }
  
  function kingInCheckSEDiagonals(board, x, y){
     console.log(`Checking SE Diagonal: From (${y}, ${x})`)
     x++;
     y++;
     while(x != 8 && y != 8){
        console.log(`${y}, ${x} : "${board[y][x]}"`)
        if(board[y][x] !== ' ') {
            if(board[y][x] == '♔')
               return true;
            else
               return false;
         }
         x++;
         y++;
     }
     return false;
  }
  
  function kingInCheckNEDiagonals(board, x, y){
     console.log(`Checking NE Diagonal: From (y: ${y}, x:${x})`)
     x++;
     y--;
     while(x != 8 && y != -1){
        console.log(`${y}, ${x} : "${board[y][x]}"`)
        if(board[y][x] !== ' ') {
            if(board[y][x] == '♔')
               return true;
            else
               return false;
         }
         x++;
         y--;
     }
     return false;
  }
  
  function kingInCheckNWDiagonals(board, x, y){
     console.log(`Checking NW Diagonal: From (y: ${y}, x:${x})`)
     x--;
     y--;
     while(x != -1 && y != -1){
        console.log(`${y}, ${x} : "${board[y][x]}"`)
        if(board[y][x] !== ' ') {
            if(board[y][x] == '♔')
               return true;
            else
               return false;
         }
         x--;
         y--;
     }
     return false;
  }
  
  function kingInCheckSouth(board, x, y){
    console.log(`Checking South: From (${y}, ${x})`)
    y--;
    while(y >= 0){
      console.log(`${y}, ${x} : "${board[y][x]}"`)
      if(board[y][x] !== ' ') {
         if(board[y][x] == '♔')
            return true;
        else
            return false;
      }
      y--;
    }
    return false;
  }
  
  function kingInCheckNorth(board, x, y){
    console.log(`Checking North: From (${y}, ${x})`)
    y++;
    while(y != 8){
      console.log(`${y}, ${x} : "${board[y][x]}"`)
      if(board[y][x] !== ' ') {
         if(board[y][x] == '♔')
            return true;
        else
            return false;
      }
      y++;
    }
    return false;
  }
  
  function kingInCheckEast(board, x, y){
    console.log(`Checking East: From (${y}, ${x})`)
    x++;
    while(x != 8){
      console.log(`${y}, ${x} : "${board[y][x]}"`)
      if(board[y][x] !== ' ') {
         if(board[y][x] == '♔')
            return true;
        else
            return false;
      }
      x++;
    }
    return false;
  }
  
  function kingInCheckWest(board, x, y){
    console.log(`Checking West: From (${y}, ${x})`)
    x--;
    while(x >= 0){
      console.log(`${y}, ${x} : "${board[y][x]}"`)
      if(board[y][x] !== ' ') {
         if(board[y][x] == '♔')
            return true;
        else
            return false;
      }
      x--;
    }
    return false;
  }
  
  function pawnChecks(board, x, y){
    console.log(`Pawn on ${x}, ${y}`);
    if(board[y+1][x+1] === '♔' ||
       board[y+1][x-1] === '♔')
         return true;
    return false;
  }
  
  function bishopChecks(board, rank, file){
    console.log(`Bishop on ${rank}, ${file}`);
    if(kingInCheckSwDiagonals(board, rank, file) || kingInCheckNEDiagonals(board, rank, file) ||
       kingInCheckNWDiagonals(board, rank, file) || kingInCheckSEDiagonals(board, rank, file)) {
      return true;
    }
    return false;
  }
  function rookChecks(board, rank, file){
    console.log(`Rook on ${rank}, ${file}`);
    if(kingInCheckSouth(board, rank, file) || kingInCheckNorth(board, rank, file) ||
       kingInCheckEast(board, rank, file) || kingInCheckWest(board, rank, file)){
      return true;
    }
    return false;
  }
  
  function queenChecks(board, rank, file){
    console.log(`Queen on ${rank}, ${file}`);
    if(kingInCheckSwDiagonals(board, rank, file) || kingInCheckNEDiagonals(board, rank, file) ||
       kingInCheckNWDiagonals(board, rank, file) || kingInCheckSEDiagonals(board, rank, file) ||
       kingInCheckSouth(board, rank, file) || kingInCheckNorth(board, rank, file) ||
       kingInCheckEast(board, rank, file) || kingInCheckWest(board, rank, file)) {
      return true;
    }
    return false;
  }
  
  function knightChecks(board, x, y){
    console.log(`Knight on ${x}, ${y}`);
    const knightMoves = [[1, -2], [-1, -2], [-2, -1], [-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1]];
    for(var i = 0; i < 8; i++) {
      var xΔ = knightMoves[i][0];
      var yΔ = knightMoves[i][1];
      var xn = x + xΔ;
      var yn = y + yΔ;
      
      if(xn >= 0 && xn <= 7 && yn >= 0 && yn <= 7 && board[yn][xn] == '♔'){
        return true;
      }
    }
    return false;
  }