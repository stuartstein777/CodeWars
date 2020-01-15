var findAverage = function (nums) {
  return nums.reduce((arr, i) => arr+=i) / nums.length;
}