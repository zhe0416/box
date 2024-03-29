using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Animal // 創建一個空間，可存放很多模板
{
    namespace qq
    {
        class Person
        {
            public double height;
            public int age;
            public string name;
            public void SayHi()
            {
                Console.WriteLine("你好啊，我叫" + name);
            }
            public void IsAdult() // void 不能回傳
            {
                if (age >= 18)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            public bool IsAdult2()
            {
                if (age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int Add(int num1,int num2) 
            {
                return num1 + num2;
            }
            // Constructor 建構方法
            public Person(double h,int a,string n) 
            {
                height = h;
                age = a;
                name = n;
            }
            class video 
{
    
}
        }
        class video
        {
            private string title;
            public string author;
            private string type; // type只能在video的class使用
            
            public video(string title, string author, string type)
            {
                Title = title;
                this.author = author;
                Type = type;
                video_count++;
            }
            public string Type 
            {
                get {return type;}
                set 
                {
                    if (value == "教育" || value == "娛樂" || value == "音樂" || value == "其他")
                    { 
                        type = value;
                    }
                    else
                    {
                        type = "其他";
                    }
                }
            }
            public string Title 
            {
                get {return title;}
                set 
                {
                    if (value == "老闆" || value == "總經理" || value == "經理" || value == "課長")
                    {
                        title = value;
                    }
                    else
                    {
                        title = "員工";
                    }
                }
            }
            public static int video_count = 0;
            public int getVideoCount() 
            {
                return video_count;
            }
        }
        class Person2
        {
            public string name;
            public int age;
            
            public void PrintAge()
            {
                Console.WriteLine(this.age);
            }
            public void PrintName()
            {
                Console.WriteLine(this.name);
            }
        }
        class Student : Person2
        {
            public string school;
            public Student(string name, int age, string school) 
            {
                this.name = name;
                this.age = age;
                this.school = school;
            }
            public void PrintSchool()
            {
                Console.WriteLine(this.school);
            }
        }
    }
        
}