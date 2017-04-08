namespace _03.Match_Tickets
{
using System;
    class Program
    {
        static void Main()
        {
            double biudjet = double.Parse(Console.ReadLine());
            string categoria = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            if (categoria == "VIP")
            {
                if (n >= 1 && n <= 4)
                {
                    double razhod = biudjet * 0.75;
                    double bileti = 499.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }


                else if (n >= 5 && n <= 9)
                {
                    double razhod = biudjet * 0.6;
                    double bileti = 499.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }


                else if (n >= 10 && n <= 24)
                {
                    double razhod = biudjet * 0.5;
                    double bileti = 499.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }


                else if (n >= 25 && n <= 49)
                {
                    double razhod = biudjet * 0.4;
                    double bileti = 499.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }



                else if (n >= 50)
                {
                    double razhod = biudjet * 0.25;
                    double bileti = 499.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }
            }




            if (categoria == "Normal")
            {
                if (n >= 1 && n <= 4)
                {
                    double razhod = biudjet * 0.75;
                    double bileti = 249.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }


                else if (n >= 5 && n <= 9)
                {
                    double razhod = biudjet * 0.6;
                    double bileti = 249.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }


                else if (n >= 10 && n <= 24)
                {
                    double razhod = biudjet * 0.5;
                    double bileti = 249.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }


                else if (n >= 25 && n <= 49)
                {
                    double razhod = biudjet * 0.4;
                    double bileti = 249.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }



                else if (n >= 50)
                {
                    double razhod = biudjet * 0.25;
                    double bileti = 249.99 * n;
                    double result = razhod + bileti;
                    if (biudjet >= result)
                    {
                        double ostava = biudjet - result;
                        Console.WriteLine("Yes! You have {0:F2} leva left.", ostava);
                    }
                    else if (biudjet < result)
                    {
                        double ostava = result - biudjet;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", ostava);
                    }
                }
            }
        }
    }
}
