function billboard(name, price = 30){
  return name.split("").reduce((acc, _) => acc+price, 0);
}