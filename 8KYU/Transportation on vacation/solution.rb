def rental_car_cost(d)
    if d >= 7
      (d * 40) - 50;
    elsif d >= 3
      (d * 40) - 20;
    else
      d * 40
    end
end