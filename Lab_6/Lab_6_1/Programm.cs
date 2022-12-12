using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Programm
    {
        static void Main(string[] args)
        {
            Human pers1 = new Human("Belous", 2002, "Student");
            Human pers2 = new Human("Bondarchuk", 2002, "Student");
            Human pers3 = new Human("Laptev", 1997, "Teacher");

            Comparer comp = new Comparer();
            Human[] arr = new[] {pers1, pers2, pers3}; 

            //сортировка по году рождения
            for(int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Human tempPers;
                    if (arr[i].CompareTo(arr[i + 1]) >= 0)
                    {
                       tempPers = arr[i];
                       arr[i] = arr[i + 1];
                       arr[i + 1] = tempPers;
                     }
                }
            }

            //сортировка по фамилии
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Human tempPers;
                    if (comp.Compare(arr[i], arr[i +1]) >= 0)
                    {
                        tempPers = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tempPers;
                    }
                }
            }

            //вывод информации
            foreach (Human i in arr)
            {
                i.Info();
            }

            Console.Read();
        }
    }
}
