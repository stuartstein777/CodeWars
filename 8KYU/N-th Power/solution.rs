fn index(nums: &[u64], n: usize) -> Option<u64> {
    if n >= nums.len() {
        return None;
    }
    return Some(num::pow(nums[n], n));
}