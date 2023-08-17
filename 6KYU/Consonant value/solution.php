function solve($s) {
  
  $largest = 0;
  $current = 0;
  
  for($i = 0; $i < strlen($s); $i++) {
    $c = $s[$i];
    if($c == 'a' || $c == 'e' || $c == 'i' || $c == 'o' || $c == 'u') {
      if($current > $largest) {
        $largest = $current;
      }
      $current = 0;
    } else {
      $current += (ord($c) - 96);
    }
  }
  
  if($current > $largest) {
    return $current;
  }
  return $largest;
}
