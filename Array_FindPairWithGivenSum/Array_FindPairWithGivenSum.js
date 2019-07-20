

// taken from
// https://www.techiedelight.com/find-pair-with-given-sum-array/


(() => {

  let timeCalculations = {
    start() {
      this.startTime = performance.now()
    },
    end() {
      this.endTime = performance.now()
    },
    startTime: null,
    endTime: null,
    totalTime() {
      let timeElapsed = parseFloat(this.endTime - this.startTime).toFixed(5);
      console.log(`Time elapsed: ${timeElapsed}`);
    }
  }

  let getRandomNumbers = (count) => {
    let numbers = [];
    numbers.length;
    while (numbers.length < count) {
      let candidateNumber = Math.floor(Math.random() * count);
      if (numbers.indexOf(candidateNumber) < 0)
        numbers.push(candidateNumber);
    }
    return numbers;
  }

  let testInput = {
    numbers: getRandomNumbers(5000),
    sum: 2200
  };

  let showLog = (log, displayLog = true) => {
    displayLog && console.log(log);
  }


  let bruteForceSolution = (showOutputs = false) => {

    showLog("A BRUTE FORCE SOLUTION: O(n^2)");

    let numbers = testInput.numbers;
    let sum = testInput.sum;
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

    let numbers = testInput.numbers;
    let targetSum = testInput.sum;

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

    let numbers = testInput.numbers;
    let targetSum = testInput.sum;
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

  /**
   * @param {callback} solution Name of the function to test
   */
  let testASolution = (callback, displayOptions) => {

    if (displayOptions.showInputs) {
      let input = "";
      testInput.numbers.map(number => input += number + ", ");
      console.log(`INPUT:\n${input}`);
      console.log(`REQUIRED SUM: ${testInput.sum}`);
    }

    timeCalculations.start();
    callback(displayOptions.showOutputs);
    timeCalculations.end();
    timeCalculations.totalTime();
  }

  let displayOptions = {
    showInputs: false,
    showOutputs: false
  }

  testASolution(bruteForceSolution, { showInputs: true, showOutputs: displayOptions.showOutputs }); // O(n^2)
  testASolution(betterSolution, displayOptions); // O(nlog(n))
  testASolution(muchBetterSolution, displayOptions); // O(n)

})();