def combat(health, damage)
    health = health - damage
    if health < 0 then 0 else health end
  end