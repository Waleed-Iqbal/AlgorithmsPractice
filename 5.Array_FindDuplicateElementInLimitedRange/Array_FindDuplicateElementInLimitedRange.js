

/*
taken from
https://www.techiedelight.com/find-duplicate-element-limited-range-array/


Given a limited range array of size 'n' and containing elements between 1 and n-1
with one element repeating, find the duplicate number in it without using any extra space.

 Example 1
 Input: [1,2,3,3,4]
 Output: 3


 Example 2
 Input: [1,2,3,4,4,5]
 Output: 4

 */

(() => {


  let testInput = {
    numbers: [1,2,3,4,4,5]
   }


   let solution_SumAndDifference = (input) => {
    // sum within a rand can be found by ... sum = n * (n+1) / 2
    // assuming that there is only 1 duplicate and it is always present
    input = input || testInput.numbers; // default input

    let totalNumbers = input.length - 1;

    let expectedSum = totalNumbers * (totalNumbers + 1) / 2;
    let originalSum = input.reduce((sum, value) =>  sum + value);

    let duplicateNumber = originalSum - expectedSum;

    let output = {
      "duplicate_Number": duplicateNumber
    };

    return output;
  }


  let displayOptions = {
    showInputs: true,
    showOutputs: true
  }

  globals.testSolution(solution_SumAndDifference, testInput, displayOptions);

})();