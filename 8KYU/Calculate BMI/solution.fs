let bmi weight height =
  let bmi = weight / (height * height)
  if bmi <= 18.0 then "Underweight"
  else if bmi <= 25.0 then "Normal"
  else if bmi <= 30.0 then "Overweight"
  else "Obese"