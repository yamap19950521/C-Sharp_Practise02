//只是創建一個資料型態的模板而已
using System;

namespace Animal {
    namespace P {
        class Person {
            public double height;
            public int age;
            public string name;

            ////方法  method (可以在class裡定義一個功能做使用)
            ////(1) 做印東西這件事
            //public void SayHi() {  //void代表沒有回傳值
            //    Console.WriteLine("你好啊!我叫" + name);
            //}


            ////為什麼需要把資料回傳回去呢?   因為呼叫的地方可能要做後續的處理(例如還要再做判斷...等)
            ////(2) 回傳值-> 把原本的呼叫覆蓋過去
            //public bool IsAdult() { //bool代表回傳值資料型態是bool

            //    if (age >= 18) {
            //        return true;
            //    } else {
            //        return false;
            //    }
            //}


            //// (3)呼叫方法時，傳資料進來 -帶參數
            //public int Add(int Num1, int Num2, string QQ) {
            //    return Num1 + Num2;
            //}




            ////(1) 建構方法 
            //public Person(string hey) {
            //    System.Console.WriteLine("創建成功"+hey);
            //}
            //(2) 建構方法 
            //public Person(double h, int a, string n) {
            //    height = h;
            //    age = a;
            //    name = n;
            //}


            //(3) 建構方法  參數跟屬性同名
            public Person(double height, int age, string name) {
                this.height = height;
                this.age = age;
                this.name = name;
            }

        }
    }
}

