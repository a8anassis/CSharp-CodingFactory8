using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp
{
    internal interface IMoveable
    {
        void Move5();

        // Default Impl
        void Move10()
        {
            Console.WriteLine("Move 10 units");
        }
    }
}
