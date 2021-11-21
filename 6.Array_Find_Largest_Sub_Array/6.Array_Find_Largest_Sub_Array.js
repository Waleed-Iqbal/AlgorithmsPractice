
/*
taken from 
http://www.techiedelight.com/find-largest-sub-array-formed-by-consecutive-integers/

Find largest sub-array formed by consecutive integers

Given an integer array, find the largest subarray formed by consecutive integers. The subarray should contain all distinct values.

Example 1
Input: [2,0,2,1,4,3,1,0]
Output: [0,2,1,4,3]


 */

(() => {


  let testInput = {
    numbers: [2,0,2,1,4,3,1,0]
   }

  let solutionFunction = (input) => {
    input = input || testInput.numbers;
    let output = [],
        indices = [];


    return output;
  }

  let displayOptions = {
    showInputs: true,
    showOutputs: true,
  }

  globals.testSolution(solutionFunction, testInput, displayOptions);

})();