

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {

  let showLog = globals.showLog;

  let testData = {
    numbers: [3, 4, -7, 3, 1, 3, 1, -4, -2, -2]
  };


  let doesSubArrayWithZeroSumExist = (showOutputs = false) => {
    let sum = 0;
    testData.numbers.map(value => {
      sum += value;
      if (sum === 0) {
        showLog("sub array with zero sum found");
        return;
      }
    });
  }

  let displayOptions = {
    showInputs: false,
    showOutputs: false
  }

  globals.testSolution(doesSubArrayWithZeroSumExist, testData, displayOptions);

})();