fn heron(a: f64, b: f64, c: f64) -> f64 {
    let s: f64 = (a + b + c) / 2.0;
    return (s * (s - a) * (s - b) * (s-c)).sqrt();
}