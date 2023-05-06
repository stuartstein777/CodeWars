package kata

func LongestRepetition(text string) Result {
  println(text)
  textLen := len(text)
  if textLen == 0 {
    return Result{}
  }
  
	var longestRune = text[0]
  var currentRune = text[0]
  var longestRep int = 1  
  var currentRep int = 1
  for i:=1; i < textLen; i++ {
      if currentRune == text[i] {
        currentRep += 1
      } else {
        if currentRep > longestRep {
          longestRep = currentRep
          longestRune = text[i-1]
        }
        
        currentRune = text[i]
        currentRep = 1
      }
  }
  
  if currentRep > longestRep {
    longestRune = text[textLen-1]
    longestRep = currentRep
  }
  
  return Result{
    C: rune(longestRune),
    L: longestRep,
  }
}