def getTotal(costs, items, tax):
    total = 0
    for i in items:
        total = total + (costs.get(i, 0) + costs.get(i, 0) * tax)
    return round(total, 2)