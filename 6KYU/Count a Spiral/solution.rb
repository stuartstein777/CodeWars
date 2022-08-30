def spiral_sum(size)
    n = size - 1
    if n % 2 == 0
        n / 2 * (n / 2 + 1) * 2 + 1 + n
    else
        (n + 1) / 2 * (n + 1) + n
    end
end