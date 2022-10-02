function invite_more_women(array $a): bool {
   $total = 0;
     
   for($i = 0; $i < count($a); $i++) {
      $total = $total + $a[$i];
   }
   return $total > 0;
}