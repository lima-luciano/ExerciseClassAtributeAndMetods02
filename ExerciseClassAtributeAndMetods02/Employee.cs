using System;
using System.Globalization;

namespace ExerciseClassAtributeAndMetods02
{
    class Employee
    {
        public string Name;
        public double Salary;
        public double Tax;

        public double TotalValueAfterTheft()
        {
            return Salary - Tax;
        } 
        
        public void IncreaseSalary(double salary)
        {
            Salary += Salary *10 / 100;
        }

        public override string ToString()
        {
            return "Employee: " + Name + ", Will receive: R$ " + TotalValueAfterTheft().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
