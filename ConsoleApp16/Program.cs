using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> Is = new List<int>();
            //Is.Add(34);
            //Is.Add(12);
            //Is.Add(25);
            //foreach (int aPart in Is)
            //{
            //    Console.WriteLine(aPart);
            //}
            //var people = new List<string>() {"Tom", "Bob", "Nike" };
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}
            //people.Clear();
            //var range = people.GetRange(1, 1);
            //Console.WriteLine (range);
            //string[] partOfPeople = new string[3];
            //people.CopyTo(0, partOfPeople, 0, 3);
            //var mike = new KeyValuePair<int, string>(56, "Mike");
            //var employees = new List<KeyValuePair<int, string>>() { mike };
            var dic = new Dictionary<int, string>       //(employees)
            {
                [1] = "СЛ",
                [2] = "ЗЛ",
                [3] = "АПЛ",
                [4] = "ФЛ",
                [5] = "КЛ",
                [6] = "КРЛ",
                [7] = "ТКЛ",
                [8] = "КСЛ",
                [9] = "СТЛ",
                [10] = "ЛДЛ",
                [11] = "БКЛ",
                [12] = "БЛ",
                [13] = "Монорельс",
                [14] = "МЦК",
                [15] = "НЛ"
            };
            string tkl = dic[7];  // Sam
            Console.WriteLine(tkl);
            //foreach (var viv in dic)
            //{
            //    Console.WriteLine($"key: {dic.Key}  value: {dic.Value}");
            //}

            Console.WriteLine("Цвет - 1; Название линии - 2");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Введите цвет линии: ");
            }
            else
            {
                Console.WriteLine("Введите Название линии: ");
                //Console.WriteLine(dic[Console.ReadLine]);
            }
        }
    }
}
