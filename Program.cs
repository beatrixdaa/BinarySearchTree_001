using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_001
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class

        public Node( string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /*A node class consists os three things, the information,references to the
     right child,and references to the left child*/

    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /* Initializing ROOT to null*/
        }
        public void insert(string element) /*Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if (currentNode != null) /* Check if the node to be inserted already inserted or not */
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else /* If the specified node is not perfect*/
            {
                tmp = new Node(element, null, null); /* create a Node*/
                if (parent == null) /* If the tree is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
    }

    public void Search(string element,ref Node parent,ref Node currentNode)
    {
        /*This function searches the currentNode of the specified Node as 
         well as the currentNode of its parent*/
        currentNode = ROOT;
        P
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
