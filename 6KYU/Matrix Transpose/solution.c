#include <stddef.h>

void transpose_matrix (
  size_t rows, size_t cols,
  const int matrix[rows][cols],
  int transpose[cols][rows])
{
    for(int x = 0; x < rows; x++) {
      for(int y = 0; y < cols; y++){
        transpose[y][x] =matrix[x][y];
      }
    }
}