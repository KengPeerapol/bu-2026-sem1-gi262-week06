using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null || list.Count <= 1) return list;

            bool swapped;
            do
            {
                swapped = false;
                LinkedListNode<int> current = list.First;

                while (current != null && current.Next != null)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);

            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            if (list == null || list.Count <= 1) return list;

            bool swapped;
            do
            {
                swapped = false;
                LinkedListNode<int> current = list.First;

                while (current != null && current.Next != null)
                {
                    if (current.Value < current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);

            return list;
        }
    }
}
