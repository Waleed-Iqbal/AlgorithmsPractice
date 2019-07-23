

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {

  let showLog = globals.showLog;
  let testASolution = globals.testASolution;


  let testInput1 = {
  //  numbers: [3, 4, -7, 3, 1, 3, 1, -4, -2, -2]
  };

  let bruteForceSolution = () => {

  }

  let displayOptions = {
    showInputs: false,
    showOutputs: true
  }

  testASolution(bruteForceSolution, testInput1, { showInputs: true, showOutputs: displayOptions.showOutputs }); // O(n^2)

})();