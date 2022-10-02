def pair_of_shoes(shoes):
   leftRight = 0
   Size = 0
    
   for shoe in shoes:
       if shoe[0] == 0:
           leftRight = leftRight + 1
           Size = Size + shoe[1]
       else:
           leftRight = leftRight - 1
           Size = Size - shoe[1]
   
   return leftRight == 0 and Size == 0