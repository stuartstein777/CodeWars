function elevator(left, right, call){
  let leftDistance = Math.abs(call - left);
  let rightDistance = Math.abs(call - right);
  
  if(leftDistance === rightDistance) {
    return 'right';
  }
  else if(leftDistance < rightDistance) {
    return 'left';
  } else {
    return 'right';
  }
}