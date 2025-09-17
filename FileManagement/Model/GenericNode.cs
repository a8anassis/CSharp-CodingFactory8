using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement.Model
{
    internal class GenericNode<T>
    {
        public T? Value { get; set; }
        public int Count { get; set; }
        public GenericNode<T>? Next { get; set; }
        public GenericNode<T>? Prev { get; set; }
    }
}
