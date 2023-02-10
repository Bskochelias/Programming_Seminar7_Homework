// Написать программу, которая обменивает элементы первой строки и последней строки
// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// В прямоугольной матрице найти строку с наименьшей суммой элементов.

//Функция ввода и проверка является ли числом
int Proverca_chisla(string text)
{ 
  System.Console.Write(text);
  int num;
  while (true)
    if (int.TryParse(Console.ReadLine(), out num))
        return num;                                                   // обработка при успехе и выход из цикла
    else                                                         // обработка при ошибке
    {
        Console.WriteLine("[ERROR]: Некоректные данные по пробуйте еще раз!");
        Console.Write("Введите число: ");
    }
}

//Создание двухмерного массива с случайными числами
int [,] CreateMass(int strok,int stolbetsov,int min,int max)
{
  int[,] arra = new int[strok,stolbetsov];
  for(int i=0;i<arra.GetLength(0);i++)
    for(int j =0;j<arra.GetLength(1);j++)
      arra[i,j] = new Random().Next(min,max);
  return arra;
}

//Печать двухмерного массива
void PrintMas(int [,]arra)
{
  for(int i=0;i<arra.GetLength(0);i++)
  {
    for(int j =0;j<arra.GetLength(1);j++)
    System.Console.Write($"{arra[i,j]} ");
  System.Console.WriteLine();
  }
}

//Замена первой и последней строки

int [,] Chain_first_last_Mass(int [,]arra)
{
    for(int j =0;j<arra.GetLength(1);j++)
      {int temp = arra[0,j];
      arra[0,j]= arra[arra.GetLength(0)-1,j];
      arra[arra.GetLength(0)-1,j] = temp;
      }
  return arra;
}

int otvet1 = 0;
string? otvet2;
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine("Добрый день прошу выбрать цифру из списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. Написать программу, которая обменивает элементы первой строки и последней строки.");
    Console.WriteLine("2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");
    Console.WriteLine("3. В прямоугольной матрице найти строку с наименьшей суммой элементов.");
    Console.WriteLine(" ");
    otvet1 = Proverca_chisla("Ваш ответ: ");

    if (otvet1 > 4 ^ otvet1 < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet1 > 4 ^ otvet1 < 1);

  Console.Clear();

  //Начало тела задач
  
  //1. Написать программу, которая обменивает элементы первой строки и последней строки.
  if (otvet1==1)
{
  int m = Proverca_chisla("Введите строки: ");
  int n = Proverca_chisla("Введите столбцы: ");
  int min = Proverca_chisla("Введите минмальное значения рандома: ");
  int max = Proverca_chisla("Введите максимальное значения рандома: ");

  int[,]arra = CreateMass(m,n,min,max);
  
  System.Console.WriteLine("Получился следующий случайный массив: ");
  PrintMas(arra);
  arra = Chain_first_last_Mass(arra);
  System.Console.WriteLine("После замены получился следующий случайный массив: ");
  PrintMas(arra);
}


  //Конец тела задач    
  Console.Write("Нажмите <Enter> для продолжения... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  do
  {
    Console.Clear();
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

    if (otvet2 != "No" && otvet2 != "no" && otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y")
    {
    Console.WriteLine("Некоректный ответ");
    Console.Write(" Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }
  }
  while (otvet2 != "No" && otvet2 != "no" & otvet2 != "NO" && otvet2 !="n" && otvet2 !="N" 
        && otvet2 != "Yes" && otvet2 != "yes" && otvet2 != "YES" && otvet2 !="y" && otvet2 !="Y");

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write("Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();