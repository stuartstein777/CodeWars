func sumOfTwoSmallestIntegersIn(_ array: [Int]) -> Int {
  return array.sorted()[0..<2].reduce(0, +)
}