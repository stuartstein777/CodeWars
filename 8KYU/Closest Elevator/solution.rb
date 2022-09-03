def elevator(left, right, call)
    left_dist = (call - left).abs
    right_dist = (call - right).abs
    
    if left_dist == right_dist
        return "right"
    end
    if left_dist < right_dist
        return "left"
    end
    return "right"
end