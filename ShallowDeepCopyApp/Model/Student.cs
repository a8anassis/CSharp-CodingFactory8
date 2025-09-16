using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopyApp.Model
{
    internal class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public Address? StuAddress { get; set; }

        public Student GetReference()
        {
            return this;
        }

        public Student GetShallowCopy()
        {
            return (Student)MemberwiseClone();      // bit-bit copy
        }

        public Student GetDeepCopy()
        {
            Student student = (Student)MemberwiseClone();
            student.StuAddress = new Address()
            {
                Street = StuAddress?.Street,
                Number = StuAddress?.Number,
                ZipCode = StuAddress?.ZipCode
            };
            return student;
        }

        // Copy ctor
        public Student(Student student)
        {
            Id = student.Id;
            Firstname = student.Firstname;
            Lastname = student.Lastname;
            StuAddress = new Address()
            {
                Street = student.StuAddress?.Street,
                Number = student.StuAddress?.Number,
                ZipCode = student.StuAddress?.ZipCode
            };
        }
    }
}
