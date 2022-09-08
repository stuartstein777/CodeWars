function solution($number){
  $total = 0;
  
  for ($x = 0; $x <= $number-1; $x++) {
    if($x % 3 == 0 || $x % 5 == 0) {
      $total = $total + $x;
    }
  }
    
  return $total;
}