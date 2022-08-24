const closestMultiple10 = num => {
    var remainder = num % 10;
    return remainder < 5 ? num - remainder : num + (10 - remainder);    
 };