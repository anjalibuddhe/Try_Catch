using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class NameException : Exception
    {
        public NameException(string message) : base(message)
        {

        }


    }

    public class Student
    {
        public string name;
        public int age;

        public void AcceptDeatils(string name, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Name  not be null");
            }
            else
            {
                this.name = name;
                this.age = age;
            }
        }

    }
   
}
