fn josephus_survivor(n: i32, k: i32) -> i32 {
    let mut r: i32 = 0;
    let mut i: i32 = 1;
     
    while i != n+1 {
        r = (r + k) % i;
        i+=1;
     }
    return r + 1;
 }