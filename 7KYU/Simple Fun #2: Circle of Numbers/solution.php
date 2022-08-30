function circle_of_numbers(int $n, int $first_number): int {
  return ($first_number + $n / 2) % $n;
}