def well(ideas):
    good_ideas = len([idea for idea in ideas if idea == 'good'])
    if good_ideas > 2:
        return 'I smell a series!'
    elif good_ideas >= 1:
        return 'Publish!'
    return 'Fail!'