using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDLinkedList
{
    public class UDLinkedList
    {
        private Node head;

        public void printAllNodes() {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddToLast(object data) {
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.next = null;
            if (head == null)
            {
                head = new Node();
                head = toAdd;
            }
            else {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }

        public Node FindMiddleNode() {
            Node middleNode = head;
            Node nextNode = head;
            Node nextToNext = head;
            while (nextToNext != null && nextToNext.next != null)
            {
                nextToNext = nextToNext.next.next;
                nextNode = nextNode.next;
            }
            middleNode = nextNode;
            Console.WriteLine(middleNode.data);
            return middleNode;
        }
    }
}
