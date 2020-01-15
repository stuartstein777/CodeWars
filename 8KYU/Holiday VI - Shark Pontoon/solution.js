function shark(pontoonDistance, sharkDistance, youSpeed, sharkSpeed, dolphin){
  var timeToLive = pontoonDistance / youSpeed;
  if(dolphin)
    sharkSpeed /= 2;
  var sharkTimeToLunch = sharkDistance / sharkSpeed;
  return (sharkTimeToLunch < timeToLive)
    ? "Shark Bait!"
    : "Alive!";
}