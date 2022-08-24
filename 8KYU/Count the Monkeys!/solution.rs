use std::convert::TryInto;

fn monkey_count(n: i32) -> Vec<i32> {
    let mut vec = Vec::with_capacity(n.try_into().unwrap());
    for i in 1..n+1{
        vec.push(i);
    }
    return vec;
}