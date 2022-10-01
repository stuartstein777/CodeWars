fn usdcny(usd: u16) -> String {
    let cny = usd as f64 * 6.75;
    return format!("{:.2} Chinese Yuan", cny);
}