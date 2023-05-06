package kata

import (
  "strings"
  "regexp"
)

func DirReduc(arr []string) []string {
    directions := strings.Join(arr, "")
    for {
      beforeReplace := directions
      directions = strings.Replace(directions, "NORTHSOUTH", "", -1)
      directions = strings.Replace(directions, "SOUTHNORTH", "", -1)
      directions = strings.Replace(directions, "EASTWEST", "", -1)
      directions = strings.Replace(directions, "WESTEAST", "", -1)
      
      if beforeReplace == directions {
        if directions == "" {
          return []string{}
        }
        re := regexp.MustCompile("(NORTH|SOUTH|EAST|WEST)")
	      return re.FindAllString(directions, -1)        
      }
    }
  return []string{}
}