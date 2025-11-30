using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestAssignment
{
    class Teacher : Person, IEmployee // производный класс "преподаватель"
    {
        // все поля закрытые
        private string surname; // фамилия
        private string faculty; // факультет
        private string post; // должность
        private DateTime startDateOfWorkExperiencee; // дата начала трудового стажа
        private double salaryAmount; // размер оклада
        public Teacher(string surname, DateTime birth, string faculty, string post, DateTime startDateOfWorkExperiencee, double salaryAmount) : base(birth)// конструктор с параметрами
        {
            this.surname = surname;
            this.faculty = faculty;
            this.post = post;
            this.startDateOfWorkExperiencee = startDateOfWorkExperiencee;
            this.salaryAmount = salaryAmount;
        }
        public Teacher() // конструктор по умолчанию
        { }
        public double Wages(double salaryAmount) // расчет заработной платы сотрудника за месяц со страховыми отчислениями
        {
            return salaryAmount * 1.302;
        }
        // определение возраста - метод базового класса не переопределяется, поэтому
        // для определения возраста используется метод базового класса Person.GetAge()
        public int WorkExperience(DateTime startDateOfWorkExperiencee) // определение стажа
        {
            return DateTime.Today.Year - startDateOfWorkExperiencee.Year - 1 + ((DateTime.Today.Month > startDateOfWorkExperiencee.Month || DateTime.Today.Month == startDateOfWorkExperiencee.Month && DateTime.Today.Day >= startDateOfWorkExperiencee.Day) ? 1 : 0);
        }
        public void Turn()
        {
            Console.WriteLine("\nДанные преподавателя: \nФамилия - {0} \nДата рождения - {1} \nФакультет - {2} \nДолжность - {3} \nДата начала трудового стажа - {4} \nРазмер оклада - {5}", surname, birth, faculty, post, startDateOfWorkExperiencee, salaryAmount);
            Console.WriteLine("Класс, моделирующий сущность");
            base.Show();
        }
    }
}
