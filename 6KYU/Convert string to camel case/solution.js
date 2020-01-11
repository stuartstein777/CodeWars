function toCamelCase(str){
  var split = str.replace(/_/g, '-').split('-');
  return split[0] + split.slice(1).map(i => i[0].toUpperCase() + i.slice(1)).join("");
}