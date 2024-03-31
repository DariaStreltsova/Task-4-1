using System;
using System.Diagnostics.Contracts;

namespace Task_4_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ёмкость массива");
            int n = int.Parse(Console.ReadLine());
            OneDimensionalArray<int> IntArray = new OneDimensionalArray<int>(n);
            Console.WriteLine("Введите количество элементов массива");
            int len = int.Parse(Console.ReadLine());
            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите int элемент");
                IntArray.Add(int.Parse(Console.ReadLine()));
            }
            IntArray.Print();
            Console.WriteLine();


            Console.WriteLine("Введите элемент, который нужно удалить");
            int p = int.Parse(Console.ReadLine());
            IntArray.Remove(p);
            IntArray.Print();
            Console.WriteLine();


            Console.WriteLine("Отсортированный массив");
            IntArray.Sort();
            IntArray.Print();
            Console.WriteLine();


            Console.WriteLine("Перевернутый массив");
            IntArray.Reverse();
            IntArray.Print();
            Console.WriteLine();


            Console.WriteLine("Введите элемент, который нужно проверить на наличие");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Есть ли элемент в массиве");
            Console.WriteLine(IntArray.ElInAr(t));


            Console.WriteLine("Первый элемент, который подходит под условие");
            Console.WriteLine(IntArray.TheFirstElementWithCond(x => x < 7));


            Console.WriteLine("Количество элементов, подходящих под условие");
            Console.WriteLine(IntArray.CountOfElementsWithCond(x => x < 7));


            Console.WriteLine("Есть ли элемент, подходящий под условие");
            Console.WriteLine(IntArray.ELInArCond(x => x < 7));


            Console.WriteLine("Подходят ли все элементы под условие");
            Console.WriteLine(IntArray.IsElementsWithCond(x => x < 7));
           
            Console.WriteLine("MAX:" + IntArray.Max());
            Console.WriteLine("MIN:" + IntArray.Min());


            Console.WriteLine("Ёмкость:" + IntArray.Capacity());
            Console.WriteLine("Ддина:" + IntArray.Elements());


            OneDimensionalArray<string> StrArray = new OneDimensionalArray<string>(n);
            for(int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите string элемент");
                StrArray.Add(Console.ReadLine());
            }

            StrArray.Print();
            Console.WriteLine();

            Console.WriteLine("Введите элемент, который нужно удалить");
            string s = Console.ReadLine();
            StrArray.Remove(s);
            StrArray.Print();
            Console.WriteLine();

            Console.WriteLine("Отсортированный массив");
            StrArray.Sort();
            StrArray.Print();
            Console.WriteLine();

            Console.WriteLine("Перевернутый массив");
            StrArray.Reverse();
            StrArray.Print();
            Console.WriteLine();

            StrArray.ElementsAfterIndex(1, 3);
            Console.WriteLine();

            Console.WriteLine("Введите элемент, который нужно проверить на наличие");
            string l = Console.ReadLine();
            Console.WriteLine("Есть ли элемент в массиве");
            Console.WriteLine(StrArray.ElInAr(l));

            Console.WriteLine("Первый элемент, который подходит под условие");
            Console.WriteLine(StrArray.TheFirstElementWithCond(x => x.Length > 3));

            Console.WriteLine("Количество элементов, подходящих под условие");
            Console.WriteLine(StrArray.CountOfElementsWithCond(x => x.Length > 3));

            Console.WriteLine("Есть ли элемент, подходящий под условие");
            Console.WriteLine(StrArray.ELInArCond(x => x.Length > 3));

            Console.WriteLine("Подходят ли все элементы под условие");
            Console.WriteLine(StrArray.IsElementsWithCond(x => x.Length > 3));
            
            Console.WriteLine("MAX:" + StrArray.Max());
            Console.WriteLine("MIN:" + StrArray.Min());

            Console.WriteLine("Ёмкость:" + StrArray.Capacity());
            Console.WriteLine("Ддина:" + StrArray.Elements());
        }
    }
}
