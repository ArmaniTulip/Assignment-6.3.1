namespace Assignment_6._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        class Node
        {
            public string Data { get; set; }
            public Node Next { get; set; }

            public Node(string data)
            {
                Data = data;
                Next = null;
            }
        }

        class Queue
        {
            private Node front;
            private Node rear;

            public Queue()
            {
                front = null;
                rear = null;
            }

            public void Enqueue(string data)
            {
                var newNode = new Node(data);
                if (rear == null)
                {
                    // If the queue is empty, set both front and rear to the new node
                    front = newNode;
                    rear = newNode;
                }
                else
                {
                    // Otherwise, add the new node to the rear
                    rear.Next = newNode;
                    rear = newNode;
                }
            }

            public string Dequeue()
            {
                if (front == null)
                    return null;

                // Dequeue the front node and update front pointer
                var data = front.Data;
                front = front.Next;
                if (front == null)
                    rear = null; // If the queue becomes empty, update rear pointer

                return data;
            }

            public bool IsEmpty()
            {
                return front == null;
            }

            public void Display()
            {
                var current = front;
                while (current != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                Console.WriteLine("None");
            }

        }
    }
}
