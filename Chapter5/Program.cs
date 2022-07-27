Console.WriteLine("3. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.");
            int number1;
            int number2;
            int number3;
            int biggest = int.MinValue;

            Console.WriteLine("Enter 3 integers:");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);
            int.TryParse(Console.ReadLine(), out number3);

            //It isn't the most elegant form, but the problem question says to use nested ifs so...
            if (number2 > number1 || number3 > number1)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("Biggest: {0}", number2);
                } else
                {
                    Console.WriteLine("Biggest: {0}", number3);
                }
                }
                 else
                {
                Console.WriteLine("Biggest: {0}", number1);
                }

            float number1;
            float number2;
            float number3; 
            float aux;
            

            Console.WriteLine("Enter 3 real numbers: ");
            float.TryParse(Console.ReadLine(), out number1);
            float.TryParse(Console.ReadLine(), out number2);
            float.TryParse(Console.ReadLine(), out number3);

            if (number1 < number2 && number1 < number3)
            {
                aux = number1;
                number1 = number3;
                number3 = aux;

                if (number1 < number2)
                {
                    aux = number1;
                    number1 = number2;
                    number2 = aux;
                }

            } else if (number2 < number1 && number2 < number3)
            {
                aux = number2;
                number2 = number3;
                number3 = aux;

                if (number1 < number2)
                {
                    aux = number1;
                    number1 = number2;
                    number2 = aux;
                }
            }
            else 
            {
                if (number1 < number2)
                {
                    aux = number1;
                    number1 = number2;
                    number2 = aux;
                }
            }

            Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);



                Console.WriteLine("..........................6..............................................................................")
            int a;
            int b;
            int c;
            double d;

            Console.WriteLine("Enter the coeficients a, b and c for a quadratic equation (ax2 + bx + c):");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            d = Math.Pow(b, 2) - 4 * a * c;

            if (d == 0)
            {
                Console.WriteLine("Discriminant = 0, one real root: {0}.", -b / (2 * a));
            } else if (d < 0)
            {
                Console.WriteLine("Discriminant is negative, no real roots.");
            } else //d > 0
            {
                Console.WriteLine("Discriminant is positive, two real roots {0} and {1}.", 
                    (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a),
                    (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a));
            }

Console.WriteLine("7. Write a program that finds the greatest of given 5 numbers.");
            int num1;
            int num2;
            int num3;
            int number4;
            int number5;   

            Console.WriteLine("Enter 5 integers: ");
            int.TryParse(Console.ReadLine(), out number1);
            int.TryParse(Console.ReadLine(), out number2);
            int.TryParse(Console.ReadLine(), out number3);
            int.TryParse(Console.ReadLine(), out number4);
            int.TryParse(Console.ReadLine(), out number5);

            int greatest = number1;
              
            if (greatest < number2)
            {
                greatest = number2;
            }

            if (greatest < number3)
            {
                greatest = number3;
            }

            if (greatest < number4)
            {
                greatest = number4;
            }

            if (greatest < number5)
            {
                greatest = number5;
            }

            Console.WriteLine("Greatest: {0}", greatest);

// 























// 9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
// - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
// - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.
Console.WriteLine("-----------------------------Chapter 5,  Solution 9 ----------------------");

















// 10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
// - If the score is between 1 and 3, the program multiplies it by 10.
// - If the score is between 4 and 6, the program multiplies it by 100.
// - If the score is between 7 and 9, the program multiplies it by 1000.
// - If the score is 0 or more than 9, the program prints an error message.
Console.WriteLine("---------------------------number10----------------------");
Random random = new Random();

 int number5 = random.Next(12);
int bonus5 = 0;
Console.WriteLine("your Score is : " + number5);
   
if (number5 <= 0 )
{
        Console.WriteLine( "Invalid Score");
}
    else if (number5 <=3) {
        bonus5 = 10;
    }
     else if (number5 <=6) {
        bonus5 = 100;
    }
     else if (number5 <=9) {
        bonus5 = 1000;
    }
     else if (number5 >9) {
        Console.WriteLine( "Invalid Score");
    }

    int Totalscore = number5 * bonus5;
    switch (number5)
    {
        case 1: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 2: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 3: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 4: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 5: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 6: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 7: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 8: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
        case 9: Console.WriteLine("Your Score is " + number5 + " and bonus is " + bonus5 + " Your total score is " + Totalscore); break;
    }

















// 11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
// - 0 --> "Zero"
// - 12 --> "Twelve"
// - 98 --> "Ninety eight"
// - 273 --> "Two hundred seventy three"
// - 400 --> "Four hundred"
// - 501 --> "Five hundred and one"
// - 711 --> "Seven hundred and eleven"
Console.WriteLine("-----------------------------Number11----------------------");

