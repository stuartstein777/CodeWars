# Should return ᐃ type:
#  0 : if ᐃ cannot be made with given sides
#  1 : acute ᐃ
#  2 : right ᐃ
#  3 : obtuse ᐃ

def triangle_type (a, b, c)
    t = 0
    if (a + b <= c) || (a + c <= b) || (b+c <= a)
      return 0
    end
    
    if a > b
      t = a
      a = b
      b = t
    end
    if a > c
      t = a
      a = c
      c = t
    end
    if c < b
      t = c
      c = b
      b = t
    end
    
    aa = a*a
    bb = b*b
    cc = c*c
    
    if aa + bb > cc
      return 1
    elsif aa + bb == cc
      return 2
    end
    return 3
end