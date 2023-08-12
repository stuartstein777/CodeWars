require(stringi)

solution <- function(a, b) {
    if (stri_length(a) < stri_length(b)) {
      paste(a, b, a, sep="")
    } else {
      paste(b, a, b, sep="")
    }
}