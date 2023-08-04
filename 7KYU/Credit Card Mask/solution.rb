def maskify(cc) 
  if cc.length > 4
    "#" * (cc.length-4) + cc[-4..-1]
  else
    cc
  end
end