function solution(nums: number[]): number[] {
  const decreasingProducts: number[] = [];
  const ascendingProducts: number[] = [];

  for (let i = nums.length - 1; i >= 0; i--) {
    if (i == nums.length - 1) decreasingProducts[i] = nums[i];
    else decreasingProducts[i] = nums[i] * decreasingProducts[i + 1];
  }

  for (let i = 0; i < nums.length; i++) {
    if (i == 0) ascendingProducts[i] = nums[i];
    else ascendingProducts[i] = nums[i] * ascendingProducts[i - 1];
  }

  const response: number[] = [];
  for (let i = 0; i < nums.length; i++) {
    if (i == 0) response[i] = decreasingProducts[i + 1];
    else if (i == nums.length - 1) response[i] = ascendingProducts[i - 1];
    else response[i] = ascendingProducts[i - 1] * decreasingProducts[i + 1];
  }
  return response;
}

console.log(solution([1, 2, 3, 4, 5]), [120, 60, 40, 30, 24]);
console.log(solution([3, 2, 1]), [2, 3, 6]);
