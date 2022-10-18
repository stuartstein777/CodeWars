fn fit_in(a: u32, b: u32, m: u32, n: u32) -> bool {
    return a+b <= std::cmp::max(m,n) && std::cmp::max(a,b) <= std::cmp::min(m,n);
}
