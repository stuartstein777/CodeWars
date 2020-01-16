function evenNumbers(array, number) {
  var evens = array.filter(i => i % 2 == 0);
  return (evens.length >= number)
    ? evens.slice(evens.length-number)
    : evens;
}