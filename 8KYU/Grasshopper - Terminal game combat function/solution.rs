fn combat(health: f32, damage: f32) -> f32 {
    let newHealth = health - damage;
    
    if newHealth < 0.0 {
        return 0.0;
    }
    return newHealth;
}