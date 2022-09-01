def square_color(file, rank):
    if file == "a" or file == "c" or file == "e" or file == "g":
        if(rank % 2 == 0):
            return "white"
        else:
            return "black"
    else:
        if(rank % 2 == 0):
            return "black"
        else:
            return "white"