

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

  let getRandomInput = (count) => {
    let numbers = [];
    numbers.length;
    while (numbers.length < count) {
      let candidateNumber = Math.floor(Math.random() * count);
      if(numbers.indexOf(candidateNumber) < 0)
      numbers.push(candidateNumber);
    }
    return numbers;
  }

  let testInput = {
    numbers: getRandomInput(1000),
    sum: 10
  };



  let bruteForceSolution = () => {

    console.log("BRUTE FORCE SOLUTION O(n^2) ...");

    let numbers = testInput.numbers;
    let sum = testInput.sum;
    let isPairFound = false;

    numbers.map((comparator, index) => {
      for (let j = index + 1; j < numbers.length; j++) {

        const comparer = numbers[j];

        if (sum === comparator + comparer) {
          console.log(`Sum found at indices ${index} and ${j}. Values are ${comparator}, ${numbers[j]}`);
          isPairFound = true;
          break;
        }
      }
    });
  }


  let betterSolution = () => {

    console.log("A better solution O(nlogn) ...")

    let numbers = testInput.numbers;
    let targetSum = testInput.sum;

    numbers = numbers.sort((a,b) => b - a); // sort in descending order
    numbers = numbers.filter(number => number <= targetSum);

    let lowIndex = 0;
    let highIndex = numbers.length-1;
    let isFound = false;

    while(lowIndex < highIndex) {
      let calculatedSum = numbers[lowIndex] + numbers[highIndex];
      if (calculatedSum === targetSum){
        console.log(`Sum found at indices ${lowIndex} and ${highIndex}. Values are ${numbers[lowIndex]}, ${numbers[highIndex]}`);
        isFound = true;
      }
      if (calculatedSum > targetSum)
        lowIndex++
      else highIndex--;
    }

    if(!isFound)
      console.log("No such pair found")
  }

  /**
   *
   * @param {callback} solution Name of the function to test
   */
  let testASolution = (callback, showInput = false) => {

    if(showInput){
      let input = "";
      testInput.numbers.map(number => input += number + ", ");
      console.log(`INPUT: ${input}`);
    }

    timeCalculations.start();
    callback();
    timeCalculations.end();
    timeCalculations.totalTime();
  }


  testASolution(bruteForceSolution); // O(n^2)
  testASolution(betterSolution); // O(nlog(n))

})();