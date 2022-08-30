def points(games):
    parsed_scores =  [[int(game.split(':')[0]), int(game.split(':')[1])] for game in games]
    res = 0
    for score in parsed_scores:
        if score[0] == score[1]:
            res+= 1
        elif score[0] > score[1]:
            res+=3
    return res