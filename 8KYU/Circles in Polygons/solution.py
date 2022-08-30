import math

def circle_diameter(sides, side_length): 
    return 2 * side_length / (math.tan(math.radians(180.0 / sides)) * 2.0)