using System;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogrami = int.Parse(Console.ReadLine());
            string typeOfDograma = Console.ReadLine();
            string deliveryType = Console.ReadLine();
            double sum = 0;

            if (numberOfDogrami < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            switch (typeOfDograma)
            {
                case "90X130":
                    sum = numberOfDogrami * 110;
                    if (numberOfDogrami > 30 && numberOfDogrami < 60)
                    {
                        sum = sum - (sum * 0.05);
                    }
                    else if (numberOfDogrami > 60)
                    {
                        sum = sum - (sum * 0.08);
                    }
                    break;

                case "100X150":
                    sum = numberOfDogrami * 140;
                    if (numberOfDogrami > 40 && numberOfDogrami < 80)
                    {
                        sum = sum - (sum * 0.06);
                    }
                    else if (numberOfDogrami > 80)
                    {
                        sum = sum - (sum * 0.10);
                    }
                    break;

                case "130X180":
                    sum = numberOfDogrami * 190;
                    if (numberOfDogrami > 20 && numberOfDogrami < 50)
                    {
                        sum = sum - (sum * 0.07);
                    }
                    else if (numberOfDogrami > 50)
                    {
                        sum = sum - (sum * 0.12);
                    }
                    break;

                case "200X300":
                    sum = numberOfDogrami * 250;
                    if (numberOfDogrami > 25 && numberOfDogrami < 50)
                    {
                        sum = sum - (sum * 0.09);
                    }
                    else if (numberOfDogrami > 50)
                    {
                        sum = sum - (sum * 0.14);
                    }
                    break;

            }

            if (deliveryType == "With delivery")
            {
                sum += 60;
            }

            if (numberOfDogrami > 99)
            {
                sum = sum - (sum * 0.04);
            }

            Console.WriteLine($"{sum:f2} BGN");
        }
    }
}
