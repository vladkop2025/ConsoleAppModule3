using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.5. Ввод и вывод в консоль
            string MyName;
            //string MyName = "Jane" можно сразу задать значение
            MyName = "Jane";
            Console.WriteLine(MyName);
            const string MyName1 = "Jane1";
            //Объявление константы
            Console.WriteLine(MyName1);
            //Использование литералов
            Console.WriteLine("Привет, мир");
            Console.WriteLine("Мне 27 лет");
            Console.WriteLine("My name is Jane");
            /*
            \n — символ перевода строки на новую строку, \t — табуляция (отступ, больше пробела). 
            Если мы используем этот символ в литерале, 
            то он не будет восприниматься как часть текста, а преобразуется в нужный нам формат.
            */
            Console.WriteLine("\t Привет, мир");
            Console.WriteLine("Привет, \n мир");
            Console.WriteLine("\t Привет, \n \t мир");
            /*
            можно и так сделать
            Console.WriteLine("\t Привет, \t мир");
            */
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is Jane");
            //перевод строки на новую строку
            Console.WriteLine("\t Привет,");
            Console.WriteLine("\t мир");
            /*
            Кроме строковых есть также символьные литералы , они обозначаются в одинарных кавычках. 
            Прежде всего это единичные символы — отдельные буквы и цифры, но чаще всего используются символы служебные, 
            например, управляющие символы, которые мы уже рассмотрели. 
            Несмотря на то, что они состоят из двух знаков (например, \t), они являются одним символьным литералом.
            Чаще всего используются символьные литералы для обозначения символов таблицы Unicode или же ASII.
            Например, можно отобразить вот такой знак: @
             */
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine('\u0040');
            //вывод символа #  - Для удобства можно запомнить символ переноса строки \n.
            Console.WriteLine('\x23');
            //логические литералы. Их всего два: true и false
            Console.WriteLine(true);
            Console.WriteLine(false);
            //Также литералами являются цифры, которые мы можем ввести с клавиатуры. 
            Console.WriteLine(5);
            /*
            Также можно записывать цифры в другой системе счисления — двоичной и шестнадцатеричной— и использовать вещественные цифры 
            (это цифры типа 8.9, 54.87 и т.п. ) Обратите внимание, что их мы пишем в коде программы через точку:
            */
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);
            /*
             И отдельно от всех стоит литерал null — он представляет ссылку, которая не указывает ни на какой объект. Что такое ссылки, 
            объекты и так далее мы рассмотрим позднее. Сейчас же можно просто запомнить, что есть такой литерал, он означает отсутствие значения.
            */
            Console.ReadKey();
        }
    }
}
