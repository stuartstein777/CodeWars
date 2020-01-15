function Warrior(n){
  this.warriorName = n
}
  
Warrior.prototype.toString = function(){
    return "Hi! my name's " + this.warriorName;
};

Warrior.prototype.name = function(newName){
    if(newName)
      this.warriorName = newName;
    return this.warriorName;
};
