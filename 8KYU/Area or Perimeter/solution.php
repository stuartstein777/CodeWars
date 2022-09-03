function areaOrPerimeter (int $l, int $w){
  if($l == $w){
    return $l * $w;
  }
  return $l*2 + $w*2;
}