using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListHW1
{
   public class Professions<T>
    {      
        public T Data { get; set; }
        public Professions<T> Previous { get; set; }
        public Professions<T> Next { get; set; }
        
        public Professions(T data)
        {
            Data = data;
        }
    }
}
