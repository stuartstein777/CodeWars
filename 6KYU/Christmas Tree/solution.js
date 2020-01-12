function christmasTree(height) {
  var result = "";
  let rowLength = (height * 2) - 1;
  for(var i = 1; i <= height; i++) {
    //console.log(i);
    //console.log(result);  
    let numberOfStars = (i * 2) - 1;
    let padding = (rowLength - numberOfStars) / 2;   
    result += " ".repeat(padding) + "*".repeat(numberOfStars) + " ".repeat(padding);
    if(i < height)
       result += "\n";  
  }
  return result;
}