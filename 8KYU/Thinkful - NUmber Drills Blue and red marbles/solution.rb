def guess_blue(blue_start, red_start, blue_pulled, red_pulled)
    total = blue_start + red_start;
    blue_remaining = blue_start - blue_pulled;
    blue_remaining / (total.to_f - (blue_pulled + red_pulled));
end
