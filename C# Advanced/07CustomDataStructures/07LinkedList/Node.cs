using System;

namespace LinkedList
{
    /// <summary>
    /// Note in Linked List
    /// </summary>
    class Node
    {
        /// <summary>
        /// Create new node
        /// </summary>
        /// <param name="value">Node value</param>
        public Node(int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// value of current node
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Pointer to next element
        /// </summary>
        public Node Next { get; set; }
    }
}