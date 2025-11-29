using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    class Student : Person, IEmployee//  производный класс "студент"
    {
        // все поля закрытые
        private string surname; // фамилия
        private string faculty; // факультет
        private string group; // группа
        private double averageScore; // средняя оценка
        public Student(string surname, DateTime birth, string faculty, string group, double averageScore) : base(birth) // конструтор с параметрами
        {
            this.surname = surname;
            this.faculty = faculty;
            this.group = group;
            this.averageScore = averageScore;
        }
        public Student() // конструктор по умолчанию
        { }
        public int Scholarship(double averageScore, out int answer) // расчет стипендии
        {
            if (4.5 <= averageScore && averageScore <= 5)
            {
                answer = 10000;
            }
            else if (3.5 <= averageScore && averageScore < 4.5)
            {
                answer = 5000;
            }
            else
            {
                answer = 0;
            } 
                return answer;
        }
        public override int GetAge(DateTime birth) // определение возраста
        {
            return base.GetAge(birth);
        }
        public void PrintStudent()
        {
            Console.WriteLine("\nДанные студента: \nФамилия - {0} \nДата рождения - {1} \nФакультет - {2} \nГруппа - {3} \nСредняя оценка - {4}", surname, birth, faculty, group, averageScore);
        }
        public void Turn()
        {
            Console.WriteLine("Класс, моделирующий сущность");
            base.Show();
        }
    }
}
