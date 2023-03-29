using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Thêm vào database

            using (var db = new EntityDBEntities1())
            {

                var select = from s in db.Students select s;

                foreach (var data in select)
                {
                    Console.WriteLine("ID: {0}", data.StudentID);
                    Console.WriteLine("NAME: {0}", data.StudentName);
                    Console.WriteLine("Gender: {0}", data.StudentGender);
                    Console.WriteLine("Address: {0}", data.Address);

                }

            }


            Console.ReadLine();
        }
    }
}
