﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Здравствуй, {name} {last_name}. Твой возраст: {age}");
            int new_age = int.Parse(age);
            if (new_age >= 18)
                Console.WriteLine("Вы уже совершеннолетний");
            else
                Console.WriteLine("Вы несовершеннолетний");
            Console.ReadLine();
        }
    }
}
