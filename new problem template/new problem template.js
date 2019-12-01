
/*
taken from
link_here

Example 1
Input: ---
Output: ---

Example 2
Input: ---
Output: ---

 */

(() => {


  let testInput = {
    numbers: [0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1]
   }

  let solutionFunction = (input) => {
    input = input || testInput.numbers;

  }

  let displayOptions = {
    showInputs: false,
    showOutputs: true
  }

  globals.testSolution(solutionFunction, testInput, displayOptions);

})();