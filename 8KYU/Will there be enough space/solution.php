function enough($cap, $on, $wait) {
  if($on + $wait <= $cap) {
    return 0;
  }
  return $wait - ($cap - $on);
}