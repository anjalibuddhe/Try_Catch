using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch



{
    public class Program
    {
        
            static void Main(string[] args)
            {
                Student student = new Student();
                try
                {
                    student.AcceptDeatils("", 20);
                }
                catch (NameException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

