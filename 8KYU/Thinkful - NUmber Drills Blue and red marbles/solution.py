def guess_blue(blue_start, red_start, blue_pulled, red_pulled):
    total = blue_start + red_start;
    blue_remaining = blue_start - blue_pulled;
    return blue_remaining / (total - (blue_pulled + red_pulled));
