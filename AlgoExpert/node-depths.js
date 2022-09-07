// 22.09.06 - DFS apporach

function nodeDepths(root = null, depth = 0) {
  if(root == null) return 0;  
  return depth + nodeDepths(root.left, depth + 1) + nodeDepths(root.right, depth + 1);
}

// This is the class of the input binary tree.
class BinaryTree {
  constructor(value) {
    this.value = value;
    this.left = null;
    this.right = null;
  }
}

// Do not edit the line below.
exports.nodeDepths = nodeDepths;

// ----

// in a bfs approach:

function nodeDepths(root = null) {
  if(root == null)
    return 0;
  const queue = [];
  let sum = 0;
  queue.push([root, 0]);
  
  while(queue.length > 0)
  {
    const [node, level] = queue.shift();
    sum += level;
    if(node.left !== null) queue.push([node.left, level+1]);
    if(node.right !== null) queue.push([node.right, level+1]);
  }

  return sum;
}

// This is the class of the input binary tree.
class BinaryTree {
  constructor(value) {
    this.value = value;
    this.left = null;
    this.right = null;
  }
}

// Do not edit the line below.
exports.nodeDepths = nodeDepths;
