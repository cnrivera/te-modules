/*
 * Document this function
 */
/**
 * Function takes in month and day and returns appropriate hemisphere where it is summer during that timeframe.
 * 
 * @param {number} month 
 * @param {number} [day = 1] 
 * @param {string} [hemisphere = 'northern'] 
 * @returns {string} if parameters match or @returns {boolean} if they do not
 */
function isSummer(month, day = 1, hemisphere = 'northern') {
  if (month === 7 || month === 8) {
    return hemisphere === 'northern';
  } else if (month === 6 && day >= 20) {
    return hemisphere === 'northern';
  } else if (month === 9 && day <= 20) {
    return hemisphere === 'northern';
  } else if (month === 1 || month === 2) {
    return hemisphere === 'southern';
  } else if (month === 12 && day >= 20) {
    return hemisphere === 'southern';
  } else if (month === 3 && day <= 20) {
    return hemisphere === 'southern';
  } else {
    return false;
  }
}

/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the students is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * We admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */

function isAdmitted(gpa, satScore = 0, recommendation = false) {

  if (recommendation == true) {
    if (gpa > 3.0 || satScore > 1200) {
      return true;
    }
    else {
      return false;
    }
  }
  else if (gpa > 4.0 || satScore > 1300) {
    return true;
  }
  else {
    return false;
  }

}

/**
 * Write a function called useParameterToFilterArray so that it takes an anonymous
 * function and uses that in `unfilteredArray` filter function. Return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

function useParameterToFilterArray(filterFunction) {
  return unfilteredArray.filter(filterFunction); {
    return number;
  }

}


/**
 * Write a function called makeNumber to take two strings
 * of digits, concatenate them together, and then return
 * the value back as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * should return the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */

function makeNumber(strFirst, strSecond = '') {
  let dualString = strFirst + strSecond;
  let newNum = parseInt(dualString);
  return newNum;

}



/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds them all together. Return the result.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */

function addAll() {

  let sum = 0;
  for (let i = 0; i < arguments.length; i++) {
    sum += arguments[i];
  }
  return sum;


}



/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */

function makeHappy(array) {
  let happyNumbers = array.map(
    (element) => {
      return 'Happy ' + element;
    }
  );
  return happyNumbers;
}


/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects containing the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * and returns an array of strings that turns the JavaScript objects
 * into mailing addresses in the form of:
 *     streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */
/**
 * Function takes an array of objects and maps each element to a const to create an array of addresses.
 * 
 * @param {object} objectArray 
 * @returns {array} an array of mailing addresses as strings
 */
function getFullAddressesOfProperties(objectArray) {
  const addresses = objectArray.map(
    (element) => {
      return `${element.streetNumber} ${element.streetName} ${element.streetType} ${element.city} ${element.state} ${element.zip}`
    }
  );
  return addresses;
}

/*
 * Create and document a function called findLargest.
 *
 * Using `forEach`, find the largest element in an array.
 * It should work for strings and numbers.
 */

/**
 * 
 * Takes an array and returns the largest number (if a number)
 * or the string with highest alphabetical place
 * 
 * @param {string} or @param {number} array
 * @returns {string} or @param {number}
 */
function findLargest(array) {
  let largest = array[0];

  array.forEach(
    (element) => {
      if (typeof array[0] == "string") {
        if (element[0] > largest[0]) {
          largest = element;
        }
      }
      else {

        if (largest < element) {
          largest = element;
        }

      }
    }
  )
  return largest;
}


/*
 * CHALLENGE
 * Create and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays and add up all sub values and return
 * the sum. For instance, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * You would return 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */

/**
 * Takes an array of arrays and reduces them to a single sum
 * 
 * 
 * @param {number} nestedArray
 * @returns {number} 
 */
function getSumOfSubArrayValues(nestedArray = []) {

  if (!nestedArray) {
    return 0;
  }

  let initialValue = 0;

  return nestedArray.reduce((sum, array) => {
    return sum + array.reduce((sum, number) => {
      return sum + number;
    }, initialValue
    );
  }, initialValue
  );
};
