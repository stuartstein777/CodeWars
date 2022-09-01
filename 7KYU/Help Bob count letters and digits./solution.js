function countLettersAndDigits(input) {
    console.log(input);
    if(input === '' || input === null)
      return 0;
    var matches = input.match(/[a-zA-Z0-9]/g);
    return (matches === null)
      ? 0
      : matches.length;
}