function changeMe(moneyIn){
    var toChange = 0;
    if (moneyIn === "£5")
      return "20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p 20p";
    else if(moneyIn === "£2")
      return "20p 20p 20p 20p 20p 20p 20p 20p 20p 20p";
    else if(moneyIn === "£1")
      return "20p 20p 20p 20p 20p";
    else if(moneyIn === "50p")
      return "20p 20p 10p";
    else if(moneyIn === "20p")
      return "10p 10p";
    else
      return moneyIn;        
} 