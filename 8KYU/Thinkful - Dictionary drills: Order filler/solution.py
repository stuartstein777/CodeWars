def fillable(stock, merch, n):
    if merch in stock and stock[merch] >= n:
        return True
    return False
    