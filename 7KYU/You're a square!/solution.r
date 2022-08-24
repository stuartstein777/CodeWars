is_square <- function(n){
  if(n < 0) FALSE else sqrt(n) %% 1 == 0
}