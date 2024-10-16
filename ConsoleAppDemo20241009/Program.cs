using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo20241009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1-1
            //int a, b, c, d;
            //double z;
            //Console.WriteLine("請輸入a:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入b:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入c:");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入d:");
            //d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"a={a},b={b},c={c},d={d}");

            //z = (a + b) * 2.0 / (c + d);

            //Console.WriteLine($"z:{z}");
            //Console.ReadKey();

            ////1-2
            //Console.WriteLine("假設有一組二元一次方程式如下：a1x+b1y=c1  ，  a2x+b2y=c2");
            //int a1, a2, b1, b2, c1, c2;
            //double x, y;

            //Console.WriteLine("請輸入a1:");
            //a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入b1:");
            //b1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入c1:");
            //c1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入a2:");
            //a2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入b2:");
            //b2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入c2:");
            //c2 = Convert.ToInt32(Console.ReadLine());

            //x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
            //y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);
            //Console.WriteLine($"x={x},y={y}");
            //Console.ReadKey();

            ////1-3
            //double a, b;
            //double y;
            //Console.WriteLine("請輸入a:");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入b:");
            //b = Convert.ToDouble(Console.ReadLine());
            //y = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
            //Console.WriteLine($"y={y}");
            //Console.ReadKey();

            ////1-4
            //double a, b,c;
            //double y;
            //Console.WriteLine("請輸入a:");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入b:");
            //b = Convert.ToDouble(Console.ReadLine());
            //c = (Math.Pow(a, 2) + Math.Pow(b, 2)) ;
            //y = Math.Sqrt(c);
            //Console.WriteLine($"y={y}");
            //Console.ReadKey();

            ////1-5
            //double a, b, c;
            //double y;
            //Console.WriteLine("請輸入a:");
            //a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入b:");
            //b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入c:");
            //c = Convert.ToDouble(Console.ReadLine());
            //y = a - (b + c)*(3*a - c);

            //Console.WriteLine($"y={y}");
            //Console.ReadKey();

            ////1-6
            //double a;

            //Console.WriteLine("請隨意輸入正負數:");
            //a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"y={Math.Abs(a)}");
            //Console.ReadKey();

            ////1-7
            //int a;
            //Console.WriteLine("請輸入西元年份:");
            //try
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //    if (a>=1911)
            //    {
            //        Console.WriteLine($"民國年份:{a - 1911}");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        Console.WriteLine("請重新輸入有效西元年份");
            //        Console.ReadKey();
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("請重新輸入有效西元年份");
            //    Console.ReadKey();
            //}

            ////1-8
            //double w, h;
            //Console.WriteLine("請輸入身高:");
            //h = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入體重:");
            //w = Convert.ToDouble(Console.ReadLine());
            //h = h / 100;
            //Console.WriteLine($"BMI:{Math.Round(w / h / h, 1, MidpointRounding.AwayFromZero)}");
            //Console.ReadKey();

            ////2-1
            //int x, y, z;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"x={x},y={y}");
            //if (x>=y)
            //{
            //    z = x;
            //}
            //else
            //{
            //    z = y;
            //}
            //Console.WriteLine($"z={z}");
            //Console.ReadKey();

            ////2-2
            //int x, y, z;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"x={x},y={y}");
            //if (x > 0 && y > 0)
            //{
            //    z = 1;
            //}else if (x < 0 && y < 0)
            //{
            //    z = -1;
            //}
            //else
            //{
            //    z = 0;
            //}
            //Console.WriteLine($"z={z}");
            //Console.ReadKey();
            ////2-3
            //int x, y, u, v, z;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入u:");
            //u = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入v:");
            //v = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"x={x},y={y},u={u},v={v}");
            //if ((x + y) > (u + v))
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}
            //Console.WriteLine($"z={z}");
            //Console.ReadKey();

            ////2-4
            //int x, y, u, v, z;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入u:");
            //u = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入v:");
            //v = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"x={x},y={y},u={u},v={v}");
            //if ((x + y) >= 2*(u + v))
            //{
            //    z = x + y;
            //}
            //else
            //{
            //    z = u + v;
            //}
            //Console.WriteLine($"z={z}");
            //Console.ReadKey();

            ////2-5
            //double x, y, z;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"x={x},y={y}");
            //if (x > y)
            //{
            //    z = Math.Pow(x, 2);
            //}
            //else
            //{
            //    z = Math.Pow(y, 2);
            //}
            //Console.WriteLine($"z={z}");
            //Console.ReadKey();

            ////2-6
            //int income,  difference;
            //double rat,tax;
            //Console.WriteLine("請輸入income:");
            //income = Convert.ToInt32(Console.ReadLine());

            //if(income> 4090000)
            //{
            //    rat = 0.4;
            //    difference = 721100;
            //}else if (income > 2180000)
            //{
            //    rat = 0.3;
            //    difference = 312100;
            //}
            //else if (income > 1090000)
            //{
            //    rat = 0.21;
            //    difference = 115900;
            //}
            //else if (income > 410000)
            //{
            //    rat = 0.13;
            //    difference = 28700;
            //}
            //else
            //{
            //    rat = 0.06;
            //    difference = 0;
            //}
            //tax = (income * rat) - difference;
            //Console.WriteLine($"tax={tax}");
            //Console.ReadKey();
            ////2-7
            //int x, y;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"x={x},y={y}");
            //if (x > 0)
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("1st quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("4th quadrant\n");
            //    }
            //}
            //else if (x == 0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Origin\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Y-axis\n");
            //    }
            //}
            //else
            //{

            //    if (y > 0)
            //    {
            //        Console.WriteLine("2nd quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3th quadrant\n");
            //    }
            //}
            //Console.ReadKey();

            ////補充習題1
            //int x, score;
            //Console.WriteLine("請輸入答對題數:");
            //x=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"答對題數:{x}");
            //if (x <= 10)
            //{
            //    score = x * 6;
            //}
            //else if (x <= 20)
            //{
            //    score = 60 + (x - 10) * 2;
            //}else if (x <= 40)
            //{
            //    score = 80 + (x - 20) * 1;
            //}
            //else
            //{
            //    score = 100;
            //}
            //Console.WriteLine($"分數:{score}");
            //Console.ReadKey();

            ////補充習題2
            //double w, h, BMI;
            //string answer;
            //Console.WriteLine("請輸入身高:");
            //h = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入體重:");
            //w = Convert.ToDouble(Console.ReadLine());
            //h = h / 100;
            //BMI= Math.Round(w / h / h, 1, MidpointRounding.AwayFromZero);
            //    if (BMI<18.5)
            //    {
            //        answer = "過輕";
            //    }
            //    else if (BMI < 24)
            //    {
            //        answer = "健康體重"; 
            //    }
            //    else if (BMI < 27)
            //    {
            //        answer = "過重";
            //    }
            //    else
            //    {
            //        answer = "肥胖";
            //    }
            //Console.WriteLine($"BMI:{BMI},{answer}");
            //Console.ReadKey();

            ////補充習題3
            //int x, y, z;
            //Console.WriteLine("請輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入z:");
            //z = Convert.ToInt32(Console.ReadLine());
            //if (x != y && x!= z && y!=z)
            //{
            //    if (x > y)
            //    {
            //        if (x < z)
            //        {
            //            Console.WriteLine($"z={z},x={x},y={y}");
            //        }
            //        else if (y > z)
            //        {
            //            Console.WriteLine($"x={x},y={y},z={z}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"x={x},z={z},y={y}");
            //        }
            //    }
            //    else
            //    {
            //        if (y < z)
            //        {
            //            Console.WriteLine($"z={z},y={y},x={x}");
            //        }
            //        else if (x > z)
            //        {
            //            Console.WriteLine($"y={y},x={x},z={z}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"y={y},z={z},x={x}");
            //        }
            //    }
            //}
            //else if (x == y && x != z)
            //{
            //    if (x > z)
            //    {
            //        Console.WriteLine($"x={x},y={y},z={z}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"z={z},x={x},y={y}");
            //    }
            //}else if (x == z && x != y)
            //{
            //    if (x > y)
            //    {
            //        Console.WriteLine($"x={x},z={z},y={y}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"y={y},x={x},z={z}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"x={x},y={y},z={z}");
            //}

            //Console.ReadKey();

            ////補充習題4
            //int profit;
            //double bonus;
            //Console.WriteLine("請輸入利潤:");
            //profit = Convert.ToInt32(Console.ReadLine());
            //if (profit <= 100000)
            //{
            //    bonus = profit * 0.1;
            //}else if (profit<=200000)
            //{
            //    bonus = 10000 + (profit - 100000) * 0.075;
            //}
            //else if (profit <= 400000)
            //{
            //    bonus = 17500 + (profit - 200000) * 0.05;
            //}else if (profit <= 600000)
            //{
            //    bonus= 27500 + (profit - 400000) * 0.03;
            //}else if (profit <= 1000000)
            //{
            //    bonus = 33500 + (profit - 600000) * 0.015;
            //}
            //else
            //{
            //    bonus = 39500 + (profit - 1000000) * 0.01;
            //}
            //Console.WriteLine($"利潤:{profit},獎金{bonus}");
            //Console.ReadKey();

            //使用switch改寫
            int score;
            string level;
            Console.WriteLine("請輸入學生成績");
            score = Convert.ToInt32(Console.ReadLine());
            score = score / 10;
            switch (score)
            {
                case 10:
                    level = "A";
                    break;
                case 9:
                    level = "A";
                    break;
                case 8:
                    level = "B";
                    break;
                case 7:
                    level = "C";
                    break;
                case 6:
                    level = "D";
                    break;
                default: level = "F";
                    break;
            }
            Console.WriteLine($"分數級別:{level}");
            Console.ReadKey();

        }
    }
}
