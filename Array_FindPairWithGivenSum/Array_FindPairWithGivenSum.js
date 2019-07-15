

// taken from
// https://www.techiedelight.com/find-pair-with-given-sum-array/


(() => {

  let testTnput1 = {
    numbers: [8, 7, 2, 5, 3, 1],
    sum: 10
  };


  let bruteForceSolution = () => {
    let numbers = testTnput1.numbers;
    let sum = testTnput1.sum;
    
    for (let i = 0; i < numbers.length; i++) {
      
      const comparator = numbers[i];
      
      for (let j = i + 1; j < numbers.length; j++) {
        
        const comparer = numbers[j];
        
        if (sum === comparator + comparer) {
          console.log(`Sum found at index ${i} and ${j}`);
          break;
        }
      }
    }
  }
  
  bruteForceSolution();

})();