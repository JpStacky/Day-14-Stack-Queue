using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueLinkedList
{
    public class StackUC2
    {
        LinkedList<int> list;
 
        public void Initialize()
        {
            list = new LinkedList<int>();
        }
        public void Add(int n)
        {
            list.AddLast(n);
        }
        public void PeakPop()
        {
            foreach (int num in list.ToList())
            {
                Console.WriteLine("Removing element "+num+" from Linked List...");
                list.Remove(num);
            }
        }
    }
}
