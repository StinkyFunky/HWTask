using System;

namespace ConsoleApp
{
    class Program
    {
        static void FirstTask()
        {
            Console.Write("Введите первое число: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}  {1}  {2}", first,second,third);
            Console.ReadLine();
        }
        static void SecondTask()
        {
            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 21;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.ReadLine();
        }
        static void ThirdTask()
        {
            Console.Write("Введите расстояние в сантиметрах: ");
            int DistanceInSm = int.Parse(Console.ReadLine());
            int DistanceInMeter = DistanceInSm / 100;
            Console.WriteLine("Полных метров: {0}", DistanceInMeter);
            Console.ReadLine();
        }
        static void FourthTask()
        {
            int days = 234;
            int weeks = days / 7;
            Console.WriteLine("Прошло полных недель: {0}", weeks);
            Console.ReadLine();
        }
        static void FifthTask()
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());
            int sum = (number / 10) + (number % 10);
            int product = (number / 10) * (number % 10);
            int numberOfUnits = number % 10;
            int numberOfTens = (number / 10) % 10;
            Console.WriteLine("Сумма его чисел: {0}", sum);
            Console.WriteLine("Произведение чисел: {0}", product);
            Console.WriteLine("Число десяткa(-ов): {0}", numberOfTens);
            Console.WriteLine("Число едениц(-a): {0}", numberOfUnits);
            Console.ReadLine();
        }
        static void SixthTask()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
            Console.ReadLine();
        }
        static void SeventhTask()
        {
            Console.Write("Введите радиус: ");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата: ");
            int side = int.Parse(Console.ReadLine());
            double CircleSquare = Math.PI * (R * R);
            int QuadrateSquare = side * side;
            if (CircleSquare > QuadrateSquare)
            {
                Console.WriteLine("Площадь круга больше.");
                Console.ReadLine();
            }
            else if (CircleSquare < QuadrateSquare) 
            {
                Console.WriteLine("Площадь квадрата больше.");
                Console.ReadLine();
            }
        }
        static void EighthTask()
        {
            Console.Write("Введите массу первого вещества: ");
            int firstMass = int.Parse(Console.ReadLine());
            Console.Write("Введите объём первого вещества: ");
            int firstVolume = int.Parse(Console.ReadLine());
            Console.Write("Введите массу второго вещества: ");
            int secondMass = int.Parse(Console.ReadLine());
            Console.Write("Введите объём второго вещества: ");
            int secondVolume = int.Parse(Console.ReadLine());
            int pFirst = firstMass / firstVolume;
            int pSecond = secondMass / secondVolume;
            if (pFirst > pSecond)
            {
                Console.WriteLine("Плотность первого вещества больше.");
                Console.ReadLine();
            }
            else if (pFirst < pSecond)
            {
                Console.WriteLine("Плотность второго вещества больше.");
                Console.ReadLine();
            }
        }
        static void NinthTask() 
        {
            Console.Write("Введите сопротивление первого участка электрической цепи: ");
            int firstR = int.Parse(Console.ReadLine());
            Console.Write("Введите напряжение первого участка электрической цепи: ");
            int firstU = int.Parse(Console.ReadLine());
            Console.Write("Введите сопротивление второго участка электрической цепи: ");
            int secondR = int.Parse(Console.ReadLine());
            Console.Write("Введите напряжение второго участка электрической цепи: ");
            int secondU = int.Parse(Console.ReadLine());
            int firstI = firstU / firstR;
            int secondI = secondU / secondR;
            if (firstI > secondI)
            {
                Console.WriteLine("На втором участе меньший ток.");
                Console.ReadLine();
            }
            else if (firstI < secondI)
            {
                Console.WriteLine("На первом участе меньший ток.");
                Console.ReadLine();
            }
        }
        static void TenthTask()
        {
            int numberStart = 20;
            int numberToEnd = 35;
            for (int i = numberStart; i < numberToEnd; i++)
            {
                Console.Write(i);
                Console.ReadLine();
            }

            int a = 10;
            Console.Write("Введите число больше 10: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i < b; i++)
            {
                Console.Write((i * i));
                Console.ReadLine();
            }

            int end = 50;
            Console.Write("Введите число меньше 50: ");
            int start = int.Parse(Console.ReadLine());
            for (int i = start; i < end; i++)
            {
                Console.Write((i * i * i));
                Console.ReadLine();
            }

            Console.Write("Введите начало дипазона: ");
            int fromNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите конец дипазона: ");
            int beforeNumber = int.Parse(Console.ReadLine());
            for (int i = fromNumber; i < beforeNumber; i++)
            {
                Console.Write(i);
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
            FourthTask();
            FifthTask();
            SixthTask();
            SeventhTask();
            EighthTask();
            NinthTask();
            TenthTask();
        }
    }
}

