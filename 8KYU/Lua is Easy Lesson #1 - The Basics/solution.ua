kata = {}
function kata.firstLua(a,b,c)
  result = a.." "..(a*b)
  print(result)
  if b >= c then return result.." Lua"
  else return result.." ".."Codewars"
  end
end

return kata