function bitsBattle(numbers) {
  var evens = numbers.filter(n => n % 2 == 0 && n != 0)
                     .map(x => x.toString(2))
                     .reduce((acc, c) => acc + c.replace(/1/g,'').length, 0);
  var odds = numbers.filter(n => n % 2 != 0 && n != 0)
                    .map(x => x.toString(2))
                    .reduce((acc, c) => acc + c.replace(/0/g, '').length, 0);
  if(evens == odds)
    return "tie";
  else if(odds > evens)
    return "odds win";
  else
    return "evens win";
}