function number($bus_stops) {
  $bus = 0;
  
  for($i = 0; $i < count($bus_stops); $i++) {
    $bus = $bus + $bus_stops[$i][0] - $bus_stops[$i][1];
  }
  
  return $bus;
}