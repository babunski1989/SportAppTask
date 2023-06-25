using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp
{
    public class Coach
    {
        private string name;
        private int age;

        public Coach(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
