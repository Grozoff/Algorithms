namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/leaf-similar-trees">Leaf-Similar Trees</see>
    /// <br>Tree, Depth-First Search, Binary Tree</br>
    /// </summary>
    internal class Problem0872
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            return Dfs(root1).SequenceEqual(Dfs(root2));
        }

        private List<int> Dfs(TreeNode root)
        {
            var lst = new List<int>();
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.left != null)
                    stack.Push(node.left);
                if (node.right != null)
                    stack.Push(node.right);
                if (node.left == null && node.right == null)
                    lst.Add(node.val);
            }
            return lst;
        }
    }
}
