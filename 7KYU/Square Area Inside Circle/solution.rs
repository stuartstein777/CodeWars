fn square_area_to_circle(size:f64) -> f64 {
    let radius = size.sqrt() / 2.0;
    return (radius * radius) * std::f64::consts::PI;
}