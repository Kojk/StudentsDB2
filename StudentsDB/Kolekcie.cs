using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDB
{
    class Kolekcie
    {

        // fronta FIFO - first in, first out
        Queue fronta = new Queue();
        //zasobnik LIFO - Last in, first out
        Stack zasobnik = new Stack();
        // hastable - tabulka
        Hashtable table = new Hashtable();
        
        public void NaplnFrontu()
        {
            fronta.Enqueue("Pavel");
            fronta.Enqueue("Pepa");
            fronta.Enqueue("Jano");


          string s = (string) fronta.Dequeue();
            foreach (string d in fronta)
            {
                Console.WriteLine(d);
            }



        }
        public void NaplnZasobnik()
        {
            zasobnik.Push(10);
            zasobnik.Push(5);
            zasobnik.Push("Pavel");
            zasobnik.Push("Peter");

            string s = zasobnik.Pop().ToString();     //  peek vrati kto je na tahu



        }
        public void NaplnTabulku()
        {
            table["Pavel Sanca"] = "216547984";
            table["Jakub"] = "14521651321";
            table.Remove("Jakub");
        }

    }
}
