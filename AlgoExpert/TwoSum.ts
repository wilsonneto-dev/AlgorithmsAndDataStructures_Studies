// https://www.algoexpert.io/questions/two-number-sum

// first approach => O(N) better! / O(N) => 18 minutes

export function twoNumberSum(array: number[], targetSum: number) {
  let missingValues: { [key: number]: boolean} = {};
  for(let num in array)
  {
    const missingValue = targetSum - array[num];
    if(missingValues[missingValue] === true)
      return [array[num], missingValue];
    missingValues[array[num]] = true;
  }
  return [];
}

// second approach after watching the solution -> time O(N log N) / space O(1) better!
export function twoNumberSum(array: number[], targetSum: number) {
    array.sort((x, y) => x - y);
    let left = 0, right = array.length - 1;
    while(left < right)
    {
      const sum = array[left] + array[right];
      if(sum == targetSum) return [array[left] , array[right]];
      if(sum < targetSum) left++;
      else right--;
    }
  return [];
}
