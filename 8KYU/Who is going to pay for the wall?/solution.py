def who_is_paying(name):
    if len(name) < 3:
        return [name]
    else:
        return [name, name[0:2]]