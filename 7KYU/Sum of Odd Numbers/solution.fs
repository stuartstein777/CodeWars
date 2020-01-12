let rowSumOddNumbers n = 
    let last = (n * n) + (n - 1)
    let start = last - (2 * (n - 1))
    ((start + last) / 2) * n