function lastSurvivor(letters, coords) {
    for(var i = 0; i < coords.length; i++) {
      var coord = coords[i];
      letters = letters.substring(0, coord) + letters.substring(coord+1);
    }
    return letters;
}