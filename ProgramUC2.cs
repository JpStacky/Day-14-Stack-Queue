using StackQueueLinkedList;

namespace StackQueueLinkedList
{
    class ProgramUC2
    {
        public static void Main()
        {
            StackUC2 stack = new StackUC2();
            stack.Initialize();
            stack.Add(70);
            stack.Add(30);
            stack.Add(56);
            stack.PeakPop();
        }
    }
}