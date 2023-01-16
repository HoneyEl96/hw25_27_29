// Урок 4. Функции

// Семинар

// Задача 24: Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.

// Напишем метод сложения
// int Sum(int number) // имя метода всегда с заглавной буквы: Sum // и указывает тип который будет в методе
// {
// int sum = 0;
// for(int i = 1; i <= number; i++)
// {
// sum+=i;
// }
// return sum; // return - возвращение искомого значения из вспомогательного метода в основной код
// }

// начнем основной код который будет обращаться к функции выше 
// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(A); // записываем значение в переменную sum используя метод Sum и введенное с клавиатуры число А
// Console.WriteLine(sum);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// позже откомментирую решение для 26 задачи

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for(int i = 0; A != 0; i++) // != - не равно
// //while(A > 0)
// {
// A/=10; // == A = A /10;
// count++;
// }

// Console.WriteLine(count);
// Console.WriteLine("Enter number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// int b = numb.ToString().Length;
// Console.WriteLine(b);

// Console.WriteLine("Enter number: ");
// string number = Console.ReadLine();
// int count = 0;
// bool ok = int.TryParse(number, out int A);
// Console.WriteLine(ok);
// if(int.TryParse(number, out int A))
// {
// while(A > 0)
// {
// A/=10; // == A = A /10;
// count++;
// }
// Console.WriteLine(count);
// }
// else
// Console.WriteLine("Ошибка");
// string a = Console.ReadLine();
// if(int.TryParse(a, out int number)) {
// Console.WriteLine(a.Length);
// } else {
// Console.WriteLine("Ошибка");
// }

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// for (count = 0; A > 0; count++)
// {
// A /= 10;
// }
// Console.WriteLine(count);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// пишем метод
// int Sum(int number) // метод именуем в заглавной Sum и ставим в начало кода
// {
// int sum = 1; // отсчет с 1
// for(int i = 1; i <= number; i++) // счетчик
// {
// sum *= i; // sum = sum * i
// }
// return sum; // запрос за возврат, иначе функция не сработает
// }

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(A)); // выводим на экран число используя метод Sum от переменной А, которую ввели с клавиатуры

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // array(массив) [на 8 элементов]
// for(int i = 0; i < array.Length; i++) // счет начинается с нулевого элемента; пока i меньше длины массива
// {
// array[i] = new Random().Next(0,2);
// //Console.Write(array[i] + ", "); // даст разделители после каждого элемента, 1.0.0.1.0.1.
// }

// Console.WriteLine('[' + string.Join(", ", array) + ']'); // string.Join(", ", array) позволяет с первого по предпоследний элемент ставить знаки разделители(,. : / и тд)
// позволяет сделать красивую запись [1,0,1,1,0,1,0,0]

// Домашка: задания 25, 27, 29:
// Желательно написать методы и решить используя их.

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
// натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// пишем метод перемножения
// int Multiplicate(int number, int stepen) // А & В
// {
// int mpt = 1; // степени начинаются с 1 // mULTIpLICAtE - mpt
// for(int count = 1; count <= stepen; count++) // счетчик до В
// {
// mpt = mpt * number; // mpt *= number // 1 * А
// // int mpt = Math.Pow(int number, int stepen)
// }
// return mpt;
// }

// Как мне сделать метод более универсальным??

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число в которое надо возвести предыдущее число:");
// int stepen = Convert.ToInt32(Console.ReadLine());

// int multiplicate = Multiplicate(number, stepen); // вызываем способ по А и В, присваиваем mpt 
// Console.WriteLine(multiplicate); // выводим результат

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]