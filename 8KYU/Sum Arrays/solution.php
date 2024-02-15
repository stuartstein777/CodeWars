function sum(array $a): float {
  $total = 0;
  
  for($i = 0; $i <  sizeof($a); $i++) {
    $total = $total + $a[$i];
  }
  
  return $total;
}