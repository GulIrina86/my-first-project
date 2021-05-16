using System;
using System.Collections.Generic;

namespace FirstConsoleApplitation
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> myList = new List<Employee>();
            myList.Add(new Employee(0, "Ira", "Gulevich", 0));
            myList.Add(new Employee(4, "Ira", "Gulevich", 0));
            myList.Add(new Employee(5, "Ira", "Gulevich", 2));
            myList.Add(new Employee(6, "Ira", "Gulevich", 4));
            myList.Add(new Employee(6, "Ira", "Gulevich", 5));

            foreach (var el in myList)
            {
                Console.WriteLine("Имя=" + el.Name + "\r\n Фамилия=" + el.Surname +  "\r\n Стаж работы=" + el.SkillLevel + "\r\n Уровень квалификации=" + el._workExperience + "\r\n Процент бонусов = " + el.getBonusPercent());

              
                Console.WriteLine("");
            }





        }
    }
}