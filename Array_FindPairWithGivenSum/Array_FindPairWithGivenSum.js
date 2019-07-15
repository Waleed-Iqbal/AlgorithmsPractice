

// taken from
// https://www.techiedelight.com/find-pair-with-given-sum-array/


(() => {

  let testInput1 = {
    numbers: [8, 7, 2, 5, 3, 1],
    sum: 10
  };

  let bruteForceSolution = () => {
    console.log("BRUTE FORCE SOLUTION ...");

    let numbers = testInput1.numbers;
    let sum = testInput1.sum;
    let isPairFound = false;

    let timeStart = performance.now();
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

    let timeEnd = performance.now();
    let totalTimeTaken = parseFloat(timeEnd - timeStart).toFixed(5);

    if (isPairFound) {
      console.log(`Brute force time complexity: O(n^2)`);
      console.log(`Brute force space complexity: O(1)`);
    }
    console.log(`Time taken: ${totalTimeTaken} milliseconds`);
  }

  bruteForceSolution();

})();