bool XO(str) {
  var lowerCase = str.toLowerCase();
  return RegExp("[x]").allMatches(lowerCase).length == RegExp("[o]").allMatches(lowerCase).length;
}