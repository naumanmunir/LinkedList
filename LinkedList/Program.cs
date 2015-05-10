using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {

        static void Main(string[] args)
        {
            LinkedList linkedlist;
        }


    }

    public class LinkedList
    {
        Node node;


        public void Add()
        {

        }
    }

    public class Node
    {
        public Node next;
        public Object data;

        private Node root = null;

        //get root node
        public Node First { get { return root; } }

        //get last node
        public Node Last
        {
            get
            {
                Node current = root;
                if (current == null)
                    return null;
                while (current.next != null)
                    current = current.next;
                return current;
            }
        }

        public void Add(object value)
        {
            Node node = new Node { data = value };

            if (root == null)
                root = node;
            else
                Last.next = node;

        }

        public void Delete(Node n)
        {
            if(root == null)
            {
                root = n.next;
                n.next = null;
            }
            else
            {
                Node current = null;

                while(current.next != null)
                {

                }
            }
        }
    }
}
