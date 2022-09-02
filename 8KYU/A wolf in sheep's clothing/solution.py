def warn_the_sheep(queue):
    index = queue[::-1].index('wolf')
    if index == 0:
        return "Pls go away and stop eating my sheep" 
    return "Oi! Sheep number " + str(index) + "! You are about to be eaten by a wolf!"