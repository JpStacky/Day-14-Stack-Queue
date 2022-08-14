namespace StackQueueLinkedList
{
    public class QueueUC3
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
    }
}
