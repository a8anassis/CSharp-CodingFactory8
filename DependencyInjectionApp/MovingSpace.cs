using InterfacesApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp
{
    internal class MovingSpace
    {
        public IMoveable? Moveable { get; }

        public MovingSpace(IMoveable? moveable)
        {
            Moveable = moveable;
        }

        public void MakeMove5()
        {
            Moveable!.Move5();
        }
    }
}
