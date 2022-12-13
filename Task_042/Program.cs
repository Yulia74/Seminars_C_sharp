// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
//  3 -> 11
//  2 -> 10

Console.Write("Enter the integer number: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

int digits = GetNumberOfDigits(number);

int[] array = GetArray(digits);

PrintArray(array);



if(!isParsed)                                     // метод, проверяющий корректность
{                                                 // введенного значения
    Console.WriteLine("Incorrect number");
    return;
}

int GetNumberOfDigits(int number)                   // метод, определяеющий количество 
{                                                   // разрядов в числе, чтобы определить
  int digits = 0;                                   // размер массива
    while (number > 0)
  {
    number /= 2;
    digits ++;
  }
 return digits;
}

int[] GetArray(int digits)                 // метод, создающий массив с найденным размером
{
    int length = digits;      
    int[] array = new int[length];        
    for (int i = length-1; i >= 0 ; i--)   // заполняем массив с конца
    {
        array[i] = number % 2;             // находим бином
        number = number / 2;
    }
    return array;
}


 void PrintArray(int[] array)              //метод, выводит массив на экран
{
       Console.WriteLine(@"Binom of the enter number [{0}]", string.Join("", array)); 
}                                          // задаем конструкцию, как это будет выглядеть на экране
