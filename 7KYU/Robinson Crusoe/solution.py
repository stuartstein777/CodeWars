import math
 
def crusoe(n, d, ang, dist_mult, ang_mult, x = 0, y = 0):
    while n != 0:
        n -= 1
        x +=(d * math.cos(math.radians(ang)))
        y +=(d * math.sin(math.radians(ang)))         
        ang *= ang_mult            
        d *= dist_mult
    return (x, y)