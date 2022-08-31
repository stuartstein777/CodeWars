function skiJump(mountain){
    var speed = mountain.length * 1.5;
    var distance = (mountain.length * speed * 9) / 10;
    
    if(distance > 50)
      return `${distance.toFixed(2)} metres: Gold!!`;
    else if(distance > 25 && distance <= 50)
      return `${distance.toFixed(2)} metres: He's flying!`;
    else if(distance > 10 && distance <= 25)
      return `${distance.toFixed(2)} metres: He's ok!`;
    else
      return `${distance.toFixed(2)} metres: He's crap!`;
}