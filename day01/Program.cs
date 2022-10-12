//註解
//這是單行註解
/*這是
        多行
            註解*/



//常見資料型態 
//字串 string
System.Console.WriteLine("我是一隻可愛白斬雞");

//字元 char
System.Console.WriteLine('a');

//整數 int
System.Console.WriteLine(100);

//浮點數 double
System.Console.WriteLine(160.5555);

//布林值 bool
System.Console.WriteLine(true);
System.Console.WriteLine(false);



//變數
string name = "錚錚";
System.Console.WriteLine(name + "今年27歲");
System.Console.WriteLine(name + "身高160.5");
System.Console.WriteLine(name + "很可愛");

name = "小白";
System.Console.WriteLine(name + "很可愛");



//字串常見的用法
//(1)  換行( /n )
System.Console.WriteLine("Hello \nMr.Right");
//(2) 在字串裡表達雙引號(\")
System.Console.WriteLine("Hello\" Mr.Right");
//(3) 字串相加 -> 連接在一起
System.Console.WriteLine("Hello" + "Mr.Right");
//(4) 字串的長度(.Length)
System.Console.WriteLine("Hello   ".Length);


//字串的方法
//(1) 字母轉成大寫 ( ToUpper() )
System.Console.WriteLine("happ 依錚".ToUpper());
//(2)字母轉成小寫( ToLower() )
System.Console.WriteLine("HAPPY".ToLower());
//(3)字串是否含有特定的子字串( .Contains("子字串") )
System.Console.WriteLine("Happy".Contains("yp"));
//(4)字串特定位置的值是什麼？( [索引] )
System.Console.WriteLine("Happy"[0]);
//(5)以字元找索引位置( .IndexOf(' ') )
System.Console.WriteLine("Happy".IndexOf('p'));
System.Console.WriteLine("Happy".IndexOf('b')); //找不到給-1
System.Console.WriteLine("Happy time".IndexOf("time")); //如果給的是字串 找第一個字母
//(6)字串第Ｎ位以前刪掉 ( .Substring(N) )
System.Console.WriteLine("Happy".Substring(2));
System.Console.WriteLine("Happy".Substring(1, 2)); //字串第一位以前刪掉，往後留兩位




//數字常見的用法(整數、浮點數)
//數字運算
System.Console.WriteLine(6 + 2);
System.Console.WriteLine(6 - 2);
System.Console.WriteLine(6 * 2);
System.Console.WriteLine(6 / 2);
System.Console.WriteLine(5.0 / 2);

//數字的方法
//(1) 絕對值System.Math.Abs()
System.Console.WriteLine(System.Math.Abs(-10));
System.Console.WriteLine(System.Math.Abs(-10.5));

//(2)次方System.Math.Pow( x,y )
System.Console.WriteLine(System.Math.Pow(2, 3));

//(3)開根號System.Math.Sqrt()
System.Console.WriteLine(System.Math.Sqrt(64));

//(4)比哪個大？System.Math.Max( x, y )
System.Console.WriteLine(System.Math.Max(101, 100));

//(5)比哪個小？System.Math.Min( x, y )
System.Console.WriteLine(System.Math.Min(101, 100));

//四捨五入 System.Math.Round()
System.Console.WriteLine(System.Math.Round(10.555));
System.Console.WriteLine(System.Math.Round(10.4));



//如何取得用戶輸入？
System.Console.Write("請問您的名字是？");
string name2 = System.Console.ReadLine();
System.Console.Write("請問您的年紀是？");
string age2 = System.Console.ReadLine();
System.Console.WriteLine("您好啊" + name2 + "你的年紀是" + age2 + "歲");







//基本計算機 ( 如果是int整數 )
//System.Console.Write("請輸入第一個數:");
//int num1 = System.Convert.ToInt32(System.Console.ReadLine());
//System.Console.Write("請輸入第二個數:");
//int num2 = System.Convert.ToInt32(System.Console.ReadLine());
//System.Console.WriteLine(num1 + num2);



//基本計算機 ( 如果是double浮點數 )
//System.Console.Write("請輸入第一個數:");
//double num1 = System.Convert.ToDouble(System.Console.ReadLine());
//System.Console.Write("請輸入第二個數:");
//double num2 = System.Convert.ToDouble(System.Console.ReadLine());
//System.Console.WriteLine(num1 + num2);



//Array 陣列
//int[] scores = { 100, 50, 30, 40 };

//創建一個空陣列叫phones，資料型態是字串，並且可以放10個字串
//string[] phones = new string[10];

//phones[0] = "0910806623";
//phones[1] = "0971769513";

//System.Console.WriteLine(phones[0]);
//取陣列的值
//System.Console.WriteLine(scores[0]);
//System.Console.WriteLine(scores[1]);
//System.Console.WriteLine(scores[2]);
//System.Console.WriteLine(scores[3]);

//更改陣列的值
//scores[0] = 80;
//System.Console.WriteLine("第0位的值更改後:"+scores[0]);









//if 判斷句
//(1) bool hungry = true;
//if (hungry)
//{
//    System.Console.WriteLine("我就去吃飯");
//}



//(2) bool rainy = false;
//if (rainy)
//{
//    System.Console.WriteLine("我就開車去上班");
//}
//else
//{
//    System.Console.WriteLine("我就走路去上班");
//}

//(3) 由上往下判斷，如果有判斷到 ，就不會執行下面的程式碼了
//int scores = 20;
//if (scores == 100)
//{
//    System.Console.WriteLine("我給你1000元");
//}
//else if (scores >= 80)
//{
//    System.Console.WriteLine("我給你500元");
//}
//else if (scores >= 60)
//{
//    System.Console.WriteLine("我給你100元");
//}
//else
//{
//    System.Console.WriteLine("你給我300元");
//}




//(4) int scores = 50;
//bool rainy = true;
//if (scores == 100 && rainy)
//{
//    System.Console.WriteLine("我給你1000元");
//}
//else
//{
//    System.Console.WriteLine("你給我100元");
//}




//(5) int scores = 50;
//bool rainy = false;
//if (scores == 100 || rainy) {
//    System.Console.WriteLine("我給你1000元");
//}
//else
//{
//    System.Console.WriteLine("你給我100元");
//}




//(6)int scores = 100;
//bool rainy = false;
//if (scores != 100 || !rainy)
//{
//    System.Console.WriteLine("我給你1000元");
//}
//else {
//    System.Console.WriteLine("你給我100元");
//}









