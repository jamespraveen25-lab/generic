using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Program
    {
        class student
        {
            internal void display<j,k,l,m,n,o> (j sid,k sname,l scollage,m location,n address,o pincode)
            {
                Console.WriteLine("student id is" + sid);
                Console.WriteLine("student name is"+sname);
                Console.WriteLine("student collage is"+scollage);
                Console.WriteLine("student loaction is "+location);
                Console.WriteLine("student address"+address);
                Console.WriteLine("studnet pincode"+pincode);


            }

        }
        static void Main(string[] args)
        {
            student james = new student();
            james.display<int,string,string,string,string,int>(25,"james","nawab","amaravathi","vizag",500013);
        }
    }
}
