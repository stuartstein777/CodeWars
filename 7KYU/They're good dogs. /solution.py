def we_rate_dogs(review, rating):
    splits = review.split("/")
    return splits[0][:-1] + str(rating) + "/" + splits[1]