/*Console.WriteLine(" 1.Write a program that reads from the console three numbers of type int and prints their sum.");
Console.WriteLine("Enter num1:");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num2:");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter num3:");
int num3=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1 + num2 + num3);
*/
/*
Console.WriteLine("2. Write a program that reads from the console the radius r of a circle and prints its perimeter and area");
Console.WriteLine(" Enter the radius: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(  2*Math.PI*r           );
*/
/*
Console.WriteLine("3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.Write a program that reads information about the company and its manager and then prints it on the console.");
Console.WriteLine(" Company information");
Console.WriteLine("Enter Company name:");
Console.ReadLine();
Console.WriteLine(" Enter Company Address:");
Console.ReadLine();
Console.WriteLine(" Enter Company phone number:");
int phonenum =Convert.ToInt32( Console.ReadLine());
Console.WriteLine(" Enter company Fax number:");
int faxnum=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(" Enter Company Website:");
Console.ReadLine();
Console.WriteLine("Manager Details");
Console.ReadLine();
Console.WriteLine("Enter manager name:");
Console.ReadLine();
Console.WriteLine("Enter Manager Surname :");
Console.ReadLine();
Console.WriteLine("Enter manager phone number:");
int ManagerPhoneNum=Convert.ToInt32(Console.ReadLine());





 
Console.WriteLine("    4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place. "  );
     int hexNum = 2015;
     Console.WriteLine("|0x{0,-8:X|", hexNum);
     double fractNum = -1.856;
     Console.WriteLine("|0,-10:f2}|", fractNum);

//
Console.WriteLine(" 5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.");
    int counter = 0;
    
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine());
    
    for (int i = a; i <= b; i++)
    {
        if (i % 5 == 0) counter++;
    }
    
    Console.WriteLine("{0} numbers found.", counter);


Console.WriteLine("   6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements. ");
Console.WriteLine(" Enter firstnum :");
int firstnum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter secondnum");
int Secondnum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Max(firstnum,Secondnum));
*/
 
  Console.WriteLine( 7"Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.");
 int total7 = 0;
    bool cond = false;
    Console.Write("Enter five numbers : ");
    int numOfAppearance = 5;
    
    for (int i = 0; i < numOfAppearance; i++)
    {
        Console.Write("Enter {0} number: ", i + 1);
        total7 += Int32.Parse(Console.ReadLine());
        

    
    }

    Console.WriteLine("Sum of all numbers is {0}.", total7);
 int a, b, c, d, e;
 bool parseSucceed = false;
 do
 {
 Console.Write("Enter first number");
 parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
Console.WriteLine(parseSucceed);
} while (!parseSucceed);
 do
 {
Console.Write("Enter second number");
 parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
 Console.WriteLine(parseSucceed);
} while (!parseSucceed);
do
 {
 Console.Write("Enter third number");
 parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
 Console.WriteLine(parseSucceed);
 } while (!parseSucceed);
 do
 {
 Console.Write("Enter fourth number");
 parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
 Console.WriteLine(parseSucceed);
 } while (!parseSucceed);
 do
{
 Console.Write("Enter fifth number");
 parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
 Console.WriteLine(parseSucceed);
} while (!parseSucceed);





Console.WriteLine(" 8. Write a program that reads five numbers from the console and prints the greatest of them ");
Console.WriteLine(" Enter firstnum:");
int firstnum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter secondnum");
int Secondnum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter thirdnum :");
int thirdnum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter fourthnum");
int fourthnum=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Enter fifthnum");
int fifthnum=Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = { firstnum, Secondnum, thirdnum , fourthnum, fifthnum};
        decimal arrayBiggest = arrayNumbers.Max();
 
        Console.WriteLine("The Largest of the input is " + arrayBiggest);


 
Console.WriteLine("     9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.       ");
 
        Console.WriteLine("Enter your First Input:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your Second Input:");

int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Third Input:");

int ThirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your First Input is " + firstNumber + ", Your second input is " + secondNumber + ", Your Third input is " + ThirdNumber );
int sum = firstNumber + secondNumber + ThirdNumber;
Console.WriteLine("The total sum of your input is " + sum);





// 
Console.WriteLine("      10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.    ");
   int total = 0;
    
    Console.Write("Enter numbers count: ");
    int length = Int32.Parse(Console.ReadLine());
    
    for (int i = 0; i < length; i++)
    {
        Console.Write("Enter {0} number: ", i + 1);
        total += Int32.Parse(Console.ReadLine());
    }
    
    Console.WriteLine("Sum of all numbers is {0}.", total);





// …
Console.WriteLine("   11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233,       ");
        Console.WriteLine("The Fibonacci sequence of 100 are : ");
         ulong fab = 100;
 
      
 
        ulong fab1 = 0;
        ulong fab2 = 1;
        Console.Write("{0} {1} ", fab1, fab2);
 
        for (ulong i2 = 2; i2 < fab; i2++)
        {
            ulong fab3 = fab1 + fab2;
            Console.Write("{0} ", fab3);
            fab1 = fab2;
            fab2 = fab3;
        }
        Console.WriteLine();






// 
Console.WriteLine(" 12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …  ");
    int num1 = 0;
    int num2 = 1;
    int sum2 = 1;
    int count = 0;
    
    Console.WriteLine(num1);
    
    while(count < 100)
    {
        sum2 = num1 + num2;
        num1 = num2;
        num2 = sum2;
        Console.WriteLine(num2);
        count++;
    }











