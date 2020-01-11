import math
def square_area_to_circle(size):
    radius = math.sqrt(size) / 2
    return round((math.pi * (radius * radius)), 8)