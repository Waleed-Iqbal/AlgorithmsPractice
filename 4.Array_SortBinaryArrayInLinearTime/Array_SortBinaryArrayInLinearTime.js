

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {

  let showLog = globals.showLog;
  let testASolution = globals.testASolution;


  let testInput = {
    numbers: [0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1]
  };

  let linearSolution = (showOutputs) => {
    // if 0 is found, prepend it to new array, for 1, append it to array

    let sortedBirnayrArray = [];
    let log = "";

    testInput.numbers.map(value => {
      if (value == 1)
        sortedBirnayrArray.push(value);
      else
        sortedBirnayrArray.unshift(value);
    });

    showLog(`SORTED BINARY ARRAY: ${log}`, showOutputs);
  }

  let displayOptions = {
    showInputs: true,
    showOutputs: true
  }

  linearSolution(testInput);
  testASolution(linearSolution, testInput, displayOptions);

})();