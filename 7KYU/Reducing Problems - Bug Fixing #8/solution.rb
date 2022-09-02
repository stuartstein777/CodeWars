def calculate_total(t1, t2)
    t1score = t1.empty? ? 0 : t1.reduce(:+) 
    t2score = t2.empty? ? 0 : t2.reduce(:+)
    
    t1score > t2score
end