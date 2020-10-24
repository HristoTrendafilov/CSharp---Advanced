using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class MyTupple<T,K,M>
    {
        public MyTupple(T item1,K item2,M item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.item3 = item3;
        }
        public T Item1 { get; set; }
        public K Item2 { get; set; }
        public M item3 { get; set; }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.item3}";
        }
    }
}
