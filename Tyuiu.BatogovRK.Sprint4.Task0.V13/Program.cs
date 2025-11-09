using Tyuiu.BatogovRK.Sprint4.Task0.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнил: Батогов Р.К.  | АСОиУБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Батогов Роман Константинович | АСОиУБ-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает сумму четных элементов массива *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

        Console.Write("Исходный массив: { "); for (int i = 0; i < array.Length; i++)
        {
            if (i < 9)
            {
                Console.Write(array[i] + ", ");
            }
            else
            {
                Console.Write(array[i] + " ");
            }
        }
        Console.WriteLine("}");
        Console.WriteLine(); Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *"); 
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма чётных элементов массива = " + ds.GetSumEvenArrEl(array));
        Console.ReadKey();
    }
}