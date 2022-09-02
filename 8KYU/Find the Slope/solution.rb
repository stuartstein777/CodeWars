def find_slope(points)
    delta_x = points[3] - points[1]
    delta_y = points[2] - points[0]
    if delta_y == 0
      return 'undefined'
    end
    return (delta_x / delta_y).floor.to_s
end