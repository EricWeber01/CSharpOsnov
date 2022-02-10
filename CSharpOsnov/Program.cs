using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOsnov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 1");
                        Console.WriteLine("Определить наименьший множитель заданного целого числа.");
                        Console.WriteLine("\n");
                        Console.Write("Введите целое число ==> ");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 2; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                Console.WriteLine("Наименьший множитель ==> {0}", i);
                                break;
                            }
                        }
                    }
                    break;
                case '2':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 2");
                        Console.WriteLine("Начальный вклад в банке равен 1000 руб. Через ");
                        Console.WriteLine("каждый месяц размер вклада увеличивается на P процентов ");
                        Console.WriteLine("от имеющейся суммы. По данному P определить, через сколько ");
                        Console.WriteLine("месяцев размер вклада превысит 1100 руб., и вывести найденное ");
                        Console.WriteLine("количество месяцев K и итоговый размер вклада S.");
                        Console.WriteLine("\n");
                        int S = 1000;
                        int K = 0;
                        Console.Write("Введите проценты ==> ");
                        int P = int.Parse(Console.ReadLine());
                        while (S != 1100)
                        {
                            S = S * (P / 100 + 1);
                            K++;
                        }
                        Console.WriteLine("Количество месяцев ==> {0}", K);
                        Console.WriteLine("Конечный размер вклада ==> {0}", S);
                    }
                    break;
                case '3':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 3");
                        Console.WriteLine("Задать пользователю 3 вопроса, в каждом вопросе ");
                        Console.WriteLine("по 3 варианта ответа. За каждый правильный ответ начисляется 2 ");
                        Console.WriteLine("балла. После вопросов выведите пользователю количество набранных ");
                        Console.WriteLine("баллов.");
                        Console.WriteLine("\n");
                        string[] q = new string[12] {"А. Я играл в доту?","1)Да","2)Нет","3)Ты дурак?","Б. Apple?", "1)Нормальная тема", "2)Для таких как Артур", "3)Не для всех", "В. Меркотан", "1)Фашист", "2)Еврей", "3)Абобус" };
                        int[] answ = new int[3] { 3, 1, 2 };
                        int a, iter = 0, score = 0;
                        for (int i = 0; i < q.Length; i += 4)
                        {
                            Console.Write("\n{0}\n{1}\n{2}\n{3}\nВведи ответ ==> ", q[i], q[i + 1], q[i + 2], q[i + 3]);
                            a = int.Parse(Console.ReadLine());
                            if (a == answ[iter])
                                score += 2;
                            iter++;
                        }
                        Console.WriteLine("Ну и как ты умудрился собрать {0} очков?.", score);
                    }
                    break;
                case '4':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 4");
                        Console.WriteLine("Запросить у пользователя число и на сколько цифр ");
                        Console.WriteLine("его сдвинуть. Сдвинуть цифры числа и вывести результат (если число ");
                        Console.WriteLine("123456 сдвинуть на 2 цифры, то получится 345612).");
                        Console.WriteLine("\n");
                        Console.Write("\nВведите число ==> ");
                        string str = Console.ReadLine();
                        Console.Write("\nВведите на сколько цифр ==> ");
                        int iter = int.Parse(Console.ReadLine());
                        string tmp = str.Substring(0, iter);
                        str = str.Remove(0, iter);
                        str += tmp;
                        Console.WriteLine("Результат ==> {0}", str);
                    }
                    break;
                case '5':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 5");
                        Console.WriteLine("Зациклить вывод дней недели таким образом: «День ");
                        Console.WriteLine("недели. Хотите увидеть следующий день?» и так до тех пор, пока ");
                        Console.WriteLine("пользователь нажимает OK.");
                        Console.WriteLine("\n");
                        string[] days = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг","Пятница", "Суббота", "Воскресенье" };
                        int a, iter = 0;
                        do
                        {
                            Console.Write("{0}.Хотите увидеть следующий день?\nДа ==> 0\nНет ==> 1\nВведите ответ ==> ", days[iter]);
                            a = int.Parse(Console.ReadLine());
                            if (iter == 6)
                                iter = 0;
                            else
                                iter++;
                        } while (a != 1);
                    }
                    break;
                case '6':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 6");
                        Console.WriteLine("Игра «Угадай число». Предложить пользователю ");
                        Console.WriteLine("загадать число от 0 до 100 и отгадать его следующим способом: ");
                        Console.WriteLine("каждую итерацию цикла делите диапазон чисел пополам, записываете ");
                        Console.WriteLine("результат в N и спрашиваете у пользователя «Ваше число > N, < N или ");
                        Console.WriteLine("== N?». В зависимости от того что указал пользователь, уменьшаете ");
                        Console.WriteLine("диапазон. Начальный диапазон от 0 до 100, поделили пополам и ");
                        Console.WriteLine("получили 50. Если пользователь указал, что его число > 50, то");
                        Console.WriteLine("изменили диапазон на от 51 до 100. И так до тех пор, пока ");
                        Console.WriteLine("пользователь не выберет == N.");
                        Console.WriteLine("\n");
                        int avg = 50, half = 25, choose;
                        do
                        {
                            Console.Write("Выйти ==> 0\nБольше ==> 1 {0}\nМеньше ==> 2 {0}\nВведите ответ ==> ", avg);
                            choose = int.Parse(Console.ReadLine());
                            if (choose == 1)
                            {
                                avg = avg + half;
                            }
                            else if (choose == 2)
                            {
                                avg = avg - half;
                            }
                            if (avg > 100 || avg < 1)
                            {
                                Console.WriteLine("Братик это ошибка");
                                break;
                            }
                            half = half / 2 + 1;
                        } while (choose != 0);
                    }
                    break;
            }
        }
    }
}