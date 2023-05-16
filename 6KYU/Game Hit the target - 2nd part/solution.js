function scanDown(grid, ci, cj, rows, lookingFor) {
    console.log(lookingFor)
    for(var i = ci; i < rows; i++) {
      if(grid[i][cj] == lookingFor) {
        return true;
      }
    }
    return false;
  }
  const solution = grid => {
    const rows = grid.length;
    const cols = grid[0].length;
    
    for(var i = 0; i < rows; i++) {
      for(var j = 0; j < cols; j++) {
        if(grid[i][j] == 'x') {
          if(scanDown(grid, i+1, j, rows, '^')) {
             return true;
          } else if(scanRight(grid, i, j+1, cols, '<')) {
             return true;
          }
        } else if(grid[i][j] == '>') {
          return scanRight(grid, i, j+1, cols, 'x');
        } else if(grid[i][j] == 'v') {
          return scanDown(grid, i+1, j, cols, 'x');
        }
      }
    }
    return false;
  }
  
  
  function scanRight(grid, ci, cj, cols, lookingFor) {
    for(var i = cj; i < cols; i++) {
      if (grid[ci][i] == lookingFor) {
        return true;
      }
    }
    return false;
  }
  /*
  
  func Solution(grid [][]rune) bool {
    fmt.Println(fmt.Sprint(grid))
      rows := len(grid)
      cols := len(grid[0])
      for i := 0; i < rows; i++ {
          for j := 0; j < cols; j++ {
              if grid[i][j] == 'x' {
                  if ScanDown(grid, i+1, j, rows, '^') {
                      return true
                  } else if ScanRight(grid, i, j+1, cols, '<') {
                      return true
                  }
              } else if grid[i][j] == '>' {
                  return ScanRight(grid, i, j+1, cols, 'x')
              } else if grid[i][j] == 'v' {
                  return ScanDown(grid, i+1, j, cols, 'x')
              }
          }
      }
      return false
  }
  */