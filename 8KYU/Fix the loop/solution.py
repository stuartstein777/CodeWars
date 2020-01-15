def list_animals(animals):
    list = ""
    for i in range(0, len(animals)):
        print(i)
        print(animals[i])
        list += str(i + 1) + ". " + animals[i] + "\n"
    return list