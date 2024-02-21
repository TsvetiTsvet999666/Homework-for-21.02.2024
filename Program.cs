using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_InputOtput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Декларирам масив от 13 елемента
            double[] grades = new double[13];// { 1,2,3,4};
            string[] names = new string[13] { "Lubo", "Milen", "Mihail", "Rado", "Svetlo", "Siana", "Silviq", "Stanislav", "Tedo", "Hristian", "Hristomir", "Tsvetelina", "Tsvetina" };  
            // Въвеждат се елементите от клавиатурата - цикъл
            for (int index = 0; index <= grades.Length;index++)
            {
                Console.WriteLine($"{index+14}. {names[index]} е ==>{grades[index]} ");
                grades[index] = double.Parse(Console.ReadLine());
            }
            // Обработка 
            grades[9] = 6;
            names[8] = "Tedo";
            grades[11] = Math.Ceiling(5.234);
            Console.WriteLine($"{names[1]}'s ");
            // Отпечатване на резултатите
        }
    }
}
