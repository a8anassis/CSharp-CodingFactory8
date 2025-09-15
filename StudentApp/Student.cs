using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{

    /// <summary>
    /// POCO (Plain Old CLR Object)
    /// </summary>
    internal sealed class Student
    {
        private readonly int id;
        private readonly string? firstname;
        private readonly string? lastname;

        // Expression-body members
        public int Id { get => id; }
        public string? Firstname { get => firstname;  }
        public string? Lastname { get => lastname;  }

        public Student()
        {

        }

        public Student(int id, string? firstname, string? lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }



        //public int Id { get { return id; } private set { id = value; } }
        //public string? Firstname { get { return firstname; } private set { firstname = value; } }
        //public string? Lastname { get { return lastname; } private set { lastname = value; } }


    }
}
