function convertToKg(mass, initialUnit){
  if(initialUnit === "g")
    return mass / 1e3;
  else if(initialUnit === "kg")
    return mass;
  else if(initialUnit === "mg")
    return mass / 1e6;
  else if(initialUnit === "μg")
    return mass / 1e9;
  else if(initialUnit === "lb")
    return mass *  0.453592;
}

function convertToMetres(distance, initialUnit){
  if(initialUnit === "m")
    return distance;
  else if(initialUnit === "cm")
    return distance / 100;
  else if(initialUnit === "mm")
    return distance / 1e3;
  else if(initialUnit === "μm")
    return distance / 1e6;
  else if(initialUnit === "ft")
    return distance * 0.3048;
}

function solution(values, units) {
  let m1 = convertToKg(values[0], units[0]);
  let m2 = convertToKg(values[1], units[1]);
  let d = convertToMetres(values[2], units[2]);
  let g = 6.67e-11;
  
  return ((m1 * m2) * g) / (d*d);
};
