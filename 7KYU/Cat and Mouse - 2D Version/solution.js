function catMouse(map,moves){
  var x = 0;
  var y = 0;
  var cxy = [];
  var mxy = [];
  for(var i = 0; i < map.length; i++){
    if(map[i] === '\n'){
      y++;
      x = 0;
    } else if(map[i] === 'C'){
      cxy[0] = x;
      cxy[1] = y;
    } else if(map[i] === 'm'){
      mxy[0] = x;
      mxy[1] = y;
    } else{
      x++;
    }
  }
  
  if(mxy.length === 0 || cxy.length === 0)
    return "boring without two animals";
    
  var diffx = Math.abs(mxy[0] - cxy[0]);
  var diffy = Math.abs(mxy[1] - cxy[1]);
  if(diffx + diffy <= moves)
    return "Caught!";
  else
    return "Escaped!";  
}

function find(c, map){


}