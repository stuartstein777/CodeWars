function sc(floor){
  if(floor < 2)
    return "";
  var screams = "Aa~ ".repeat(floor-1) + "Pa!";
  if(floor <= 6)
    screams += " Aa!"
  return screams;
}