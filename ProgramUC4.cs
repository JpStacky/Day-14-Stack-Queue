namespace StackQueueLinkedList
{
    public class ProgramUC4
    {
        public static void Main()
        {
            QueueUC4 queue = new QueueUC4();
            queue.Initialize();
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Enqueue(56);
            queue.Dequeue();
        }
    }
}