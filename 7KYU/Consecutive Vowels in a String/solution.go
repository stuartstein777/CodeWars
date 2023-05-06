package kata


func GetTheVowels(word string) int {
  nextVowel := map[rune]rune{
    'a': 'e',
    'e': 'i',
    'i': 'o',
    'o': 'u',
    'u': 'a'}
  
  consecutive := 0
  var currentVowel = rune(0)
  
  for _, c := range word {
    _, isVowel := nextVowel[c]
    
    if isVowel {
      nextVowel, _ := nextVowel[currentVowel]
      if (currentVowel == 0 && c == 'a') || c == nextVowel {
        consecutive += 1
        currentVowel = c
      }
    }
  }
  
  return consecutive
}