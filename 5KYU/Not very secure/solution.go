package kata

import "regexp"

func alphanumeric(str string) bool {
  if len(str) == 0 {
    return false
  }
  
  pattern := "[^a-zA-Z0-9]"
	matched, _ := regexp.MatchString(pattern, str)
  
  return !matched
}