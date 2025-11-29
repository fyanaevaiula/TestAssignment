using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    class Manager : Person, IEmployee// производный класс "менеджер"
    {
        // все поля закрытые
        private string surname; // фамилия
        private string faculty; // факультет
        private string post; // должность
        private DateTime startDateOfWorkExperiencee; // дата начала трудового стажа
        private double salaryAmount; // размер оклада
        public Manager(string surname, DateTime birth, string faculty, string post, DateTime startDateOfWorkExperiencee, double salaryAmount) : base(birth)// конструктор с параметрами
        {
            this.surname = surname;
            this.faculty = faculty;
            this.post = post;
            this.startDateOfWorkExperiencee = startDateOfWorkExperiencee;
            this.salaryAmount = salaryAmount;
        }
        public Manager() // конструктор по умолчанию
        { }
        public double Wages(double salaryAmount) // расчет заработной платы сотрудника за месяц со страховыми отчислениями
        {
            return salaryAmount * 1.302;
        }
        public int GetAge(DateTime birth) // определение возраста
        {
            return base.GetAge(birth);
        }
        public int WorkExperience(DateTime startDateOfWorkExperiencee) // определение стажа
        {
            return DateTime.Today.Year - startDateOfWorkExperiencee.Year - 1 + ((DateTime.Today.Month > startDateOfWorkExperiencee.Month || DateTime.Today.Month == startDateOfWorkExperiencee.Month && DateTime.Today.Day >= startDateOfWorkExperiencee.Day) ? 1 : 0);
        }
        public void Turn()
        {
            Console.WriteLine("\nДанные менеджера: \nФамилия - {0} \nДата рождения - {1} \nФакультет - {2} \nДолжность - {3} \nДата начала трудового стажа - {4} \nРазмер оклада - {5}", surname, birth, faculty, post, startDateOfWorkExperiencee, salaryAmount);
            Console.WriteLine("Класс, моделирующий сущность");
            base.Show();
        }
    }
}
