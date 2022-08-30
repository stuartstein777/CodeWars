def bmi(weight, height)
    bmi = (weight / (height * height))
    case bmi
      when 0..18.5
        "Underweight"
      when 18.5..25
        "Normal"
      when 25..30
        "Overweight"
      else
        "Obese"
      end
end