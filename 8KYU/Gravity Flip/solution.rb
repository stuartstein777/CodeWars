def flip(dir, boxes)
    boxes.sort_by { |x| dir=='L' ? -x : x }
  end