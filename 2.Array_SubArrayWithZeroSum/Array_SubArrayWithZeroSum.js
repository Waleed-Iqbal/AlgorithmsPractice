

// taken from
// https://www.techiedelight.com/check-subarray-with-0-sum-exists-not/


(() => {


  let testNumbers = [3, 4, -7, 3, 1, 3, 1, -4, -2, -2];


  let doesSubArrayWithZeroSumExist = (numbers) => {
    let sum = 0;
    numbers.map(value => {
      sum += value;
      if (sum === 0) {
        console.log("sub array with zero sum found");
        return;
      }
    });
  }

  doesSubArrayWithZeroSumExist(testNumbers);

})();