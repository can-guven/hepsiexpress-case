using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada_Case_Study
{
    public class Node
    {
        public Direction data;
        public Node next;
        public Node prev;
        public Direction getValue()
        {
            return data;
        }

        public Node getNext()
        {
            return next;
        }
        public Node getPrev()
        {
            return prev;
        }
    }
}
