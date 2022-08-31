function getNumberFromString(s) {
    console.log(s);
      return Number(s.match(/\d+/g).join(''));
}