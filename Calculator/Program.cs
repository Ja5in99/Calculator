using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Calculator
    {
        public static void Main()
        {
            List<string> Calculations = new List<string>();
            string op;
            double result;
            bool restart = true;
            Console.WriteLine("Välkommen till en fantastisk miniräknare.");
            while (restart)
            {

                Console.WriteLine("Skriv ett tal");
                string num1 = Console.ReadLine();
                double number1;

                bool containsLetter = Regex.IsMatch(num1, @"\d+"); 
                while (containsLetter == true)
                {
                    restart = false;


                    double.TryParse(num1, out number1);
                

                    Console.WriteLine("Vilken operatör");
                    Console.WriteLine("Välj mellan + , - , / , * ");
                    op = Console.ReadLine();
                    bool containsop = Regex.IsMatch(op, "[-, +  /,  *, ]");
                    while (containsop == false)
                    {
                        Console.WriteLine("Skriv en ny operatör");
                        op = Console.ReadLine();
                        bool containsoptest = Regex.IsMatch(op, "[-, +,  /,  *,   ]");
                        if (containsoptest == true)
                        {
                            containsop = true;
                        }
                    }
                    

                    Console.WriteLine("Skriv ett till tal");
                    string num2 = Console.ReadLine();
                    string uppernum2 = num2.ToUpper(); 
                    double value;

                    bool containsnum2 = Regex.IsMatch(uppernum2, @"\d+"); 

                    if (double.TryParse(uppernum2, out value)) 
                        {
                            while (value == 0 && op == "/")
                            {
                                Console.WriteLine("Skriv in ett annat tal");
                                value = Convert.ToDouble(Console.ReadLine());
                            }
                        while (containsnum2 == true)
                        {
                            if (op == "+")
                            {
                                result = number1 + value;
                                Console.WriteLine("Svar " + result);
                                Convert.ToString(result);
                                Calculations.Add(number1 + "+" + value + "=" + result);
                                restart = false;
                                break;

                            }
                            else if (op == "-")
                            {
                                result = number1 - value;
                                Console.WriteLine("Svar " + result);
                                Calculations.Add(number1 + "-" + value + "=" + result);
                                Convert.ToString(result);
                                restart = false;
                                break;
                            }
                            else if (op == "*")
                            {
                                result = number1 * value;
                                Console.WriteLine("Svar " + result);
                                Calculations.Add(number1 + "*" + value + "=" + result);
                                Convert.ToString(result);
                                restart = false;
                                break;

                            }
                            else if (op == "/")
                            {
                                result = number1 / value;
                                Console.WriteLine("Svar " + result);
                                Calculations.Add(number1 + "/" + value + "=" + result);
                                Convert.ToString(result);
                                restart = false;
                                break;

                            }
                        }
                        }
                        else if (uppernum2 == "MARCUS")
                        {
                            Console.WriteLine("Hej!");
                            restart = false;
                            break;

                            
                        }
                        string r;
                        string upperr;
                        Console.WriteLine("Do you wanna go again?");
                        Console.WriteLine("Enter Y for yes, H for history and anything else for no");
                        r = Console.ReadLine();
                        upperr = r.ToUpper();



                        if (upperr == "Y")
                        {
                            restart = true;
                            break;
                        }
                        else if (upperr == "H")
                        {
                            Calculations.ForEach(Console.WriteLine);
                            break;
                        }
                        else
                        {
                            restart = false;
                            break;
                        }
                }

            }
        }
    }
}
