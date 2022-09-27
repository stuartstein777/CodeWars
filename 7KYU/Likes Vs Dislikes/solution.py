# Like, Dislike, Nothing come from Preloaded
def like_or_dislike(lst):
    cur = Nothing
    
    for i in lst:
        if i == cur:
            cur = Nothing
        else:
            cur = i
    
    return cur
