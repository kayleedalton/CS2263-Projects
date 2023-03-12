using System;
//Form to test Dequeues, Stacks, and Queues
//Completed March 12th, 2023
//Kaylee Dalton
namespace HW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   DequeueClass<int> dequeue = new DequeueClass<int>();
Random rand = new Random();

for (int i = 0; i < 4; i++)
{
    int randomNumber = rand.Next(1, 101); // generate random number between 1 and 100
    if (i % 2 == 0)
    {
        dequeue.PushLeft(randomNumber);
        MessageBox.Show($"Pushed {randomNumber} to the left");
    }
    else
    {
        dequeue.PushRight(randomNumber);
        MessageBox.Show($"Pushed {randomNumber} to the right");
    }
}

MessageBox.Show("Number of items in dequeue: " + dequeue.Count()); // expected output: Number of items in dequeue: 4

MessageBox.Show("Item popped from left: " + dequeue.PopLeft().ToString()); // expected output: Item popped from left: [randomly generated number]
MessageBox.Show("Item popped from right: " + dequeue.PopRight().ToString()); // expected output: Item popped from right: [randomly generated number]
MessageBox.Show("Item popped from left: " + dequeue.PopLeft().ToString()); // expected output: Item popped from left: [randomly generated number]
MessageBox.Show("Item popped from right: " + dequeue.PopRight().ToString()); // expected output: Item popped from right: [randomly generated number]

MessageBox.Show("Number of items in dequeue: " + dequeue.Count()); // expected output: Number of items in dequeue: 0


            // StackClass with birds
            StackClass<string> stack = new StackClass<string>();

            stack.Push("robin");
            MessageBox.Show("Push (robin)");
            stack.Push("sparrow");
            MessageBox.Show("Push (sparrow)");
            stack.Push("cardinal");
            MessageBox.Show("Push (cardinal)");
            MessageBox.Show("Number of items in stack: " + stack.Count()); // expected output: Number of items in stack: 3

            MessageBox.Show("Item popped from stack: " + stack.Pop()); // expected output: Item popped from stack: cardinal
            MessageBox.Show("Item popped from stack: " + stack.Pop()); // expected output: Item popped from stack: sparrow

            stack.Push("blue jay");
            MessageBox.Show("Push (blue jay)");

            MessageBox.Show("Number of items in stack: " + stack.Count()); // expected output: Number of items in stack: 2

            MessageBox.Show("Item popped from stack: " + stack.Pop()); // expected output: Item popped from stack: blue jay

            MessageBox.Show("Number of items in stack: " + stack.Count()); // expected output: Number of items in stack: 1


            // QueueClass with Dune characters
            QueueClass<string> queue = new QueueClass<string>();

            queue.Enqueue("Paul Atreides");
            MessageBox.Show("Adding (Paul Atreides)");
            queue.Enqueue("Jessica");
            MessageBox.Show("Adding (Jessica)");
            queue.Enqueue("Duncan Idaho");
            MessageBox.Show("Adding (Duncan Idaho)");
            MessageBox.Show("Number of items in queue: " + queue.Count()); // expected Number of items in queue: 3
            MessageBox.Show("Item dequeued from queue: " + queue.Dequeue()); // expected Paul Atreides
            MessageBox.Show("Item dequeued from queue: " + queue.Dequeue()); // expectedJessica
            

            
            queue.Enqueue("Chani");
            MessageBox.Show("Adding (Chani)");

            MessageBox.Show("Number of items in queue: " + queue.Count()); // expected Number of items in queue: 2

            MessageBox.Show("Item dequeued from queue: " + queue.Dequeue()); // expectedItem dequeued from queue: Duncan Idaho

            MessageBox.Show("Number of items in queue: " + queue.Count()); // expected Number of items in queue: 1

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    /********************************
KD February 2023
This is an implementation of linked lists in C#
This is the main definition of the DoubleLinkedList class
********************************/
    internal class DoubleLinkedList<T>
    {

        public DoubleLinkedListNode<T> firstNode = null;
        public DoubleLinkedListNode<T> lastNode = null;
        public DoubleLinkedListNode<T> currentNode = null;

        public int nodeNumber = 0;
        public DoubleLinkedList()
        {
        }

        // creates first node in list with firstValue
        public DoubleLinkedList(T firstValue)
        {
            firstNode = new DoubleLinkedListNode<T>(firstValue);
            lastNode = firstNode;
            currentNode = firstNode;
            nodeNumber = 1;
        }

        public DoubleLinkedListNode<T> GetCurrentNode()
        {
            return currentNode;
        }

        /*******************************
    * KD Feb2023 InsertFirst
    * Inserts a new node with the specified value at the beginning of the list.
    * *****************************/
        public void InsertFirst(T value)
        {
            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);

            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = firstNode;
                currentNode = firstNode;
            }
            else
            {

                newNode.next = firstNode;
                firstNode.previous = newNode;
                firstNode = newNode;
                currentNode = firstNode;
            }

            nodeNumber++;
        }
        /*******************************
    * KD Feb2023 InsertBeforeFirst
    * Inserts a new node with the specified value before the first node in the list.
    * *****************************/
        public void InsertBeforeFirst(T value)
        {
            if (firstNode == null)
            {
                InsertFirst(value);
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            newNode.next = firstNode;
            firstNode.previous = newNode;
            firstNode = newNode;
            nodeNumber++;
        }
        /*******************************
    * KD Feb2023 InsertAfterLast
    * Inserts a new node with the specified value after the last node in the list.
    * *****************************/
        public void InsertAfterLast(T value)
        {
            if (lastNode == null)
            {
                InsertFirst(value);
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            lastNode.next = newNode;
            newNode.previous = lastNode;
            lastNode = newNode;
            currentNode = lastNode;
            nodeNumber++;
        }
        /*******************************
    * KD Feb2023 InsertAfterCurrent
    * Inserts a new node with the specified value after the current node in the list.
    * *****************************/
        public void InsertAfterCurrent(T value)
        {
            if (currentNode == null)
            {
                InsertFirst(value);
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            newNode.next = currentNode.next;
            newNode.previous = currentNode;
            if (currentNode.next != null)
            {
                currentNode.next.previous = newNode;
            }
            currentNode.next = newNode;
            currentNode = newNode;
            if (lastNode == currentNode.previous)
            {
                lastNode = currentNode;
            }
            nodeNumber++;
        }
        /********************************

    KD Feb2023 NumberOfNodesInList
    Returns the number of nodes in the linked list
    *********************************/
        public int NumberOfNodesInList()
        {
            return nodeNumber;
        }

        /********************************
    KD Feb2023 DeleteFirst
    Deletes the first node in the linked list
    *********************************/
        public void DeleteFirst()
        {
            if (firstNode == null)
            {
                return;
            }

            if (firstNode.next == null)
            {
                firstNode = null;
                lastNode = null;
                currentNode = null;
            }
            else
            {
                firstNode = firstNode.next;
                firstNode.previous = null;
                currentNode = firstNode;
            }
            nodeNumber--;
        }
        /********************************

    KD Feb2023 DeleteLast
    Deletes the last node in the linked list
    *********************************/
        public void DeleteLast()
        {
            if (lastNode == null)
            {
                return;
            }

            if (lastNode.previous == null)
            {
                firstNode = null;
                lastNode = null;
                currentNode = null;
            }
            else
            {
                lastNode = lastNode.previous;
                lastNode.next = null;
                currentNode = lastNode;
            }
            nodeNumber--;
        }

        /********************************

    KD Feb2023 DeleteCurrent
    Deletes the current node in the linked list
    *********************************/
        public void DeleteCurrent()
        {
            if (currentNode == null)
            {
                return;
            }

            if (currentNode.previous == null)
            {
                DeleteFirst();
                return;
            }

            if (currentNode.next == null)
            {
                DeleteLast();
                return;
            }

            currentNode.previous.next = currentNode.next;
            currentNode.next.previous = currentNode.previous;
            currentNode = currentNode.next;
            nodeNumber--;
        }

        /********************************

    KD Feb2023 MoveToNext
    Moves the current node to the next node in the linked list
    *********************************/
        public void MoveToNext()
        {
            if (currentNode == null || currentNode.next == null)
            {
                return;
            }

            currentNode = currentNode.next;
        }

        /********************************

    KD Feb2023 MoveToPrevious
    Moves the current node to the previous node in the linked list
    *********************************/

        public void MoveToPrevious()
        {
            if (currentNode == null || currentNode.previous == null)
            {
                return;
            }

            currentNode = currentNode.previous;
        }
        /********************************

    KD Feb2023 Find/FindRecursive
        *finds a value in a list and tells you where it is,
        *or says it's not there. It checks each item in the list until it finds a match,
        *and keeps doing this until it finishes the list or finds the value.
    *********************************/

        public DoubleLinkedListNode<T> Find(T value)
        {
            return FindRecursive(firstNode, value);
        }

        private DoubleLinkedListNode<T> FindRecursive(DoubleLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                return null;
            }

            if (node.value.Equals(value))
            {
                return node;
            }

            return FindRecursive(node.next, value);
        }

        /********************************

    KD Feb2023 GetDisplayString/Recursive
    Returns a string representation of the linked list
    *********************************/
        public string GetDisplayString()
        {
            if (firstNode == null)
            {
                return "";
            }

            return GetDisplayStringRecursive(firstNode);
        }

        private string GetDisplayStringRecursive(DoubleLinkedListNode<T> node)
        {
            if (node == null)
            {
                return "";
            }

            string result = node.value.ToString() + " ";
            result += GetDisplayStringRecursive(node.next);
            return result;
        }


    }
    /*******************************
     * KD Feb2023 defines the double linked node
     * uses default T value
     ********************************/
    internal class DoubleLinkedListNode<T>
    {
        public T value;
        public DoubleLinkedListNode<T> next = null;
        public DoubleLinkedListNode<T> previous = null;

        public DoubleLinkedListNode(T value)
        {
            this.value = value;
            previous = null;
            next = null;
        }

        private DoubleLinkedListNode()
        {
            value = default(T);
        }
    }
    /********************************
 * KD March 2023
 * Makes a Dequeue class using the DoubleLinkedList class
 ********************************/
    internal class DequeueClass<T>
    {
        private DoubleLinkedList<T> linkedList;

        public DequeueClass()
        {
            linkedList = new DoubleLinkedList<T>();
        }

        public void PushLeft(T value)
        {
            linkedList.InsertBeforeFirst(value);
        }

        public void PushRight(T value)
        {
            linkedList.InsertAfterLast(value);
        }

        public T PopLeft()
        {
            DoubleLinkedListNode<T> node = linkedList.firstNode;

            if (node == null)
            {
                return default(T);
            }

            linkedList.DeleteFirst();
            return node.value;
        }

        public T PopRight()
        {
            DoubleLinkedListNode<T> node = linkedList.lastNode;

            if (node == null)
            {
                return default(T);
            }

            linkedList.DeleteLast();
            return node.value;
        }

        public int Count()
        {
            return linkedList.NumberOfNodesInList();
        }
    }

    /********************************
     * KD March 2023
     * Makess a Stack class using the DequeueClass
     ********************************/
    internal class StackClass<T> : DequeueClass<T>
    {
        public void Push(T value)
        {
            base.PushLeft(value);
        }

        public T Pop()
        {
            return base.PopLeft();
        }
    }

    /********************************
     * KD March 2023
     * Implements a Queue class using the DequeueClass
     ********************************/
    internal class QueueClass<T> : DequeueClass<T>
    {
        public void Enqueue(T value)
        {
            base.PushRight(value);
        }

        public T Dequeue()
        {
            return base.PopLeft();
        }
    }

    //I tried to have the dequeue and stack and queue methods in a different file
    //but I couldn't get it to import the methods properly visual studio was being finicky
    //So I just pasted them in the bottom (>_<)it's really ugly I'm sorry
    //I'll figure out how to properly call methods from other files with VisualStudio by the next assignment
}
