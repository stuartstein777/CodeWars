def factorial(n)
    n == 0 ? 1 : (1..n).inject(:*)
end