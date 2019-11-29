

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {

  let testInput = {
   numbers: [0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1]
  }

  let sortBinaryArrayInLinearTime = (input) => {
    input = input || testInput.numbers;
    let testOutPut = {
      numbers: []
    }
    // if 0 is found, prepend it to new array, for 1, append it to array

    let sortedBinaryArray = [];

    testInput.numbers.map(value => {
      if (value == 1)
      sortedBinaryArray.push(value);
      else
      sortedBinaryArray.unshift(value);
    });

    testOutPut.numbers = sortedBinaryArray;

    return testOutPut;
  }

  let displayOptions = {
    showInputs: true,
    showOutputs: true,
  }

  globals.testSolution(sortBinaryArrayInLinearTime, testInput, displayOptions);

})();