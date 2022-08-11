// https://www.algoexpert.io/questions/find-closest-value-in-bst

// 22/08/11 -> t = O(k) / s = O(k) -> 40 minutes
export function findClosestValueInBst(tree: BST, target: number, closest: number | null = null): number|null  {
  if(tree.value == target) return tree.value;
  
  if(closest == null || Math.abs(target - tree.value) < Math.abs(target - closest))
    closest = tree.value;

  const next = (target < tree.value) ? tree.left : tree.right;
  if(next == null) return closest;
  return findClosestValueInBst(next, target, closest);
}

// t = O(K) / s = O(1)
export function findClosestValueInBst(tree: BST, target: number): number|null  {
  let closest: number | null = null, 
    current: BST | null = tree;
  while(current != null)
  {
    if(current.value == target) return current.value;
    if(closest == null || Math.abs(target - current.value) < Math.abs(target - closest))
      closest = current.value;
    current = (target < current.value) ? current.left : current.right;
  }
  return closest;
}
