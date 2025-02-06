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
            /*3.7. Преобразования типов
                        C# имеет строгое соответствие типов друг другу, у него есть методы, как из одного типа сделать другой. 
                        Есть два пути преобразований: явное преобразование и неявное.
                        Сначала стоит обсудить явное — это когда мы задаём типам, как превратиться друг в друга. Это преобразование называется 
                        explicit conversion — «принудительное» преобразование
                        Оно указывается следующим образом: (тип) переменная_другого типа
                            int olddata = 6; 
                            byte data = (byte)olddata;  //int в byte - то называется приведением типов
                        */

            /*
            Что касательно числовых типов, то преобразования бывают расширяющие и сужающие. В данный момент мы применили сужающее преобразование: 
            тип int больше типа byte, и область памяти на переменную должна сузиться. Это может привести к потере данных. 
            Расширяющее преобразование работает по обратному принципу: мы переводим переменную с меньшим диапазоном в больший, 
            что не может привести к потере данных.
            Чем больше тип, тем меньше у него безопасных преобразований.
            */

            /*у каждого объекта C# есть метод ToString(), и наша переменная типа int не является исключением
            То есть это внутреннее преобразование int к string, оно вызывается именно методом ToString(). Но даже 
            если мы укажем для вывода на экран переменную int без преобразования, ошибки не будет
            Методы Write и WriteLine вызывают метод ToString для всех значений, которые в них попадают. Но при этом неявно этот метод не вызывается.
            string data = (byte)olddata;  выдаст ошибку
            */

            /*Метод Convert и позволяет конвертировать значения разных типов и на каждый имеется свой алгоритм.
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your age is {0} ", age);
                Console.ReadKey();
            если вы введете с клавиатуры вместо, допустим, "45" другое значение, например "45 лет" программа завершится с ошибкой преобразования типов данных.
            */

            /*Кроме преобразования с помощью методов Convert, есть методы Parse и TryParse у системных типов данных
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Your age is {0} ", age);
                Console.ReadKey();
            */

            /*
            И если Parse работает по принципу метода Convert — при наличии ошибки он возвращает эту ошибку и не производит дальнейших операций — 
            то TryParse возвращает булевское значение в зависимости от того, было ли преобразование удачным. После этого его можно обработать. 
                Console.Write("Enter your age: ");
                int age;
                bool iscorrect = int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine("Your age is {0} ", age);
                Console.ReadKey();
            При неправилном  воде в переменной age в этом случае будет значение по умолчанию — 0. Об обработках исключений мы поговорим в других модулях
            */

            /*Итак, продолжим общение с компьютером. Пусть получит краткую справку о нас:
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                Console.ReadKey();
            */

            /*Сейчас возраст мы вводим в переменную типа int.Это слишком много, почему бы не привести её к byte?
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                byte age = (byte)int.Parse(Console.ReadLine());
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                Console.ReadKey();
            */

            /* Но что произойдет, если какой-нибудь долгожитель введет значение 256 ? Данные успешно преобразуются в формат int из строки, но что будет с byte?
            выведет 0 - при конвертации int в byte происходит урезание, сжатие
            Для работы с подобными случаями есть служебное слово checked. Оно помогает проверить, возможно ли преобразование без потери данных.
            при превышении генерится ошибка на уровне исполнения - об обработке ошибок мы ещё поговорим позже
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                byte age = checked((byte)int.Parse(Console.ReadLine()));
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                Console.ReadKey();
                
                Console.Write("What is your favorite day of week");
                DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
                Console.WriteLine("Your favorite day is {0}", day);
                Console.ReadKey();
            */

            /*Но всегда ли нам нужно преобразование типов в явном виде?
            В начале мы поговорим про неявное преобразование — implicit conversion
            В случае когда наш целевой тип данных больше, чем тот, из которого мы хотим преобразовать, эту операцию 
            может выполнить сам язык, нам не требуется делать ничего.
            На уровне работы с памятью, естественно, происходит процесс расширения, но с нашей стороны мы просто работаем с результатом.
                byte age = checked((byte)int.Parse(Console.ReadLine()));
                int intage = age;
                Console.WriteLine("Your name is {0} and age is {1} ", age, intage);
            */

            /*
            Также мы можем использовать приём неявной типизации. В этом случае нам не нужно определять тип переменной, но нужно 
            её инициализировать. В приложениях, в которых мы используем не только простые операции, неявная типизация позволяет 
            немного упростить работу — не всегда мы знаем, какой точно тип нам придёт из того или иного метода, и не всегда это имеет значение.
            Не говоря уже о том, что это иногда спасает от внесения изменений в остальные элементы программы, если изменилось где-то 
            в одном месте. Но это мы рассмотрим позже
            Вместо типа переменной мы указываем служебное слово var. Неявная типизации требует от нас сразу иницализировать нашу переменную
            числовые литералы по умолчанию имеют тип int в случае целых чисел, а тип double — в случае вещественны
                var age = checked((byte)int.Parse(Console.ReadLine()));
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                Console.Write("What is your favorite day of week? ");
                var day = (DayOfWeek)int.Parse(Console.ReadLine());
                Console.WriteLine("Your favorite day is {0}", day);

                var age = 65;
                var name = "Vlad";
                var howItall = 162;
                var myshoe = 37.5;
                Console.WriteLine("Your name is {0} and age is {1} ", name, age);
                Console.WriteLine("What is my grouth? {0} sm", howItall);
                Console.WriteLine("What is my shoe size? {0}", myshoe);
            */
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.Write("Введите день рождения в формате ДД.ММ.ГГГГ:");
            var birthdate = Console.ReadLine();
            Console.Write("Ваш день рождения {0}", birthdate);
        }
    }
}
