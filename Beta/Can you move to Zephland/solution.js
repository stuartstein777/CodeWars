function immigration(a) {
  console.log(a);
  var score = 0;
  score += a.Zephlish * (3 / 100);
  score += a.Math * (3 / 100);
  if(a.crime)
    score -= 3;
  
  if(Number(a.investment.substr(0, a.investment.length-3)) >= 1000000)
    score += 2;
  
  if(a.programmer)
    score +=2;
    
  if(score > 6)
    return "Welcome to Zephland!";
  else
    return "Sorry, your application is rejected.";
}