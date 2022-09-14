function josephus_survivor(int $n, int $k): int {
  $r = 0;
  $i = 1;
  
  while($i != $n+1) {
    $r = ($r + $k) % $i;
    $i++;
  }
  return $r+1;
}