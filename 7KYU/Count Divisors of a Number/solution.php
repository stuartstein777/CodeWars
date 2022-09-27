function divisors($n) {
  $totalDivisors = 0;
  
  for($i = 1; $i <= $n; $i++) {
    if($n % $i == 0) {
      $totalDivisors++;
    }
  }
  return $totalDivisors;
}