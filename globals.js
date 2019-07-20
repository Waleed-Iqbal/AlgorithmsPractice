
// working on the article
// https://techiedelight.quora.com/500-Data-Structures-and-Algorithms-interview-questions-and-their-solutions

(() => {

  /**
   * To calculate the running time of a function
   */
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

  /**
   *
   * @param {array} count upper limit of numbers starting from zero
   */
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

  let testData = {
    numbers: getRandomNumbers(5000),
    sum: 2200
  };

  /**
   *
   * @param {string} log the message to show
   * @param {boolean} displayLog display message or not
   */
  let showLog = (log, displayLog = true) => {
    displayLog && console.log(log);
  }


    /**
   * @param {callback} solution Name of the function to test
   * @param {displayOptions} displayOptions to display inputs and outputs
   */
  let testASolution = (callback, displayOptions) => {

    if (displayOptions.showInputs) {
      let input = "";
      testData.numbers.map(number => input += number + ", ");
      console.log(`INPUT:\n${input}`);
      console.log(`REQUIRED SUM: ${testData.sum}`);
    }

    timeCalculations.start();
    callback(displayOptions.showOutputs);
    timeCalculations.end();
    timeCalculations.totalTime();
  }


  return globals = {
    testData: testData,
    showLog: showLog,
    testASolution: testASolution
  };


})()