using System;
using System.Dynamic;

namespace Practic04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Кол-во студентов");
            int Kol = Convert.ToInt32(Console.ReadLine());

            TablStudents(Kol);
            
        }
        static void TablStudents(int Kol)
        {
            object[][,] Tabl = new object[Kol][,];

            string SubjectName; int ball; int subjects;

            for (int i = 0; i < Kol; i++)
            {
                Console.WriteLine("Введите имя студента");
                string name = Console.ReadLine();
                Console.WriteLine("Введите кол-во предметов");
                subjects = Convert.ToInt32(Console.ReadLine());

                Tabl[i] = new object[subjects + 1, 2];

                for (int j = 1; j <= subjects; j++)
                {
                    Console.WriteLine($"Введите {j}-й предмет");
                    SubjectName = Console.ReadLine();
                    Tabl[i][j, 0] = SubjectName;
                    Console.WriteLine("Введите балл");
                    ball = Convert.ToInt32(Console.ReadLine());
                    Tabl[i][j, 1] = ball;

                    
                }
                Tabl[i][0, 0] = name;

                SredneeArif(Tabl, subjects, i, name);
            }

            
        }

        public static void SredneeArif(object[][,] Tabl, int subjects, int p, string name)
        {
            int[] Balls = new int[subjects];

            for (int i = 1; i <= subjects; i++)
            {
                Balls[i-1] = Convert.ToInt32(Tabl[p][i, 1]);
            }

            int sredn=0;

            for (int i = 0; i < Balls.Length; i++)
            {
                sredn += Balls[i];
            }

            sredn = sredn / Balls.Length;

            Last(sredn, name);
        }

        public static void Last(int sredn, string name)
        {
            Console.Clear();

            Console.WriteLine($"У студента с именем {name} среднее арифмитическое по всем баллам {sredn}");
        }
    }
}
