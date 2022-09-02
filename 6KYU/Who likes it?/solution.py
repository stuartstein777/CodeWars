def likes(names):
    number_of_names = len(names)
    if number_of_names == 0:
        return 'no one likes this'
    elif number_of_names == 1:
        return names[0] + ' likes this'
    elif number_of_names == 2:
        return names[0] + ' and ' + names[1] + ' like this'
    elif number_of_names == 3:
        return names[0] + ', ' + names[1] + ' and ' + names[2] + ' like this'
    return names[0] + ', ' + names[1] + ' and ' + str(len(names)-2) + ' others like this'
    