function mineColor(file, rank) {
    if(file == "a" || file == "c" || file == "e" || file == "g"){
      return (rank % 2 == 0) ? 'white' : 'black';
    } else {
      return (rank % 2 == 0) ? 'black' : 'white';
    }  
}