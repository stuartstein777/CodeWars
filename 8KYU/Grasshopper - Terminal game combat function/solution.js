function combat(health, damage) {
    var newHealth = health - damage;
    return newHealth < 0 ? 0 : newHealth;
  }