fn slice_plus_slice(xs: &[i32], ys: &[i32]) -> i32 {
    let sumxs: i32 = xs.iter().sum();
    let sumys: i32 = ys.iter().sum();
    return sumxs + sumys;
}