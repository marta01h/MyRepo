﻿using System;

Console.WriteLine("1.Угадай число");
Console.WriteLine("2.Таблица умножения");
Console.WriteLine("3.Вывод делителей числа");
Console.WriteLine("4.Закрыть программу");
int i = 1;
    while (i < 9)
    {
        Console.WriteLine("Выберете одно из действий: ");
        int d = Convert.ToInt32(Console.ReadLine());

        if (d == 1)

        {
            Random rand = new Random();
            int a = rand.Next(10);
            int count = 1;
            Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгодать его за три попытки.");
            Console.WriteLine("Введите первое число:");
            int k = Convert.ToInt32(Console.ReadLine());
            while (count <= 3)
            {
                if (a == k)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }

        else if (d == 2)
        {
            Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int b = 1; b < 10; b++)
            {
                Console.Write(b + "   |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + b * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        else if (d == 3)
        {
            Console.Write("Введите число: ");
            int c = int.Parse(Console.ReadLine());
            for (int a = 1; a <= c; a++)
            {
                if (c % a == 0) Console.Write("{0} ", a);
            }
        }

        else if (d == 4)
        {
            Environment.Exit(0);
        }
    }