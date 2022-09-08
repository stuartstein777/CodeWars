def solution(n)
    (1..(n-1)).select{|x| x % 3 == 0 || x % 5 == 0}.sum
end