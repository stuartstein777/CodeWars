def stack_height_2d(layers)
    if layers == 0
      0
    else
      Math.sqrt(((layers - 1.0) ** 2) - (((layers - 1.0) / 2.0) ** 2))+1
    end
  end 