// https://www.algoexpert.io/questions/validate-subsequence

// 22/08/09 -> time O(n) / space O(1) -> 5 minutes

export function isValidSubsequence(array: number[], sequence: number[]) {
  let sequencePointer = 0;
  for(let idx = 0; idx < array.length; idx++)
    if(sequence[sequencePointer] == array[idx])
      if(++sequencePointer == sequence.length)
        return true;

  return false;
}
