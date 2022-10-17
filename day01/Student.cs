using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day01 {
    class Student : Person_one {  //讓Sudent類別繼承Person類別(裡面有的屬性跟方法就不用重複寫了! )
        public string school;

        public Student(string name, int age, string school) { 
            this.name = name ;
            this.age = age ;
            this.school = school ;
        }

        public void PrintSchool() {
            Console.WriteLine(this.school);
        }

    }
}
