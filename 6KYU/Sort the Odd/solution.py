def sort_array(xs):
    odds = sorted([i for i in xs if i % 2 != 0])
    odd_counter = 0
    res = []
    index = 0
    for i in xs:
        if i % 2 != 0:
            res.append(odds[odd_counter])
            odd_counter+=1
        else:
            res.append(i)
        index+=1
    return res