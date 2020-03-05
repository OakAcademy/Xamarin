using System;
using System.Collections.Generic;
using System.Text;

namespace CafeMenuApp.Models
{
    public class Group<K,T>: List<T>
    {
        public K Title { get; set; }

        public Group(K title, IEnumerable<T> list)
        {
            this.Title = title;
            this.AddRange(list);
        }
    }
}
