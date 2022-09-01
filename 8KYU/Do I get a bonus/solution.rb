def bonus_time(salary, bonus)
    if(bonus)
      salary = salary * 10
    end
    "$#{salary}"
end