// Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] array = GenerateArray(-5,5,10);               //7  вызываем метод с параметрами (какие хотим)
                                                    //   получаем здесь массив
PrintArray(array);                                 //10  вызываем метод по печатанию заданного массива

Console.Write("Enter the integer number: ");       //11 просим пользователя ввести число

bool isParsed = int.TryParse(Console.ReadLine(), out int number); //13 вызываем метод, проверяющий введенное число на корректность

bool result = FindNumber(array, number);            //15 вызываем метод, находящий введенное число в массиве

Console.WriteLine($"{number} - find number in array. It`s {result}");  //16 выводим на печать результат (истина, ложь)




int[] GenerateArray(int min, int max, int length)   //1  метод, созадющий массив, принимает на вход
{                                                   //   минимальное, максимальное значение и размер массива
    Random random = new Random();                   //4  создаем объект Рандом
    int[] array = new int [length];                 //2  создаем массив с целыми числами, с заданным  
                                                    //   пользователем размером
    for (var i = 0; i < array.Length; i++)          //3  проходимся циклом по массиву
    {
        array[i] = random.Next(min, max + 1);       //5  обращаемся к массиву по индексу и вызываем в нем метод
    }
    return array;                                   //6 возвращаем массив
} 

void PrintArray(int[] array)                        //8 объявляем метод, который выводит массив на экран (принимает на вход массив)
{
     Console.WriteLine(@"[{0}]", string.Join(",", array)); //9 задаем конструкцию, как это будет выглядеть на экране
}    
                                                                
if(!isParsed)                                        //12 метод, который принимает введенное число и проверяет
{                                                    // его на корректность
    Console.WriteLine("Incorrect number");           // если это не число, то возвращает возвращает нам
    return;
}

bool FindNumber(int[] array, int number)            //14 метод, находящий заданное число в массиве
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
}


// КУСОК КОДА - НАХОДЯЩИЙ КОЛИЧЕСТВО НАХОЖДЕНИЙ ИСКОМОГО ЧИСЛА В МАССИВЕ
// Console.WriteLine("Введите искомое число ");
// int necessaryNumber = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < size; i++)
// 	{
// 		if(array[i] == necessaryNumber)
// 		{
// 			count++;
// 		}
// 	}
// if (count > 0) 
// 	{
// 	Console.WriteLine($"Это число найдено в количестве: {count}");
// 	}
// else
// {
// 	Console.WriteLine("Чисел нет");
// }