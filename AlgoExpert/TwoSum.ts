// first approach => O(N) / O(1) => 18 minutes

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
