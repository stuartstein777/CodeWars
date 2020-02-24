function duckShoot(ammo, accuracy, ducks){
  var ducksShot = Math.floor(ammo * accuracy);
  var ducksSplit = ducks.split('');
  var result = "";
  for(var i = 0; i < ducksSplit.length; i++){
    if(ducksSplit[i] === '2' && ducksShot > 0){
        result+= 'X';
        ducksShot-=1;
    } else {
        result+= ducksSplit[i];
    }
  }
  return result;
}