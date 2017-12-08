using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDB databaza = new StudentsDB();
            databaza.LoadStudenty();
            Student[] zotriedenyStudenti;
            bool triedene = databaza.Zotried(databaza.poleStudentov, out zotriedenyStudenti);

            foreach (Student s in zotriedenyStudenti)
            {
                Console.WriteLine(s.Meno + " " + s.Priezvysko + " " + s.Vek);
            }
            Console.WriteLine(" ");
            foreach (Student s in d
                atabaza.poleStudentov)
            {
                Console.WriteLine(s.Meno + " " + s.Priezvysko + " " + s.Vek);
            }



            Console.ReadLine();
        }
    }
}
