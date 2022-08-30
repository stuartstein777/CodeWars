def shark(pontoonDistance, sharkDistance, youSpeed, sharkSpeed, dolphin):
    if dolphin:
        sharkSpeed /= 2
    return "Alive!" if pontoonDistance/youSpeed < sharkDistance/sharkSpeed else "Shark Bait!"