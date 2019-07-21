

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {

  let showLog = globals.showLog;
  let testASolution = globals.testASolution;


  let testInput1 = {
   numbers: [3, 4, -7, 3, 1, 3, 1, -4, -2, -2]
  };
  // Sub arrays are
  // [3,4,-7]
  // [3, 4, -7, 3, 1, 3, 1, -4, -2, -2]
  // [4,-7,3]
  // [-7,3,1,3]
  // [3,1,3,1,-4,-2,-2]
  // [3,1,-4]


  let testInput2 = [4, 2, -3, -1, 0, 4];
  // sub arrays are
  // [-3,-1,0,4]
  // [0]


  // O(n^2)
  let bruteForceSolution = (showOutputs) => {

    let sum = 0;
    let subArray = "";
    let totalNumbers = testInput1.numbers.length;

    testInput1.numbers.map((number, index, numbers) => {
      sum = 0;
      subArray = "";

      for (let i = index; i < totalNumbers; i++) {
        sum += numbers[i];
        subArray += numbers[i] + ", ";

        if (sum === 0)
          showLog(`ZERO SUM SUBARRAY: ${subArray}`, showOutputs);
      }
    });
  }

  let displayOptions = {
    showInputs: false,
    showOutputs: true
  }

  testASolution(bruteForceSolution, testInput1, { showInputs: true, showOutputs: displayOptions.showOutputs }); // O(n^2)

})();