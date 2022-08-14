namespace StackQueueLinkedList
{
    public class QueueUC4
    {
        LinkedList<int> list;
        public void Initialize()
        {
            list = new LinkedList<int>();
        }
        public void Enqueue(int n)
        {
            list.Append(n);
        }
        public void Dequeue()
        {
            foreach (var num in list)
            {
                Console.WriteLine(num);
                //Console.WriteLine("Removing Element " + num + " from Queue ");
               // list.Remove(num);
            }
        }
    }
}
