def score(x)
  x.chars.map {|x| x.codepoints[0]-64 }.reduce {|acc,i| acc+=i}
end

def battle(x, y)
  x_score = score(x)
  y_score = score(y)
  
  if x_score > y_score
    x
  elsif x_score < y_score
    y
  else
    "Tie!"
  end
end