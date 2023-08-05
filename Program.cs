using System;
using MyLibrary;


namespace NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            void Task63()
            // Задайте значения M и N. Напишите рекурсивный метод, 
            // который выведет все натуральные числа кратные 3-ём в промежутке от M до N
            {
                int M=MyLibraryClass.Input("Введите число М");
                int N=MyLibraryClass.Input("Введите число N");

                while (M<=N)
                {
                    if (M%3==0)
                    {
                        Console.Write($"{M}, ");
                    }
                    M++;
                }
            }
            // Task63();

            // void Recurtion63(int M, int N)
            // {
            //     if (M>N) return;
            //     if (M%3==0) Console.Write($"{M} ");
                
            //     Recurtion63(M+1, N);
            // }
            // int M=MyLibraryClass.Input("введите число M ");
            // int N=MyLibraryClass.Input("введите число N ");

            // Recurtion63(M, N);


            int Recurtion63_1(int M, int N, int result=0) // Хотела сделать с запоминанием результата, но не получается
            {
                if (M>N) return result;
                if (M%3==0) 
                {
                    result = M;
                    Console.Write($"{result} ");
                }

                return Recurtion63_1(M+1, N, result);
                
            }
            int M=MyLibraryClass.Input("введите число M ");
            int N=MyLibraryClass.Input("введите число N ");
            
            Console.Clear();
            // Recurtion63_1(M, N);


            int Recurtion66(int A, int B, int sum=0)
            // Задайте значения M и N. Напишите рекурсивный метод, 
            // который найдёт сумму натуральных элементов в промежутке от M до N.
            // Вместо M и N взяла A и B
            {
                if (A>B) return sum;
                sum=sum+A;
                A=A+1;
                return Recurtion66 (A, B, sum);
            }
            int A=MyLibraryClass.Input("введите число A ");
            int B=MyLibraryClass.Input("введите число B ");
            int sum = Recurtion66(A, B);
            Console.WriteLine($"{sum}");

            Console.Clear();
            // Recurtion66(A,B);

            
            double Recurtion68(double m, double n)
            // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n 
            {
                //если m=0 то А = n+1
                // если n=0 то A(m-1.1)
                // m и n >0 то A (m-1, A(m, n-1))


                // if (n<0 && m<0) Console.WriteLine ("Такой функции не существует"); // не получается вывести отрицательные значения
                
                if (m==0) // работает
                {
                    return n+1;
                }
                else
                    if (n==0 && m>0) 
                    {
                        return Recurtion68(m-1, 1); // работает
                    }
                else return Recurtion68 ((m-1), Recurtion68 (m, n-1)); // работает
                    
                // else Console.WriteLine("Такой функции не существует");
                return Recurtion68 (m,n);

            }
            double m=MyLibraryClass.Input("введите число m ");
            double n=MyLibraryClass.Input("введите число n ");

            Console.Clear();
            Console.WriteLine($"{Recurtion68(m,n)}");
            
        }
    }
}
