import math

def time_to_catch(n):
    hours = math.floor(n / 3600)
    minutes = math.floor((n - (hours * 3600)) / 60)
    seconds = n - (hours * 3600) - (minutes * 60)
    return [hours, minutes, seconds]
    
def race(v1, v2, g):
    if v1 > v2:
        return None
    else:
        v1speed = v1 / 3600 #speed is in ft / sec
        v2speed = v2 / 3600
        speed_difference = v2speed - v1speed
        return time_to_catch(math.floor(g / speed_difference))