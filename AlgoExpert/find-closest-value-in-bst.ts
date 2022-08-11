// https://www.algoexpert.io/questions/find-closest-value-in-bst

// 22/08/11 -> t = O(n) / s = O(1) -> 40 minutes
export function findClosestValueInBst(tree: BST, target: number, closest: number | null = null): number|null  {
  if(tree.value == target) return tree.value;
  
  if(closest == null || Math.abs(target - tree.value) < Math.abs(target - closest))
    closest = tree.value;

  const next = (target < tree.value) ? tree.left : tree.right;
  if(next == null) return closest;
  return findClosestValueInBst(next, target, closest);
}
