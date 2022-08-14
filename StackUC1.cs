using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueLinkedList
{
    public class StackUC1
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
    }
}
