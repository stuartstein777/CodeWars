def two_oldest_ages(ages):
    ages.sort(reverse=True)
    oldest = ages[0:2]
    oldest.sort()
    return oldest