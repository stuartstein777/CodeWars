def bonus_time(salary, bonus)
    if(bonus)
      salary *= 10
    end
    return "$#{salary}"
end