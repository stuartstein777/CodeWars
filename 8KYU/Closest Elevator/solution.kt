fun elevator(left: Int, right: Int, call: Int): String {
   var leftDist = Math.abs(call - left)
   var rightDist = Math.abs(call - right)
   if(leftDist < rightDist)
      return "left"
   return "right"
}