using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    /// <summary>
    /// Linked list of integers
    /// </summary>
    class LinkedList : IEnumerable<int>
    {
        /// <summary>
        /// First node of the list
        /// </summary>
        public Node First { get; set; }
        /// <summary>
        /// Last node of the List
        /// </summary>
        public Node Last { get; set; }
        /// <summary>
        /// Number of nodes in the list
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Create empty linked list
        /// </summary>
        public LinkedList()
        {
            this.Count = 0;
        }
        /// <summary>
        /// Create linked list from collection
        /// </summary>
        /// <param name="collection">Collection of integers 
        /// to add to the list</param>
        public LinkedList(IEnumerable<int> collection)
            :this()
        {
            foreach (var item in collection)
            {
                this.AddLast(item);
            }
        }
        /// <summary>
        /// Adds new node to the end of the list
        /// </summary>
        /// <param name="value">value to add</param>
        /// <returns></returns>
        public void AddLast(int value)
        {
            var newElement = new Node(value);

            if (Last == null)
            {
                First = newElement;
                Last = newElement;
            }
            else
            {
                Last.Next = newElement;
                Last = newElement;
            }

            Count++;
        }

        /// <summary>
        /// Adds new element to the beginning of the list
        /// </summary>
        /// <param name="value"></param>
        public void AddFirst(int value) 
        {
            var newElement = new Node(value);

            if (First == null)
            {
                First = newElement;
                Last = newElement;
            }
            else
            {
                newElement.Next = First;
                First = newElement;
            }

            Count++;
        }

        /// <summary>
        /// Adds new node after given
        /// </summary>
        /// <param name="node">Node to insert after</param>
        /// <param name="value">value to insert</param>
        public void AddAfter(Node node, int value)
        {
            if (node == null)
            {
                throw new ArgumentNullException("Node can not be null");
            }

            var newElement = new Node(value);
            newElement.Next = node.Next;
            node.Next = newElement;

            Count++;
        }

        /// <summary>
        /// Adds element before given node
        /// </summary>
        /// <param name="node">node to inset before</param>
        /// <param name="value">value to insert</param>
        public void AddBefore(Node node, int value)
        {
            if (node == null)
            {
                throw new ArgumentNullException("Node can not be null");
            }

            var newElement = new Node(value);
            if (node == First)
            {
                newElement.Next = First;
                First = newElement;
            }
            else
            {
                var current = First;

                while (current != null)
                {
                    if (current.Next == node)
                    {
                        newElement.Next = node;
                        current.Next = newElement;
                        break;
                    }

                    current = current.Next;
                }
            }
            var currentElement = First;
            Count++;
        }

        /// <summary>
        /// Gets Enumerator for linked list
        /// </summary>
        public IEnumerator<int> GetEnumerator()
        {
            Node current = First;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        /// <summary>
        /// Gets Enumerator for linked list
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        public bool Contains(int value)
        {
            bool result = false;
            var current = First;

            while (current != null)
            {
                if (current.Value == value)
                {
                    result = true;
                    break;
                }

                current = current.Next;
            }

            return result;
        }

        /// <summary>
        /// Find first node
        /// </summary>
        /// <param name="value">value to search for</param>
        /// <returns></returns>
        public Node Find(int value)
        {
            Node result = null;
            var current = First;

            while (current != null)
            {
                if (current.Value == value)
                {
                    result = current;
                    break;
                }
                current = current.Next;
            }

            return result;
        }

        
        /// <summary>
        /// Removes giden node
        /// </summary>
        /// <param name="node">node to remove</param>
        public void Remove(Node node)
        {
            if (node == null)
            {
                throw new ArgumentException("Node can not be null");
            }

            if (First == node)
            {
                First = First.Next;
            }
            else
            {
                var current = First;

                while (current != null)
                {
                    if ((current.Next == node))
                    {
                        current.Next = node.Next;
                        break;
                    }

                    current = current.Next;
                }
            }
            
            Count--;
        }

        public void Remove(int value)
        {
            var node = Find(value);

            if (node != null)
            {
                Remove(node);
            }
        }

        public void RemoveFirst()
        {
            if (First != null)
            {
                if (First == Last)
                {
                    Last = null;
                }

                First = First.Next;
                Count--;
            }

        }

        public void RemoveLast()
        {
            if (Last != null)
            {
                if (Last == First)
                {
                    Last = First = null;
                }

                var current = First;
                while (current != null)
                {
                    if (current.Next == Last)
                    {
                        current.Next = null;
                        Last = current;
                    }

                    current = current.Next;
                }

                Count--;
            }
        }

        public void RemoveAll(int value)
        {
            /*
            var current = First;
            if (First?.Value == value) //Operator ?. ako First e null целия резултат ще е null и този if няма да се случи. Spestqwa prowerkata
            {
              //сложно ще е така, трябва да се търси докъде имат еднакви стойности (фор цилъл)  
            }
            */

            var current = Find(value);

            while (current != null)
            {
                Remove(current);
                current = Find(value);
            }
        }
    }
}