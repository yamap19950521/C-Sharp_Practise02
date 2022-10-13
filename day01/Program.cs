//註解
//這是單行註解
/*這是
        多行
            註解*/

//-----------------------------------------------------------------------------------------

//常見資料型態 
//字串 string
//System.Console.WriteLine("我是一隻可愛白斬雞");

////字元 char
//System.Console.WriteLine('a');

////整數 int
//System.Console.WriteLine(100);

////浮點數 double
//System.Console.WriteLine(160.5555);

////布林值 bool
//System.Console.WriteLine(true);
//System.Console.WriteLine(false);

//-----------------------------------------------------------------------------------------

////變數
//string name = "錚錚";
//System.Console.WriteLine(name + "今年27歲");
//System.Console.WriteLine(name + "身高160.5");
//System.Console.WriteLine(name + "很可愛");

//name = "小白";
//System.Console.WriteLine(name + "很可愛");

//-----------------------------------------------------------------------------------------

////字串常見的用法
////(1)  換行( /n )
//System.Console.WriteLine("Hello \nMr.Right");
////(2) 在字串裡表達雙引號(\")
//System.Console.WriteLine("Hello\" Mr.Right");
////(3) 字串相加 -> 連接在一起
//System.Console.WriteLine("Hello" + "Mr.Right");
////(4) 字串的長度(.Length)
//System.Console.WriteLine("Hello   ".Length);

//-----------------------------------------------------------------------------------------

////字串的方法
////(1) 字母轉成大寫 ( ToUpper() )
//System.Console.WriteLine("happ 依錚".ToUpper());
////(2)字母轉成小寫( ToLower() )
//System.Console.WriteLine("HAPPY".ToLower());
////(3)字串是否含有特定的子字串( .Contains("子字串") )
//System.Console.WriteLine("Happy".Contains("yp"));
////(4)字串特定位置的值是什麼？( [索引] )
//System.Console.WriteLine("Happy"[0]);
////(5)以字元找索引位置( .IndexOf(' ') )
//System.Console.WriteLine("Happy".IndexOf('p'));
//System.Console.WriteLine("Happy".IndexOf('b')); //找不到給-1
//System.Console.WriteLine("Happy time".IndexOf("time")); //如果給的是字串 找第一個字母
////(6)字串第Ｎ位以前刪掉 ( .Substring(N) )
//System.Console.WriteLine("Happy".Substring(2));
//System.Console.WriteLine("Happy".Substring(1, 2)); //字串第一位以前刪掉，往後留兩位

//-----------------------------------------------------------------------------------------

////數字常見的用法(整數、浮點數)
////數字運算
//System.Console.WriteLine(6 + 2);
//System.Console.WriteLine(6 - 2);
//System.Console.WriteLine(6 * 2);
//System.Console.WriteLine(6 / 2);
//System.Console.WriteLine(5.0 / 2);

//-----------------------------------------------------------------------------------------

////數字的方法
////(1) 絕對值System.Math.Abs()
//System.Console.WriteLine(System.Math.Abs(-10));
//System.Console.WriteLine(System.Math.Abs(-10.5));

////(2)次方System.Math.Pow( x,y )
//System.Console.WriteLine(System.Math.Pow(2, 3));

////(3)開根號System.Math.Sqrt()
//System.Console.WriteLine(System.Math.Sqrt(64));

////(4)比哪個大？System.Math.Max( x, y )
//System.Console.WriteLine(System.Math.Max(101, 100));

////(5)比哪個小？System.Math.Min( x, y )
//System.Console.WriteLine(System.Math.Min(101, 100));

////四捨五入 System.Math.Round()
//System.Console.WriteLine(System.Math.Round(10.555));
//System.Console.WriteLine(System.Math.Round(10.4));

//-----------------------------------------------------------------------------------------

////如何取得用戶輸入？
//System.Console.Write("請問您的名字是？");
//string name2 = System.Console.ReadLine();
//System.Console.Write("請問您的年紀是？");
//string age2 = System.Console.ReadLine();
//System.Console.WriteLine("您好啊" + name2 + "你的年紀是" + age2 + "歲");

//-----------------------------------------------------------------------------------------

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

//-----------------------------------------------------------------------------------------

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

//-----------------------------------------------------------------------------------------

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



//(6) int scores = 100;
//bool rainy = false;
//if (scores != 100 || !rainy)
//{
//    System.Console.WriteLine("我給你1000元");
//}
//else
//{
//    System.Console.WriteLine("你給我100元");
//}


//-----------------------------------------------------------------------------------------

//進階計算機(取的用戶三個輸入，分別兩個數字 一個運算-可相加相減相乘相除)
//System.Console.Write("請輸入第一個數字: ");
//double Num1 = System.Convert.ToDouble(System.Console.ReadLine());

//System.Console.Write("請輸入要做的運算: ");
//string cal = System.Console.ReadLine();

//System.Console.Write("請輸入第二個數字: ");
//double Num2 = System.Convert.ToDouble(System.Console.ReadLine());

//if (cal == "+")
//{
//    System.Console.WriteLine(Num1 + Num2);
//}
//else if (cal == "-")
//{
//    System.Console.WriteLine(Num1 - Num2);
//}
//else if (cal == "*")
//{
//    System.Console.WriteLine(Num1 * Num2);
//}
//else if (cal == "/")
//{
//    System.Console.WriteLine(Num1 / Num2);
//}
//else {
//    System.Console.WriteLine("不合法的運算符號，運算符號請輸入+ - * /");
//}

//-----------------------------------------------------------------------------------------

//// While迴圈 (可以重複執行同樣的程式碼直到條件判斷為false為止)

////while寫法一
//int i = 5;
//while (i <= 10) 
//{
//    System.Console.WriteLine(i);
//    i++;
//}



////while寫法二 (先做完加一後再判斷)
//int i = 15;
//do
//{
//    System.Console.WriteLine(i);
//    i++;
//}

//while (i <= 10);

//-----------------------------------------------------------------------------------------

//猜數字遊戲(假設數字為50，用戶輸入20，就要提示要大一點;反之)

//(1) 可以無限次讓玩家輸入直到達對
//int Num = 50;
//int userNum;
//do
//{
//    System.Console.Write("請猜一個數: ");
//    userNum = System.Convert.ToInt32(System.Console.ReadLine());

//    if (Num > userNum)
//    {
//        System.Console.WriteLine("數字再大一點");
//    }
//    else if (Num < userNum)
//    {
//        System.Console.WriteLine("數字在小一點");
//    }
//    else if (Num == userNum)
//    {
//        System.Console.WriteLine("恭喜答對");
//    }
//}

//while (userNum != Num);



//(2) 玩家只能最多猜三次 沒答對就輸了

//int Num = 50;
//int userNum;
//int guess_count= 0;//目前答題數次數
//int guess_limit = 3;//最多達幾次
//bool win = false;//贏了

//do
//{
//        System.Console.Write("請猜一個數: ");
//        userNum = System.Convert.ToInt32(System.Console.ReadLine());
//        guess_count++;

//        if (Num > userNum)
//        {
//            System.Console.WriteLine("數字再大一點");
//        }
//        else if (Num < userNum)
//        {
//            System.Console.WriteLine("數字在小一點");
//        }
//        else if (Num == userNum )
//        {
//            System.Console.WriteLine("答對!");
//            win = true;
//        }

//} while (userNum != Num && guess_count < guess_limit);

//if (!win) {
//    System.Console.WriteLine("你輸了!");
//}


//-----------------------------------------------------------------------------------------

// for迴圈(可以重複執行同樣的程式碼直到條件判斷為false為止) 跟while迴圈相同
//for (int i = 1; i <= 10; i++ ){
//    System.Console.WriteLine(i);
//}

//用for迴圈取得陣列所有值
//int[] nums = { 100, 200, 300, 400, 500, 600 };
//for(int i=0; i< nums.Length; i++){ 
//    System.Console.WriteLine(nums[i]);
//}

//-----------------------------------------------------------------------------------------

//二維陣列     (n維陣列 ,增加)
//int[,] nums = {
//    { 1, 2, 3 },
//    { 4 ,5, 6 },
//    { 7, 8, 9 } 
//};

//System.Console.WriteLine(nums[0,2]);

//寫法二
//int[,] num = new int[3,2];
//num[0, 0] = 50;

//-----------------------------------------------------------------------------------------

// class類別、 object物件(有很多東西沒辦法用之前介紹的資料型態座表示，因此可以創建自己的資料型態
// )


//如何創建類別class
//步驟一 方案總管 對專案名稱點右鍵 ->  加入 -> 新增項目 -> 選擇 : 類別 -> 名稱:為創建的資料型態的名字 *注意 第一個字母用大寫表示

//創建實體的Person
//person1是一個物件
using Animal.P;
Person person1 = new Person();
person1.age = 18;
person1.name = "小白";
person1.height = 160.5;

System.Console.WriteLine(person1.name);




