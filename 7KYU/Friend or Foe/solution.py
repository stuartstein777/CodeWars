def friend(names):
    friends = []
    for name in names:
        if len(name) == 4:
            friends.append(name)
    return friends