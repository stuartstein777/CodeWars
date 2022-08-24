int combat(int health, int damage){
  health = health - damage;
  return health < 0 ? 0 : health;
}