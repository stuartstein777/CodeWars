function oddOrEven(array) {
    return array.reduce((acc, i) => acc+i, 0) % 2 == 0
      ? 'even'
      : 'odd';
 }