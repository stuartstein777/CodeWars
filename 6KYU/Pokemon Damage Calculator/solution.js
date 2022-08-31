function calculateDamage(yourType, opponentType, attack, defense){
    console.log(yourType + " | " + opponentType);
    console.log(attack + " | " + defense);
    var damage = 50 * (attack / defense);
    if(yourType === "fire" && opponentType === "grass")
      damage *= 2.0;
    if(yourType === "fire" && opponentType === "water")
      damage *= 0.5;
    if(yourType === "water" && opponentType === "grass")
      damage *= 0.5;
    if(yourType === "water" && opponentType === "electric")
      damage *= 0.5;
    if(yourType === "grass" && opponentType === "fire")
      damage *= 0.5;
    if(yourType === "water" && opponentType === "fire")
      damage *= 2.0;
    if(yourType === "grass" && opponentType === "water")
      damage *= 2.0;
    if(yourType === "electric" && opponentType === "water")
      damage *= 2.0;
    if(yourType === opponentType)
      damage *= 0.5;
    return damage;  
  }