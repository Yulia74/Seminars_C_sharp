// Напишите программу, которая будеть выдавать название дня
// недели по заданному номеру: 3 -> среда, 5 -> пятница 

int n = int.Parse(Console.ReadLine());

if(n == 6 && n == 7) Console.WriteLine("Выходные"); 
else if(n < 1 && n > 7) Console.WriteLine("Неправильно ввели число");
else Concole.Write.Line("That day is not exits"):
