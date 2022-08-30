def printer_error(s):
    return str(len([char for char in s if char in 'nopqrstuvwxyz'])) + "/" + str(len(s))