// t = O(N) / s = O(N)
function solution(nums: Array<number>, k: number): boolean {
  const set = new Set();
  for (let num of nums) {
    const target = k - num;
    if (set.has(target)) return true;
    set.add(num);
  }
  return false;
}

// t = O(Nlog(N)) / s = O(1)
function solutionAlternative(nums: Array<number>, k: number): boolean {
  nums.sort((x, y) => x - y);
  let left = 0,
    right = nums.length - 1;
  while (left < right) {
    const sum = nums[left] + nums[right];
    if (sum == k) return true;
    if (sum < k) ++left;
    else --right;
  }
  return false;
}

console.log(solutionAlternative([1, 2, 3, 4, 5], 7));
console.log(solutionAlternative([10, 15, 3, 7], 17));
console.log(solutionAlternative([10, 15, 3, 7], 30));
