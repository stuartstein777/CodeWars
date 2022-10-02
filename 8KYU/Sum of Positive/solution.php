function positive_sum($arr) {
  $total = 0;
  
  for($i = 0; $i < count($arr); $i++) {
    if($arr[$i] > 0) {
      $total = $total + $arr[$i];
    }
  }
    
  return $total;
}