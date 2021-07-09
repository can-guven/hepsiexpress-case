using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada_Case_Study
{
    public class CompassLinkedList
    {
        public Node head;
        public Node tail;
        int size;
        public CompassLinkedList()
        {
            head = null;
            buildLinkedList();
        }

        private void buildLinkedList()
        {
            insert(new North());
            insert(new West());
            insert(new South());
            insert(new East());
        }
        public void insert(Direction direction)
        {
            if (head == null)
            {
                Node node = new Node();
                node.data = direction;
                node.next = node.prev = node;
                head = node;
                size++;
                return;
            }

            Node last = (head).prev;    

            Node new_node = new Node();
            new_node.data = direction;
  
            new_node.next = head;

            (head).prev = new_node;

            new_node.prev = last;

            last.next = new_node;
            size++;
        }
        public Direction getDirection(Direction direction,Turn turn)
        {
            if (head == null)
            {
                return null;
            }
            else
            {
                Node tempNode = head;
                for (int i = 0; i < size; i++)
                {
                    if (tempNode.getValue().GetType()==direction.GetType())
                    {
                        if (turn == Turn.LEFT)
                            return tempNode.getNext().getValue();
                        else
                            return  tempNode.getPrev().getValue();
                    }
                    tempNode = tempNode.getNext();
                }
            }
            return null;
        }
    }
}
