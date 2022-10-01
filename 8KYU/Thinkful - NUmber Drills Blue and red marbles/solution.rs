fn guess_blue(blue_start: u32, red_start: u32, blue_pulled: u32, red_pulled: u32) -> f32 {
    let total: u32 = blue_start + red_start;
    let blue_rem: f32 = (blue_start - blue_pulled) as f32;
    return blue_rem / (total - (blue_pulled + red_pulled)) as f32;
}