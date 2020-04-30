using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LlistHW1.Model
{
    public class Human<T> : IEnumerable<T>
    {
        public Professions<T> Head { get; set; }
        public Professions<T> Tail { get; set; }
        public int Count { get; set; }


        public Human() { }

        public void Add(T data)
        {
            var item = new Professions<T>(data);
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }
        public void Remove(T data)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

    }
}
