function weatherInfo (fahrenheit) {
  var c = convertToCelsius(fahrenheit)
  if (c <= 0)
    return (c + " is freezing temperature")
  else
    return (c + " is above freezing temperature")
}

function convertToCelsius(fahrenheit) {
  var celsius = (fahrenheit - 32) * (5/9.0)
  return celsius
}