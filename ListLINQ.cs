using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IQBALNAFIS
{
    internal class ListLINQ
    {
        List<int> number = new List<int>() { 1, 12, 25, 3, 5, 7, 9, 2, 4, 8, 10 };
        List<string> names = new List<string>() { "iqbal", "nafis","asd" };
        public void UsingWhereCondition()
        {
            var results = number.Where(n => n == 12 || n == 7);
            Console.WriteLine("\n" + string.Join(",", results));
        }

        public void Sort()
        {
            var asc = number.ToList().OrderBy(n => n);
            var dec = number.ToList().OrderByDescending(n => n);

            Console.WriteLine("asc : " + string.Join(",", asc));
            Console.WriteLine("asc : " + string.Join(",", dec));
        }

        public void Sum()
        {
            var resultSum = number.Sum();
            Console.WriteLine("sum number : " + string.Join(",", resultSum));
        }
        public void GetFirst()
        {
            var resultFirst = number.First();
            Console.WriteLine("first number : " + string.Join(",", resultFirst));
        }

        public void CetakNama()
        {
            var namaNama = names;
            Console.WriteLine("nama nama : " + string.Join(", ",namaNama));
        }

       
    }
}
