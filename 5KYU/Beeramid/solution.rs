fn next_level_cost(price: f32, level: usize) -> f32 {
    return (level * level) as f32 * price;
}

fn beeramid (bonus: i32, price: f32) -> usize {
    let mut total_cost:f32 = 0.0;
    let mut level:usize = 0;
    
    while total_cost <= bonus as f32 {
        level = level + 1;
        total_cost += next_level_cost(price, level);
    }
    if level == 0{
        return level;
    }
    return (level-1) as usize;    
}