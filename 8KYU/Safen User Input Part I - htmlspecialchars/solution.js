function htmlspecialchars(formData) {
  return formData.split("").reduce((acc, i, m) => acc + replaceChar(i), "");
}

function replaceChar(char){
  console.log(char);
  switch(char){
    case '<':
      return "&lt;";
    case '>':
      return "&gt;";
    case '"':
      return "&quot;";
    case "&":
      return "&amp;";
    default:
      return char;
  }
}