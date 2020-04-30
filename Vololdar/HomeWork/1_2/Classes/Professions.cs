using System;
using System.Collections.Generic;
using System.Text;

namespace LlistHW1.Model
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

        public override string ToString()
        {
            return Data.ToString();
        }


    }
}
