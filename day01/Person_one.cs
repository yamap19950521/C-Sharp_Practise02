using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01 {
    class Person_one { 
        public string name;
        public int age;

        public void PrintAge() { 
            Console.WriteLine(this.age);
        }

        public void PrintName() {
            Console.WriteLine(this.name);
        }
    }
}
