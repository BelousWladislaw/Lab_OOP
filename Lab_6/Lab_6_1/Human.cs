using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Human : IComparable
    {
        private String lastName;
        private int yearOfBirth;
        private String status;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Human(String newLName, int newYear, String newStatus)
        {
            lastName = newLName;
            yearOfBirth = newYear;
            status = newStatus;
        }
        public Human()
        {
            lastName = "not defined";
            yearOfBirth = 0;
            status = "not defined";
        }

        public virtual int Info()
        {
            Console.WriteLine($"last name: {LastName}");
            Console.WriteLine($"year of birth: {yearOfBirth}");
            return 0;
        }

        public void showParametrs()
        {
            Console.WriteLine($"last name: {lastName}");
            this.Info();
            Console.WriteLine($"status: {status}");
        }

        public int CompareTo(object obj)
        {
            if (obj is Human human)
            {
                return yearOfBirth.CompareTo(human.yearOfBirth);
            }
            else if (obj is null)
            {
                throw new ArgumentNullException("Cannot compare to a null value");
            }
            else
            {
                throw new ArithmeticException("Cannot compare to a value with a mismatching type");
            }
        }
    }
}
