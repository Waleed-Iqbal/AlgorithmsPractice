

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {

  let showLog = globals.showLog;
  let testASolution = globals.testASolution;


  // let testInput1 = {
  //   numbers: [0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1]
  // };

  let testInput1 = [0, 1, 0, 0, 1, 1, 1, 0, 1, 0, 1];

  let bruteForceSolution = (input) => {
    // if 0 is found, prepend it to new array, for 1, append it to array

    let log = `Input:\n`;
    let sortedBirnayrArray = [];
    input.map(value => {
      log += `${value}, `;

      if (value == 1)
        sortedBirnayrArray.push(value);
      else
        sortedBirnayrArray.unshift(value);
    });

    log += `\nOutput:\n`;

    sortedBirnayrArray.map(value => {
      log += `${value}, `;
    })


    console.log(log);
    return sortedBirnayrArray;

  }

  let displayOptions = {
    showInputs: false,
    showOutputs: true
  }

  bruteForceSolution(testInput1);
  //testASolution(bruteForceSolution, testInput1);

})();