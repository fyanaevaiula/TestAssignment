using System;
using System.ComponentModel.Design;

namespace TestAssignment
{
    class Program
    {
        static void Main()
        {
            string s = "Иванов";
            DateTime b = DateTime.Parse("3 Jan 2007 00:00:00");
            string f = "ФИРТ";
            string g = "ИС123";
            double a = 3.56;
            Student st = new Student(s, b, f, g, a); // передача элементов конструктору
            st.Turn();
            int area0 = st.Scholarship(a);
            Console.WriteLine("Стипендия студента в месяц, руб. = " + area0);
            int area1 = st.GetAge(b);
            Console.WriteLine("Возраст студента: " + area1);
            
            string s1 = "Петров";
            DateTime b1 = DateTime.Parse("19 Jan 1968 00:00:00");
            string f1 = "ФИРТ";
            string p1 = "доцент";
            DateTime sd1 = DateTime.Parse("1 Jan 1990 00:00:00");
            double sa1 = 80000.0;
            Teacher ta = new Teacher(s1, b1, f1, p1, sd1, sa1); // передача элементов конструктору
            ta.Turn();
            double area2 = ta.Wages(sa1);
            Console.WriteLine("Заработная плата преподавателя в месяц, руб. = " + area2);
            int area3 = ta.GetAge(b1);
            Console.WriteLine("Возраст преподавателя: " + area3);
            int area4 = ta.WorkExperience(sd1);
            Console.WriteLine("Трудовой стаж преподавателя: " + area4);
               
            string s2 = "Сидоров";
            DateTime b2 = DateTime.Parse("07 Jan 1969 00:00:00");
            string f2 = "ФИРТ";
            string p2 = "менеджер";
            DateTime sd2 = DateTime.Parse("9 Jan 1991 00:00:00");
            double sa2 = 50000.0;
            Manager ma = new Manager(s2, b2, f2, p2, sd2, sa2); // передача элементов конструктору
            ma.Turn();
            double area5 = ma.Wages(sa2);
            Console.WriteLine("Заработная плата менеджера в месяц, руб. = " + area5);
            int area6 = ma.GetAge(b2);
            Console.WriteLine("Возраст менеджера: " + area6);
            int area7 = ma.WorkExperience(sd2);
            Console.WriteLine("Трудовой стаж менеджера: " + area7);
        
            string s3 = "Козлов";
            DateTime b3 = DateTime.Parse("08 Jan 1995 00:00:00");
            string f3 = "лаборатория";
            string p3 = "администратор";
            DateTime sd3 = DateTime.Parse("9 Jan 2018 00:00:00"); ;
            double sa3 = 45000.0;
            Administrator mg = new Administrator(s3, b3, f3, p3, sd3, sa3); // передача элементов конструктору
            mg.Turn();
            double area8 = mg.Wages(sa3);
            Console.WriteLine("Заработная плата администратора в месяц, руб. = " + area8);
            int area9 = mg.GetAge(b3);
            Console.WriteLine("Возраст администратора: " + area9);
            int area10 = mg.WorkExperience(sd3);
            Console.WriteLine("Трудовой стаж администратора: " + area10);
        }
    }
}
