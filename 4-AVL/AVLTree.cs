using System;

namespace ALGA
{
    public class AVLTree
    {
        public Node? root;

        public void insert(int number)
        {
            throw new NotImplementedException();
        }

        public bool isBalanced()
        {
            throw new NotImplementedException();
        }

        public void prettyprint()
        {
            if (root != null)
            {
                root.prettyprint("→", " ");
            }
        }
    }
}
