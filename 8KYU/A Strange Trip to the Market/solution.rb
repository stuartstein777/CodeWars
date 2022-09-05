def is_lock_ness_monster(s)
    s.downcase.include? "tree fiddy" or
    s.downcase.include? "three fifty" or
    s.include? "3.50"
end