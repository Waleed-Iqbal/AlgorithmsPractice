

// taken from
// https://www.techiedelight.com/find-pair-with-given-sum-array/


(() => {

  let testInput1 = {
    numbers: [8, 7, 2, 5, 3, 1],
    sum: 10
  };


  let bruteForceSolution = () => {
    let numbers = testInput1.numbers;
    let sum = testInput1.sum;
    let isPairFound = false;
    
    for (let i = 0; i < numbers.length; i++) {
      
      const comparator = numbers[i];
      for (let j = i + 1; j < numbers.length; j++) {
        
        const comparer = numbers[j];
        
        if (sum === comparator + comparer) {
          console.log(`Sum found at indices ${i} and ${j}. Values are ${numbers[i]}, ${numbers[j]}`);
          isPairFound = true;
          break;
        }
      }
    }
    
    if(isPairFound) {
      console.log(`Brute force time complexity: O(n^2)`);
      console.log(`Brute force space complexity: O(1)`);
    }
  }
  
  bruteForceSolution();

})();