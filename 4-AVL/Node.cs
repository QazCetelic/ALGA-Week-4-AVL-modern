using System;

namespace ALGA
{
    public class Node
    {
        public int number;

        public Node? left, right;

        public Node(int number)
        {
            this.number = number;
        }

        public Node rotateLeft()
        {
            throw new NotImplementedException();
        }

        public Node rotateRight()
        {
            throw new NotImplementedException();
        }

        public void prettyprint(String firstPrefix, String prefix)
        {
            Console.WriteLine(firstPrefix + number);

            if (right == null)
            {
                Console.WriteLine(prefix + "├── .");
            }
            else
            {
                right.prettyprint(prefix + "├── ", prefix + "|   ");
            }

            if (left == null)
            {
                Console.WriteLine(prefix + "└── .");
            }
            else
            {
                left.prettyprint(prefix + "└── ", prefix + "    ");
            }
        }
    }
}
