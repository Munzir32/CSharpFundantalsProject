 Console.WriteLine("------------Question6---------");
 Console.Write("input integer N: ");
 int integerN  = int.Parse(Console.ReadLine()); 
 Console.Write("input integer k: ");
 int integerK = int.Parse(Console.ReadLine());
 long factorialN =1;
 long factorialK =1;
 int subtractedinteger = integerN-integerK;
 long subtrataction =1;
 while(integerN  > 0)
  {
 factorialN*=integerN;
 integerN--;
 }
Console.WriteLine($"the factorial of {integerN} is {factorialN}");
 do
{
 factorialK*=integerK;
 integerK--;
 } while (integerK>0);
Console.WriteLine($"the factorial of {integerK} is {factorialK}");
long Result = factorialN / factorialK;
 Console.WriteLine($"the division of {factorialN} and {factorialK} is {Result}");

 Console.WriteLine("-----------Question7-----------");
 do
 {
     subtrataction*=subtractedinteger;
   subtractedinteger--;
 } while (subtractedinteger>0);
 Console.WriteLine($"the result of substracted factorial is {subtrataction}");
long factorial = factorialN *factorialK;
 long totalfactorial = factorial/subtrataction;
 Console.WriteLine($"the result of the total  is {totalfactorial}");

 Console.WriteLine("-------------------Question8--------------------");
 Console.Write("enter intgerN: ");
 int N = int.Parse(Console.ReadLine());
 int MultipliedN = 2*N;
 long MultipliedfactorialN = 1;
 long Nfactorial = 1;
 int AddedN = N+1;
 long AddedFactorial =1;
 do
 {
     MultipliedfactorialN*=MultipliedN;
     MultipliedN--;
} while (MultipliedN>0);
 do
 {
     AddedFactorial*=AddedN;
     AddedN--;
 } while (AddedN>0);
 do
 {
         Nfactorial *= N;
    N--;
 } while (N>0);
  
  long CatalanNumber = (MultipliedfactorialN)/(AddedFactorial*Nfactorial);

Console.WriteLine("-------------------Question9----------------");
double S = 1;
 double sequence;
 Console.Write("enter an integer X: ");
 int X = int.Parse(Console.ReadLine());
long Factorialn = 1;
 for (int k = 0; k < 5; )
 {
    k++;
  do
  {
    Factorialn*=k;
    k--;
  } while (k<0);
  k++;
 sequence=Factorialn/Math.Pow(X,k);
     S+=sequence;
   }  
    Console.WriteLine(S);

 Console.WriteLine("--------------Question10----------------");
 Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter columns: ");
 int columns = Convert.ToInt32(Console.ReadLine());
int [,] myArray = new int [rows,columns];

 for (int i = 0; i <myArray.GetLength(0); i++)
{
     for (int j = 0; j <myArray.GetLength(1); j++)
     {
         Console.Write($"the integer of roll {i} and column {j} is: ");
         myArray[i,j]=Convert.ToInt32(Console.ReadLine());
     }
 }

 for (int i = 0; i <myArray.GetLength(0); i++)
{
    for (int j = 0; j <myArray.GetLength(1);j++)
{
     Console.Write( myArray[i,j] + " ");
        
   }
  Console.WriteLine();
  }
      Console.WriteLine("---------------Question11-----------");
  Console.Write("Enter an integer: ");
     int n = int.Parse(Console.ReadLine());
    int count = 0;

     for (int i = 5; n/i >1 ;  )
     {
       count += n/i;
         i*=5;
       }
      Console.WriteLine($"the number of zeros in {n}! is {count}");

     Console.WriteLine("--------------------Question12---------------");
      Console.WriteLine("Enter a decimal Number: ");
       int Decimal = Convert.ToInt32(Console.ReadLine());
      string ConvertedNo = Convert.ToString(Decimal,2);
       Console.WriteLine($"The binary number of {Decimal} is {ConvertedNo}");

      Console.WriteLine("--------------------Question13----------------");
       Console.Write("Enter a binary Number: ");
    string Binary = Console.ReadLine();
     int BinaryConvert = Convert.ToInt32(Binary,2);
     Console.WriteLine("the decimal Number of  "+Binary+ " is "+ BinaryConvert );

      Console.WriteLine("--------------Question14--------------");
       Console.WriteLine("Enter a decimal number: ");
   int Integer = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("the hexadecimal number of {0} is {0:X}",Integer);

      Console.WriteLine("---------------Question15-------------");
 Console.Write("Enter an hexadecimal number: ");
      string hexadecimal = Console.ReadLine();
      int DecimalInt = Convert.ToInt32(hexadecimal,16);
   Console.WriteLine("The hexadeciaml number of {0} is {1}",hexadecimal,DecimalInt);

  Console.WriteLine("------------Question16--------------");
       Random Numbers = new Random();
      Console.Write("Enter any Number: ");
       int Anyinteger = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < Anyinteger;)
     {
       i++;
     Console.WriteLine(Numbers.Next(i,Anyinteger));
    }
      Console.WriteLine("----------------Question17--------------------");
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
  while (a!=b)
  {
   if (a>b)
   {
    a-=b;
   } 
   else
   {
    b-=a;
  }
  }
  Console.WriteLine("the gcd of both number is "+a);