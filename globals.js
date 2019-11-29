
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
      console.log(`\nTime elapsed: ${timeElapsed}\n`);
    }
  }

  /**
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


  /**
   * @param {string} log the message to show
   * @param {boolean} displayLog display message or not
   */
  let showLog = (log, displayLog = true) => {
    displayLog && console.log(log);
  }


  let displayAllData = (testData) => {
    var allTestData = Object.entries(testData);

    let input = "";
    allTestData.map((value) => {
      let inputName = value[0]; // first index is always name
      let inputValue = value[1]; // second index is always the value

      input += `\n${inputName.toUpperCase()}:\n`;

      if (inputValue.constructor === Array) {
        inputValue.map(val => {
          input += `${val.toString()}, `;
        });
      }
      else if (inputValue.constructor === String || inputValue.constructor === Number || inputValue.constructor === Boolean)
        input += inputValue.toString();
      else if (inputValue.constructor === Object) {
        input += JSON.stringify(inputValue);
      }
    });

    console.log(`${input}`);
  }


  /**
 * @param {callback} solution Name of the function to test
 * @param {displayOptions} displayOptions to display inputs and outputs
 */
  let testSolution = (callback, testData, displayOptions) => {

    displayOptions = displayOptions || defaultDisplayOptions;

    if (displayOptions.showInputs) {
      showLog("\nINPUTS ...");
      displayAllData(testData);
    }

    timeCalculations.start();
    let output = callback();
    timeCalculations.end();
    timeCalculations.totalTime();

    if (displayOptions.showOutputs) {
      showLog("\nOUTPUTS ...");
      displayAllData(output);
    }
  }


  let defaultDisplayOptions = {
    showInputs: true,
    showOutputs: true
  }

  return globals = {
    showLog: showLog,
    testSolution: testSolution,
    getRandomNumbers: getRandomNumbers
  };


})()