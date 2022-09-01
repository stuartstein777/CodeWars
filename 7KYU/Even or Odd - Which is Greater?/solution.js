function evenOrOdd(str) {
    let digits = str.split('').map((c) => Number(c));
    var evenSum = digits.reduce((acc, i) => i % 2 == 0 ? acc + i : acc, 0);
    var oddSum = digits.reduce((acc, i) => i % 2 != 0 ? acc + i : acc, 0);
    if(evenSum > oddSum)
      return 'Even is greater than Odd';
    else if(evenSum < oddSum)
      return 'Odd is greater than Even';
    else
      return 'Even and Odd are the same';
}