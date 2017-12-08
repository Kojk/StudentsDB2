using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDB
{
    class StudentsDB
    {
        string[] Meno = new string[10] { "Peter", "Pavol", "Alex", "Martin", "Karol", "Pista", "Artur", "Frantisek", "Samuel", "Tomas" };
        string[] Priezvisko = new string[10] { "Palfy", "Bondra", "Satan", "Demitra", "Hosa", "Hasek", "Zigo", "Gaborik", "Lintner", "Hamsik" };
        public Student[] poleStudentov = new Student[10];

        public void LoadStudenty()
        {
            Random nahodneCislo = new Random();
            for (int i = 0; i < poleStudentov.Length; i++)
            {
                Student student;
                student.Meno = Meno[nahodneCislo.Next(10)];
                student.Priezvysko = Priezvisko[nahodneCislo.Next(10)];
                student.Vek = nahodneCislo.Next(15, 80);

                poleStudentov[i] = student;


            }



        }
        public bool Zotried(Student[] studenti, out Student[] zotriedenePole)
        {
            bool boloTriedene = false; ;
            zotriedenePole = (Student[]) studenti.Clone();      //pretypovanie z objektu na pole
            for (int i = 0; i < zotriedenePole.Length ; i++)
            {
                for(int j =0; j < zotriedenePole.Length -1; j++)
                {
                    if (zotriedenePole[j].Vek > zotriedenePole[j + 1].Vek)
                    {
                        Student tempStudent = zotriedenePole[j + 1];
                        zotriedenePole[j + 1] = zotriedenePole[j];
                        zotriedenePole[j] = tempStudent;
                        boloTriedene = true;
                    }

                }
            }
            return boloTriedene;

        }


       

        



    }
}
