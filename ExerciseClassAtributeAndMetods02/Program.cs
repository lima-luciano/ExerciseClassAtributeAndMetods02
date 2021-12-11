using System;
using System.Globalization;

namespace ExerciseClassAtributeAndMetods02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee f1 = new Employee(); 

            Console.Write("Type your name: ");
            f1.Name = Console.ReadLine();
            Console.Write("groos salary: ");
            f1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            f1.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write(f1);
            Console.WriteLine();

            Console.Write("Type porcentage to increase the salary: ");
            double inc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.IncreaseSalary(inc);

            Console.Write("Update data: " + f1);

        }
    }
}
