function highAndLow(numbers){
    var nums = numbers.split(' ').map(Number);
    
    return `${Math.max(...nums)} ${Math.min(...nums)}`;
  }