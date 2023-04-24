// // Задача 34 Задайте массив, заполненныйслучайными 3-значными числами.
// //Определите сколько в массиве четных чисел.
// Console.WriteLine("Введите, сколько будет элементов в массиве");
// int n=Convert.ToInt32(Console.ReadLine());

// int[] numArr=new int[n];
// int res=0;
// for (int i=0; i<n; i++)
// {
// numArr[i]=new Random().Next(99,1000);
// Console.WriteLine("элемент номер " +i +" " +numArr[i]);
// if(numArr[i]%2==0)
//   {
//   res++;
//   }
// }
// Console.WriteLine("Количество ченых: " +res);
////////////////////////////////////////////////
// // Задача 36 Задайте массив-строку, найдите сумму всех элементов на нечетных позициях

// Console.WriteLine("Введите, сколько будет элементов в массиве");
// int n=Convert.ToInt32(Console.ReadLine());

// int[] numArr=new int[n];
// int res=0;
// for (int i=0; i<n; i++)
// {
// numArr[i]=new Random().Next(-500,501);
// Console.WriteLine("элемент номер " +i +" " +numArr[i]);
// if(i%2!=0)
//   {
//   res=res+numArr[i];
//   }
// }
// Console.WriteLine("Сумма нечетных: " +res);

////////////////////////////////////////////////
// // Задача 38 Задайте массив веществ. чисел. Надите разницу между макс и мин элементами массива

// Console.WriteLine("Введите, сколько будет элементов в массиве:");
// int n=Convert.ToInt32(Console.ReadLine());

// double[] Arr=new double[n];
// double res=0;
// for (int i=0; i<n; i++)
// {
//     Random rnd=new Random();
//     double temp=rnd.NextDouble() *1000-500;
//     Arr[i]=temp;
//     Console.WriteLine("элемент номер " +i +" " +Arr[i]);
// }

// res=Arr.Max()-Arr.Min();
// Console.WriteLine("Разница между макс и мин элементами вещественного массива: " +res);

////////////////////////////////////////////////
// // Задача 33 Программа проверяет, есть ли числа в заданном массиве

//  int[] numArr=new int[] {1,7898,66,-6,-52,-6,0};
//  Console.WriteLine("Рассматриваемый массив " +String.Join(",",numArr));

// Console.WriteLine("Введите число, которое будем искать в массиве");
// int num=Convert.ToInt32(Console.ReadLine());

//   for (int i=0; i<numArr.Length; i++)
// {
//  if (numArr[i]==num)
//  {
//     Console.WriteLine("Число найдено на позиции " +i);
//  }
//  else 
//  {
//   Console.WriteLine("Искомое число на позиции " +i +" не найдено!");
//  }
// }
 
