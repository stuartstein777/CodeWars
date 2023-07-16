zero_fuel <- function(distance, mpg, fuel_left) {
  fuel_left * mpg >= distance 
}