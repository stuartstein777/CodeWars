import math
def duty_free(price, discount, holiday_cost):
    return math.floor(holiday_cost / (price * (discount / 100)))