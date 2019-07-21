

// taken from
// https://www.techiedelight.com/find-pair-with-given-sum-array/


(() => {

  let showLog = globals.showLog;
  let testASolution = globals.testASolution;


  let testData = {
    numbers: this.globals.getRandomNumbers(8000),
    sum: 2250
  }


  let bruteForceSolution = (showOutputs = false) => {

    showLog("A BRUTE FORCE SOLUTION: O(n^2)");

    let numbers = testData.numbers;
    let sum = testData.sum;
    let isPairFound = false;

    numbers.map((comparator, index) => {
      for (let j = index + 1; j < numbers.length; j++) {

        const comparer = numbers[j];

        if (sum === comparator + comparer) {
          showLog(`Sum found at indices ${index} and ${j}. Values are ${comparator}, ${numbers[j]}`, showOutputs);
          isPairFound = true;
          break;
        }
      }
    });

    if (!isPairFound)
      showLog("No such pair found", showOutputs);
  }


  let betterSolution = (showOutputs = false) => {

    showLog("A BETTER SOLUTION: O(nlogn)")

    let numbers = testData.numbers;
    let targetSum = testData.sum;

    numbers = numbers.sort((a, b) => b - a); // sort in descending order
    numbers = numbers.filter(number => number <= targetSum);

    let lowIndex = 0;
    let highIndex = numbers.length - 1;
    let isPairFound = false;

    while (lowIndex < highIndex) {
      let calculatedSum = numbers[lowIndex] + numbers[highIndex];
      if (calculatedSum === targetSum) {
        showLog(`Sum found at indices ${lowIndex} and ${highIndex}. Values are ${numbers[lowIndex]}, ${numbers[highIndex]}`, showOutputs);
        isPairFound = true;
      }
      if (calculatedSum > targetSum)
        lowIndex++
      else highIndex--;
    }

    if (!isPairFound)
      showLog("No such pair found", showOutputs);
  }


  let muchBetterSolution = (showOutputs = false) => {

    showLog("A MUCH BETTER SOLUTION: O(n)");

    let numbers = testData.numbers;
    let targetSum = testData.sum;
    let numbersMap = {};
    let isPairFound = false;

    numbers.map((value, index) => {
      let difference = Math.abs(targetSum - value);
      if (numbersMap.hasOwnProperty(difference) && (difference + value === targetSum)) {
        showLog(`Sum found at indices ${numbersMap[difference]} and ${index}. Values are ${difference}, ${value}`, showOutputs);
        isPairFound = true;
      }

      if (!numbersMap[value])
        numbersMap[value] = index;
    });

    if (!isPairFound)
      showLog("No such pair found", showOutputs);

  }

  let displayOptions = {
    showInputs: false,
    showOutputs: false
  }

  testASolution(bruteForceSolution, testData, { showInputs: false, showOutputs: displayOptions.showOutputs }); // O(n^2)
  testASolution(betterSolution, testData, displayOptions); // O(nlog(n))
  testASolution(muchBetterSolution, testData, displayOptions); // O(n)

})();