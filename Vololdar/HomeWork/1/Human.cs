using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListHW1
{
    public class Human<Ttype> : IEnumerable<Ttype>
    {
        public Professions<Ttype> Head;
        public Professions<Ttype> Tail;
        public int count;

        public void Add(Ttype data)
        {
            Professions<Ttype> profession = new Professions<Ttype>(data);

            if (count == 0)
            {
                Head = profession;
                Tail = profession;
                count = 1;
            }

            Tail.Next = profession;
            profession.Previous = Tail;
            Tail = profession;
            count++;
        }

        public void Remove(Ttype data)
        {
            Professions<Ttype> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;

                }
                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    Tail = current.Previous;
                }


                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    Head = current.Next;
                }
                count--;
                return;
            }
            return;
        }
                

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<Ttype> IEnumerable<Ttype>.GetEnumerator()
        {
            Professions<Ttype> current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }
}


