package kata

import (
  "math"
  "strconv"
)

func GetV(color string) float64 {
  r := color[1:3]
  g := color[3:5]
  b := color[5:]
  
  rv,_ := strconv.ParseInt(r, 16, 32)
  gv,_ := strconv.ParseInt(g, 16, 32)
  bv,_ := strconv.ParseInt(b, 16, 32)
  
  return math.Max(float64(rv), math.Max(float64(bv), float64(gv)))
}

func Brightest(colors []string) string {
  
  brightestColour := ""
  var brightest float64 = 0
  
  for _,color := range colors {
    brightness := GetV(color)
    if(brightness > brightest) {
      brightest = brightness
      brightestColour = color
    }
  }
  
  return brightestColour
}