/******************************************************************************

Write a function

class Solution { public int solution(int[] A); }

that, given an array A consisting of N integers, returns the number of distinct values in array A.

For example, given array A consisting of six elements such that:

 A[0] = 2    A[1] = 1    A[2] = 1
 A[3] = 2    A[4] = 3    A[5] = 1
the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].

*******************************************************************************/
using System;
using System.Collections.Generic;
class Solution {
    
    public static void printOutAll( int[] arr){
            Console.WriteLine();
            for(int i=0; i <arr.Length; i++){
                    Console.Write(arr[i] + " ");
            }    
            Console.WriteLine();
        }
    
    public static int solution(int[] A){
        /*int counter = 0;
        Array.Sort(A);
        for(int i=0; i<A.Length-1; i++){
            if(A[i] != A[i+1]){
                counter++;
            }
        }
        return counter;*/
        
        //return (new HashSet<int>(A)).Count;
            /*
            int lenght = A.Length;
            Array.Sort(A);
            int current, before = A[0];
            int countdif = 1;
            for (int i = 1; i < lenght; i++)
            {
                current = A[i];
                if (current != before)
                {
                    before = current;
                    countdif++;
                }
            }
            return countdif;*/
            
            //int lenght = A.Length;
            Array.Sort(A);
            
            int distincts = 1;
            for (int i = 0; i < A.Length-1; i++)
            {
                
                if (A[i] != A[i+1])
                {
                    distincts++;
                }
            }
            return distincts;
            
        
    }
        

    
    
  static void Main() {
      int[] arr = {2,1,1,2,3,1};
      printOutAll(arr);
      
      Console.WriteLine(solution(arr));
      
  }
}


