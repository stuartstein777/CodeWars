function catMouse(m, j){
  let cat = m.indexOf('C');
  let mouse = m.indexOf('m');
  let dog = m.indexOf('D');
  
  if(cat === -1 || mouse === -1 || dog === -1)
    return "boring without all three";
  if(Math.abs(cat - mouse) > j)
   return "Escaped!";
  else if((dog > cat) && (dog < mouse) ||
          (dog > mouse) && (dog < cat))
    return "Protected!";
  else
    return "Caught!";
}