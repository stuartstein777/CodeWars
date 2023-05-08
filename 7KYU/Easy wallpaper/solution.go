package kata

import "math"

func WallPaper(l, w, h float64) string {
  translations := map[int]string {
    1: "one",
    2: "two",
    3: "three",
    4: "four",
    5: "five",
    6: "six",
    7: "seven",
    8: "eight",
    9: "nine",
    10: "ten",
    11: "eleven",
    12: "twelve",
    13: "thirteen",
    14: "fourteen",
    15: "fifteen",
    16: "sixteen",
    17: "seventeen",
    18: "eighteen",
    19: "nineteen",
    20: "twenty"}
  
  if l == 0 || w == 0 || h == 0 {
      return "zero"
    }
  
   totalArea := (((2 * (100 * w * h)) +(2 * (100 * l * h))) * 100) / 52000
   rolls := int(math.Ceil(totalArea * 1.15))
   return translations[rolls] 
}
