def number_of_occurrences(element, sample):
    count = 0
    for i in sample:
        if i == element:
            count += 1
    return count