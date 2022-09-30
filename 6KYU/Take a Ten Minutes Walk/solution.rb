def is_valid_walk(walk)
    walk.length() == 10 and walk.count('n') == walk.count('s') and walk.count('e') == walk.count('w')
end