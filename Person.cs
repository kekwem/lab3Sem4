using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okna_dialogowe
{
    public class Person
    {
        private string first_name;
        private string second_name;
        private double rok_urodzenia;
        private string miasto;

        public Person(string first_name, string second_name, double rok_urodzenia, string miasto)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.rok_urodzenia = rok_urodzenia;
            this.miasto = miasto;
        }

        public override string ToString()
        {
            return first_name + " " + second_name + " " + rok_urodzenia + " " + miasto;
        }
    }
}
