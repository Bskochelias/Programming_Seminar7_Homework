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

//Сортировка одномерного массива по возрастанию
int [] Poryadok_Stroki_1DMass(int [] arra1D)
{
  for(int i=0;i<arra1D.Length-1;i++)
    for(int j =0;j<arra1D.Length-i-1;j++)
      {
        if(arra1D[j]>arra1D[j+1])
          {int temp = arra1D[j];
          arra1D[j]=arra1D[j+1];
          arra1D[j+1]=temp;
          }
      }
  return arra1D;
}

//Сортировка двухмерного массива по возрастанию
int [,] Poryadok_Stroki_2DMass(int [,] arra2D)
{
  for(int i=0;i<arra2D.GetLength(0);i++)
    { 
      int [] arra1D = new int [arra2D.GetLength(1)]; 
      for(int j =0;j<arra2D.GetLength(1);j++)
      {arra1D[j] = arra2D[i,j];}
      arra1D = Poryadok_Stroki_1DMass (arra1D);
      for(int j =0;j<arra2D.GetLength(1);j++)
      {arra2D[i,j] = arra1D[j];}
    }
  return arra2D;
}

//Нахождения суммы элементов массива
int Min_Chislo_Mas(int [] arra1D)
{
    int sum=0;
    for(int i=0;i<arra1D.Length;i++)
      { sum+=arra1D[i];
      }
  return sum;
}

//Нахождения строку с наименьшей суммой элементов.
(int,int) Min_Sum_2DMass(int [,] arra2D)
{
  int index=0,sum=99999999;
  for(int i=0;i<arra2D.GetLength(0);i++)
    { 
      int [] arra1D = new int [arra2D.GetLength(1)]; 
      for(int j =0;j<arra2D.GetLength(1);j++)
      {arra1D[j] = arra2D[i,j];}
       
      if(sum > Min_Chislo_Mas(arra1D))
      {
        sum = Min_Chislo_Mas(arra1D);
        index = i;
      }
    }
  return (sum,index);
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

    if (otvet1 > 3 ^ otvet1 < 1)
    {
      Console.WriteLine("Такой задачи тут нету!");
      Console.Write("Нажмите <Enter> для повторго ввода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}      
    }

  } while (otvet1 > 3 ^ otvet1 < 1);

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

 // 2.Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
  if (otvet1==2)
  {
    int m = Proverca_chisla("Введите строки: ");
    int n = Proverca_chisla("Введите столбцы: ");
    int min = Proverca_chisla("Введите минмальное значения рандома: ");
    int max = Proverca_chisla("Введите максимальное значения рандома: ");

    int[,]arra = CreateMass(m,n,min,max);
    
    System.Console.WriteLine("Получился следующий случайный массив: ");
    PrintMas(arra);
    arra = Poryadok_Stroki_2DMass(arra);
    System.Console.WriteLine("После замены получился следующий случайный массив: ");
    PrintMas(arra);
  }

  //3. В прямоугольной матрице найти строку с наименьшей суммой элементов.
  if (otvet1==3)
  {
    int m = Proverca_chisla("Введите строки: ");
    int n = Proverca_chisla("Введите столбцы: ");
    int min = Proverca_chisla("Введите минмальное значения рандома: ");
    int max = Proverca_chisla("Введите максимальное значения рандома: ");

    int[,]arra = CreateMass(m,n,min,max);
    
    System.Console.WriteLine("Получился следующий случайный массив: ");
    PrintMas(arra);
    (int sum,int index) = Min_Sum_2DMass(arra); 

    System.Console.WriteLine($"{index+1} cтрока с наименьшей суммой элементов которая равна: {sum}");
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