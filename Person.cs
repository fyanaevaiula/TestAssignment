using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment
{
    abstract class Person// абстрактный класс
    {
        protected DateTime birth;// Член класса будет виден в наследниках
        public Person(DateTime birth)// конструктор с параметрами
        {
            this.birth = birth;
        }
        public Person() // конструктор по умолчанию
        { }
        public virtual int GetAge(DateTime birth) // метод, который может быть по-разному реализован в потомках - определение возраста
        {
           return DateTime.Today.Year - birth.Year - 1 + ((DateTime.Today.Month > birth.Month || DateTime.Today.Month == birth.Month && DateTime.Today.Day >= birth.Day) ? 1 : 0);
        }
        public virtual void Show()
        {
            Console.WriteLine("Иерархия классов учебного центра");
        }
    }
}
