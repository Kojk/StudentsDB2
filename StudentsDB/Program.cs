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
            //StudentsDB databaza = new StudentsDB();
            //databaza.LoadStudenty();
            //Student[] zotriedenyStudenti;
            //bool triedene = databaza.Zotried(databaza.poleStudentov, out zotriedenyStudenti);

            //foreach (Student s in zotriedenyStudenti)
            //{
            //    Console.WriteLine(s.Meno + " " + s.Priezvysko + " " + s.Vek);
            //}
            //Console.WriteLine(" ");
            //foreach (Student s in databaza.poleStudentov)
            //{
            //    Console.WriteLine(s.Meno + " " + s.Priezvysko + " " + s.Vek);
            //}
            //Console.WriteLine(" ");
            //foreach (Student s in databaza.zoznamStudentov)
            //{
            //    Console.WriteLine(s.Meno + " " + s.Priezvysko + " " + s.Vek);
            //}

            //bool bolo;
            ////if (triedene) bolo = true;
            //bolo = (triedene) ? true : false;   // podmienka zapis v jednom riadku

            Kolekcie k = new Kolekcie();
            k.NaplnFrontu();

            k.NaplnZasobnik();
            k.NaplnTabulku();




            Console.ReadLine();
        }
    }
}
