using System;

//Пользователь вводит данные о работнике, программа выводит эти данные в структурированном виде.

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Введите имя, фамилию, возраст, опыт работы и язык программирования работника: ");
            employee.Name = Context.name;
            employee.Surname = Context.surname;
            employee.Age = Context.age;
            employee.workExperience = Context.exp;
            employee.programLanguage = Context.lang;
            Console.Write($"\r\nИмя: {employee.Name}\r\nФамилия: {employee.Surname} \r\nВозраст: {employee.Age} \r\nОпыт работы: {employee.workExperience} \r\nЯзык программирования: {employee.programLanguage}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }

    class Context
    {
        public static string name = Console.ReadLine();
        public static string surname = Console.ReadLine();

        public static string age_input = Console.ReadLine();
        public static byte age = Convert.ToByte(age_input);

        public static string exp_input = Console.ReadLine();
        public static byte exp = Convert.ToByte(exp_input);

        public static string lang = Console.ReadLine();

    }

    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public byte workExperience { get; set; }
        public string programLanguage { get; set; }
    }


}
