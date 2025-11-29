using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    class Administrator : Person, IEmployee // производный класс "администратор"
    {
        // все поля закрытые
        private string surname; // фамилия
        private string laboratory; // лаборатория
        private string post; // должность
        private DateTime startDateOfWorkExperiencee; // дата начала трудового стажа
        private double salaryAmount; // размер оклада
        public Administrator(string surname, DateTime birth, string laboratory, string post, DateTime startDateOfWorkExperiencee, double salaryAmount) : base(birth)// конструктор с параметрами
        {
            this.surname = surname;
            this.laboratory = laboratory;
            this.post = post;
            this.startDateOfWorkExperiencee = startDateOfWorkExperiencee;
            this.salaryAmount = salaryAmount;
        }
        public Administrator() // конструктор по умолчанию
        { }
        public double Wages(double salaryAmount) // расчет заработной платы сотрудника за месяц со страховыми отчислениями
        {
            return salaryAmount * 1.302;
        }
        public int GetAge(DateTime birth) // переопределение метода класса-родителя - определение возраста
        {
            return base.GetAge(birth);
        }
        public int WorkExperience(DateTime startDateOfWorkExperiencee) // определение стажа
        {
            return DateTime.Today.Year - startDateOfWorkExperiencee.Year - 1 + ((DateTime.Today.Month > startDateOfWorkExperiencee.Month || DateTime.Today.Month == startDateOfWorkExperiencee.Month && DateTime.Today.Day >= startDateOfWorkExperiencee.Day) ? 1 : 0);
        }
        public void Turn()
        {
            Console.WriteLine("\nДанные администратора: \nФамилия - {0} \nДата рождения - {1} \nЛаборатория - {2} \nДолжность - {3} \nДата начала трудового стажа - {4} \nРазмер оклада - {5}", surname, birth, laboratory, post, startDateOfWorkExperiencee, salaryAmount);
            Console.WriteLine("Класс, моделирующий сущность");
            base.Show();
        }
    }
}
