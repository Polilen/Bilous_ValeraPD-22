using System;

namespace sr
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new Cars();
            bool exist = true;

            string color;
            int yearOfMade = 0;
            int price = 0;
            int enginePower = 0;

            byte amount = 0;
            string tempForInput;

            
            Console.WriteLine("Добрый день , привествую вас в магазине Polilen");
            Console.WriteLine("Хотите ли вы выбирать магину по параметрам?");
            Console.WriteLine("{Yes(Да, хочу), No(Нет, не хочу , хочу увидеть все варианты)}");
            Console.Write("Введите Yes или No: ");
            tempForInput = Console.ReadLine();

            if (tempForInput == "Yes")
            {
                while (exist)
                {
                    amount = 0;
                    color = null;
                    tempForInput = null;

                    Console.WriteLine();
                    Console.WriteLine("Вы можете вибрать себе машину по таких параметрах");
                    Console.Write("{Цвет(");
                    Console.Write("На английском");
                    Console.Write("), Год производства, Цена и Мощьность двигателя} \n");
                    Console.Write("Если ви хотите пропустить какую-то характеристику введите - \n\n");

                    Console.Write("Введите цвет авто: ");
                    color = Console.ReadLine();
                    if (color == "-")
                        amount++;

                    Console.Write("Введите год производства: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else yearOfMade = Convert.ToInt32(tempForInput);

                    Console.Write("Введите желаемую цену: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else price = Convert.ToInt32(tempForInput);
                    Console.Write("Введите желаемую мощьность двигателя: ");
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else enginePower = Convert.ToInt32(tempForInput);

                    cars.findCar(amount, color, yearOfMade, price, enginePower);
                    Console.WriteLine("\nМне не нравлятся эти машины , хочу сделать выбрать еще раз! ");
                    Console.WriteLine("{Yes, No(Виход из программи)}");
                    Console.Write("Введите Yes или No: ");
                    tempForInput = Console.ReadLine();
                    exist = tempForInput == "Yes" ? true : false;
                }
            }
            else
            {
                cars.showInfoAboutCars();
                Console.WriteLine();
                exist = false;
            }

        }
    }
}