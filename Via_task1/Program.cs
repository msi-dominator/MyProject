using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Via_task1
{
   
    public class Node
    {
        public string val;
        public Node next;
        public Node prev;
    }

    class MyLinkedList
    {
        public Node Head;

        /// <summary>
        /// Добавление в однонаправленный список после определенного элемена
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="certainNode"></param>
        public void AddAfterRef(Node newNode, Node certainNode)
        {
            Node curNode = Head;
            while (curNode!= certainNode)
            {
                curNode = curNode.next;
            }
            newNode.next = curNode.next;
            curNode.next = newNode;
        }

        /// <summary>
        ///  Добавление в двунаправленный список после определенного элемена
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="certainNode"></param>
        public void DoubleAfterref(Node newNode, Node certainNode)
        {
            Node curNode = Head;
            while (curNode != certainNode)
            {
                curNode = curNode.next;
            }
            newNode.next = curNode.next;
            curNode.next.prev = newNode;
            newNode.prev = curNode;
            curNode.next = newNode;

        }
        public void AddAfterVal(Node newNode, Node certainNode)
        {
            Node curNode = Head;
            while (curNode.val != certainNode.val)
            {
                curNode = curNode.next;
            }
            newNode.next = curNode.next;
            curNode.next = newNode;
        }

        /// <summary>
        /// добавление перед элементом  для однонаправленного списка
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="certainNode"></param>
        public void AddBeforeRef(Node newNode, Node certainNode)
        {
            Node curNode = Head;
            Node prevNode = Head;
            while (curNode != certainNode)
            {
                prevNode = curNode;
                curNode = curNode.next;
            }
            newNode.next = curNode;
            prevNode.next = newNode;

        }


        /// <summary>
        /// добавление перед элементом  для двуправленного списка
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="certainNode"></param>
        public void DoubleAddBeforeref(Node newNode, Node certainNode)
        {
            Node curNode = Head;
            Node prevNode = Head;
            while (curNode!=newNode)
            {
                prevNode = curNode;
                curNode = curNode.next;
            }
            newNode.next = curNode;
            newNode.prev = curNode.prev;
            curNode.prev = newNode;
            prevNode.next = newNode;
        }

        /// <summary>
        /// добавление в начало для однонаправленного списка
        /// </summary>
        /// <param name="newNode"></param>
        public void AddInBegin(Node newNode)
        {
            newNode.next = Head;
            newNode = Head;
        }

        /// <summary>
        /// добавление в начало для двуправленного списка
        /// </summary>
        /// <param name="newNode"></param>
        public void doubleAddInBegin(Node newNode)
        {
            newNode.next = Head;
            newNode = Head;
            newNode.prev = null;
        }

        /// <summary>
        /// добавление в конец для однонаправленного списка
        /// </summary>
        /// <param name="newNode"></param>
        public void AddInEnd(Node newNode)
        {
            Node curNode = Head.next;
            while (curNode.next!=null)
            {
                curNode = curNode.next;
            }
            curNode.next = newNode;
            newNode.next = null;
        }

        /// <summary>
        /// добавление в конец для двунаправленного списка
        /// </summary>
        /// <param name="newNode"></param>
        public void DoubleAddInEnd(Node newNode)
        {
            Node curNode = Head.next;
            while (curNode.next != null)
            {
                curNode = curNode.next;
            }
            curNode.next = newNode;
            newNode.next = null;
            newNode.prev = curNode;
        }

        /// <summary>
        /// очистка однонапрвленного списка
        /// </summary>
        public void ClearList()
        {
            Node curNode = Head;
            Node nextNode = curNode.next;
            while (nextNode!=null)
            {
                curNode.next = null;
                curNode = nextNode;
                nextNode = nextNode.next;
            }
            curNode.next = null;
        }

        /// <summary>
        /// очисткадвунапрвленного списка
        /// </summary>
        public void DoubleClearList()
        {
            Node curNode = Head;
            Node nextNode = curNode.next;
            while (nextNode != null)
            {
                curNode.next = null;
                curNode.prev = null;
                curNode = nextNode;
                nextNode = nextNode.next;
            }
            curNode.next = null;
        }
        public Node GivenUseIndex(int index)
        {
            Node curNode = Head;
            int i = 0;
            while (i!=index)
            {
                i += 1;
                curNode = curNode.next;
            }
            return curNode;
        }

        public Node GivenUseValue(string value)
        { 
            Node curNode = Head;
            string val = Head.val;
            while (val != value)
            {
                curNode = curNode.next;
                val = curNode.val;
            }
            return curNode;
        }

        public int NumberElements ()
        {
            Node curNode = Head.next;
            int sum = 1;
            while (curNode!= null)
            {
                sum += 1;
                curNode = curNode.next;
            }
            return sum;
        }
    }
     
  
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node();
            first.val = "Первый";
            first.prev = null;
            Node second = new Node();
            second.val = "Второй";
            first.next = second;
            second.prev = first;
            Node third = new Node();
            third.val = "Третий";
            third.prev = second;
            second.next = third;
            Node forth = new Node();
            forth.val = "Четвертый";
            forth.prev = third;
            third.next = forth;
            Node fifth = new Node();
            fifth.val = "Пятый";
            forth.next = fifth;
            fifth.prev = forth;
            fifth.next = null;

            MyLinkedList List = new MyLinkedList();
            List.Head = first;
            Node newNode = new Node();
            newNode.val = "new";
          
        }

    }

    
}
