import math
def calculate_tip(amount, rating):
    if rating.lower() == 'excellent':
        return math.ceil(amount * 0.20)
    elif rating.lower() == 'great':
        return math.ceil(amount * 0.15)
    elif rating.lower() == 'good':
        return math.ceil(amount * 0.10)
    elif rating.lower() == 'poor':
        return math.ceil(amount * 0.05)
    elif rating.lower() == 'terrible':
        return 0
    else:
        return "Rating not recognised"