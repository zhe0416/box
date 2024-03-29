// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
System.Console.WriteLine("小黑");
string name = "小黑";
int num = 6;
char sex = 'M';
double sum = 163.2;
bool score = true;
string phrase = "Hello, World!";
Console.WriteLine(name + "的國文成績是" + num + ",性別是" + sex + ",總成績是" + sum + "，是否合格:" + score);
Console.WriteLine("Hello\nWorld!"); //換行
Console.WriteLine("Hello \"World!\" ");// \後面的"是字串
Console.WriteLine(name.Length); // 計算name長度
Console.WriteLine("Hello, World!".Length);// 計算Hello, World!長度
Console.WriteLine(phrase.ToUpper()); //將phrase裡的字串變成大寫
Console.WriteLine(phrase.ToLower()); //將phrase裡的字串變成小寫
Console.WriteLine(phrase.Contains("Hello")); //判斷phrase裡是否有Hello字串
Console.WriteLine(phrase[4]); //輸出phrase裡第5個字串
Console.WriteLine(phrase.IndexOf('r')); //輸出phrase裡的r是第幾個字元，如果有重複，則回傳最先發現的
Console.WriteLine(phrase.IndexOf("World!")); //輸出phrase裡的World!是第幾個字元開始，找不到則回傳-1
Console.WriteLine(phrase.Substring(3, 5)); //輸出phrase，並從第4個開始輸出，並只輸出5個字元
*/
//-----------------------------------------------------------------------------------------------------------
/*
Console.WriteLine(5 + 2);
Console.WriteLine(5 - 2);
Console.WriteLine(5 * 2);
Console.WriteLine(5 / 2);
Console.WriteLine(5.0 / 2);
Console.WriteLine((5+3) * num );
Console.WriteLine(System.Math.Abs(-10)); //絕對值
Console.WriteLine(System.Math.Pow(2,3)); //次方
Console.WriteLine(System.Math.Sqrt(64)); //開根號
Console.WriteLine(System.Math.Max(24, 7)); //回傳最大
Console.WriteLine(System.Math.Min(24, 7)); //回傳最小
Console.WriteLine(System.Math.Round(3.54623, 2)); //四捨五入
*/
//-----------------------------------------------------------------------------------------------------------
/*
System.Console.Write("請輸入姓名:");
string name = System.Console.ReadLine();
System.Console.Write("請輸入年紀:");
string age = System.Console.ReadLine();
System.Console.WriteLine("歡迎你，" + name + "，您今年" + age + "歲!");

System.Console.Write("請輸入第一個數:");
int num1 = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("請輸入第二個數:");
Double num2 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine(num1 + num2);
*/
//-----------------------------------------------------------------------------------------------------------
/*
// 陣列
int[] score = { 50, 60, 70, 80, 90 };
System.Console.WriteLine(score[0]);
score[0] = 60;
System.Console.WriteLine(score[0]);

string[] phones = new string[10]; //建立一個字串，可放10個值
phones[0] = "0123456789";
phones[1] = "0888888888";
Console.WriteLine(phones[0]);
Console.WriteLine(phones[1]);
*/
//-----------------------------------------------------------------------------------------------------------
/*
// if 判斷句
bool hungry = true;
if(hungry)
{
    Console.WriteLine("我就去吃飯");
}

bool rainning = false;
if(rainning)
{
    Console.WriteLine("我就開車上班");
}
else
{
    Console.WriteLine("我就走路上班");
}


int score = 100;
if (score == 100)
{
    Console.WriteLine("獎勵1000");
}
else if (score >= 80)
{
    Console.WriteLine("獎勵500");
}
else if (score >= 60)
{
    Console.WriteLine("獎勵100");
}
else 
{
    Console.WriteLine("付出300");
}


bool ranning = false;
int score = 100;
if (ranning == true && score == 100) // and = &&
{
    Console.WriteLine("我給你1000");
}
else
{
    Console.WriteLine("你給我100");
}

bool ranning = false;
int score = 100;
if (ranning == true || score == 100) // or = ||
{
    Console.WriteLine("我給你1000");
}
else
{
    Console.WriteLine("你給我100");
}

bool ranning = true;
int score = 100;
if (ranning != true || score != 100) // or = ||
{
    Console.WriteLine("你給我100");
}
else
{
    Console.WriteLine("我給你1000");
}

//-----------------------------------------------------------------------------------------------------------
// 進階計算題
Console.WriteLine("請輸入第一個數：");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());
Console.WriteLine("請輸入要做的運算：");
string oper = System.Console.ReadLine();
Console.WriteLine("請輸入第二個數：");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());
if (oper == "+")
{
    Console.WriteLine("結果是：" + (num1 + num2));
}
else if (oper == "-")
{
    Console.WriteLine("結果是：" + (num1 - num2));
}
else if (oper == "*")
{
    Console.WriteLine("結果是：" + (num1 * num2));
}
else if (oper == "/")
{
    Console.WriteLine("結果是：" + (num1 / num2));
}
//-----------------------------------------------------------------------------------------------------------
// while 迴圈
int num1 = 0;
while (num1 <= 5)
{
    Console.WriteLine(num1);
    num1 += 1;
}

int num1 = 0;
int sum = 0;
while(num1 <=10)
{
    sum += num1;
    num1 ++;
}
Console.WriteLine(sum);

// do...while 先執行在判斷
int num1 = 0;
do
{
    Console.WriteLine(num1);
    num1++;
}
while (num1 <= 5);

// 猜數字遊戲
int secret = 66;
int guess;
int guess_count = 0;
int guess_limit = 3;
bool win = fales;

do
{
    Console.Write("請輸入猜測:");
    guess = System.Convert.ToInt32(System.Console.ReadLine());
    guess_count++; 
    if (guess > secret)
    {
        Console.WriteLine("小一點");
       
    }
    else if (guess < secret)
    {
        Console.WriteLine("大一點");
        
    }
    else 
    {
        Console.WriteLine("猜對了");
     
    }
}
while (guess != secret && guess_count < guess_limit);
if(!win)
{
    Console.WriteLine("抱歉你輸了");
}

//-----------------------------------------------------------------------------------------------------------
// for 迴圈
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

int[] nums = {10, 20, 30, 40, 50 };
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

//-----------------------------------------------------------------------------------------------------------
// 二維陣列
int[,] nums = { 
    {1,2,3}, 
    {4,5,6},
    {7,8,9}
};
Console.WriteLine(nums[2,1]);

int[,] num = new int[3,4]; //創建二維陣列
num[0, 0] = 3;
num[0, 1] = 4;

int[,,] num3 = {{ //創建三維陣列 多一個,及{}
    {1,2,3},
    {4,5,6},
    {7,8,9}
} };
Console.WriteLine(num3[2, 1]);

//-----------------------------------------------------------------------------------------------------------
//類別class 物件object Method方法
using Animal.qq; //使用哪個空間裡的模板
using System; //前面不用再加System

Person person1 = new Person(170.5,42,"小明");
person1.height = 183.3;
person1.age = 23;
person1.name = "李泓哲";
person1.SayHi();
person1.IsAdult();
Console.WriteLine(person1.IsAdult2());
Console.WriteLine(person1.Add(2, 3));

Console.WriteLine(person1.height);

Person person2 = new Person(163.2,23,"小偷");
person2.height = 173.5;
person2.age = 16;
person2.name = "小菊";
Console.WriteLine(person1.name);
Console.WriteLine(person2.age);
person2.SayHi();
person2.IsAdult();
Console.WriteLine(person2.IsAdult2());

using Animal.qq; //使用哪個空間裡的模板
using System; //前面不用再加System
Person person1 = new Person(170.5, 42, "小明");
Person person2 = new Person(163.2, 23, "小偷");
Console.WriteLine(person1.name);
Console.WriteLine(person2.name);

// getter setter
using Animal.qq;

video video1 = new video("真","D","舒服");
video video2 = new video("有那麼舒服嗎","真假","確實");
video1.Type = "教育";
Console.WriteLine(video1.Title);
Console.WriteLine(video1.Type);

//-----------------------------------------------------------------------------------------------------------
// static attribute 靜態屬性
using Animal.qq;
Console.WriteLine(video.video_count);
video video1 = new video("真", "D", "舒服");
Console.WriteLine(video.video_count);
video video2 = new video("有那麼舒服嗎", "真假", "確實");
Console.WriteLine(video1.getVideoCount());

//-----------------------------------------------------------------------------------------------------------
// static method、static class static=靜態
using c_;
Tool tool = new Tool(); //如果我宣告靜態，則無法執行
Tool.SayHi();
Console.WriteLine(Math.Sqrt(36));
*/
//-----------------------------------------------------------------------------------------------------------
// inheritance 繼承
using Animal.qq;

Student student1 = new Student("小白",10,"國小");
Console.WriteLine(student1.school);
student1.PrintAge();
student1.PrintName();







