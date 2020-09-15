using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPlayground.Problems
{
    //Two Number Sum
    //Write a function that takes in a non-empty array of distinct integers represnting a target sum.
    //If any two numbers in the input array sum up to the target sum, the function should return them
    //in an array, in sorted order. If no two numbers sump up to the target sum, the function should
    //return an empty array. Assume that there will be at most one pair of numbers summing up to the 
    //target sum. 

    
    /// <summary>
    /// O(n^2) time | O(1) space
    /// </summary>
    public class TwoNumberSum
    {
        int[] input = { 3, 5, -4, 8, 11, 1, -1, 6 };
        int[] output = { -1, 11 };

        public int[] NaiveImplementaiton(int targetSum)
        {
            for(var i = 0; i < input.Length; i++)
            {
                var firstNumber = input[i];
                for(var j = i+1; j < input.Length; j++)
                {
                    var secondNumber = input[j];
                    if (firstNumber + secondNumber == targetSum)
                    {
                        return new []{ firstNumber, secondNumber }.OrderBy(x => x).ToArray(); 
                    }
                }
            }
            return null;
        }
    }
}
