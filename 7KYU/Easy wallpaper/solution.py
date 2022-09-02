import math


def wallpaper(l, w, h):
    toEnglish = dict([(0, 'zero'),
        (1, 'one'),
        (2, 'two'),
        (3, 'three'),
        (4, 'four'),
        (5, 'five'),
        (6, 'six'),
        (7, 'seven'),
        (8, 'eight'),
        (9, 'nine'),
        (10, 'ten'),
        (11, 'eleven'),
        (12, 'twelve'),
        (13, 'thirteen'),
        (14, 'fourteen'),
        (15, 'fifteen'),
        (16, 'sixteen'),
        (17, 'seventeen'),
        (18, 'eighteen'),
        (19, 'nineteen'),
        (20, 'twenty')])
    
    if l == 0 or w == 0 or h == 0:
        return 'zero'
    else:
        #totalArea as cm
        totalArea = (((2 * (100 * w * h)) +(2 * (100 * l * h))) * 100) / 52000
        rolls = math.ceil(totalArea * 1.15)
        return toEnglish[rolls]
    
    
    
    
    