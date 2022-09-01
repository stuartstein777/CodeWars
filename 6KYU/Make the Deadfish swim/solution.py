def parse(data):
    v = 0
    output = []
    
    for i in data:
        if i == 'i':
            v+=1
        elif i == 'd':
            v-=1
        elif i == 's':
            v *= v
        elif i == 'o':
            output.append(v)
    return output