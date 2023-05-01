module solution;

export int findUniq(const int[] nums) 
{
    if(nums[0] == nums[1] && nums[2] != nums[0]) {
      return nums[2];
  } else if(nums[0] != nums[1] && nums[0] != nums[2]) {
      return nums[0];
  } else if(nums[0] != nums[1] && nums[0] == nums[2]) {
      return nums[1];
  }
  
  for(size_t i = 3; i < nums.length; i++) {
    if(nums[i] != nums[0]) {
      return nums[i];
    }
  }
  return 0;
}
