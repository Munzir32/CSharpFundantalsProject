/*1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, longand ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.");
*/
sbyte = 97,112.
byte = 224,97,112.
short =-10000, -115, 20000,1990.
ushort= 52130, 20000, 1990
int= 52,130; -115; 4825932; 97; -10000; 20000; 224; 112; -44; -1,000,000;1990
uint= : 52,130; -115; 
4825932; 97;20000; 224; 970,700,000; 112;-1,000,000;1990;
long= : 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
1990; 123456789123456789
ulong=  52,130;4825932; 97;20000; 224; 970,700,000; 112;000,000; 
1990; 123456789123456789
*********************************************************************************
/2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;3456.091124875956542151256683467?  double number1 = 34.567839023;
      */
      
        float number2 = 12.345f;
        double number3 = 8923.1234857;
        decimal number4 = 3456.091124875956542151256683467m;    
//*************************************************************************************

//3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.


decimal number1 = 5.25745243896m;
        decimal number2 = 9.8544531763m;
        number1 += number2;
        Console.WriteLine(number1.ToString("#.######"));
*******************************************************************************************
//4. Initialize a variable of type int with a value of 256 inhexadecimal format (256 is 100 in a numeral system with base 16).

int number = 0x200;
******************************************************************************************
//5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72). char variable = 0x100;
/*****************************************************************************************
//6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
bool isMale = true
*/
*****************************************************************************************
//" 7. Declare two variables of type string with values /"Hello" and /"World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.

string greeting1 = "Hello";
string greeting2 = "World";
object salutation = (greeting1 + " " + greeting2);
Console.WriteLine(salutation);
//***************************************************************************
/*8  Declare two variables of type string and give them values "Hello" and 
"World". Assign the value obtained by the concatenation of the two 
variables of type string (do not miss the space in the middle) to a 
variable of type object. Declare a third variable of type string and 
initialize it with the value of the variable of type object (you should use 
type casting)*/
string salutation = (greeting1 + " " + greeting2);
string salutation = obj.ToString(salutation);
Console.WriteLine(salutation);
// ****************************************************************************

/*9. Declare two variables of type string and assign them a value “The 
"use" of quotations causes difficulties.” (without the outer quotes). 
In one of the variables use quoted string and in the other do not use it.*/
 
string word1 ="The \"use\" of quotations causes difficulties.";        
string word2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
//*********************************************************************************************
//10. Write a program to print a figure in the shape of a heart by the sign "o"
         Console.WriteLine("  0        0 ");
        Console.WriteLine("0   0    0   0");
        Console.WriteLine(" 0   0  0   0");
        Console.WriteLine("  0   00   0");
        Console.WriteLine("   0      0 ");
        Console.WriteLine("    0    0  ");
        Console.WriteLine("     0  0   ");
        Console.WriteLine("      00   ");
//        ***************************************************************************************
  Console.WriteLine(" 11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character /"©"");

        Console.WriteLine("    ©");
        Console.WriteLine("   © ©");
        Console.WriteLine("  ©   ©");
        Console.WriteLine(" ©     ©");
        Console.WriteLine("©©©©©©©©");


//Console.WriteLine("12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic /– first name, last name, age, gender (/‘m’ or /‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names");

 string firstName;
        string lastName;
        byte age;
        char gender;
        int id;

//********************************************************************************************

Console.WriteLine(" 13 Declare two variables of type int. Assign to them values 5 and 10 respectively Exchange swap their values and print them");
        int a = 5;
        int b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("a:{0} b:{1}", a, b);




    


