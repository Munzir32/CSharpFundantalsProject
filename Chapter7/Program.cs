/ 1. Write a program, which creates an array of 20 elements of type integer and initializes each of the elements with a value equals to the index of the element multiplied by 5. Print the elements to the console.

 int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }






// 2. Write a program, which reads two arrays from the console and checks whether they are equal (two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal).



bool arraysEqual = true;
Console.Write("Enter length of first array: ");
int length11 = Int32.Parse(Console.ReadLine());
int[] arrA = new int[length11];
for (int i11 = 0; i11 < arrA.Length; i11++)
{
Console.Write("Enter element {0}: ", i11);
arrA[i11] = Int32.Parse(Console.ReadLine());
}
Console.Write("\nEnter length of second array: ");
if (length11 != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
else
{
int[] arrB = new int[length11];
for (int i11 = 0; i11 < arrB.Length; i11++)
{
Console.Write("Enter element {0}: ", i11);
arrB[i11] = Int32.Parse(Console.ReadLine());
}
for (int i11 = 0; i11 < arrA.Length; i11++)
{
if (arrA[i11] != arrB[i11])
{
Console.WriteLine("\nArrays are different.");
arraysEqual = false;
break;
}
}
if (arraysEqual) Console.WriteLine("\nArrays are the same.");

}



// 3. Write a program, which compares two arrays of type char lexicographically (character by character) and checks, which one is first in the lexicographical order.
 bool arrayEqual = true;
            char[] arr3A = new char[5] { 'a', 'b', 'c', 'd', 'e' };
            char[] arr3B = new char[5] { 'a', 'b', 'c', 'd', 'e' };

            if (arr3A.Length > arr3B.Length){ Console.WriteLine("Second array is lexicographicaly first.");}
            else if (arr3A.Length < arr3B.Length) 
            {Console.WriteLine("First array is lexicographicaly first.");
            }
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arr3A[i] < arr3B[i])
                    {
                        Console.WriteLine("First array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                    if (arrA[i] > arr3B[i])
                    {
                        Console.WriteLine("Second array is lexicographicaly first.");
                        arrayEqual = false;
                        break;
                    }
                }

                if (arrayEqual) Console.WriteLine("Arrays are lexicographicaly equal.");
            }



// 4. Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
int count12 = 1, tempCount12 = 1, number12 = 0;

			Console.WriteLine ("Enter array length: ");
			int length12 = Int32.Parse (Console.ReadLine ());
			int[] array12 = new int[length12];

			for (int i12 = 0; i12 < array12.Length; i12++) 
			{
				Console.Write ("Enter {0} element: ", i12);
				array12 [i12] = Int32.Parse (Console.ReadLine ());
			}

			for (int i12 = 0; i12 < array12.Length - 1; i12++) 
			{
                if (array12[i12] == array12[i12 + 1]) tempCount12++;
                else tempCount12 = 1;

				if (tempCount12 > count12) 
				{
					count12 = tempCount12;
					number12 = array12 [i12];
				}
			}

			for (int i12 = 0; i12 < count12; i12++) Console.WriteLine (" {0} is maximal sequence of consecutive equal numbers in your input ", number12);







// 5. Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 Console.Write("Enter array length: ");
            int length5 = Int32.Parse(Console.ReadLine());

            int[] arr5 = new int[length5];
            int sames = 1, bestSames = 1, bestStart = 0, lastElement = 0;

            for (int i = 0; i < arr5.Length; i ++)
            {
                Console.Write("Enter {0} element: ", i);
                arr5[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr5.Length - 1; i++)
            {
                if (arr5[i] + 1 == arr5[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }
                }
                else sames = 1;
            }

            for (int i = bestStart; i < bestSames + bestStart; i++) Console.Write("{0}, ", arr5[i]);




// 6. Write a program, which finds the maximal sequence of increasing elements in an array arr[n]. It is not necessary the elements to be consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
 int counter6 = 0, tempIndex6, tempCounter6;

            Console.Write("Enter array length: ");
            int length6 = Int32.Parse(Console.ReadLine());

            int[] arr6 = new int[length6];
            int[] result6 = new int[length6];

            for (int i = 0; i < length6; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr6[i] = Int32.Parse(Console.ReadLine());
            }            
 
            for (int i = 0; i < length6; i++)
            {
                int[] tempResult6 = new int[length6];
                tempIndex6 = tempCounter6 = 1;                
                tempResult6[0] = arr6[i];

                for (int j = i + 1; j < length6; j++)
			    {                
				    if (arr6[j] > tempResult6[tempIndex6 - 1])
                    {
                        tempResult6[tempIndex6] = arr6[j];
                        tempIndex6++;
                        tempCounter6++;
                    }
                    else if (tempIndex6 > 1 && arr6[j] > tempResult6[tempIndex6 - 2] && arr6[j] < tempResult6[tempIndex6 - 1]) tempResult6[tempIndex6 - 1] = arr6[j];
                }

                if (counter6 < tempCounter6)
                {
                    counter6 = tempCounter6;
                    result6 = tempResult6;
                }
            }

            for (int i = 0; i < counter6; i++) Console.Write("{0},", result6[i]);

// 7. Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.
int maxsum = 0;

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K (K < N): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arrayofN= new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arrayofN[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arrayofN, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i ++) maxsum += arrayofN[i];

            Console.WriteLine("\nBiggest sum is {0}", maxsum);



// 8. Sorting an array means to arrange its elements in an increasing (or decreasing) order. Write a program, which sorts an array using the algorithm "selection sort".











// 9. Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11
 int sum = 0, tempSum;
            
            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                tempSum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum) sum = tempSum;
                }
            }

            Console.WriteLine("Result is {0}. ", sum);


// 10. Write a program, which finds the most frequently occurring element in an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).

 int counter13 = 0, tempCounter = 1, appearance = 0;

            Console.Write("Enter the number of Element you want in this Array  ");
            int length13 = Int32.Parse(Console.ReadLine());

            int[] array13 = new int[length13];

            for (int i = 0; i < length13; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array13[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(array13);

            for (int i = 0; i < length13 - 1; i++)
            {
                if (array13[i] == array13[i + 1]) tempCounter++;
                else tempCounter = 1;
                if (tempCounter > counter13)
                {
                    counter13 = tempCounter;
                        appearance = array13[i];
                }
            }

            Console.WriteLine("{0} was found {1} times in the list of elements you entered.", appearance, counter13);


// 11. Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}.













// 12. Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. The size of the matrices will be read from the console. See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion:
// 1 3 6 10
// 2 5 9 13
// 4 8 12 15
// 7 11 14 16

// 4 5 6 7
// 3 14 15 8
// 2 13 16 9
// 1 12 11 10

// 4 5 12 13
// 3 6 11 14
// 2 7 10 15
// 1 8 9 16

// 4 8 12 16
// 3 7 11 15
// 2 6 10 14
// 1 5 9 13
// b)
// c) d)*
// a)
Console.WriteLine("...........number 12..................");
 Console.WriteLine("------------------Matrix as shown in A ------------------------- ");
  Console.Write("How many column of matrix do you want : ");
            int qy = Int32.Parse(Console.ReadLine());

            Console.Write("How many row of matrix do you want : ");
            int qx = Int32.Parse(Console.ReadLine());

            int qa = 0;

            for (int qi = 1; qi <= qy; qi++)
            {
                Console.Write("{0} ", qi);

                qa += qi;

                for (int qj = 1; qj < qx; qj++)
                {
                    qa += qy;
                    Console.Write("{0} ", qa);                    
                }

                qa = 0;
                Console.WriteLine();
            }



        
 Console.WriteLine("Enter matrix size: ");
            int matsize = Int32.Parse(Console.ReadLine());

            int[,] matarr = new int[matsize, matsize];
            matarr[0, 0] = 1;

            for (int abb = 1; abb < matarr.GetLength(0); abb++)
                if (abb % 2 == 1) matarr[0, abb] = matarr[0, abb - 1] + matsize * 2 - 1;
                else matarr[0, abb] = matarr[0, abb - 1] + 1;

            for (int abb = 1; abb < matarr.GetLength(0); abb++)
                for (int abc = 0; abc < matarr.GetLength(1); abc++)
                    if (abc % 2 == 1) matarr[abb, abc] = matarr[abb - 1, abc] - 1;
                    else matarr[abb, abc] = matarr[abb - 1, abc] + 1;

            for (int abb = 0; abb < matarr.GetLength(0); abb++)
            {
                for (int abc = 0; abc < matarr.GetLength(1); abc++) Console.Write("{0, 4}", matarr[abb, abc]);
                Console.WriteLine();
            }

    

Console.WriteLine("Enter Matrix size: ");
            int Length20 = Int32.Parse(Console.ReadLine());

            int[,] matArray = new int[Length20, Length20];
            matArray[Length20 - 1, 0] = 1;
            int counter20 = 1;
            for (int Row = Length20 - 2; Row >= 0; Row--)
            {
                matArray[Row, 0] = matArray[Row + 1, 0] + counter20;
                int newRow = Row;
                for (int diagonal = 1; diagonal <= counter20; diagonal++)
                {
                    matArray[newRow + 1, diagonal] = matArray[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter20++;
            }

            matArray[0, Length20 - 1] = Length20 * Length20;
            int diagonalLength = 2;
            int posX = 1;
            int posY = Length20 - 1;
            int prevX = 0;
            int prevY = Length20 - 1;

            for (int qbi = 1; qbi < counter20 - 1; qbi++)
            {
                for (int qbj = 1; qbj <= diagonalLength; qbj++)
                {
                   matArray[posX, posY] =matArray[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY; 
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = qbi + 1;
                posY = Length20 - 1;
            }

            for (int qbi = 0; qbi < matArray.GetLength(0); qbi++)
            {
                for (int qbj = 0; qbj < matArray.GetLength(1); qbj++) Console.Write("{0, 4}",matArray[qbi, qbj]);
                Console.WriteLine();
            }




























// 22. 
        int subset = 0, longestLength = 0;

            Console.Write("Enter arr length: ");
            int length22 = Int32.Parse(Console.ReadLine());
                        
            int[] arr22 = new int[length22];

            for (int i = 0; i < length22; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr22[i] = Int32.Parse(Console.ReadLine());
            }

            int m = (1 << length22);
            int[,] subsets = new int[m, length22];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < length22; j++) subsets[i, j] = i / (m / 2 / (1 << j)) % 2;

            for (int i = 0; i < m; i++)
            {
                int max = -1000, count22 = 0;

                for (int j = 0; j < length22; j++)
                {
                    if (subsets[i, j] > 0)
                    {
                        if (arr22[j] >= max)
                        {
                            count22++;
                            max = arr[j];
                        }
                        else
                        {
                            count22 = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count22)
                {
                    longestLength = count22;
                    subset = i;
                }
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < length22; i++) if (subsets[subset, i] > 0) Console.Write(arr22[i] + "; ");
